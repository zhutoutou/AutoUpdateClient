using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CustomControls
{
    [ToolboxItem(true)]
    public class PicEidtEx:PictureEdit
    {
        public PicEidtEx()
        {
            HoverColor = Color.FromArgb(100, 0, 0, 0);
            ClickColor = Color.FromArgb(100, 0, 0, 0);
            this.Properties.Appearance.BackColor = Color.Transparent;
            this.MouseEnter += PicEidtEx_MouseEnter;
            this.MouseLeave += PicEidtEx_MouseLeave;
            this.MouseUp += PicEidtEx_MouseUp;
            this.MouseDown += PicEidtEx_MouseDown;
        }

        private void PicEidtEx_MouseEnter(object sender, EventArgs e)
        {
            this.Properties.Appearance.BackColor = HoverColor;
        }

        private void PicEidtEx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Properties.Appearance.BackColor = ClickColor;
            }
        }

        private void PicEidtEx_MouseLeave(object sender, EventArgs e)
        {
            this.Properties.Appearance.BackColor = Color.Transparent;
        }

        private void PicEidtEx_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Properties.Appearance.BackColor = HoverColor;
            }
        }

        public Color HoverColor { get; set; }

        public Color ClickColor { get; set; }
    }
}
