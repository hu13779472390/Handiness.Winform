﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing;
namespace Handiness.Winform.Editor
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class SymbolEditor : UITypeEditor
    {

        public override Object EditValue(ITypeDescriptorContext context, IServiceProvider provider, Object value)
        {
            String current = value as String;
            String selected = AwesomeFont.warning;
            if (String.IsNullOrEmpty(current))
            {
                return selected;
            }

            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                SymbolEditControl editControl = new SymbolEditControl(edSvc);
                editControl.Selected = current;
                edSvc.DropDownControl(editControl);
                selected = editControl.Selected;
                editControl.Dispose();
            }
            return selected;
        }
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }
        public override void PaintValue(PaintValueEventArgs e)
        {
            Font font = new Font(AwesomeFont.FontFamily, 9F);
            Brush brush = new SolidBrush(Color.Black);
            String text = e.Value as String;
            if (text == null)
            {
                text = "Error";
                font = new Font("黑体",9F);
            }
       
            RectangleF rect = new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            e.Graphics.DrawString(text, font, brush, rect, new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });
            brush.Dispose();
            base.PaintValue(e);
        }
        public override Boolean GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }
    }
}
