using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms.Design;

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
                SymbolEditControl editControl = new SymbolEditControl();
                editControl.Selected = current;
                edSvc.DropDownControl(editControl);

                selected = editControl.Selected;
            }
            return selected;
        }
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }
        public override void PaintValue(PaintValueEventArgs e)
        {

            base.PaintValue(e);
        }
        public override Boolean GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return base.GetPaintValueSupported(context);
        }
    }
}
