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
        private void CreateNavMap(string path1,NavPoint nav,EPubDocument epub)
        {
            var dir =new DirectoryInfo(path1);
            foreach (var folder in dir.GetDirectories( ))
            {
                if (!folder.Name.Contains("_files"))
                {
                    var navin = nav.AddNavPoint(folder.Name, folder.Name + ".html", playorder++);
                    CreateNavMap(folder.FullName, navin, epub);
                    epub.AddXhtmlData(folder.Name + ".html", HtmlList(folder.FullName));
                   
                }
                else
                {
                    foreach (var imgfile   in GetFiles(folder.FullName,".jpg;"))
                    {
                         epub.AddImageFile(imgfile.FullName,Path.Combine( folder.Name,imgfile.Name));
                    }
                    foreach (var imgfile in GetFiles(folder.FullName, ".css;"))
                    {
                        epub.AddStylesheetFile(imgfile.FullName, Path.Combine(folder.Name, imgfile.Name));
                    }
                   
                }
            }
            foreach (var file in GetFiles(path1,".html;"))
            {
                epub.AddXhtmlData(file.Name, ReadHtml(file.FullName));
                nav.AddNavPoint(Path.GetFileNameWithoutExtension(file.Name),file.Name, playorder++);
              
            }

         }

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

        private void testButton_Click(object sender, EventArgs e)
        {
            var epub = new EPubDocument();
            string source = @"C:\Users\cheng\Desktop\新建文件夹";
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




            epub.AddImageFile(picBCover.ImageLocation, "Cover.jpg");
            var root = epub.AddNavPoint(source, "root", 0);
           
            CreateNavMap(source,root,epub);
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
                picBCover.SizeMode = PictureBoxSizeMode.StretchImage;
                picBCover.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
