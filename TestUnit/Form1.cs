using Handiness.Winform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            this.Width = 1366;
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
