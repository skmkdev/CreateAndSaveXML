namespace CreateAndSaveXML
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateXml_button = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.textBoxFolderName = new System.Windows.Forms.TextBox();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateXml_button
            // 
            this.CreateXml_button.Location = new System.Drawing.Point(30, 63);
            this.CreateXml_button.Name = "CreateXml_button";
            this.CreateXml_button.Size = new System.Drawing.Size(89, 23);
            this.CreateXml_button.TabIndex = 2;
            this.CreateXml_button.Text = "Create XML";
            this.CreateXml_button.UseVisualStyleBackColor = true;
            this.CreateXml_button.Click += new System.EventHandler(this.CreateXml_button_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(30, 109);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(389, 146);
            this.treeView1.TabIndex = 4;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(30, 23);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(89, 23);
            this.buttonSelectFolder.TabIndex = 11;
            this.buttonSelectFolder.Text = "Select Folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // textBoxFolderName
            // 
            this.textBoxFolderName.Location = new System.Drawing.Point(126, 25);
            this.textBoxFolderName.Name = "textBoxFolderName";
            this.textBoxFolderName.ReadOnly = true;
            this.textBoxFolderName.Size = new System.Drawing.Size(132, 20);
            this.textBoxFolderName.TabIndex = 13;
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Location = new System.Drawing.Point(125, 63);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(89, 23);
            this.buttonSaveXML.TabIndex = 14;
            this.buttonSaveXML.Text = "Save XML";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            this.buttonSaveXML.Click += new System.EventHandler(this.buttonSaveXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 275);
            this.Controls.Add(this.buttonSaveXML);
            this.Controls.Add(this.textBoxFolderName);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.CreateXml_button);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateXml_button;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.TextBox textBoxFolderName;
        private System.Windows.Forms.Button buttonSaveXML;
    }
}

