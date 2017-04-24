﻿using System;
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
        public virtual SizeF TextPixelSize { get; private set; }
        /// <summary>
        /// 开启鼠标穿透
        /// </summary>
        [Description("开启鼠标穿透")]
        public virtual Boolean CanMousePenetrable { get; set; } = false;
        public BaseControl()
        {
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.UserPaint,true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.DoubleBuffered = true;
        }
        /// <summary>
        /// 绘制文字信息至指定区域，默认文字垂直位置居中，水平位置由参数<see cref="x"/>指定
        /// </summary>
        /// <param name="g"></param>
        /// <param name="vectorRect"></param>
        /// <param name="x">若值为0 则文字水平也居中</param>
        protected virtual void DrawText(Graphics g, Brush brush, RectangleF vectorRect, Single x)
        {
            PointF offsex = new PointF(0, 0);
            if (x != 0)
            {
                vectorRect.Width = 0;
                offsex.X = x;
            }
            this.DrawText(g, brush, vectorRect, offsex);
        }
        /// <summary>
        /// 在控件上绘制文字信息，此函数默认将文字绘制至区域中心,并根据偏移量调整位置
        /// </summary>
        /// <param name="g"></param>
        /// <param name="vectorRect">承载文字的区域</param>
        /// <param name="offset">文字的偏移量</param>
        protected virtual void DrawText(Graphics g, Brush brush, RectangleF vectorRect, PointF offset)
        {
            SizeF textPixelSize = this.FetchTextPixelSize(g);
            this.TextPixelSize = textPixelSize;
            PointF textLocation = new PointF(0, 0);
            textLocation.X = vectorRect.Width != 0 ? (vectorRect.Width - textPixelSize.Width) / 2 : 0;
            textLocation.Y = vectorRect.Height != 0 ? (vectorRect.Height - textPixelSize.Height) / 2 : 0;
            if (!offset.IsEmpty)
            {
                textLocation.X += offset.X;
                textLocation.Y += offset.Y;
            }
            if (textLocation.X + textPixelSize.Width < this.Width)
            {
                this.DrawText(g, brush, textLocation.X, textLocation.Y);
            }
        }
        protected virtual void DrawText(Graphics g, Brush brush, Single x, Single y)
        {
            if (!String.IsNullOrEmpty(this.Text))
            {
                g.DrawString(this.Text, this.Font, brush, x, y);
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
        protected virtual void DrawText(Graphics g, Brush brush, RectangleF vectorRect)
        {
            this.DrawText(g, brush, vectorRect, PointF.Empty);
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
        protected virtual void SendMessageToParent(Int32 msg,Int32 wParam=0,Int32 lParam=0)
        {
            if (this.Parent != null)
            {
                WindowsApi.SendMessage(this.Parent.Handle, msg, wParam, lParam);
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (this.CanMousePenetrable)
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
