using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Windows.Forms.Design;
using Handiness.Winform.Control;
using System.Diagnostics;

namespace Handiness.Winform.Editor
{
    public partial class SymbolEditControl : UserControl
    {
        private string _pattern = AwesomeFont.warning;
        private IWindowsFormsEditorService _edSvc;
        private ToolTip _toolTip;

        public SymbolEditControl(IWindowsFormsEditorService edSvc):this()
        {
            this._edSvc = edSvc;
        }
        public SymbolEditControl()
        {
            InitializeComponent();
        }

        public string Selected
        {
            get
            {
                return this._pattern;
            }
            set
            {
                this._pattern = value;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            this._toolTip = new ToolTip();
            LoadPatterns();
            base.OnLoad(e);
        }
        private void LoadPatterns()
        {
            FieldInfo[] fields = typeof(AwesomeFont).GetFields();
            this._flpPatternContainer.Visible = false;
            this._flpPatternContainer.Controls.Clear();
            Symbol[] symbols = new Symbol[fields.Length];
            for (int i = 0; i < fields.Length; ++i)
            {
                Symbol symbol = new Symbol();
                symbol.Size = new Size(24, 23);
                symbol.SymbolSize = 10;
                symbol.BackColor = Color.FromArgb(61,195,245);
                symbol.ForeColor = Color.White;
                symbol.SymbolPattern = fields[i].GetValue(null).ToString();
                symbol.Margin = new Padding(2,2,2,2);
                this._toolTip.SetToolTip(symbol, fields[i].Name);
                symbols[i] = symbol;
                symbol.MouseDown += (s,e)=>
                {
                    this.Selected = symbol.SymbolPattern;
                    this._edSvc?.CloseDropDown();
                };
                symbol.MouseHover += (s,e)=>
                {
                    symbol.BackColor = Color.FromArgb(175,175,175);
                };
                symbol.MouseLeave +=(s,e)=>
                {
                    symbol.BackColor = Color.FromArgb(61, 195, 245);
                };
            }
            this._flpPatternContainer.Controls.AddRange(symbols);
            this._flpPatternContainer.Visible = true;
        }
    }
}
