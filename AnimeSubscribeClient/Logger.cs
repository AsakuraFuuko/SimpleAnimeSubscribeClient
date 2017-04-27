using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeSubscribeClient
{
    public static class Logger
    {
        private static string infoFile = "info.log";
        private static string errorFile = "error.log";
        private static object SpinLock = new object();

        public static void Info(object msg)
        {
            lock (SpinLock)
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.CurrentDirectory, infoFile), true))
                {
                    sw.WriteLine(String.Format("[{0}] {1}", DateTime.Now.ToString("yy-MM-dd HH:mm:ss"), msg));
                }
            }
        }

        public static void Error(object msg)
        {
            lock (SpinLock)
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.CurrentDirectory, errorFile), true))
                {
                    sw.WriteLine(String.Format("[{0}] {1}", DateTime.Now.ToString("yy-MM-dd HH:mm:ss"), msg));
                }
            }
        }
    }
}