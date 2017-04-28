using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Handiness.Winform.Control
{
    public class Shade : BaseControl
    {
        /// <summary>
        /// 遮罩的Alpha值
        /// </summary>
        public Int32 Alpha { get { return this._alpha; } set { this._alpha = value; this.Invalidate(); } }
        /// <summary>
        /// 是否绘制文字
        /// </summary>
        public Boolean CanDrawText
        {
            get
            {
                return this._canDrawText;
            }
            set
            {
                this._canDrawText = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 开启 WS_EX_TRANSPARENT,使控件支持透明
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020;
                return cp;
            }
        }

        /********************************/
        private Int32 _alpha = 150;
        private Boolean _canDrawText = true;
        public Shade()
        {
            this.SetStyle(ControlStyles.Opaque, true);
            this.FollowParentBackColor = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Color color = Color.FromArgb(this.Alpha, this.BackColor);
            Brush backBrush = new SolidBrush(color);

            g.FillRectangle(backBrush, this.ClientRectangle);
            if (this.CanDrawText)
            {
                Brush textBrush = new SolidBrush(this.ForeColor);
                e.Graphics.DrawString(this.Text, this.Font, textBrush, this.ClientRectangle, this.TextAlignFormat);
                textBrush.Dispose();
            }

            base.OnPaint(e);
        }
    }
}
