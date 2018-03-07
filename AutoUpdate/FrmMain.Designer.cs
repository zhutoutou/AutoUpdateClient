namespace AutoUpdate
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.progressBarinfo = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelState = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelTitle = new DevExpress.XtraEditors.PanelControl();
            this.picWinmin = new DevExpress.XtraEditors.PictureEdit();
            this.picWinclose = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarinfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTitle)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinclose.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarinfo
            // 
            this.progressBarinfo.Location = new System.Drawing.Point(12, 156);
            this.progressBarinfo.Name = "progressBarinfo";
            this.progressBarinfo.Size = new System.Drawing.Size(397, 31);
            this.progressBarinfo.TabIndex = 0;
            // 
            // labelState
            // 
            this.labelState.Location = new System.Drawing.Point(12, 136);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(60, 14);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "当前进度：";
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 100);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(430, 30);
            this.panelControl1.TabIndex = 4;
            // 
            // panelTitle
            // 
            this.panelTitle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelTitle.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelTitle.ContentImage")));
            this.panelTitle.Controls.Add(this.picWinmin);
            this.panelTitle.Controls.Add(this.picWinclose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(430, 100);
            this.panelTitle.TabIndex = 3;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // picWinmin
            // 
            this.picWinmin.EditValue = global::AutoUpdate.Properties.Resources.最小化;
            this.picWinmin.Location = new System.Drawing.Point(370, 0);
            this.picWinmin.Margin = new System.Windows.Forms.Padding(0);
            this.picWinmin.Name = "picWinmin";
            this.picWinmin.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picWinmin.Properties.Appearance.Options.UseBackColor = true;
            this.picWinmin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picWinmin.Properties.ReadOnly = true;
            this.picWinmin.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picWinmin.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picWinmin.Size = new System.Drawing.Size(30, 20);
            this.picWinmin.TabIndex = 4;
            this.picWinmin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picWinmin_MouseClick);
            this.picWinmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picWinmin_MouseDown);
            this.picWinmin.MouseEnter += new System.EventHandler(this.picWinmin_MouseEnter);
            this.picWinmin.MouseLeave += new System.EventHandler(this.picWinmin_MouseLeave);
            this.picWinmin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picWinmin_MouseUp);
            // 
            // picWinclose
            // 
            this.picWinclose.EditValue = global::AutoUpdate.Properties.Resources.关闭_;
            this.picWinclose.Location = new System.Drawing.Point(400, 0);
            this.picWinclose.Margin = new System.Windows.Forms.Padding(0);
            this.picWinclose.Name = "picWinclose";
            this.picWinclose.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picWinclose.Properties.Appearance.Options.UseBackColor = true;
            this.picWinclose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picWinclose.Properties.ReadOnly = true;
            this.picWinclose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picWinclose.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picWinclose.Size = new System.Drawing.Size(30, 20);
            this.picWinclose.TabIndex = 3;
            this.picWinclose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picWinclose_MouseClick);
            this.picWinclose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picWinclose_MouseDown);
            this.picWinclose.MouseEnter += new System.EventHandler(this.picWinclose_MouseEnter);
            this.picWinclose.MouseLeave += new System.EventHandler(this.picWinclose_MouseLeave);
            this.picWinclose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picWinclose_MouseUp);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 340);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.progressBarinfo);
            this.Controls.Add(this.labelState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "自动更新程序";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarinfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTitle)).EndInit();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWinmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinclose.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl progressBarinfo;
        private DevExpress.XtraEditors.LabelControl labelState;
        private DevExpress.XtraEditors.PanelControl panelTitle;
        private DevExpress.XtraEditors.PictureEdit picWinmin;
        private DevExpress.XtraEditors.PictureEdit picWinclose;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}

