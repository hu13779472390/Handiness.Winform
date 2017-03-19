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
        }

        private void panel1_Paint(Object sender, PaintEventArgs e)
        {

        }
    }
    public interface ITest<out T> where T : class
    {
         
    }
}
