using Handiness.Winform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Handiness.Winform.Control;
namespace TestUnit
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e)
        {
            scutcheon3.Height += 100;

            SCROLLINFO si = new SCROLLINFO();
            si.cbSize = (UInt32)System.Runtime.InteropServices.Marshal.SizeOf(si);
            si.fMask = WindowsConstants.SIF_ALL;
            if (WindowsApi.GetScrollInfo(this.panel1.Handle, WindowsConstants.SB_VERT, ref si))
            {
                this.scutcheon2.Text = si.nPos.ToString();
            }
            //     this.Width = 1366;
            //    this.SuspendLayout();
            //Shade shade = new Shade();
            //shade.Size = new Size(450, 400);
            //shade.Location = new Point(100, 25);
            //shade.BackColor = Color.FromArgb(175, 175, 175);
            //shade.EnabledMousePierce = false;
            //shade.Dock = DockStyle.Fill;
            //this.Controls.Add(shade);

            //Shade shade1 = new Shade();
            //shade1.Alpha = 150;
            //shade1.EnabledDrawText = true;
            //shade1.EnabledMousePierce = false;
            //shade1.Location = new System.Drawing.Point(66, 38);
            //shade1.Margin = new System.Windows.Forms.Padding(0);
            //shade1.Name = "shade1";
            //shade1.Size = new System.Drawing.Size(608, 388);
            //shade1.TabIndex = 15;
            //shade1.Text = "shade1";
            //shade1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.Controls.Add(shade1);
            //shade1.BringToFront();

            //  this.ResumeLayout(false);
            base.OnShown(e);
        }
        private void windowsButton1_Click(Object sender, EventArgs e)
        {

        }

        private void windowsButton1_Click_1(Object sender, EventArgs e)
        {

        }

        private void button1_Click(Object sender, EventArgs e)
        {
            this.Width += 100;
        }
    }
}
