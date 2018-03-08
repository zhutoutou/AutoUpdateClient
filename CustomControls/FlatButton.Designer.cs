using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace CustomControls
{
    partial class FlatButton
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picEidt = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picEidt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picEidt
            // 
            this.picEidt.Location = new System.Drawing.Point(0, 0);
            this.picEidt.Name = "picEidt";

            this.picEidt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picEidt.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picEidt.Size = new System.Drawing.Size(0, 0);
            this.picEidt.TabIndex = 0;
            this.picEidt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picEidt_MouseDown);
            this.picEidt.MouseEnter += new System.EventHandler(this.picEidt_MouseEnter);
            this.picEidt.MouseLeave += new System.EventHandler(this.picEidt_MouseLeave);
            this.picEidt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picEidt_MouseUp);
            // 
            // FlatButton
            // 
            this.Controls.Add(this.picEidt);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor,true);
            this.BackColor = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.picEidt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private DevExpress.XtraEditors.PictureEdit picEidt;
    }
}
