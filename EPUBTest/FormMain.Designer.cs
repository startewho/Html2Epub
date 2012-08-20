namespace Wiz2EPub
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.axWizCategoryTree = new AxWizKMControlsLib.AxWizCategoryCtrl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCoverImage = new System.Windows.Forms.Button();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.tbLanguage = new System.Windows.Forms.TextBox();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.checkBoxFonts = new System.Windows.Forms.CheckBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbImageRule = new System.Windows.Forms.Label();
            this.tbImageRule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHtmlRule = new System.Windows.Forms.TextBox();
            this.lbFolderRule = new System.Windows.Forms.Label();
            this.tbFolderRule = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSelectEPubFilePath = new System.Windows.Forms.Button();
            this.tbEPubFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbConvert = new System.Windows.Forms.Label();
            this.progressBarConver = new System.Windows.Forms.ProgressBar();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.saveFileDialogEPub = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWizCategoryTree)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 465);
            this.tabControl1.TabIndex = 30;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.axWizCategoryTree);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(537, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "选择Wiz目录";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // axWizCategoryTree
            // 
            this.axWizCategoryTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWizCategoryTree.Enabled = true;
            this.axWizCategoryTree.Location = new System.Drawing.Point(3, 3);
            this.axWizCategoryTree.Name = "axWizCategoryTree";
            this.axWizCategoryTree.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWizCategoryTree.OcxState")));
            this.axWizCategoryTree.Size = new System.Drawing.Size(531, 433);
            this.axWizCategoryTree.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(537, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置EPub参数";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCoverImage);
            this.groupBox2.Controls.Add(this.picCover);
            this.groupBox2.Controls.Add(this.tbFolder);
            this.groupBox2.Controls.Add(this.tbSubject);
            this.groupBox2.Controls.Add(this.lbSubject);
            this.groupBox2.Controls.Add(this.tbLanguage);
            this.groupBox2.Controls.Add(this.lbLanguage);
            this.groupBox2.Controls.Add(this.lbAuthor);
            this.groupBox2.Controls.Add(this.tbAuthor);
            this.groupBox2.Controls.Add(this.checkBoxFonts);
            this.groupBox2.Controls.Add(this.tbTitle);
            this.groupBox2.Controls.Add(this.lbTitle);
            this.groupBox2.Location = new System.Drawing.Point(17, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 275);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EPub";
            // 
            // btnCoverImage
            // 
            this.btnCoverImage.Location = new System.Drawing.Point(332, 237);
            this.btnCoverImage.Name = "btnCoverImage";
            this.btnCoverImage.Size = new System.Drawing.Size(150, 21);
            this.btnCoverImage.TabIndex = 50;
            this.btnCoverImage.Text = "设置封面...";
            this.btnCoverImage.UseVisualStyleBackColor = true;
            this.btnCoverImage.Click += new System.EventHandler(this.btnCoverImage_Click);
            // 
            // picCover
            // 
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCover.Location = new System.Drawing.Point(332, 20);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(150, 200);
            this.picCover.TabIndex = 49;
            this.picCover.TabStop = false;
            this.picCover.Click += new System.EventHandler(this.btnCoverImage_Click);
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(30, 238);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(228, 21);
            this.tbFolder.TabIndex = 48;
            this.tbFolder.Text = "FolderPath";
            this.tbFolder.Visible = false;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(65, 99);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(50, 21);
            this.tbSubject.TabIndex = 46;
            this.tbSubject.Text = "Wiz";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(28, 102);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(29, 12);
            this.lbSubject.TabIndex = 47;
            this.lbSubject.Text = "类型";
            // 
            // tbLanguage
            // 
            this.tbLanguage.Location = new System.Drawing.Point(65, 142);
            this.tbLanguage.Name = "tbLanguage";
            this.tbLanguage.Size = new System.Drawing.Size(50, 21);
            this.tbLanguage.TabIndex = 44;
            this.tbLanguage.Text = "zh-CN";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Location = new System.Drawing.Point(30, 145);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(29, 12);
            this.lbLanguage.TabIndex = 45;
            this.lbLanguage.Text = "语言";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(28, 23);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(29, 12);
            this.lbAuthor.TabIndex = 40;
            this.lbAuthor.Text = "作者";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(65, 20);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(168, 21);
            this.tbAuthor.TabIndex = 39;
            this.tbAuthor.Tag = "auto";
            this.tbAuthor.Text = "Just";
            this.tbAuthor.TextChanged += new System.EventHandler(this.tbAuthor_TextChanged);
            // 
            // checkBoxFonts
            // 
            this.checkBoxFonts.AutoSize = true;
            this.checkBoxFonts.Location = new System.Drawing.Point(32, 215);
            this.checkBoxFonts.Name = "checkBoxFonts";
            this.checkBoxFonts.Size = new System.Drawing.Size(90, 16);
            this.checkBoxFonts.TabIndex = 43;
            this.checkBoxFonts.Text = "Embed fonts";
            this.checkBoxFonts.UseVisualStyleBackColor = false;
            this.checkBoxFonts.Visible = false;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(65, 56);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(168, 21);
            this.tbTitle.TabIndex = 41;
            this.tbTitle.Tag = "auto";
            this.tbTitle.Text = "Wiz电子书";
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(28, 59);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(29, 12);
            this.lbTitle.TabIndex = 42;
            this.lbTitle.Text = "标题";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbImageRule);
            this.groupBox1.Controls.Add(this.tbImageRule);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbHtmlRule);
            this.groupBox1.Controls.Add(this.lbFolderRule);
            this.groupBox1.Controls.Add(this.tbFolderRule);
            this.groupBox1.Location = new System.Drawing.Point(17, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 90);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "过滤";
            // 
            // lbImageRule
            // 
            this.lbImageRule.AutoSize = true;
            this.lbImageRule.Location = new System.Drawing.Point(229, 55);
            this.lbImageRule.Name = "lbImageRule";
            this.lbImageRule.Size = new System.Drawing.Size(29, 12);
            this.lbImageRule.TabIndex = 52;
            this.lbImageRule.Text = "图片";
            // 
            // tbImageRule
            // 
            this.tbImageRule.Location = new System.Drawing.Point(264, 52);
            this.tbImageRule.Name = "tbImageRule";
            this.tbImageRule.Size = new System.Drawing.Size(140, 21);
            this.tbImageRule.TabIndex = 51;
            this.tbImageRule.Text = ".jpg;.png;.gif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "文档";
            // 
            // tbHtmlRule
            // 
            this.tbHtmlRule.Location = new System.Drawing.Point(65, 52);
            this.tbHtmlRule.Name = "tbHtmlRule";
            this.tbHtmlRule.Size = new System.Drawing.Size(140, 21);
            this.tbHtmlRule.TabIndex = 49;
            this.tbHtmlRule.Text = ".html;.htm;.xhtml";
            // 
            // lbFolderRule
            // 
            this.lbFolderRule.AutoSize = true;
            this.lbFolderRule.Location = new System.Drawing.Point(18, 26);
            this.lbFolderRule.Name = "lbFolderRule";
            this.lbFolderRule.Size = new System.Drawing.Size(41, 12);
            this.lbFolderRule.TabIndex = 48;
            this.lbFolderRule.Text = "文件夹";
            // 
            // tbFolderRule
            // 
            this.tbFolderRule.Location = new System.Drawing.Point(65, 20);
            this.tbFolderRule.Name = "tbFolderRule";
            this.tbFolderRule.Size = new System.Drawing.Size(140, 21);
            this.tbFolderRule.TabIndex = 47;
            this.tbFolderRule.Text = "_files";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSelectEPubFilePath);
            this.tabPage3.Controls.Add(this.tbEPubFilePath);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.lbConvert);
            this.tabPage3.Controls.Add(this.progressBarConver);
            this.tabPage3.Controls.Add(this.lbLogs);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(537, 439);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "生成EPub";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSelectEPubFilePath
            // 
            this.btnSelectEPubFilePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectEPubFilePath.Location = new System.Drawing.Point(407, 27);
            this.btnSelectEPubFilePath.Name = "btnSelectEPubFilePath";
            this.btnSelectEPubFilePath.Size = new System.Drawing.Size(107, 21);
            this.btnSelectEPubFilePath.TabIndex = 13;
            this.btnSelectEPubFilePath.Text = "选择文件(&B)...";
            this.btnSelectEPubFilePath.UseVisualStyleBackColor = true;
            this.btnSelectEPubFilePath.Click += new System.EventHandler(this.btnSelectEPubFilePath_Click);
            // 
            // tbEPubFilePath
            // 
            this.tbEPubFilePath.Location = new System.Drawing.Point(138, 27);
            this.tbEPubFilePath.Name = "tbEPubFilePath";
            this.tbEPubFilePath.ReadOnly = true;
            this.tbEPubFilePath.Size = new System.Drawing.Size(263, 21);
            this.tbEPubFilePath.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "生成文件(*.epub):";
            // 
            // lbConvert
            // 
            this.lbConvert.AutoSize = true;
            this.lbConvert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbConvert.Location = new System.Drawing.Point(21, 72);
            this.lbConvert.Name = "lbConvert";
            this.lbConvert.Size = new System.Drawing.Size(35, 12);
            this.lbConvert.TabIndex = 9;
            this.lbConvert.Text = "进度:";
            // 
            // progressBarConver
            // 
            this.progressBarConver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBarConver.Location = new System.Drawing.Point(23, 97);
            this.progressBarConver.Name = "progressBarConver";
            this.progressBarConver.Size = new System.Drawing.Size(491, 22);
            this.progressBarConver.Step = 1;
            this.progressBarConver.TabIndex = 10;
            // 
            // lbLogs
            // 
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 12;
            this.lbLogs.Location = new System.Drawing.Point(23, 128);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(491, 292);
            this.lbLogs.TabIndex = 11;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(427, 487);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "下一步";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.tbGenerateEpub_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 12);
            this.label3.TabIndex = 51;
            this.label3.Text = "建议图片比例3:4,如600*800,300*400等";
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 532);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "为知笔记(Wiz)导出成EPub电子书";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWizCategoryTree)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private AxWizKMControlsLib.AxWizCategoryCtrl axWizCategoryTree;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbImageRule;
        private System.Windows.Forms.TextBox tbImageRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHtmlRule;
        private System.Windows.Forms.Label lbFolderRule;
        private System.Windows.Forms.TextBox tbFolderRule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.TextBox tbLanguage;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.CheckBox checkBoxFonts;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnCoverImage;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Label lbConvert;
        private System.Windows.Forms.ProgressBar progressBarConver;
        private System.Windows.Forms.ListBox lbLogs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectEPubFilePath;
        private System.Windows.Forms.TextBox tbEPubFilePath;
        private System.Windows.Forms.SaveFileDialog saveFileDialogEPub;
        private System.Windows.Forms.Label label3;
    }
}

