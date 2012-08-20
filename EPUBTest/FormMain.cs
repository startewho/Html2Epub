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
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Collections;
//第三方的.dll

namespace Wiz2EPub
{

    /*
     * 响应wiz目录控件的响应事件
     */
    [ComVisible(true), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface WizEventListenerInterface
    {
        [PreserveSig, DispId(0)]
        void OnEvents(object param2, object param1, object objCtrl, string commandName);
    }
    [ComVisible(true), ClassInterface(ClassInterfaceType.AutoDispatch)]


    public partial class FormMain : Form, WizEventListenerInterface
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> dic;

        
        /**
         * 获取路径的文件数组
         */
        static FileInfo[] GetFiles(string path, string type)
        {
            var typearr = type.Split(new char[]{';'},StringSplitOptions.RemoveEmptyEntries);
            var dir = new DirectoryInfo(path);
            FileInfo[] fileInfo = (from c in dir.GetFiles() where typearr.Contains( c.Extension.ToLower()) select c).ToArray();
            return fileInfo;
        }
       

        /**
         * 创建导航目录
         */

        private static int _playorder = 0;//自动累加计数
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

        /**
         * 评估进度条时，计算子文档总数
         */
        private int getWizFolderDocumentCount(WizFolder wizfolder)
        {
            WizDocumentCollection documents = wizfolder.Documents;
            int count = documents.count;
            foreach (WizFolder subFolder in wizfolder.Folders)//递归所有子目录
            {
                count += getWizFolderDocumentCount(subFolder);
            }
            return count;

        }


        /**
         * 从wiz folder中 导出为html
         */
        private void ExportWizFolder(string rootpath, WizFolder wizfolder, NavPoint nav, bool isroot, Document epub)
        {
            AddLog("展开目录" + wizfolder.Location + "到" + rootpath);
            
            NavPoint subnav = ExportWizFolderDocuments(wizfolder, rootpath, nav, isroot, epub, 0);

            foreach (WizFolder subFolder in wizfolder.Folders)//递归所有子目录
            {
                ExportWizFolder(rootpath, subFolder, subnav, false, epub);//子nav
            }
        }
       

        /*
         * wiz doc导出为html
         */
        private NavPoint ExportWizFolderDocuments(WizFolder wizfolder, string path, NavPoint nav, bool isroot, Document epub, int flags)
        {
            WizDocumentCollection documents = wizfolder.Documents;
            //将文件导出为ziw，同时生成本节点的索引
            var categorycontent = new StringBuilder(25);
            string categoryhtml = File.ReadAllText(Path.Combine(Application.StartupPath, "page.xhtml"));

            categorycontent.Append("<h1>目录</h1>\r\n");

            string folderindexname = getFolderFileName(wizfolder.Name) + ".html";
           
            NavPoint contentNav = null;

            if (nav == null)//根节点创建
            {
                if (isroot)
                {
                    folderindexname = "root.html";
                    epub.AddNavPoint("目录", folderindexname, _playorder++);//创建节点
                    contentNav = null;
                }
                else
                {
                    contentNav = epub.AddNavPoint(wizfolder.Name, folderindexname, _playorder++);//创建节点
                }
            }
            else//子节点创建目录
            {
                contentNav = nav.AddNavPoint(wizfolder.Name, folderindexname, _playorder++);//创建节点
            }

            //第一次循环，生成catelog.html
            Hashtable hsTemp = new Hashtable();
            
            AddLog("正在生成目录:" + wizfolder.Name);
            foreach (WizDocument objDoc in documents)
            {
                string name = objDoc.Title;
                string fileindex = getDocumentFileName(name);
                string filename = fileindex + ".html";

                hsTemp.Add(fileindex, objDoc);//加入到临时hashmap中

                StringBuilder stringBuilder = categorycontent.AppendFormat("<div><a href=\"{0}\">{1}</a></div>\r\n", filename, name);
            }

            categoryhtml = categoryhtml.Replace("%%TITLE%%", wizfolder.Name);
            categoryhtml = categoryhtml.Replace("%%CONTENT%%", categorycontent.ToString());

            epub.AddXhtmlData(folderindexname, categoryhtml);//写入content

            //需要对key先排序，fileindex定长，根据asc排序

            ArrayList keylist=  new ArrayList(hsTemp.Keys);
            keylist.Sort();

            //第二次循环再加入数据
            foreach (object key in keylist)
            {
                string fileindex = key as string;
                WizDocument objDoc = hsTemp[key] as WizDocument;

                string name = objDoc.Title;
                string filename =  fileindex + ".html";
                string filefullname = Path.Combine(path, filename);
                
                AddLog("正在处理:" + wizfolder.Location + name);

                try
                {
                    objDoc.SaveToHtml(filefullname, flags);
                    html2xhtmlWithCss(filefullname);//转换为xhtml格式

                    epub.AddXhtmlFile(filefullname, filename);//写入到epub中

                    //加入到content中

                    //加入所有资源文件
                    string respath = fileindex + "_files";
                    string resfullpath = Path.Combine(path, respath);
                    if (Directory.Exists(resfullpath))//不存在则不处理子目录
                    {
                        foreach(FileInfo imgfile in GetFiles(resfullpath, tbImageRule.Text))
                        {
                            epub.AddImageFile(imgfile.FullName, Path.Combine(respath, imgfile.Name));
                        }

                        foreach(FileInfo cssFile in GetFiles(resfullpath, ".css;"))
                        {
                            epub.AddStylesheetFile(cssFile.FullName, Path.Combine(respath, cssFile.Name));
                        }
                    }

                            
                    //加入到navpoint中
                    if (isroot)//如果是根目录，则加入到根目录
                    {
                        epub.AddNavPoint(name, filename, _playorder++);
                    }
                    else
                    {
                        contentNav.AddNavPoint(name, filename, _playorder++);
                    }
                }
                catch (Exception e)
                {
                        AddLog("导出html失败:" + e.Message);
                }

                IncrementProgress();

            }


            return contentNav;//返回nav节点
            //categoryhtml

            //生成folder的索引文件
            //把子文档索引写进去
        }

        /*
         *目录改名为 001 002 ...
         */
       private static int _documentOrder = 0;//自动计数2
       private  string getDocumentFileName(string name) 
       {
            ++_documentOrder;
            var sb = new StringBuilder();
            var newname = sb.AppendFormat("node{0:00000}", _documentOrder).ToString();
//            dic.Add(newname, name);
            return newname;
       }

       private static int _folderOrder = 0;//自动计数2
       private string getFolderFileName(String foldername)
       {
           ++_folderOrder;
           var sb = new StringBuilder();
           var newname = sb.AppendFormat("catelog{0:000}", _folderOrder).ToString();
           //            dic.Add(newname, name);
           return newname;
       }

        /*
         * 执行按钮
         */
        private void tbGenerateEpub_Click(object sender, EventArgs e)
        {
            if (btnStart.Text.Equals("下一步"))//下一步的命令
            {
                tabControl1.SelectedIndex = 1;//强制跳到第一个

                return;
            }
            tabControl1.SelectedIndex = 2;//切换到进度tab

            if (tbEPubFilePath.Text.Length < 1)//为空时需要选择文件名
            {
                btnSelectEPubFilePath_Click(null, null);//强制弹出按钮
            }

            if (tbEPubFilePath.Text.Length < 1)
            {
                AddLog("未选择保存的epub文件路径");
                return;
            }

            createTemp();//创建临时目录

            _documentOrder = 0;//重新初始化计数
            _folderOrder = 0;
            _playorder = 1;//重新初始化，从1开始，0表示封面的编号

            int docCount = getWizFolderDocumentCount(axWizCategoryTree.SelectedFolder as WizFolder);

            progressBarConver.Maximum = docCount;
            progressBarConver.Value = 0;

            Document epub = new Document();
            //Add metadata
            epub.AddAuthor(tbAuthor.Text);
            epub.AddTitle(tbTitle.Text);
            epub.AddLanguage(tbLanguage.Text);
            epub.AddType(tbSubject.Text);
            epub.AddStylesheetFile(Path.Combine(Application.StartupPath, "style.css"), "style.css");

            if (picCover.Image != null)
            {
                FileInfo imgfile = new FileInfo(picCover.ImageLocation);
                if (imgfile.Exists)
                {
                    string imgname = "cover" + imgfile.Extension.ToLower();
                    epub.AddImageFile(imgfile.FullName, imgname);
                    epub.AddNavPoint("封面", "cover.xhtml", _playorder++);
                    string html = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xmlns=\"http://www.w3.org/1999/xhtml\"><head><title>Cover</title><style type=\"text/css\"> img { max-width: 100%; } </style></head><body><div id=\"cover-image\"><img src=\"" + imgname + "\" alt=\"为知笔记电子书\"/></div></body></html>";
                    epub.AddXhtmlData("cover.xhtml", html);
                }
            }

            ExportWizFolder(_temppath, axWizCategoryTree.SelectedFolder as WizFolder, null, true, epub);
           
            AddLog("正在生成EPub文件,请稍候...");
            try
            {
                epub.Generate(tbEPubFilePath.Text);
                AddLog("生成EPub完成：" + tbEPubFilePath.Text);
            }
            catch (Exception ex)
            {
                AddLog("失败:" + ex.Message);
            }

            AddLog("正在清理临时文件,请稍候...");
           
            clearTemp();//清理缓存
            
            AddLog("完成");            
            
        }



        /*
         * 设置封面
         */
        private void btnCoverImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog =new OpenFileDialog();

            openFileDialog.Filter = "image files (*.jpg,*.png)|*.jpg;*.png|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog( ) == DialogResult.OK)
            {
                picCover.ImageLocation = openFileDialog.FileName;
            }
        }

 
        /*
         * 拖放目录进来
         */
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

        /*
         * 拖放图片进来当封面
         */
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

        /*
         * 初始化
         */
        private void FormMain_Load(object sender, EventArgs e)
        {
            

            initWiz();
            axWizCategoryTree.EventsListener = this;

            picCover.SizeMode = PictureBoxSizeMode.StretchImage;
            picCover.ImageLocation = Path.Combine(Application.StartupPath, "cover.png");

        }

        /*
         * 初始化wiz
         */
        public void initWiz()
        {
            WizDatabase db = new WizDatabase();
            try
            {
                db.Open("");
                axWizCategoryTree.Database = db;
                axWizCategoryTree.Border = true;
            }
            catch (Exception ex)
            {
                AddLog("打开Wiz数据失败:");
            }
        }

        /*
         * 日志显示
         */

        delegate void delegateAddLog(string msg);
        public void AddLog(String msg)
        {
            if (this.lbConvert.InvokeRequired)
            {
                delegateAddLog d = new delegateAddLog(AddLog);
                this.Invoke(d, new object[] { msg });
            }
            else
            {
                lbConvert.Text = msg;
                if (lbLogs.Items.Count >= 500)
                    lbLogs.Items.RemoveAt(0);
                lbLogs.Items.Add(msg);
                lbLogs.SelectedIndex = lbLogs.Items.Count - 1;

                Application.DoEvents();

            }
        }

        delegate void delegateIncrementProgress();

        public void IncrementProgress()
        {
            if (this.progressBarConver.InvokeRequired)
            {
                delegateIncrementProgress d = new delegateIncrementProgress(IncrementProgress);
                this.Invoke(d);
            }
            else
            {
                progressBarConver.Increment(1);
            }
        }

        //临时缓存路径
        public static string _temppath = Path.GetTempPath() + "Wiz2EPub_" + DateTime.Now.ToString("yyyyMMddHHmmssffff");
        //退出时清理缓存
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        /*
         * 清理临时目录
         */
        private void clearTemp()
        {
            try
            {
                System.IO.Directory.Delete(_temppath, true); //清理缓存目录
            }
            catch (Exception ex)
            {
                AddLog(ex.Message);
            }

        }

        private void createTemp()
        {
            try
            {
                System.IO.Directory.CreateDirectory(_temppath);

            }
            catch (Exception ex)
            {
                AddLog(ex.Message);
                return;
            }
        }

        [DispId(0)]
        public void OnEvents(object param2, object param1, object objCtrl, string commandName)
        {
            if (commandName == "CategoryCtrlOnSelChanged")
            {
                checkConvertReady();
            }
        }
        /*
         * 是否准备就绪
         */
        int isReady = 0;//0表示下一步 1表示准备就绪了

        public void checkConvertReady()
        {
            if (axWizCategoryTree.SelectedFolder == null)//选择无效
            {
                isReady = 0;
                btnStart.Text = "下一步";
                btnStart.Enabled = false;
            }
            else
            {
                btnStart.Enabled = true;
                if (tabControl1.SelectedIndex > 0)
                {
                    btnStart.Text = "生成EPub电子书";
                }
                isReady = 1;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isReady == 0)
            {
                tabControl1.SelectedIndex = 0;//强制跳到第一个
            }
            checkConvertReady();

            if (axWizCategoryTree.SelectedFolder != null)
            {
                if (tbTitle.Tag.Equals("auto") || tbTitle.Text.Length < 1)
                {
                    tbTitle.Text = (axWizCategoryTree.SelectedFolder as WizFolder).Name;
                    tbTitle.Tag = "auto";
                }

                if (tbAuthor.Tag.Equals("auto") || tbAuthor.Text.Length < 1)
                {
                    tbAuthor.Text = (axWizCategoryTree.Database as WizDatabase).UserName;
                    tbAuthor.Tag = "auto";
                }
            }
        }

        /**
         * 设置目标文件
         */
        private void btnSelectEPubFilePath_Click(object sender, EventArgs e)
        {
            tbEPubFilePath.Text = "";
            saveFileDialogEPub.Filter = "epub files (*.epub)|*.epub|All files (*.*)|*.*";
            saveFileDialogEPub.FilterIndex = 1;
            saveFileDialogEPub.RestoreDirectory = true;
            saveFileDialogEPub.FileName = tbTitle.Text+ ".epub";
            if (saveFileDialogEPub.ShowDialog() == DialogResult.OK)
            {
                tbEPubFilePath.Text = saveFileDialogEPub.FileName;
            }
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            tbTitle.Tag = "changed";
        }

        private void tbAuthor_TextChanged(object sender, EventArgs e)
        {
            tbAuthor.Tag = "changed";
        }

        //给html转换为xhtml格式，并加上css
        private static void html2xhtmlWithCss(String filename)
        {
            /* html2xhtml进程总是死，计划改为自己调用命令行
            string runcmd = Application.StartupPath + "\\html2xhtml
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(@"C:\listfiles.bat"); 
            psi.RedirectStandardOutput = true; 
            psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden; 
            psi.UseShellExecute = false; 
            System.Diagnostics.Process listFiles; 
            listFiles = System.Diagnostics.Process.Start(psi); 
            System.IO.StreamReader myOutput = listFiles.StandardOutput; 
            listFiles.WaitForExit(2000);
   
            if (listFiles.HasExited)  
            {  
                 string output = myOutput.ReadToEnd();  
                 
             }
            */

            FileInfo fi = new FileInfo(filename);
            FileStream fs = fi.OpenRead();
            var sr = new StreamReader(fs, Encoding.UTF8);//都出为utf8
            string temp = sr.ReadToEnd();
            sr.Close();
            var sw = new StreamWriter(fi.FullName, false, Encoding.UTF8);

            //调用html2xhtml代码
            temp = Corsis.Xhtml.Html2Xhtml.RunAsFilter(stdin => stdin.Write(temp)).ReadToEnd();
            temp = Corsis.Xhtml.Html2XhtmlExtensions.RipNamespace(temp);
            temp = Regex.Replace(temp, "FONT-FAMILY[^;]+?;", "", RegexOptions.IgnoreCase);
            temp = Regex.Replace(temp, "</head>", " <link href='style.css' rel='stylesheet' type='text/css' />\r\n</head>", RegexOptions.IgnoreCase);
            sw.Write(temp);
            sw.Close();
        }
    }
}
