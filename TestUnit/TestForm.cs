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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            this.scutcheon1.Paint += Scutcheon1_Paint;
        }

        private void Scutcheon1_Paint(Object sender, PaintEventArgs e)
        {
   
        }

        private void panel1_Paint(Object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(Object sender, EventArgs e)
        {
            this.circleWaitIndicator1.IsRolled = !this.circleWaitIndicator1.IsRolled;
        }
    }
    public interface ITest<out T> where T : class
    {
         
    }
}
