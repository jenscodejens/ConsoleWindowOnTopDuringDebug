using System.Runtime.InteropServices;

namespace Assignment2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "On Top";
            MakeTheConsoleWindowAlwaysOnTop();








        // Set console window as top even if VS is the active window during debugging
        }
        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();
        private static void MakeTheConsoleWindowAlwaysOnTop()
        {
            const uint SWP_NOMOVE = 0x0002;
            const uint SWP_NOSIZE = 0x0001;
            const int HWND_TOPMOST = -1;


            IntPtr consoleWindowHandle = GetConsoleWindow();
            SetWindowPos(consoleWindowHandle, new IntPtr(HWND_TOPMOST), 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
        }
    }
}