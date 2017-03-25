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
                //switch (value)
                //{
                //    case WindowsButtonType.Maximize:
                //        {
                //            this._fnSendMessage = () =>
                //              {
                //                  Form form = this.FindForm();
                //                  if (form == null)
                //                  {
                //                      return;
                //                  }
                //                  if (form.WindowState == FormWindowState.Maximized)
                //                  {
                //                      this.Text = "000";
                //                  }
                //              };
                //        }
                //        break;
                //    case WindowsButtonType.Minimize:
                //        {
                //        }
                //        break;
                //    case WindowsButtonType.Close:
                //    default:
                //        {
                //        }
                //        break;
                //}
                #endregion
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
            this.Font = new Font(AwesomeFont.FontFamily, 15, FontStyle.Regular);
            this.Text = AwesomeFont.address_book;
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
