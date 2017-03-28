using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Handiness.Winform.Control
{
    public  class Symbol: BaseControl
    {

        [Description(" 图标的大小,以磅为单位")]
        public Single SymbolSize
        {
            get
            {
                return this.Font.Size;
            }
            set
            {
                this.Font = new Font(AwesomeFont.FontFamily, value);
            }
        }
        [Description(" 图标的颜色")]
        public Color SymbolColor
        {
            get
            {
                return this.ForeColor;
            }
            set
            {
                this.ForeColor = value ;
                this.Invalidate();
            }
        }

        [Editor(typeof(AwesomeFontCodeSelector),typeof(UITypeEditor))]
        [Description("图标的样式")]
        public string SymbolPattern
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }

        [Obsolete]
        [Browsable(false)]
        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
            }
        }

        [Obsolete]
        [Browsable(false)]
        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = value;
            }
        }

        [Browsable(false)]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }

            set
            {
                base.ForeColor = value;
            }
        }

        public Symbol()
        {
            this.Font = new Font(AwesomeFont.FontFamily, 15);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush textBrush = new SolidBrush(this.ForeColor);
            RectangleF Rect = new RectangleF(new PointF(0, 0), this.Size);
            this.DrawText(g, textBrush, Rect);
            //释放笔刷资源
            this.ReleaseBrush(textBrush);
            base.OnPaint(pevent);
        }

      
    }
}
