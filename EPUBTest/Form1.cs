using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Reflection;
using System.Resources;
using EPubDocument = Epub.Document;
using NavPoint = Epub.NavPoint;

namespace EPUBTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

         int playorder=1;
     
        static FileInfo[] GetFiles(string path, string type)
        {
                var typearr = type.Split(new char[]{';'},StringSplitOptions.RemoveEmptyEntries);
                var dir = new DirectoryInfo(path);
                FileInfo[] fileInfo = (from c in dir.GetFiles() where typearr.Contains( c.Extension.ToLower()) select c).ToArray();
                return fileInfo;
            
        }

        static string HtmlList(string path)
        {
            var result = new StringBuilder(25);
            var fileinfolist = GetFiles(path, ".html;");
            foreach (var fileInfo in fileinfolist)
            {
                result.Append(fileInfo.Name);
            }
            return result.ToString();
        }

        static bool UnContions(string str,string part)
        {
            return !str.Contains(part) ;
        }
        private void CreateNavMap(string path,NavPoint nav,EPubDocument epub)
        {
            var dir =new DirectoryInfo(path);
            foreach (var folder in dir.GetDirectories( ))
            {
                if (!folder.Name.Contains(tbFolderRule.Text))
                {
                    var navin = nav.AddNavPoint(folder.Name, folder.Name + ".html", playorder++);
                    CreateNavMap(folder.FullName, navin, epub);
                    epub.AddXhtmlData(folder.Name + ".html", HtmlList(folder.FullName));
                   
                }
                else
                {
                    foreach (var imgfile   in GetFiles(folder.FullName,tbImageRule.Text))
                    {
                         epub.AddImageFile(imgfile.FullName,Path.Combine( folder.Name,imgfile.Name));
                    }
                    foreach (var imgfile in GetFiles(folder.FullName, ".css;"))
                    {
                        epub.AddStylesheetFile(imgfile.FullName, Path.Combine(folder.Name, imgfile.Name));
                    }
                   
                }
            }
            foreach (var file in GetFiles(path,tbHtmlRule.Text))
            {
                //epub.AddXhtmlData(file.Name, ReadHtml(file.FullName));
                string epubpath = StringFixer(file.Name, "#");
                epub.AddXhtmlFile(file.FullName, epubpath);
                nav.AddNavPoint(Path.GetFileNameWithoutExtension(file.Name),epubpath, playorder++);
              
            }

         }



        /// <summary>
        /// 写入Html
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private  string ReadHtml(string path)
        {
            using(var fs=new FileStream(path,FileMode.Open))
            {
                
                using (var tr=new StreamReader(fs,Encoding.UTF8))
                {
                    return tr.ReadToEnd();
                }
            }
        }


        /// <summary>
        /// 删除指定字符串，在ncx文件中#等符号不能正确使用
        /// </summary>
        /// <param name="s">源字符串</param>
        /// <param name="part">替换部分</param>
        /// <returns>去掉空格的返回值</returns>
        private string StringFixer(string s,string part)
        {
            return s.Replace(part,"").Trim();
        }


        private void testButton_Click(object sender, EventArgs e)
        {
            var epub = new EPubDocument();
            string source =tbFolder.Text;
            
            //Add metadata
            epub.AddAuthor(textboxAuthor.Text);
            epub.AddTitle(textboxTitle.Text);
            epub.AddLanguage(tbLanguage.Text);
            epub.AddType(tbSubject.Text);

           // String css = EPUBTest.Properties.Resources.style;

            //if (checkBoxFonts.Checked)
            //{
            //    css += "\nbody { font-family: LiberationSerif; }\n";
            //    css += "@font-face { font-family : LiberationSerif; font-weight : normal; font-style: normal; src : url(LiberationSerif-Regular.ttf); }\n";
            //    css += "@font-face { font-family : LiberationSerif; font-weight : normal; font-style: italic; src : url(LiberationSerif-Italic.ttf); }\n";
            //    css += "@font-face { font-family : LiberationSerif; font-weight : bold; font-style: normal; src : url(LiberationSerif-Bold.ttf); }\n";
            //    css += "@font-face { font-family : LiberationSerif; font-weight : bold; font-style: italic; src : url(LiberationSerif-BoldItalic.ttf); }\n";

            //    epub.AddData("LiberationSerif-Regular.ttf", EPUBTest.Properties.Resources.LiberationSerif_Regular, "application/octet-stream");
            //    epub.AddData("LiberationSerif-Bold.ttf", EPUBTest.Properties.Resources.LiberationSerif_Bold, "application/octet-stream");
            //    epub.AddData("LiberationSerif-Italic.ttf", EPUBTest.Properties.Resources.LiberationSerif_Italic, "application/octet-stream");
            //    epub.AddData("LiberationSerif-BoldItalic.ttf", EPUBTest.Properties.Resources.LiberationSerif_BoldItalic, "application/octet-stream");
            //}

            //epub.AddStylesheetData("style.css", css);
            //Bitmap coverImg = EPUBTest.Properties.Resources.pngSample;
            //MemoryStream coverData = new MemoryStream();
            //coverImg.Save(coverData, ImageFormat.Png);
            //String coverId = epub.AddImageData("cover.png", coverData.GetBuffer());
            //epub.AddMetaItem("cover", coverId);
            

            //String page_template = Encoding.UTF8.GetString(EPUBTest.Properties.Resources.page);




            epub.AddImageFile(picCover.ImageLocation, "Cover.jpg");


            var root = epub.AddNavPoint(source, "root", 0);
            epub.AddNavPoint("Cover", "cover.html", 1);
            CreateNavMap(source,root,epub);
            epub.AddXhtmlData("cover.html", "<img src='Cover.jpg'/>");
            SaveFileDialog saveFileDialog = new SaveFileDialog();


            saveFileDialog.Filter = "epub files (*.epub)|*.epub|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                epub.Generate(saveFileDialog.FileName);
            }
        }

        private void btnCoverImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog =new OpenFileDialog();
            if (openFileDialog.ShowDialog( ) == DialogResult.OK)
            {
                picCover.SizeMode = PictureBoxSizeMode.StretchImage;
                picCover.ImageLocation = openFileDialog.FileName;
            }
        }

 

        private void tbFolder_DragDrop(object sender, DragEventArgs e)
        {
            tbFolder.Text = ((System.Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void tbFolder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        //private void picCover_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        e.Effect = DragDropEffects.All;
        //    }
        //}


        //private void picCover_DragDrop(object sender, DragEventArgs e)
        //{
        //    string file = ((System.Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
          
        //        if (System.IO.File.Exists(file))

        //            this.picCover.ImageLocation = file;
        //            // 设置按钮状态
      
            
        //}

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= picCover.Location.X && x <= picCover.Location.X + picCover.Width && y >= picCover.Location.Y && y <= picCover.Location.Y + picCover.Height)
            {

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                picCover.SizeMode = PictureBoxSizeMode.StretchImage;
                picCover.ImageLocation =files[0];
                

            }
        }
    }
}
