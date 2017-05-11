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
        //public static SymbolEditControl Instance
        //{
        //    get
        //    {
        //        if (_Instance == null)
        //        {
        //            _Instance = new SymbolEditControl();
        //        }
        //        return _Instance;
        //    }
        //}
        //private static SymbolEditControl _Instance = null;
        public IWindowsFormsEditorService WindowsFormsEditorService { get; set; } = null;

        private string _pattern = AwesomeFont.warning;
        private ToolTip _toolTip;

        public SymbolEditControl(IWindowsFormsEditorService edSvc = null) : this()
        {
            this.WindowsFormsEditorService = edSvc;
            this._toolTip = new ToolTip();

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
            this.DrawSymbolPatterns();
            base.OnLoad(e);
        }
        private void DrawSymbolPatterns()
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
                symbol.BackColor = Color.FromArgb(61, 195, 245);
                symbol.ForeColor = Color.White;
                symbol.SymbolPattern = fields[i].GetValue(null).ToString();
                symbol.Margin = new Padding(2, 2, 2, 2);
                this._toolTip.SetToolTip(symbol, fields[i].Name);
                symbols[i] = symbol;
                symbol.MouseDown += (s, e) =>
                {
                    this.Selected = symbol.SymbolPattern;
                    this.WindowsFormsEditorService?.CloseDropDown();
                };
                symbol.MouseHover += (s, e) =>
                {
                    Symbol sbl = s as Symbol;
                    sbl.BackColor = Color.FromArgb(175, 175, 175);
                };
                symbol.MouseLeave += (s, e) =>
                 {
                     Symbol sbl = s as Symbol;
                     sbl.BackColor = Color.FromArgb(61, 195, 245);
                 };
            }
            this._flpPatternContainer.Controls.AddRange(symbols);
            this._flpPatternContainer.Visible = true;

        }
    }
}
