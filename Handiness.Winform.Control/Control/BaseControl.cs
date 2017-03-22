using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Handiness.Winform;
namespace Handiness.Winform.Control
{
    public class BaseControl : System.Windows.Forms.Control
    {
        [Description("文本内容在当前字体与环境下的占用的大小（注意！当他大于控件的大小时，控件不会显示文字信息）")]
        public SizeF TextPixelSize { get; private set; }
        /// <summary>
        /// 开启鼠标穿透
        /// </summary>
        [Description("开启鼠标穿透")]
        public Boolean CanMousePenetrable { get; set; } = false;
        public BaseControl()
        {
            this.SetStyle(ControlStyles.Opaque, false);
            this.DoubleBuffered = true;
        }

        /// <summary>
        /// 在控件上绘制文字信息，此函数默认将文字绘制至区域中心
        /// </summary>
        /// <param name="g"></param>
        /// <param name="vectorRect">承载文字的区域</param>
        /// <param name="offset">文字的偏移量</param>
        protected virtual void DrawText(Graphics g, RectangleF vectorRect, PointF offset)
        {
            if (!String.IsNullOrEmpty(this.Text))
            {
                SizeF textPixelSize = this.FetchTextPixelSize(g);
                this.TextPixelSize = textPixelSize;

                Brush textBrush = new SolidBrush(this.ForeColor);
                PointF textLocation = new PointF(0, 0);
                if (!vectorRect.IsEmpty)
                {
                    textLocation.X = vectorRect.Width != 0 ? (vectorRect.Width - textPixelSize.Width) / 2 : 0;
                    textLocation.Y = vectorRect.Height!=0?(vectorRect.Height - textPixelSize.Height) / 2:0;
                }
                if (!offset.IsEmpty)
                {
                    textLocation.X += offset.X;
                    textLocation.Y += offset.Y;
                }
                g.DrawString(this.Text, this.Font, textBrush, textLocation);
                textBrush.Dispose();
            }
        }
        protected virtual SizeF FetchTextPixelSize(Graphics g)
        {
            return g.MeasureString(this.Text, this.Font);
        }
        /// <summary>
        /// 在控件上绘制文字信息，此函数默认将文字绘制至区域中心，如果需要调整文字的位置，请使用其他重载
        /// </summary>
        /// <param name="g"></param>
        /// <param name="vectorRect">承载文字的区域</param>
        protected virtual void DrawText(Graphics g, RectangleF vectorRect)
        {
            this.DrawText(g, vectorRect, PointF.Empty);
        }
        protected override void OnParentBackColorChanged(EventArgs e)
        {
            //让容器背景跟随父容器的背景颜色变化
            this.BackColor = this.Parent.BackColor;
            base.OnParentBackColorChanged(e);
        }
        protected virtual void ReleaseBrush(params Brush[] brushs)
        {
            foreach (Brush brush in brushs)
            {
                brush.Dispose();
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (this.CanMousePenetrable)
            {
                switch (m.Msg)
                {
                    case WMConstants.WM_MOUSEACTIVATE:
                    case WMConstants.WM_MOUSEFIRST:
                    case WMConstants.WM_MOUSEHOVER:
                    case WMConstants.WM_MOUSELAST:
                    case WMConstants.WM_MOUSELEAVE:
                        {
                            m.Msg = WMConstants.WM_NULL;
                        }
                        break;
                }
            }
            base.WndProc(ref m);
        }
    }
}
