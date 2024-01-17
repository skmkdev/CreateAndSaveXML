using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace CreateAndSaveXML
{
    public partial class Form1 : Form
    {
        XDocument xdoc = null;
       
        public Form1()
        {
            InitializeComponent();

            folderBrowserDialog1.SelectedPath = @"c:\temp";
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBoxFolderName.Text = folderBrowserDialog1.SelectedPath;
        }

        private void CreateXml_button_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxFolderName.Text))
            {
                string header = "<?xml version=\"1.0\" encoding=\"utf-8\" ?><Directory></Directory> ";
                xdoc = XDocument.Parse(header);
                XElement root = xdoc.Root;

                CreateXmlRecursive(textBoxFolderName.Text, root);
            }
            CreateTree();
        }

        private float CreateXmlRecursive(string folder, XElement folderElement)
        {
            folderElement.SetValue(folder);

            DirectoryInfo dInfo = new DirectoryInfo(folder);

            int numberOfFiles = 0;
            float size = 0.0f;

            foreach (FileInfo fInfo in dInfo.GetFiles())
            {
                try
                {
                    float fSize = fInfo.Length;
                    size += fSize;
                    folderElement.Add(new XElement("File", new object[] {
                        new XAttribute("Size",fSize),
                        new XAttribute("CreationDate", fInfo.CreationTime.ToShortDateString()),
                        new XAttribute("LastAccessDate", fInfo.LastAccessTime.ToShortDateString()),
                        new XAttribute("LastModifiedDate", fInfo.LastWriteTime.ToShortDateString()),
                        fInfo.Name
                    }));
                    numberOfFiles += 1;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error : Cannot Access File '{0}'", fInfo.Name);
                }
            }
            foreach (string subFolder in Directory.GetDirectories(folder))
            {
                XElement childDirectory = new XElement("Directory");
                folderElement.Add(childDirectory);
                float dSize = CreateXmlRecursive(subFolder, childDirectory);
                size += dSize;
            }
            folderElement.Add(new XAttribute[] {
                new XAttribute("size", size),
                new XAttribute("numberOfFiles", numberOfFiles)
            });

            return size;
        }

        private void CreateTree()
        {
            if (xdoc != null)
            {
                TreeNode rootNode = new TreeNode(xdoc.Root.FirstNode.ToString());
                AddNode(xdoc.Root, rootNode);
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(rootNode);
                treeView1.ExpandAll();
            }
        }

        private void AddNode(XElement xElement, TreeNode inTreeNode)
        {
            foreach (var att in xElement.Attributes())
            {
                inTreeNode.Text = inTreeNode.Text + " " + att.Name.LocalName + ": " + att.Value;
            }
            foreach (XElement childElement in xElement.Elements())
            {
                TreeNode tNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(childElement.Value))];
                AddNode(childElement, tNode);
            }
        }

        private void buttonSaveXML_Click(object sender, EventArgs e)
        {
            XmlTextWriter xwriter = new XmlTextWriter(@"c:\temp\xDoc.xml", Encoding.UTF8);
            xwriter.Formatting = Formatting.Indented;
            xdoc.WriteTo(xwriter);
            xwriter.Close();
            MessageBox.Show("Saving was successful!");
        }
    }
}
