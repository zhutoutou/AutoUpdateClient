using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace CustomControls
{
    public partial class FlatButton : Control
    {
        public FlatButton()
        {
            InitializeComponent();
            HoverColor = Color.FromArgb(100, 0, 0, 0);
            ClickColor = Color.FromArgb(100, 0, 0, 0);

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            picEidt.Size = new System.Drawing.Size(Width, Height);
            if (PicImage != null)
            {
                picEidt.EditValue = PicImage;
                picEidt.Properties.SizeMode = PictureSizeMode.Zoom;
            }
            base.OnPaint(pe);
        }

        public Color HoverColor;

        public Color ClickColor;

        public Image PicImage;

        private void picEidt_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.picEidt.Properties.Appearance.BackColor = ClickColor;
            }
        }

        private void picEidt_MouseEnter(object sender, EventArgs e)
        {
            this.picEidt.Properties.Appearance.BackColor = HoverColor;
        }

        private void picEidt_MouseLeave(object sender, EventArgs e)
        {
            this.picEidt.Properties.Appearance.BackColor = Color.Transparent;
        }

        private void picEidt_MouseUp(object sender, MouseEventArgs e)
        {
            this.picEidt.Properties.Appearance.BackColor = HoverColor;
        }
    }
}
