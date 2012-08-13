using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WizKMCoreLib;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WizDatabase _wizdb=new WizDatabase();
            _wizdb.Open("");
            Action<WizFolder> ac = Program.Counter;

            Parallel.ForEach(_wizdb.Folders, ac(_wizdb.Folders[0]));
         
            Console.ReadKey();
        }

       static void Counter(WizFolder i)
       {
           Console.WriteLine("i={0},TaskName={1},ThreadName={2}", i, Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
       }
    }
}
