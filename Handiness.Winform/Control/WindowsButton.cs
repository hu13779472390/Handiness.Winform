﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Handiness.Winform.Control
{

    public enum WindowsButtonType
    {
        Close,
        Minimize,
        Maximize
    }
    public class WindowsButton : BaseControl
    {
        [Description("系统按钮正常时的颜色")]
        public Color NormalColor
        {
            get
            {
                return this._normalColor;
            }
            set
            {
                if (this._normalColor != value)
                {
                    this._normalColor = value;
                    this._currentColor = value;
                    this.Invalidate();
                }
            }
        }
        [Description("指针悬浮时系统按钮的颜色")]
        public Color HoverColor { get; set; } = Color.FromArgb(70, 200, 250);
        [Description("系统按钮被点击时的颜色")]
        public Color DownColor { get; set; } = Color.FromArgb(175, 175, 175);

        [Description(" 图标的大小,以磅值为单位")]
        public Single IconSize
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
        [Description("系统按钮的类型")]
        public WindowsButtonType WindowsButtonType
        {
            get
            {
                return this._windowsButtonType;
            }
            set
            {
                #region 判断windows button 的类型，附加指定的消息函数
                switch (value)
                {
                    case WindowsButtonType.Maximize:
                        {
                            this.Text = AwesomeFont.window_maximize;
                            this._fnSendMessage = () =>
                              {
                                  Form parentForm = this.FindForm();
                                  if (parentForm != null)
                                  {
                                      if (parentForm.WindowState == FormWindowState.Maximized)
                                      {
                                          parentForm.WindowState = FormWindowState.Normal;
                                          this.Text = AwesomeFont.window_maximize;
                                      }
                                      else if(parentForm.WindowState == FormWindowState.Normal)
                                      {
                                          parentForm.WindowState = FormWindowState.Maximized;
                                          this.Text = AwesomeFont.window_restore;
                                      }
                                  }
                              };
                        }
                        break;
                    case WindowsButtonType.Minimize:
                        {
                            this.Text = AwesomeFont.window_minimize;
                            this._fnSendMessage = () =>
                            {
                                Form parentForm = this.FindForm();
                                if (parentForm != null)
                                {
                                    parentForm.WindowState = FormWindowState.Minimized;
                                };
                            };
                        }
                        break;
                    case WindowsButtonType.Close:
                    default:
                        {
                            this.Text = AwesomeFont.window_close_o;
                            this._fnSendMessage = () =>
                            {
                                Form parentForm = this.FindForm();
                                if (parentForm != null)
                                {
                                    parentForm.Close();
                                };
                            };
                        }
                        break;
                }
                this.Invalidate();
                #endregion
                this._windowsButtonType = value;
            }
        }
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override String Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = value;
                this.Invalidate();
            }
        }
        //[Browsable(false)]
        //public override SizeF TextPixelSize
        //{
        //    get
        //    {
        //        return base.TextPixelSize;
        //    }
        //}

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
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
        /********************************/
        private Color _normalColor = Color.FromArgb(61, 195, 245);
        private Color _currentColor = Color.FromArgb(61, 195, 245);
        private Single _shadowWidth = 1;
        private Color _shadowColor = Color.FromArgb(150, 175, 175, 175);
        private WindowsButtonType _windowsButtonType = WindowsButtonType.Close;
        private Action _fnSendMessage;
        public WindowsButton()
        {
            this.Font = new Font(AwesomeFont.FontFamily, 10);
            this.Size = new Size(40, 35);
            this.WindowsButtonType = WindowsButtonType.Close;
            
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {

            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;


            SizeF buttonSzie = new SizeF(this.Width - this._shadowWidth, this.Height - this._shadowWidth);
            Brush nrlBrush = new SolidBrush(this._currentColor);
            Brush shadowBrush = new SolidBrush(this._shadowColor);
            RectangleF buttonRect = new RectangleF(new PointF(0, 0), buttonSzie);
            RectangleF shadowRect = new RectangleF(new PointF(this._shadowWidth, this._shadowWidth), buttonSzie);
            Brush textBrush = new SolidBrush(this.ForeColor);
             

            g.FillRectangle(shadowBrush, shadowRect);
            g.FillRectangle(nrlBrush, buttonRect);

            this.DrawText(g, textBrush, buttonRect);
            //释放笔刷资源
            this.ReleaseBrush(nrlBrush, shadowBrush, textBrush);
            base.OnPaint(pevent);
        }
        protected override void OnClick(EventArgs e)
        {
            this._fnSendMessage.Invoke();
            base.OnClick(e);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            this._currentColor = this.HoverColor;
            this.Invalidate();
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this._currentColor = this.NormalColor;
            this.Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {

            this._currentColor = this.DownColor;
            this.Invalidate();
            base.OnMouseDown(mevent);

        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {

            this._currentColor = this.HoverColor;
            this.Invalidate();
            base.OnMouseUp(mevent);

        }
    }
}
