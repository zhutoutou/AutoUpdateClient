using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"开始运行");
            Task task = KillProAsync("");
            Console.WriteLine($"运行结束1");
            if (task.IsCompleted)
            {
                Console.WriteLine($"运行结束2,计数{task.IsCompleted}");
            }
            Console.WriteLine("结束");
            Console.ReadLine();
        }

        private static async Task<int> CountCharactersAsync(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            Console.WriteLine($"开始调用");

            /*var res = await req.GetResponseAsync()*/
            ;
            var res = await Task.Factory.StartNew(() => req.GetResponse().ContentLength);
            Console.WriteLine($"调用完成");

            return (int)res;
        }

        /// <summary>
        /// 关闭目标程序
        /// </summary>
        /// <param name="name"></param>
        public static async Task KillProAsync(string name)
        {
            await Task.Factory.StartNew(() =>
            {
                bool hasKill = false;
                while (!hasKill)
                {
                    Process[] process = Process.GetProcesses();
                    foreach (var pro in process)
                    {
                        if (pro.ProcessName == name)
                        {
                            pro.Kill();
                        }
                    }
                    Thread.Sleep(1000 * 2);
                    if (!(from pro in Process.GetProcesses() where pro.ProcessName == name select pro).Any())
                    {
                        hasKill = true;
                    }
                }
            });
        }
    }
}