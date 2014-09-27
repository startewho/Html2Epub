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
            this.label3 = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.cbBy = new System.Windows.Forms.ComboBox();
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
            this.tabControl1.Location = new System.Drawing.Point(19, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 581);
            this.tabControl1.TabIndex = 30;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.axWizCategoryTree);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(719, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "选择Wiz目录";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // axWizCategoryTree
            // 
            this.axWizCategoryTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWizCategoryTree.Enabled = true;
            this.axWizCategoryTree.Location = new System.Drawing.Point(4, 4);
            this.axWizCategoryTree.Margin = new System.Windows.Forms.Padding(4);
            this.axWizCategoryTree.Name = "axWizCategoryTree";
            this.axWizCategoryTree.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWizCategoryTree.OcxState")));
            this.axWizCategoryTree.Size = new System.Drawing.Size(711, 544);
            this.axWizCategoryTree.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(719, 552);
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
            this.groupBox2.Location = new System.Drawing.Point(23, 166);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(663, 344);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EPub";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "建议图片比例3:4,如600*800,300*400等";
            // 
            // btnCoverImage
            // 
            this.btnCoverImage.Location = new System.Drawing.Point(443, 296);
            this.btnCoverImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnCoverImage.Name = "btnCoverImage";
            this.btnCoverImage.Size = new System.Drawing.Size(200, 26);
            this.btnCoverImage.TabIndex = 50;
            this.btnCoverImage.Text = "设置封面...";
            this.btnCoverImage.UseVisualStyleBackColor = true;
            this.btnCoverImage.Click += new System.EventHandler(this.btnCoverImage_Click);
            // 
            // picCover
            // 
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCover.Location = new System.Drawing.Point(443, 25);
            this.picCover.Margin = new System.Windows.Forms.Padding(4);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(199, 250);
            this.picCover.TabIndex = 49;
            this.picCover.TabStop = false;
            this.picCover.Click += new System.EventHandler(this.btnCoverImage_Click);
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(40, 298);
            this.tbFolder.Margin = new System.Windows.Forms.Padding(4);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(303, 25);
            this.tbFolder.TabIndex = 48;
            this.tbFolder.Text = "FolderPath";
            this.tbFolder.Visible = false;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(87, 124);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(4);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(65, 25);
            this.tbSubject.TabIndex = 46;
            this.tbSubject.Text = "Wiz";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(37, 128);
            this.lbSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(37, 15);
            this.lbSubject.TabIndex = 47;
            this.lbSubject.Text = "类型";
            // 
            // tbLanguage
            // 
            this.tbLanguage.Location = new System.Drawing.Point(87, 178);
            this.tbLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.tbLanguage.Name = "tbLanguage";
            this.tbLanguage.Size = new System.Drawing.Size(65, 25);
            this.tbLanguage.TabIndex = 44;
            this.tbLanguage.Text = "zh-CN";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Location = new System.Drawing.Point(40, 181);
            this.lbLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(37, 15);
            this.lbLanguage.TabIndex = 45;
            this.lbLanguage.Text = "语言";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(37, 29);
            this.lbAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(37, 15);
            this.lbAuthor.TabIndex = 40;
            this.lbAuthor.Text = "作者";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(87, 25);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(223, 25);
            this.tbAuthor.TabIndex = 39;
            this.tbAuthor.Tag = "auto";
            this.tbAuthor.Text = "Just";
            this.tbAuthor.TextChanged += new System.EventHandler(this.tbAuthor_TextChanged);
            // 
            // checkBoxFonts
            // 
            this.checkBoxFonts.AutoSize = true;
            this.checkBoxFonts.Location = new System.Drawing.Point(43, 269);
            this.checkBoxFonts.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFonts.Name = "checkBoxFonts";
            this.checkBoxFonts.Size = new System.Drawing.Size(117, 19);
            this.checkBoxFonts.TabIndex = 43;
            this.checkBoxFonts.Text = "Embed fonts";
            this.checkBoxFonts.UseVisualStyleBackColor = false;
            this.checkBoxFonts.Visible = false;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(87, 70);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(223, 25);
            this.tbTitle.TabIndex = 41;
            this.tbTitle.Tag = "auto";
            this.tbTitle.Text = "Wiz电子书";
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(37, 74);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(37, 15);
            this.lbTitle.TabIndex = 42;
            this.lbTitle.Text = "标题";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbSort);
            this.groupBox1.Controls.Add(this.cbBy);
            this.groupBox1.Controls.Add(this.lbImageRule);
            this.groupBox1.Controls.Add(this.tbImageRule);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbHtmlRule);
            this.groupBox1.Controls.Add(this.lbFolderRule);
            this.groupBox1.Controls.Add(this.tbFolderRule);
            this.groupBox1.Location = new System.Drawing.Point(23, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(663, 135);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "过滤";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "文档";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "排序";
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Asc",
            "Desc"});
            this.cbSort.Location = new System.Drawing.Point(352, 105);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(185, 23);
            this.cbSort.TabIndex = 54;
            // 
            // cbBy
            // 
            this.cbBy.FormattingEnabled = true;
            this.cbBy.Items.AddRange(new object[] {
            "Title",
            "DateCreated",
            "DateModified"});
            this.cbBy.Location = new System.Drawing.Point(87, 105);
            this.cbBy.Name = "cbBy";
            this.cbBy.Size = new System.Drawing.Size(185, 23);
            this.cbBy.TabIndex = 53;
            // 
            // lbImageRule
            // 
            this.lbImageRule.AutoSize = true;
            this.lbImageRule.Location = new System.Drawing.Point(305, 69);
            this.lbImageRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbImageRule.Name = "lbImageRule";
            this.lbImageRule.Size = new System.Drawing.Size(37, 15);
            this.lbImageRule.TabIndex = 52;
            this.lbImageRule.Text = "图片";
            // 
            // tbImageRule
            // 
            this.tbImageRule.Location = new System.Drawing.Point(352, 65);
            this.tbImageRule.Margin = new System.Windows.Forms.Padding(4);
            this.tbImageRule.Name = "tbImageRule";
            this.tbImageRule.Size = new System.Drawing.Size(185, 25);
            this.tbImageRule.TabIndex = 51;
            this.tbImageRule.Text = ".jpg;.png;.gif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "文档";
            // 
            // tbHtmlRule
            // 
            this.tbHtmlRule.Location = new System.Drawing.Point(87, 65);
            this.tbHtmlRule.Margin = new System.Windows.Forms.Padding(4);
            this.tbHtmlRule.Name = "tbHtmlRule";
            this.tbHtmlRule.Size = new System.Drawing.Size(185, 25);
            this.tbHtmlRule.TabIndex = 49;
            this.tbHtmlRule.Text = ".html;.htm;.xhtml";
            // 
            // lbFolderRule
            // 
            this.lbFolderRule.AutoSize = true;
            this.lbFolderRule.Location = new System.Drawing.Point(24, 32);
            this.lbFolderRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFolderRule.Name = "lbFolderRule";
            this.lbFolderRule.Size = new System.Drawing.Size(52, 15);
            this.lbFolderRule.TabIndex = 48;
            this.lbFolderRule.Text = "文件夹";
            // 
            // tbFolderRule
            // 
            this.tbFolderRule.Location = new System.Drawing.Point(87, 25);
            this.tbFolderRule.Margin = new System.Windows.Forms.Padding(4);
            this.tbFolderRule.Name = "tbFolderRule";
            this.tbFolderRule.Size = new System.Drawing.Size(185, 25);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(719, 552);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "生成EPub";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSelectEPubFilePath
            // 
            this.btnSelectEPubFilePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectEPubFilePath.Location = new System.Drawing.Point(543, 34);
            this.btnSelectEPubFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectEPubFilePath.Name = "btnSelectEPubFilePath";
            this.btnSelectEPubFilePath.Size = new System.Drawing.Size(143, 26);
            this.btnSelectEPubFilePath.TabIndex = 13;
            this.btnSelectEPubFilePath.Text = "选择文件(&B)...";
            this.btnSelectEPubFilePath.UseVisualStyleBackColor = true;
            this.btnSelectEPubFilePath.Click += new System.EventHandler(this.btnSelectEPubFilePath_Click);
            // 
            // tbEPubFilePath
            // 
            this.tbEPubFilePath.Location = new System.Drawing.Point(184, 34);
            this.tbEPubFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbEPubFilePath.Name = "tbEPubFilePath";
            this.tbEPubFilePath.ReadOnly = true;
            this.tbEPubFilePath.Size = new System.Drawing.Size(349, 25);
            this.tbEPubFilePath.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "生成文件(*.epub):";
            // 
            // lbConvert
            // 
            this.lbConvert.AutoSize = true;
            this.lbConvert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbConvert.Location = new System.Drawing.Point(28, 90);
            this.lbConvert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConvert.Name = "lbConvert";
            this.lbConvert.Size = new System.Drawing.Size(45, 15);
            this.lbConvert.TabIndex = 9;
            this.lbConvert.Text = "进度:";
            // 
            // progressBarConver
            // 
            this.progressBarConver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBarConver.Location = new System.Drawing.Point(31, 121);
            this.progressBarConver.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarConver.Name = "progressBarConver";
            this.progressBarConver.Size = new System.Drawing.Size(655, 28);
            this.progressBarConver.Step = 1;
            this.progressBarConver.TabIndex = 10;
            // 
            // lbLogs
            // 
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 15;
            this.lbLogs.Location = new System.Drawing.Point(31, 160);
            this.lbLogs.Margin = new System.Windows.Forms.Padding(4);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(653, 364);
            this.lbLogs.TabIndex = 11;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(569, 609);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(177, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "下一步";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.tbGenerateEpub_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 665);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.ComboBox cbBy;
    }
}

