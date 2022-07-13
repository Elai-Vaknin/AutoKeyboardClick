using System;
using System.Windows.Forms;
using System.Threading;
using AutoItX3Lib;
using AutoIt;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace AutoKeyboardClick
{       
    public partial class Form1 : Form
    {
        public const int WM_KEYDOWN = 0x100;
        public const int WM_KEYUP = 0x101;
        public const int WM_CHAR = 0x0102;
        public const int WM_COMMAND = 0x111;
        public const int WM_LBUTTONDOWN = 0x201;
        public const int WM_LBUTTONUP = 0x202;
        public const int WM_LBUTTONDBLCLK = 0x203;
        public const int WM_RBUTTONDOWN = 0x204;
        public const int WM_RBUTTONUP = 0x205;
        public const int WM_RBUTTONDBLCLK = 0x206;


        [DllImport("User32.dll")]
        public static extern int FindWindowEx(
            int hwndParent,
            int hwndChildAfter,
            string strClassName,
            string strWindowName);


        // The SendMessage function sends the specified message to a window or windows. 
        // It calls the window procedure for the specified window and does not return
        // until the window procedure has processed the message. 
        [DllImport("User32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);


        AutoItX3 au3 = new AutoItX3();
        Dictionary<char, int> keys_to_direct_input = new Dictionary<char, int>();


        private void LoadKeyInputs()
        {
            keys_to_direct_input.Add('1', 0x02001);
            keys_to_direct_input.Add('2', 0x03001);
            keys_to_direct_input.Add('3', 0x04001);
            keys_to_direct_input.Add('4', 0x05001);
            keys_to_direct_input.Add('5', 0x06001);
            keys_to_direct_input.Add('6', 0x07001);
            keys_to_direct_input.Add('7', 0x08001);
            keys_to_direct_input.Add('8', 0x09001);
            keys_to_direct_input.Add('9', 0x0A001);
            keys_to_direct_input.Add('0', 0x0B001);
            keys_to_direct_input.Add('-', 0x0C001);
            keys_to_direct_input.Add('=', 0x0D001);
            keys_to_direct_input.Add('Q', 0x10001);
            keys_to_direct_input.Add('W', 0x11001);
            keys_to_direct_input.Add('E', 0x12001);
            keys_to_direct_input.Add('R', 0x13001);
            keys_to_direct_input.Add('T', 0x14001);
            keys_to_direct_input.Add('Y', 0x15001);
            keys_to_direct_input.Add('U', 0x16001);
            keys_to_direct_input.Add('I', 0x17001);
            keys_to_direct_input.Add('O', 0x18001);
            keys_to_direct_input.Add('P', 0x19001);
            keys_to_direct_input.Add('[', 0x1A001);
            keys_to_direct_input.Add(']', 0x1B001);
            keys_to_direct_input.Add('A', 0x1E001);
            keys_to_direct_input.Add('S', 0x1F001);
            keys_to_direct_input.Add('D', 0x20001);
            keys_to_direct_input.Add('F', 0x21001);
            keys_to_direct_input.Add('G', 0x22001);
            keys_to_direct_input.Add('H', 0x23001);
            keys_to_direct_input.Add('J', 0x24001);
            keys_to_direct_input.Add('K', 0x25001);
            keys_to_direct_input.Add('L', 0x26001);
            keys_to_direct_input.Add(';', 0x27001);
            keys_to_direct_input.Add('`', 0x29001);
            keys_to_direct_input.Add('Z', 0x2C001);
            keys_to_direct_input.Add('X', 0x2D001);
            keys_to_direct_input.Add('C', 0x2E001);
            keys_to_direct_input.Add('V', 0x2F001);
            keys_to_direct_input.Add('B', 0x30001);
            keys_to_direct_input.Add('N', 0x31001);
            keys_to_direct_input.Add('M', 0x32001);
            keys_to_direct_input.Add(',', 0x33001);
            keys_to_direct_input.Add('.', 0x34001);
            keys_to_direct_input.Add('/', 0x35001);
        }

        public Form1()
        {
            InitializeComponent();

            LoadKeyInputs();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String name = tbInput.Text;

            if (name == null)
                return;

            IntPtr zero = IntPtr.Zero;

            for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
            {
                Thread.Sleep(500);
                zero = FindWindow(null, name);
                lblMessage.Text = zero + "";
            }

            if (zero != IntPtr.Zero)
            {
                const int VK_F5 = 0x47;

                PostMessage(zero, WM_KEYDOWN, VK_F5, 0x2F0001);
                
                Thread.Sleep(100);

                PostMessage(zero, WM_KEYUP, VK_F5, 0x2F0001);

                //lblMessage.Text = "ID: " + zero;
                //SetForegroundWindow(zero);
                //au3.Send("g");
                //AutoItX.Send("g");
                //SendKeys.SendWait("{k}");
                //SendKeys.SendWait("{TAB}");
                //SendKeys.SendWait("{TAB}");
                //SendKeys.SendWait("{ENTER}");
                //SendKeys.SendWait("g");
                //SendKeys.Flush();
            }
        }
    }
}
