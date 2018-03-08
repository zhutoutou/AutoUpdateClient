using System;
using System.Configuration;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdate
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.picEidtEx.ClickColor = Color.FromArgb(100, 100, 100, 255);
            this.picEidtEx.HoverColor = Color.FromArgb(100, 200, 0, 0);
            labelState.Text = "开始运行";
        }

        public new UpdateHelper Update;

        private bool _beiginMove;
        private int _currentYPosition;
        private int _currentXPosition;

        public delegate void RefreshHandler(object value);

        private void Initialize()
        {
            try
            {
                string url = ConfigurationManager.AppSettings["SourceURL"];

                progressBarinfo.Properties.PercentView = true;
                Update = new UpdateHelper();
                Update.GetCurValue += Update_GetCurValue;
                Update.GetMaxVaule += Update_GetMaxVaule;

                Task.Factory.StartNew(() =>
                {
                    SetLabelText("开始关闭");
                    Task kiiopro = Update.KillProAsync("SocketTool");
                    if (kiiopro.IsCompleted)
                    {
                        SetLabelText("关闭成功");
                        string path = Application.StartupPath + "\\" + DateTime.Now.ToString("yyyyMMdd");
                        Task<string> t2 = Update.DownloadAsync(url, path + ".zip");
                        Task<bool> t3 = Update.ExtractAsync(t2.Result, path);
                        if (t3.Result)
                        {
                            Update.StartPro(path + "\\SocketTool");
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                        SetLabelText("关闭失败");
                    }
                });
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void SetLabelText(object value)
        {
            if (labelState.InvokeRequired)
            {
                BeginInvoke(new RefreshHandler(SetLabelText), value);
            }
            else
            {
                labelState.Text = value.ToString();
            }
        }

        private void Update_GetMaxVaule(object value)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new RefreshHandler(Update_GetMaxVaule), value);
            }
            else
            {
                int val = (int)value;
                progressBarinfo.Properties.Maximum = val;
            }
        }

        private void Update_GetCurValue(object value)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new RefreshHandler(Update_GetCurValue), value);
            }
            else
            {
                int val = (int)value;
                progressBarinfo.Properties.Step = val;
                progressBarinfo.PerformStep();
                progressBarinfo.Update();
            }
        }

        #region 事件
        #region panelTitle的事件
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                _beiginMove = true;
                _currentXPosition = MousePosition.X;
                _currentYPosition = MousePosition.Y;
            }
        }
        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {

            if (_beiginMove)
            {
                Left += MousePosition.X - _currentXPosition;
                Top += MousePosition.Y - _currentYPosition;
                _currentXPosition = MousePosition.X;
                _currentYPosition = MousePosition.Y;
            }
        }
        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                _beiginMove = false;
            }
        }
        #endregion

        #region 最小化按钮的事件
        private void picWinmin_MouseEnter(object sender, EventArgs e)
        {
            picWinmin.BackColor = Color.FromArgb(100, 100, 100, 255);
        }

        private void picWinmin_MouseLeave(object sender, EventArgs e)
        {
            picWinmin.BackColor = Color.FromArgb(0, 100, 100, 255);
        }

        private void picWinmin_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picWinmin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picWinmin.BackColor = Color.FromArgb(100, 0, 0, 0);
            }
        }

        private void picWinmin_MouseUp(object sender, MouseEventArgs e)
        {
            picWinmin.BackColor = Color.FromArgb(100, 100, 100, 255);
        }


        #endregion
        
        #region 关闭按钮的事件
        private void picWinclose_MouseEnter(object sender, EventArgs e)
        {
            picWinclose.BackColor = Color.FromArgb(100, 200, 0, 0);
        }

        private void picWinclose_MouseLeave(object sender, EventArgs e)
        {
            picWinclose.BackColor = Color.FromArgb(0, 200, 0, 0);
        }

        private void picWinclose_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void picWinclose_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picWinclose.BackColor = Color.FromArgb(100, 0, 0, 0);
            }
        }

        private void picWinclose_MouseUp(object sender, MouseEventArgs e)
        {
            picWinclose.BackColor = Color.FromArgb(100, 200, 0, 0);
        }


        #endregion
        #endregion
    }
}