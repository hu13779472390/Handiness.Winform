using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
namespace Handiness.Winform.Control
{

    /// <summary>
    /// 标牌的形状类型
    /// </summary>
    public enum ScutcheonShapeType
    {
        /// <summary>
        /// 圆形
        /// </summary>
        Circle,
        /// <summary>
        /// 方形
        /// </summary>
        Square,
        /// <summary>
        /// 三角形
        /// </summary>
        Triangle
    }

    /// <summary>
    /// 标牌
    /// </summary>
    public class Scutcheon : System.Windows.Forms.Control
    {
        [Description("标牌的颜色")]
        public Color ScutcheonColor { get; set; } = Color.FromArgb(175, 175, 175);
        [Description("阴影的颜色")]
        public Color ShadowColor { get; set; } = Color.FromArgb(175, 175, 175);
        [Description("阴影的宽度")]
        public Int32 ShadowWidth { get; set; } = 2;
        [Description("标牌的形状")]
        public ScutcheonShapeType ScutcheonShape { get; set; } = ScutcheonShapeType.Circle;
        [Description("文本内容在当前字体与环境下的占用的大小（注意！当他大于控件的大小时，控件不会显示文字信息）")]
        public SizeF TextPixelSize { get; private set; }

        public Scutcheon() : base()
        {
            this.ScutcheonColor = Color.FromArgb(27, 166, 228);
            this.ForeColor = Color.White;
            
        }
        


        protected override void OnPaint(PaintEventArgs e)
        {
            Int32 scutcheonWidth = this.Width - this.ShadowWidth - 1;
            Int32 scutcheonHeight = this.Height - this.ShadowWidth - 1;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;

            /*********************/

            Rectangle shadowRect = new Rectangle(this.ShadowWidth, this.ShadowWidth, scutcheonWidth, scutcheonHeight);
            Brush shadowBursh = new SolidBrush(this.ShadowColor);


            Rectangle scutcheonRect = new Rectangle(0, 0, scutcheonWidth, scutcheonHeight);
            Brush scutcheonBrush = new SolidBrush(this.ScutcheonColor);

            ///计算文字占用的像素大小
            SizeF textPixelSize = g.MeasureString(this.Text, this.Font);
            this.TextPixelSize = textPixelSize;

            Brush textBrush = new SolidBrush(this.ForeColor);

            PointF textLocation = new PointF((scutcheonWidth - textPixelSize.Width) / 2, (scutcheonHeight - textPixelSize.Height) / 2);
            switch (this.ScutcheonShape)
            {
                case ScutcheonShapeType.Square:
                    {
                        g.FillRectangle(shadowBursh, shadowRect);
                        g.FillRectangle(scutcheonBrush, scutcheonRect);
                    }
                    break;
                case ScutcheonShapeType.Triangle:
                    {
                        //文字相对于垂直居中下移25%
                        textLocation = new PointF((scutcheonWidth - textPixelSize.Width) / 2, (scutcheonHeight * 1.25F - textPixelSize.Height) / 2);
                        PointF[] vertexes = new PointF[]
                            {
                               new PointF(scutcheonWidth/2.0F,0),
                               new PointF(0,scutcheonHeight),
                               new PointF(scutcheonWidth,scutcheonHeight),
                            };
                        PointF[] shadowVertexes = new PointF[]
                           {
                               new PointF(scutcheonWidth/2.0F+this.ShadowWidth,ShadowWidth/2.0F),
                               new PointF(this.ShadowWidth,scutcheonHeight+this.ShadowWidth),
                               new PointF(scutcheonWidth+this.ShadowWidth,scutcheonHeight+this.ShadowWidth),
                            };
                        g.FillPolygon(shadowBursh, shadowVertexes);
                        g.FillPolygon(scutcheonBrush, vertexes);
                    }
                    break;
                case ScutcheonShapeType.Circle:
                default:
                    {
                        g.FillEllipse(shadowBursh, shadowRect);
                        g.FillEllipse(scutcheonBrush, scutcheonRect);
                    }
                    break;
            }
            if (textPixelSize.Width < scutcheonWidth)
            {
                g.DrawString(this.Text, this.Font, textBrush, textLocation);
            }

            shadowBursh.Dispose();
            scutcheonBrush.Dispose();
            base.OnPaint(e);
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
    }
}
