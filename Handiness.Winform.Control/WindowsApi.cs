using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace Handiness.Winform
{
    public class WindowsApi
    {
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hwnd, Int32 wMsg, Int32 wParam, Int32 lParam);
    }
}
