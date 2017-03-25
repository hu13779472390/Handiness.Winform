using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Handiness.Winform
{
    public partial class BaseForm : Form
    {
        private Point _currentMousePoint;
        private Boolean _isMove = false;
        /********************************/
        public BaseForm()
        {
            InitializeComponent();
            this.InitializeForm();
        }
        /// <summary>
        /// 初始化窗体
        /// </summary>
        protected virtual void InitializeForm()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.Opaque, false);
            this.Icon = Properties.Resources.HandinessIcon;
               this.TransparencyKey = Color.FromArgb(240,240,240);
            this.BackColor = Color.FromArgb(240, 240, 240);
        }

        /// <summary>
        /// 窗体阴影的绘制
        /// </summary>
        /// <param name="e"></param>
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
        }


        #region 窗体移动
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                this._currentMousePoint = e.Location;
                this._isMove = true;
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (this._isMove)
            {
                /**计算Point偏移值*/
                Int32 offsetX = e.Location.X - this._currentMousePoint.X;
                Int32 offsetY = e.Location.Y - this._currentMousePoint.Y;

                this.Location = new Point(this.Location.X + offsetX, this.Location.Y + offsetY);
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            this._isMove = false;
            base.OnMouseUp(e);
        }
        #endregion
    }
}
