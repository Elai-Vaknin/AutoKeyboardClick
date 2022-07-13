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

        private int activateKeyPress;
        private bool pressing;
        private IntPtr selectedWindow;
        private int delay;
        private int repeats;

        private void LoadKeyInputs()
        {
            keys_to_direct_input.Add('1', 0x020001);
            keys_to_direct_input.Add('2', 0x030001);
            keys_to_direct_input.Add('3', 0x040001);
            keys_to_direct_input.Add('4', 0x050001);
            keys_to_direct_input.Add('5', 0x060001);
            keys_to_direct_input.Add('6', 0x070001);
            keys_to_direct_input.Add('7', 0x080001);
            keys_to_direct_input.Add('8', 0x090001);
            keys_to_direct_input.Add('9', 0x0A0001);
            keys_to_direct_input.Add('0', 0x0B0001);
            keys_to_direct_input.Add('-', 0x0C0001);
            keys_to_direct_input.Add('=', 0x0D0001);
            keys_to_direct_input.Add('Q', 0x100001);
            keys_to_direct_input.Add('W', 0x110001);
            keys_to_direct_input.Add('E', 0x120001);
            keys_to_direct_input.Add('R', 0x130001);
            keys_to_direct_input.Add('T', 0x140001);
            keys_to_direct_input.Add('Y', 0x150001);
            keys_to_direct_input.Add('U', 0x160001);
            keys_to_direct_input.Add('I', 0x170001);
            keys_to_direct_input.Add('O', 0x180001);
            keys_to_direct_input.Add('P', 0x190001);
            keys_to_direct_input.Add('[', 0x1A0001);
            keys_to_direct_input.Add(']', 0x1B0001);
            keys_to_direct_input.Add('A', 0x1E0001);
            keys_to_direct_input.Add('S', 0x1F0001);
            keys_to_direct_input.Add('D', 0x200001);
            keys_to_direct_input.Add('F', 0x210001);
            keys_to_direct_input.Add('G', 0x220001);
            keys_to_direct_input.Add('H', 0x230001);
            keys_to_direct_input.Add('J', 0x240001);
            keys_to_direct_input.Add('K', 0x250001);
            keys_to_direct_input.Add('L', 0x260001);
            keys_to_direct_input.Add(';', 0x270001);
            keys_to_direct_input.Add('`', 0x290001);
            keys_to_direct_input.Add('Z', 0x2C0001);
            keys_to_direct_input.Add('X', 0x2D0001);
            keys_to_direct_input.Add('C', 0x2E0001);
            keys_to_direct_input.Add('V', 0x2F0001);
            keys_to_direct_input.Add('B', 0x300001);
            keys_to_direct_input.Add('N', 0x310001);
            keys_to_direct_input.Add('M', 0x320001);
            keys_to_direct_input.Add(',', 0x330001);
            keys_to_direct_input.Add('.', 0x340001);
            keys_to_direct_input.Add('/', 0x350001);
        }

        private void Init()
        {
            this.activateKeyPress = 0x3B;
            this.pressing = false;
            this.selectedWindow = IntPtr.Zero;
            this.repeats = 10;
            this.delay = 500;

            LoadKeyInputs();

            foreach (KeyValuePair<char, int> entry in keys_to_direct_input)
            {
                cbKeys.Items.Add(entry.Key);
            }

            cbSpecial.SelectedIndex = 0;
            cbStartStop.SelectedIndex = 0;
            lblFound.Text = "";
        }

        public Form1()
        {
            InitializeComponent();

            Init();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String name = tbInput.Text;

            if (name == null)
                return;

            IntPtr zero = IntPtr.Zero;

            for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
            {
                zero = FindWindow(null, name);
            }

            if (zero != IntPtr.Zero)
            {
                lblFound.Text = zero + "";

                selectedWindow = zero;

                /*
                
                */
            }
            else
            {
                lblFound.Text = "Can't Find";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int keyCode = 0x3B; // F1

            keyCode += cbStartStop.SelectedIndex;

            if (keyCode <= 0x44) // F10
                this.activateKeyPress = keyCode;

            lblTest.Text = keyCode + "";

        }

        private void reset()
        {
            pressing = false;

            btnStart.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.selectedWindow == null)
                return;

            pressing = true;

            btnStart.Enabled = false;

            char selectedKey = cbKeys.SelectedItem.ToString()[0];

            int value = 0;

            keys_to_direct_input.TryGetValue(selectedKey, out value);

            if (value == 0)
                return;

            for (int i = 0; i < this.repeats; i++)
            {
                PostMessage(this.selectedWindow, WM_KEYDOWN, (int)selectedKey, value);

                Thread.Sleep(10);

                PostMessage(this.selectedWindow, WM_KEYUP, (int)selectedKey, value);

                Thread.Sleep(this.delay);
            }

            reset();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
