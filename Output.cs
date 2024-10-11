using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TClicker
{
    public class Output
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        public static void ClickAtPosition(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
        }

        public static void RightClickAtPosition(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event((int)(MouseEventFlags.RIGHTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.RIGHTUP), 0, 0, 0, 0);
        }

        public static void DoubleClickAtPosition(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event((int)(MouseEventFlags.LEFTDOWN | MouseEventFlags.LEFTUP), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.LEFTDOWN | MouseEventFlags.LEFTUP), 0, 0, 0, 0);
        }

    }
}
