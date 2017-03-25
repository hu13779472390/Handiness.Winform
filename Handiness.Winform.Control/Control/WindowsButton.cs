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

    public enum WindowsButtonType
    {
        Close,
        Minimize,
        Maximize
    }
    public class WindowsButton : Button
    {

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
        [Browsable(false)]
        public override SizeF TextPixelSize
        {
            get
            {
                return base.TextPixelSize;
            }
        }

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
        /********************************/
        private WindowsButtonType _windowsButtonType = WindowsButtonType.Close;
        private Action _fnSendMessage;
        public WindowsButton()
        {
            this.Font = new Font(AwesomeFont.FontFamily, 10);
            this.Size = new Size(40, 35);
            this.WindowsButtonType = WindowsButtonType.Close;
        }
        protected override void OnClick(EventArgs e)
        {
            this._fnSendMessage.Invoke();
            base.OnClick(e);
        }
    }
}
