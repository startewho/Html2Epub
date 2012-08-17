namespace Html2Epub
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
            this.tbGenerateEpub = new System.Windows.Forms.Button();
            this.textboxAuthor = new System.Windows.Forms.TextBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.checkBoxFonts = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBSelectedDocs = new System.Windows.Forms.RadioButton();
            this.rBRootFolder = new System.Windows.Forms.RadioButton();
            this.rBSelectedFolder = new System.Windows.Forms.RadioButton();
            this.tbFolder = new System.Windows.Forms.TextBox();
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
            this.cmBFolder = new System.Windows.Forms.ComboBox();
            this.lbFolder = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // tbGenerateEpub
            // 
            this.tbGenerateEpub.Location = new System.Drawing.Point(516, 12);
            this.tbGenerateEpub.Name = "tbGenerateEpub";
            this.tbGenerateEpub.Size = new System.Drawing.Size(174, 21);
            this.tbGenerateEpub.TabIndex = 0;
            this.tbGenerateEpub.Text = "创建Epub";
            this.tbGenerateEpub.UseVisualStyleBackColor = true;
            this.tbGenerateEpub.Click += new System.EventHandler(this.tbGenerateEpub_Click);
            // 
            // textboxAuthor
            // 
            this.textboxAuthor.Location = new System.Drawing.Point(66, 29);
            this.textboxAuthor.Name = "textboxAuthor";
            this.textboxAuthor.Size = new System.Drawing.Size(413, 21);
            this.textboxAuthor.TabIndex = 1;
            this.textboxAuthor.Text = "Just";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(6, 32);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(29, 12);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.Text = "作者";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(6, 65);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(29, 12);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "标题";
            // 
            // textboxTitle
            // 
            this.textboxTitle.Location = new System.Drawing.Point(66, 65);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(413, 21);
            this.textboxTitle.TabIndex = 3;
            this.textboxTitle.Text = "Wiz File Epub";
            // 
            // checkBoxFonts
            // 
            this.checkBoxFonts.AutoSize = true;
            this.checkBoxFonts.Location = new System.Drawing.Point(8, 280);
            this.checkBoxFonts.Name = "checkBoxFonts";
            this.checkBoxFonts.Size = new System.Drawing.Size(90, 16);
            this.checkBoxFonts.TabIndex = 9;
            this.checkBoxFonts.Text = "Embed fonts";
            this.checkBoxFonts.UseVisualStyleBackColor = false;
            this.checkBoxFonts.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tbFolder);
            this.groupBox1.Controls.Add(this.tbSubject);
            this.groupBox1.Controls.Add(this.lbSubject);
            this.groupBox1.Controls.Add(this.tbLanguage);
            this.groupBox1.Controls.Add(this.lbLanguage);
            this.groupBox1.Controls.Add(this.lbAuthor);
            this.groupBox1.Controls.Add(this.textboxAuthor);
            this.groupBox1.Controls.Add(this.checkBoxFonts);
            this.groupBox1.Controls.Add(this.textboxTitle);
            this.groupBox1.Controls.Add(this.lbTitle);
            this.groupBox1.Location = new System.Drawing.Point(21, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 412);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "元数据";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBSelectedDocs);
            this.panel1.Controls.Add(this.rBRootFolder);
            this.panel1.Controls.Add(this.rBSelectedFolder);
            this.panel1.Location = new System.Drawing.Point(6, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 46);
            this.panel1.TabIndex = 28;
            this.panel1.Visible = false;
            // 
            // rBSelectedDocs
            // 
            this.rBSelectedDocs.AutoSize = true;
            this.rBSelectedDocs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rBSelectedDocs.Location = new System.Drawing.Point(375, 12);
            this.rBSelectedDocs.Name = "rBSelectedDocs";
            this.rBSelectedDocs.Size = new System.Drawing.Size(95, 16);
            this.rBSelectedDocs.TabIndex = 27;
            this.rBSelectedDocs.TabStop = true;
            this.rBSelectedDocs.Text = "SelectedDocs";
            this.rBSelectedDocs.UseVisualStyleBackColor = true;
            // 
            // rBRootFolder
            // 
            this.rBRootFolder.AutoSize = true;
            this.rBRootFolder.Location = new System.Drawing.Point(3, 12);
            this.rBRootFolder.Name = "rBRootFolder";
            this.rBRootFolder.Size = new System.Drawing.Size(83, 16);
            this.rBRootFolder.TabIndex = 25;
            this.rBRootFolder.TabStop = true;
            this.rBRootFolder.Text = "RootFolder";
            this.rBRootFolder.UseVisualStyleBackColor = true;
            // 
            // rBSelectedFolder
            // 
            this.rBSelectedFolder.AutoSize = true;
            this.rBSelectedFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rBSelectedFolder.Location = new System.Drawing.Point(172, 12);
            this.rBSelectedFolder.Name = "rBSelectedFolder";
            this.rBSelectedFolder.Size = new System.Drawing.Size(107, 16);
            this.rBSelectedFolder.TabIndex = 26;
            this.rBSelectedFolder.TabStop = true;
            this.rBSelectedFolder.Text = "SelectedFolder";
            this.rBSelectedFolder.UseVisualStyleBackColor = true;
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(20, 322);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(459, 21);
            this.tbFolder.TabIndex = 24;
            this.tbFolder.Text = "FolderPath";
            this.tbFolder.Visible = false;
            this.tbFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFolder_DragDrop);
            this.tbFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbFolder_DragEnter);
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(66, 108);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(413, 21);
            this.tbSubject.TabIndex = 13;
            this.tbSubject.Text = "WizCollection";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(6, 108);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(29, 12);
            this.lbSubject.TabIndex = 14;
            this.lbSubject.Text = "类型";
            // 
            // tbLanguage
            // 
            this.tbLanguage.Location = new System.Drawing.Point(66, 151);
            this.tbLanguage.Name = "tbLanguage";
            this.tbLanguage.Size = new System.Drawing.Size(413, 21);
            this.tbLanguage.TabIndex = 11;
            this.tbLanguage.Text = "zh-CN";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Location = new System.Drawing.Point(6, 154);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(29, 12);
            this.lbLanguage.TabIndex = 12;
            this.lbLanguage.Text = "语言";
            // 
            // picCover
            // 
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCover.Location = new System.Drawing.Point(514, 249);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(171, 211);
            this.picCover.TabIndex = 15;
            this.picCover.TabStop = false;
            // 
            // btnCoverImage
            // 
            this.btnCoverImage.Location = new System.Drawing.Point(512, 222);
            this.btnCoverImage.Name = "btnCoverImage";
            this.btnCoverImage.Size = new System.Drawing.Size(171, 21);
            this.btnCoverImage.TabIndex = 17;
            this.btnCoverImage.Text = "封面";
            this.btnCoverImage.UseVisualStyleBackColor = true;
            this.btnCoverImage.Click += new System.EventHandler(this.btnCoverImage_Click);
            // 
            // lbFolderRule
            // 
            this.lbFolderRule.AutoSize = true;
            this.lbFolderRule.Location = new System.Drawing.Point(512, 48);
            this.lbFolderRule.Name = "lbFolderRule";
            this.lbFolderRule.Size = new System.Drawing.Size(65, 12);
            this.lbFolderRule.TabIndex = 19;
            this.lbFolderRule.Text = "文件夹规则";
            // 
            // tbFolderRule
            // 
            this.tbFolderRule.Location = new System.Drawing.Point(512, 63);
            this.tbFolderRule.Name = "tbFolderRule";
            this.tbFolderRule.Size = new System.Drawing.Size(174, 21);
            this.tbFolderRule.TabIndex = 18;
            this.tbFolderRule.Text = "_files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "网页规则";
            // 
            // tbHtmlRule
            // 
            this.tbHtmlRule.Location = new System.Drawing.Point(514, 120);
            this.tbHtmlRule.Name = "tbHtmlRule";
            this.tbHtmlRule.Size = new System.Drawing.Size(174, 21);
            this.tbHtmlRule.TabIndex = 20;
            this.tbHtmlRule.Text = ".html;.htm;.xhtml";
            // 
            // lbImageRule
            // 
            this.lbImageRule.AutoSize = true;
            this.lbImageRule.Location = new System.Drawing.Point(512, 166);
            this.lbImageRule.Name = "lbImageRule";
            this.lbImageRule.Size = new System.Drawing.Size(53, 12);
            this.lbImageRule.TabIndex = 23;
            this.lbImageRule.Text = "图片规则";
            // 
            // tbImageRule
            // 
            this.tbImageRule.Location = new System.Drawing.Point(514, 181);
            this.tbImageRule.Name = "tbImageRule";
            this.tbImageRule.Size = new System.Drawing.Size(174, 21);
            this.tbImageRule.TabIndex = 22;
            this.tbImageRule.Text = ".jpg;.png;.gif";
            // 
            // cmBFolder
            // 
            this.cmBFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBFolder.FormattingEnabled = true;
            this.cmBFolder.Location = new System.Drawing.Point(85, 15);
            this.cmBFolder.Name = "cmBFolder";
            this.cmBFolder.Size = new System.Drawing.Size(420, 20);
            this.cmBFolder.TabIndex = 25;
            // 
            // lbFolder
            // 
            this.lbFolder.AutoSize = true;
            this.lbFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbFolder.Location = new System.Drawing.Point(28, 16);
            this.lbFolder.Name = "lbFolder";
            this.lbFolder.Size = new System.Drawing.Size(29, 12);
            this.lbFolder.TabIndex = 29;
            this.lbFolder.Text = "来源";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 578);
            this.Controls.Add(this.lbFolder);
            this.Controls.Add(this.cmBFolder);
            this.Controls.Add(this.lbImageRule);
            this.Controls.Add(this.tbImageRule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHtmlRule);
            this.Controls.Add(this.lbFolderRule);
            this.Controls.Add(this.tbFolderRule);
            this.Controls.Add(this.btnCoverImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.tbGenerateEpub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Html2Epub";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbGenerateEpub;
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
        private System.Windows.Forms.RadioButton rBRootFolder;
        private System.Windows.Forms.RadioButton rBSelectedFolder;
        private System.Windows.Forms.RadioButton rBSelectedDocs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmBFolder;
        private System.Windows.Forms.Label lbFolder;
    }
}

