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
        public override String Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = value;
                Graphics g = this.CreateGraphics();
                this.CalcuteTextPixelSize(g, true);
                g.Dispose();
            }
        }
        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                Graphics g = this.CreateGraphics();
                this.CalcuteTextPixelSize(g, true);
                g.Dispose();
            }
        }

        protected virtual SizeF TextPixelSizeCache { get; private set; } = SizeF.Empty;
        /// <summary>
        /// 开启鼠标穿透
        /// </summary>
        [Description("开启鼠标穿透")]
        public virtual Boolean EnabledMousePierce { get; set; } = false;
        public BaseControl()
        {
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.DoubleBuffered = true;
            this.Margin = new Padding(0, 0, 0, 0);
            this.Padding = new Padding(0, 0, 0, 0);
        }
        /// <summary>
        /// 绘制文字信息至指定区域，默认文字垂直位置居中，水平位置由参数<see cref="x"/>指定
        /// </summary>
        /// <param name="g"></param>
        /// <param name="vectorRect"></param>
        protected virtual void DrawText(Graphics g, Brush brush, RectangleF vectorRect, Single x)
        {
            SizeF textSize = this.CalcuteTextPixelSize(g);
            Single offsetY = (vectorRect.Height - textSize.Height) / 2.0F;
            this.DrawText(g, brush, x, offsetY);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            this.Invalidate();
            base.OnTextChanged(e);
        }
        /// <summary>
        /// 在控件上绘制文字信息，此函数默认将文字绘制至区域中心,并根据偏移量调整位置
        /// </summary>
        /// <param name="g"></param>
        /// <param name="vectorRect">承载文字的区域</param>
        /// <param name="offset">文字的偏移量</param>
        protected virtual void DrawText(Graphics g, Brush brush, PointF offset)
        {
            this.DrawText(g, brush, offset.X, offset.Y);
        }
        protected virtual void DrawText(Graphics g, Brush brush, String text, Font font, Single x, Single y)
        {
            if (!String.IsNullOrEmpty(text))
            {
                g.DrawString(text, font, brush, x, y);
            }
        }
        
        protected virtual void DrawText(Graphics g, Brush brush, Single x, Single y)
        {
            this.DrawText(g, brush, this.Text, this.Font, x, y);
        }
        protected virtual SizeF CalcuteTextPixelSize(Graphics g, Boolean force = false)
        {
            if (this.TextPixelSizeCache == SizeF.Empty || force)
            {
                this.TextPixelSizeCache = g.MeasureString(this.Text, this.Font);
            }
            return this.TextPixelSizeCache;
        }
        /// <summary>
        /// 使用 控件的字体与以及字体颜色创建的笔刷绘制 文本至指定的区域正中心
        /// </summary>
        /// <param name="g"></param>
        /// <param name="vectorRect"></param>
        protected virtual void DrawText(Graphics g, RectangleF vectorRect)
        {
            Brush textBrush = new SolidBrush(this.ForeColor);
            this.DrawText(g, textBrush, vectorRect);
            this.ReleaseBrush(textBrush);
        }
        /// <summary>
        /// 在控件上绘制文字信息，此函数默认将文字绘制至区域中心，如果需要调整文字的位置，请使用其他重载
        /// </summary>
        /// <param name="g"></param>
        /// <param name="vectorRect">承载文字的区域</param>
        protected virtual void DrawText(Graphics g, Brush brush, RectangleF vectorRect)
        {
            SizeF textSize = this.CalcuteTextPixelSize(g);
            Single offsetX = (vectorRect.Width - textSize.Width) / 2.0F;
            Single offsetY = (vectorRect.Height - textSize.Height) / 2.0F;
            this.DrawText(g, brush, this.Text, this.Font, offsetX, offsetY);
        }
        protected override void OnParentBackColorChanged(EventArgs e)
        {
            //让容器背景跟随父容器的背景颜色变化
            if (this.Parent != null)
            {
                this.BackColor = this.Parent.BackColor;
            }
            base.OnParentBackColorChanged(e);
        }
        protected virtual void ReleaseBrush(params Brush[] brushs)
        {
            foreach (Brush brush in brushs)
            {
                brush.Dispose();
            }
        }
        protected virtual void SendMessageToParent(Int32 msg, Int32 wParam = 0, Int32 lParam = 0)
        {
            if (this.Parent != null)
            {
                WindowsApi.SendMessage(this.Parent.Handle, msg, wParam, lParam);
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (this.EnabledMousePierce)
            {
                switch (m.Msg)
                {
                    case WindowsConstants.WM_MOUSEACTIVATE:
                    case WindowsConstants.WM_MOUSEFIRST:
                    case WindowsConstants.WM_MOUSEHOVER:
                    case WindowsConstants.WM_MOUSELAST:
                    case WindowsConstants.WM_MOUSELEAVE:
                    case WindowsConstants.WM_LBUTTONDOWN:
                    case WindowsConstants.WM_LBUTTONUP:
                    case WindowsConstants.WM_LBUTTONDBLCLK:
                    case WindowsConstants.WM_RBUTTONDOWN:
                    case WindowsConstants.WM_RBUTTONUP:
                    case WindowsConstants.WM_RBUTTONDBLCLK:
                    case WindowsConstants.WM_MBUTTONDOWN:
                    case WindowsConstants.WM_MBUTTONUP:
                    case WindowsConstants.WM_MBUTTONDBLCLK:
                    case WindowsConstants.WM_NCHITTEST:
                        {
                            //将返回值置为 -1 表示交由父控件处理
                            m.Result = (IntPtr)(-1);
                        }
                        break;
                    default:
                        {
                            base.WndProc(ref m);
                        }
                        break;
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
