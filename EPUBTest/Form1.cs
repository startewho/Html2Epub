using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using Epub;
using WizKMCoreLib;
//第三方的.dll

namespace Html2Epub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rBRootFolder.Select();
            InitFolder();
        }


        private int _order;
        private int _playorder;
        private string _tempDirectory;
        private string _source;
        private Dictionary<string, string> dic;
        DealHtml _dealhtml = new DealHtml( );


        static FileInfo[] GetFiles(string path, string type)
        {
                var typearr = type.Split(new char[]{';'},StringSplitOptions.RemoveEmptyEntries);
                var dir = new DirectoryInfo(path);
                FileInfo[] fileInfo = (from c in dir.GetFiles() where typearr.Contains( c.Extension.ToLower()) select c).ToArray();
                return fileInfo;
            
        }


        private WizKMCoreLib.WizDatabase _wizdb=new WizDatabase();
       
        private string HtmlList(string path)
        {
            var result = new StringBuilder(25);
            string temp = File.ReadAllText(Path.Combine(Application.StartupPath,"page.xhtml"));

            var fileinfolist = GetFiles(path, ".html;.xhtml;.htm");
            result.Append("<h1>Content</h1>\r\n");
            foreach (var fileInfo in fileinfolist)
            {
                var filename=Path.GetFileNameWithoutExtension(fileInfo.Name);
                StringBuilder stringBuilder = result.AppendFormat("<div><a href=\"{0}\">{1}</a></div>\r\n", fileInfo, dic.ContainsKey(filename) ? dic[filename] : filename);
             
            }
            temp = temp.Replace("%%TITLE%%", path);
            temp = temp.Replace("%%CONTENT%%", result.ToString());
            return temp;
        }

        
        private void CreateNavMap(string path,NavPoint nav,Document epub)
        {
            var dir =new DirectoryInfo(path);

            foreach (var folder in dir.GetDirectories( ))
            {
                if (!folder.Name.Contains(tbFolderRule.Text))
                {
                    var navin = nav.AddNavPoint(folder.Name, folder.Name + ".xhtml", _playorder++);
                    CreateNavMap(folder.FullName, navin, epub);
                    epub.AddXhtmlData(folder.Name + ".xhtml", HtmlList(folder.FullName));
                   
                }
                else
                {

                    Parallel.ForEach(GetFiles(folder.FullName, tbImageRule.Text), imgfile =>
                                                        {
                                                            epub.AddImageFile( imgfile.FullName, Path.Combine(folder.Name,imgfile.Name));
                                                        });

                    Parallel.ForEach(GetFiles(folder.FullName, ".css;"), cssFile =>
                                                        {
                                                            epub.AddStylesheetFile(cssFile.FullName,Path.Combine(folder.Name,cssFile.Name));
                                                        });

                }
            }
            foreach (var file in GetFiles(path,tbHtmlRule.Text))
            {
                string tempstr;
                string filename = Path.GetFileNameWithoutExtension(file.Name);
                string epubpath = StringFixer(dic.ContainsKey(filename)?dic[filename]:filename, "#");
                epub.AddXhtmlFile(file.FullName, file.Name);
                nav.AddNavPoint(epubpath,file.Name, _playorder++);
                tempstr = string.Empty;
            }

       

         }



        private string GetTempDirectory()
        {
            
                _tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                Directory.CreateDirectory(_tempDirectory);
                return _tempDirectory;
        }


        /// <summary>
        /// 删除指定字符串，在ncx文件中#等符号不能正确使用
        /// </summary>
        /// <param name="s">源字符串</param>
        /// <param name="part">替换部分</param>
        /// <returns>去掉空格的返回值</rteurns>
        private string StringFixer(string s,string part)
        {
            return s.Replace(part,"").Trim();
        }

        private  void InitFolder()
        {
            _wizdb.Open("");
            var folders = _wizdb.Folders;
            cmBFolder.Items.Add("All");
            foreach (var folder in folders)
            {
                cmBFolder.Items.Add(folder.Name);

            }
            _wizdb.Close();
        }

        private WizFolder SetFolder ()
        {
            _wizdb.Open("");
           
            foreach (var folder in _wizdb.Folders)
            {
             
                if (folder.Name == cmBFolder.Text)
                return folder;
               
            }
            
            return _wizdb.Folders[3].RootFolder;
        }

        private List<WizFolder> GetWizFolderList()
        {
            List<WizFolder> list=new List<WizFolder>();
            _wizdb.Open("");
            foreach (var folder in _wizdb.Folders)
            {
                 list.Add(folder);
            }
           
            return list;
        }
         
        private void GetWizHtmlFolder(string htmlfolder,WizFolder wizfolder)
        {

               ExportHtml(wizfolder, Path.Combine(htmlfolder, wizfolder.Name + "\\"), "0");
          //  string path = Path.Combine(_wizdb.DatabasePath, cmBFolder.Text+"\\");
        
                foreach (var folder in wizfolder.Folders )
                {
                    ExportHtml(folder, Path.Combine(htmlfolder, wizfolder.Name + "\\" + folder.Name + "\\"), "0");
                }
               
            //return htmlfolder;
        }
       


        void ExportHtml(WizFolder objFolder, string path, string flags)
        {
            WizDocumentCollection documents = objFolder.Documents;

            //Action<WizFolder> awiz = Test;
           // Parallel.ForEach(objFolder.Documents,   d(doc));
            Parallel.For(0, documents.count, i =>
                                                 {
                                                     var objDoc = documents[i];
                                                     var name = objDoc.Title;
                                                     var filename = path + MakeValidFileName(name) + ".xhtml";
                                                     objDoc.SaveToHtml(filename, flags);
                                                     //
                                                 }
                );

        }
        


       private  string MakeValidFileName(string name) 
       {
         
               ++_order;
               var sb = new StringBuilder();
               var newname = sb.AppendFormat("{0:000}", _order).ToString();
               dic.Add(newname, name);
               return newname;
          
       }


        private void tbGenerateEpub_Click(object sender, EventArgs e)
        {
            var epub = new Document();
            _order = 0;
            _playorder = 0;
            dic=new Dictionary<string, string>(35);
            _tempDirectory = GetTempDirectory();
            List<WizFolder> _list = GetWizFolderList();

            if (cmBFolder.SelectedIndex==0)
            {
                foreach (var wizFolder in _list)
                {
                    GetWizHtmlFolder(_tempDirectory, wizFolder);
                }
                _source = _tempDirectory;
            }
            else
            {
                GetWizHtmlFolder(_tempDirectory, _list[cmBFolder.SelectedIndex-1]);
                _source = Path.Combine(_tempDirectory, cmBFolder.Text+"\\");
            }


            _dealhtml.AdjustNook(_source);
           
            //Add metadata
            epub.AddAuthor(textboxAuthor.Text);
            epub.AddTitle(textboxTitle.Text);
            epub.AddLanguage(tbLanguage.Text);
            epub.AddType(tbSubject.Text);
            epub.AddStylesheetFile(Path.Combine(Application.StartupPath, "style.css"), "style.css");

            if (picCover.Image != null)
            {
                epub.AddImageFile(picCover.ImageLocation, "Cover.jpg");
                epub.AddNavPoint("Cover", "cover.xhtml", _playorder++);
                epub.AddXhtmlData("cover.xhtml", "<img src='Cover.jpg'/>");
            }
            var root = epub.AddNavPoint(cmBFolder.Text, "root.xhtml", _playorder++);
            epub.AddXhtmlData("root.xhtml", HtmlList(_source));
            
            CreateNavMap(_source,root,epub);
          

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "epub files (*.epub)|*.epub|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = cmBFolder.Text;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    epub.Generate(saveFileDialog.FileName);
                    MessageBox.Show("生成EPUB完成：" + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("失败:" + ex.Message);
                }
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
