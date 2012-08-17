using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Html2Epub
{
    class DealHtml
    {

        public  void AdjustNook(string path)
         {
             var dirinfo = new DirectoryInfo(path);
             Parallel.ForEach(GetFiles(path, ".html;.htm;.xhtml"), fileInfo => AddCss(fileInfo));
             Parallel.ForEach(dirinfo.GetDirectories(), dir =>AdjustNook(dir.FullName) );
         }
        
         
         private void AddCss(FileInfo fi)
         {

             FileStream fs = fi.OpenRead();
             var sr =new StreamReader(fs,Encoding.UTF8);
             string temp = sr.ReadToEnd();
             sr.Close( );
          
             var sw =new StreamWriter(fi.FullName,false,Encoding.UTF8);

             //调用html2xhtml代码
             temp = Corsis.Xhtml.Html2Xhtml.RunAsFilter(stdin => stdin.Write(temp)).ReadToEnd( );
             temp = Corsis.Xhtml.Html2XhtmlExtensions.RipNamespace(temp);
             temp = Regex.Replace(temp, "FONT-FAMILY[^;]+?;", "", RegexOptions.IgnoreCase);
             temp = Regex.Replace(temp, "</head>", " <link href='style.css' rel='stylesheet' type='text/css' />\r\n</head>", RegexOptions.IgnoreCase); 
            sw.Write(temp);
            sw.Close();
         }
         
         
         
         static FileInfo[] GetFiles(string path, string type)
        {
            var typearr = type.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var dir = new DirectoryInfo(path);
            FileInfo[] fileInfo = (from c in dir.GetFiles( ) where typearr.Contains(c.Extension.ToLower( )) select c).ToArray( );
            return fileInfo;

        }
    }
}
