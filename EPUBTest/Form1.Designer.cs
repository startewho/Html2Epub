namespace EPUBTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.testButton = new System.Windows.Forms.Button();
            this.textboxAuthor = new System.Windows.Forms.TextBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.checkBoxFonts = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.tbLanguage = new System.Windows.Forms.TextBox();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.btnCoverImage = new System.Windows.Forms.Button();
            this.lbFolderRule = new System.Windows.Forms.Label();
            this.tbFolderRule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHtmlRule = new System.Windows.Forms.TextBox();
            this.lbImageRule = new System.Windows.Forms.Label();
            this.tbImageRule = new System.Windows.Forms.TextBox();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // testButton
            // 
            resources.ApplyResources(this.testButton, "testButton");
            this.testButton.Name = "testButton";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // textboxAuthor
            // 
            resources.ApplyResources(this.textboxAuthor, "textboxAuthor");
            this.textboxAuthor.Name = "textboxAuthor";
            // 
            // lbAuthor
            // 
            resources.ApplyResources(this.lbAuthor, "lbAuthor");
            this.lbAuthor.Name = "lbAuthor";
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.Name = "lbTitle";
            // 
            // textboxTitle
            // 
            resources.ApplyResources(this.textboxTitle, "textboxTitle");
            this.textboxTitle.Name = "textboxTitle";
            // 
            // checkBoxFonts
            // 
            resources.ApplyResources(this.checkBoxFonts, "checkBoxFonts");
            this.checkBoxFonts.Name = "checkBoxFonts";
            this.checkBoxFonts.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSubject);
            this.groupBox1.Controls.Add(this.lbSubject);
            this.groupBox1.Controls.Add(this.tbLanguage);
            this.groupBox1.Controls.Add(this.lbLanguage);
            this.groupBox1.Controls.Add(this.lbAuthor);
            this.groupBox1.Controls.Add(this.textboxAuthor);
            this.groupBox1.Controls.Add(this.checkBoxFonts);
            this.groupBox1.Controls.Add(this.textboxTitle);
            this.groupBox1.Controls.Add(this.lbTitle);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tbSubject
            // 
            resources.ApplyResources(this.tbSubject, "tbSubject");
            this.tbSubject.Name = "tbSubject";
            // 
            // lbSubject
            // 
            resources.ApplyResources(this.lbSubject, "lbSubject");
            this.lbSubject.Name = "lbSubject";
            // 
            // tbLanguage
            // 
            resources.ApplyResources(this.tbLanguage, "tbLanguage");
            this.tbLanguage.Name = "tbLanguage";
            // 
            // lbLanguage
            // 
            resources.ApplyResources(this.lbLanguage, "lbLanguage");
            this.lbLanguage.Name = "lbLanguage";
            // 
            // picCover
            // 
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picCover, "picCover");
            this.picCover.Name = "picCover";
            this.picCover.TabStop = false;
            // 
            // btnCoverImage
            // 
            resources.ApplyResources(this.btnCoverImage, "btnCoverImage");
            this.btnCoverImage.Name = "btnCoverImage";
            this.btnCoverImage.UseVisualStyleBackColor = true;
            this.btnCoverImage.Click += new System.EventHandler(this.btnCoverImage_Click);
            // 
            // lbFolderRule
            // 
            resources.ApplyResources(this.lbFolderRule, "lbFolderRule");
            this.lbFolderRule.Name = "lbFolderRule";
            // 
            // tbFolderRule
            // 
            resources.ApplyResources(this.tbFolderRule, "tbFolderRule");
            this.tbFolderRule.Name = "tbFolderRule";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbHtmlRule
            // 
            resources.ApplyResources(this.tbHtmlRule, "tbHtmlRule");
            this.tbHtmlRule.Name = "tbHtmlRule";
            // 
            // lbImageRule
            // 
            resources.ApplyResources(this.lbImageRule, "lbImageRule");
            this.lbImageRule.Name = "lbImageRule";
            // 
            // tbImageRule
            // 
            resources.ApplyResources(this.tbImageRule, "tbImageRule");
            this.tbImageRule.Name = "tbImageRule";
            // 
            // tbFolder
            // 
            this.tbFolder.AllowDrop = true;
            resources.ApplyResources(this.tbFolder, "tbFolder");
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFolder_DragDrop);
            this.tbFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbFolder_DragEnter);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.lbImageRule);
            this.Controls.Add(this.tbImageRule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHtmlRule);
            this.Controls.Add(this.lbFolderRule);
            this.Controls.Add(this.tbFolderRule);
            this.Controls.Add(this.btnCoverImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.testButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox textboxAuthor;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox textboxTitle;
        private System.Windows.Forms.CheckBox checkBoxFonts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.TextBox tbLanguage;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Button btnCoverImage;
        private System.Windows.Forms.Label lbFolderRule;
        private System.Windows.Forms.TextBox tbFolderRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHtmlRule;
        private System.Windows.Forms.Label lbImageRule;
        private System.Windows.Forms.TextBox tbImageRule;
        private System.Windows.Forms.TextBox tbFolder;
    }
}

