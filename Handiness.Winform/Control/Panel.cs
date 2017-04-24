using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Handiness.Winform.Control
{
    public class Panel : System.Windows.Forms.Panel
    {
        /// <summary>
        /// 自定义边框的样式
        /// </summary>
        [Description("自定义边框的样式")]
        public ButtonBorderStyle CustomBorderStyle { get; set; } = ButtonBorderStyle.Solid;
        /// <summary>
        ///自定义边框的颜色
        /// </summary>
        [Description("自定义边框的颜色")]
        public Color CustomBorderColor { get; set; } = Color.Gray;

        [Description("自定义边框的宽度")]
        public Int32 CustomBorderWith { get; set; } = 1;
        /// <summary>
        /// 是否绘制边框
        /// </summary>
        public Boolean IsPaintBorder { get; set; } = true;

        public Panel() : base()
        {
            this.DoubleBuffered = true;
        }
        

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.IsPaintBorder)
            {
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, this.CustomBorderColor, this.CustomBorderWith,
                                           this.CustomBorderStyle, this.CustomBorderColor, this.CustomBorderWith,
                                           this.CustomBorderStyle, this.CustomBorderColor, this.CustomBorderWith,
                                           this.CustomBorderStyle, this.CustomBorderColor, this.CustomBorderWith,
                                           this.CustomBorderStyle);

            }
            base.OnPaint(e);
        }
    }
}
