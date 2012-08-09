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
            this.testButton = new System.Windows.Forms.Button();
            this.textboxAuthor = new System.Windows.Forms.TextBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.richtextSampleContent = new System.Windows.Forms.RichTextBox();
            this.checkBoxJpeg = new System.Windows.Forms.CheckBox();
            this.checkBoxPng = new System.Windows.Forms.CheckBox();
            this.checkBoxGif = new System.Windows.Forms.CheckBox();
            this.checkBoxFonts = new System.Windows.Forms.CheckBox();
            this.checkBoxSvg = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLanguage = new System.Windows.Forms.TextBox();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.picBCover = new System.Windows.Forms.PictureBox();
            this.btnCoverImage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBCover)).BeginInit();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(516, 12);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(174, 21);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Generate ePUB";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // textboxAuthor
            // 
            this.textboxAuthor.Location = new System.Drawing.Point(72, 29);
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
            this.lbAuthor.Size = new System.Drawing.Size(41, 12);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.Text = "Author";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(6, 65);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(35, 12);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Title";
            // 
            // textboxTitle
            // 
            this.textboxTitle.Location = new System.Drawing.Point(72, 65);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(413, 21);
            this.textboxTitle.TabIndex = 3;
            this.textboxTitle.Text = "Wiz File Epub";
            // 
            // richtextSampleContent
            // 
            this.richtextSampleContent.Location = new System.Drawing.Point(12, 12);
            this.richtextSampleContent.Name = "richtextSampleContent";
            this.richtextSampleContent.Size = new System.Drawing.Size(498, 21);
            this.richtextSampleContent.TabIndex = 5;
            this.richtextSampleContent.Text = "Add some text here in  any language";
            // 
            // checkBoxJpeg
            // 
            this.checkBoxJpeg.AutoSize = true;
            this.checkBoxJpeg.Checked = true;
            this.checkBoxJpeg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxJpeg.Location = new System.Drawing.Point(8, 253);
            this.checkBoxJpeg.Name = "checkBoxJpeg";
            this.checkBoxJpeg.Size = new System.Drawing.Size(132, 16);
            this.checkBoxJpeg.TabIndex = 6;
            this.checkBoxJpeg.Text = "Add JPEG test page";
            this.checkBoxJpeg.UseVisualStyleBackColor = true;
            // 
            // checkBoxPng
            // 
            this.checkBoxPng.AutoSize = true;
            this.checkBoxPng.Checked = true;
            this.checkBoxPng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPng.Location = new System.Drawing.Point(8, 274);
            this.checkBoxPng.Name = "checkBoxPng";
            this.checkBoxPng.Size = new System.Drawing.Size(126, 16);
            this.checkBoxPng.TabIndex = 7;
            this.checkBoxPng.Text = "Add PNG test page";
            this.checkBoxPng.UseVisualStyleBackColor = true;
            // 
            // checkBoxGif
            // 
            this.checkBoxGif.AutoSize = true;
            this.checkBoxGif.Checked = true;
            this.checkBoxGif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGif.Location = new System.Drawing.Point(8, 295);
            this.checkBoxGif.Name = "checkBoxGif";
            this.checkBoxGif.Size = new System.Drawing.Size(126, 16);
            this.checkBoxGif.TabIndex = 8;
            this.checkBoxGif.Text = "Add GIF test page";
            this.checkBoxGif.UseVisualStyleBackColor = true;
            // 
            // checkBoxFonts
            // 
            this.checkBoxFonts.AutoSize = true;
            this.checkBoxFonts.Location = new System.Drawing.Point(8, 338);
            this.checkBoxFonts.Name = "checkBoxFonts";
            this.checkBoxFonts.Size = new System.Drawing.Size(90, 16);
            this.checkBoxFonts.TabIndex = 9;
            this.checkBoxFonts.Text = "Embed fonts";
            this.checkBoxFonts.UseVisualStyleBackColor = true;
            // 
            // checkBoxSvg
            // 
            this.checkBoxSvg.AutoSize = true;
            this.checkBoxSvg.Checked = true;
            this.checkBoxSvg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSvg.Location = new System.Drawing.Point(8, 317);
            this.checkBoxSvg.Name = "checkBoxSvg";
            this.checkBoxSvg.Size = new System.Drawing.Size(126, 16);
            this.checkBoxSvg.TabIndex = 10;
            this.checkBoxSvg.Text = "Add SVG test page";
            this.checkBoxSvg.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSubject);
            this.groupBox1.Controls.Add(this.lbSubject);
            this.groupBox1.Controls.Add(this.tbLanguage);
            this.groupBox1.Controls.Add(this.lbLanguage);
            this.groupBox1.Controls.Add(this.lbAuthor);
            this.groupBox1.Controls.Add(this.checkBoxSvg);
            this.groupBox1.Controls.Add(this.textboxAuthor);
            this.groupBox1.Controls.Add(this.checkBoxFonts);
            this.groupBox1.Controls.Add(this.textboxTitle);
            this.groupBox1.Controls.Add(this.checkBoxGif);
            this.groupBox1.Controls.Add(this.lbTitle);
            this.groupBox1.Controls.Add(this.checkBoxPng);
            this.groupBox1.Controls.Add(this.checkBoxJpeg);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 400);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MetaData";
            // 
            // tbLanguage
            // 
            this.tbLanguage.Location = new System.Drawing.Point(72, 151);
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
            this.lbLanguage.Size = new System.Drawing.Size(53, 12);
            this.lbLanguage.TabIndex = 12;
            this.lbLanguage.Text = "Language";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(72, 105);
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
            this.lbSubject.Size = new System.Drawing.Size(47, 12);
            this.lbSubject.TabIndex = 14;
            this.lbSubject.Text = "Subject";
            // 
            // picBCover
            // 
            this.picBCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBCover.Location = new System.Drawing.Point(550, 292);
            this.picBCover.Name = "picBCover";
            this.picBCover.Size = new System.Drawing.Size(140, 179);
            this.picBCover.TabIndex = 15;
            this.picBCover.TabStop = false;
            // 
            // btnCoverImage
            // 
            this.btnCoverImage.Location = new System.Drawing.Point(550, 265);
            this.btnCoverImage.Name = "btnCoverImage";
            this.btnCoverImage.Size = new System.Drawing.Size(139, 21);
            this.btnCoverImage.TabIndex = 17;
            this.btnCoverImage.Text = "CoverImage";
            this.btnCoverImage.UseVisualStyleBackColor = true;
            this.btnCoverImage.Click += new System.EventHandler(this.btnCoverImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 498);
            this.Controls.Add(this.btnCoverImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBCover);
            this.Controls.Add(this.richtextSampleContent);
            this.Controls.Add(this.testButton);
            this.Name = "Form1";
            this.Text = "Html2Epub";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox textboxAuthor;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox textboxTitle;
        private System.Windows.Forms.RichTextBox richtextSampleContent;
        private System.Windows.Forms.CheckBox checkBoxJpeg;
        private System.Windows.Forms.CheckBox checkBoxPng;
        private System.Windows.Forms.CheckBox checkBoxGif;
        private System.Windows.Forms.CheckBox checkBoxFonts;
        private System.Windows.Forms.CheckBox checkBoxSvg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.TextBox tbLanguage;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.PictureBox picBCover;
        private System.Windows.Forms.Button btnCoverImage;
    }
}

