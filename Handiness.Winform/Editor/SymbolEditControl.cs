using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Handiness.Winform.Editor
{
    public partial class SymbolEditControl : UserControl
    {
        public SymbolEditControl()
        {
            InitializeComponent();

      
        }
        public String Selected
        {
            get
            {
                return AwesomeFont.address_card;
            }
            set
            {
               
            }
        }
    }
}
