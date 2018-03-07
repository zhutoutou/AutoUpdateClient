using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using static System.IO.Compression.ZipFile;

namespace AutoUpdate
{
    public class UpdateHelper
    {
        #region 事件
        /// <summary>
        /// 进度条最大值改变时间
        /// </summary>
        public event EventArgsEx GetMaxVaule;

        /// <summary>
        /// 进度条值改变事件
        /// </summary>
        public event EventArgsEx GetCurValue;

        /// <summary>
        /// 进度条事件委托
        /// </summary>
        /// <param name="value"></param>
        public delegate void EventArgsEx(object value);

        #endregion 事件

        #region 构造函数

        public UpdateHelper()
        {
        }

        #endregion 构造函数

        #region 方法
        /// <summary>
        /// 关闭程序
        /// </summary>
        /// <param name="name">程序名称</param>
        public async Task KillProAsync(string name)
        {
            await Task.Factory.StartNew(() =>
            {
                bool blnSucess = false;
                while (!blnSucess)
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
                        blnSucess = true;
                    }
                }
            });
        }

        /// <summary>
        /// 启动程序
        /// </summary>
        /// <param name="path">程序启动地址</param>
        public void StartPro(string path)
        {
            Process.Start(path);
        }

        /// <summary>
        /// 下载最新版本
        /// </summary>
        /// <param name="sourcepath">下载地址</param>
        /// <param name="installpath">安装路径</param>
        public async Task<string> DownloadAsync(string sourcepath, string installpath)
        {
            await Task.Factory.StartNew(() =>
            {
                string path = installpath.Substring(0, installpath.Length - installpath.LastIndexOf('\\'));
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sourcepath);
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                long totalsize = res.ContentLength;
                OnGetProcessBarMaxValue((int)totalsize);
                byte[] buffer = new byte[1024];
                int curHasreadsize = 0;
                Stream sr = res.GetResponseStream();
                Stream sw = new FileStream(installpath, FileMode.Create);
                if (sr != null)
                {
                    int osize = sr.Read(buffer, 0, buffer.Length);
                    while (osize > 0)
                    {
                        curHasreadsize = curHasreadsize + osize;
                        OnGetProcessBarCurValue(curHasreadsize);
                        sw.Write(buffer, 0, osize);
                        osize = sr.Read(buffer, 0, buffer.Length);
                    }
                }

                sr?.Close();
                sw.Close();
            });
            return installpath;
        }

        /// <summary>
        /// 解压缩目标文件
        /// </summary>
        /// <param name="srcfilepath">资源文件</param>
        /// <param name="desfilepath">目标地址</param>
        /// <returns></returns>
        public async Task<bool> ExtractAsync(string srcfilepath, string desfilepath)
        {
            var task = await Task.Factory.StartNew(() =>
            {
                var zipArchive = Open(srcfilepath, ZipArchiveMode.Read);
                if (srcfilepath != null)
                {
                    DeleteDirectory(desfilepath);
                    ExtractToDirectory(srcfilepath, desfilepath);
                }

                return true;
            });
            return task;
        }

        private void DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                foreach (var file in Directory.GetFiles(path))
                {
                    if (File.Exists(file))
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch (Exception)
                        {
                            // ignored
                        }
                    }
                }
                Directory.Delete(path);
            }
        }
        #endregion
        private void OnGetProcessBarMaxValue(int value)
        {
            GetMaxVaule?.Invoke(value);
        }

        private void OnGetProcessBarCurValue(int value)
        {
            GetCurValue?.Invoke(value);
        }
    }
}