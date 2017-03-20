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
    public class Button : System.Windows.Forms.Button
    {
        public Label Label { get; private set; } 
        public Button() : base()
        {
            this.Label = new Label();
            this.Label.Location = new Point(0,0);
            this.Label.Size = new Size(20,20);
            this.Label.Text = "ddd";
            this.Controls.Add(this.Label);
        }
    }
}
