﻿using Handiness.Winform;
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
            this.scutcheon1.Font = new Font(AwesomeFont.FontFamily, 15, FontStyle.Regular);
            this.scutcheon1.Text = AwesomeFont.bus;
        }
    }
}
