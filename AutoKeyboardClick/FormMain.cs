using System;
using System.Windows.Forms;
using System.Threading;
using AutoItX3Lib;
using AutoIt;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace AutoKeyboardClick
{       
    public partial class FormMain : Form
    {
        [DllImport("User32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
        LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);

        AutoItX3 au3 = new AutoItX3();
        Dictionary<char, int> keys_to_direct_input = new Dictionary<char, int>();


        private int delay;
        private int repeats;
        private int activateKeyPress;
        private int currentX;
        private int currentY;

        private Point originalPosition;

        private IntPtr selectedWindow;
        private IntPtr keysHook;

        private char selectedKey;

        private bool pressing;
        private bool dragging;
        private bool focused;

        private const int WH_KEYBOARD_LL = 0xD;
        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;
        private const int WM_CHAR = 0x0102;
        private const int WM_COMMAND = 0x111;
        private const int WM_LBUTTONDOWN = 0x201;
        private const int WM_LBUTTONUP = 0x202;
        private const int WM_LBUTTONDBLCLK = 0x203;
        private const int WM_RBUTTONDOWN = 0x204;
        private const int WM_RBUTTONUP = 0x205;
        private const int WM_RBUTTONDBLCLK = 0x206;

        private FormMouseTracer overlay;
        private Thread threadPressing;
        private LowLevelKeyboardProc keyHookInstance;

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
            Point p = pbDragLanding.PointToScreen(Point.Empty);
            overlay = new FormMouseTracer();
            overlay.FormBorderStyle = FormBorderStyle.None;
            overlay.ShowInTaskbar = false;
            //overlay.TopMost = true;
            overlay.Owner = this;
            overlay.Size = new Size(10, 10);
            overlay.BackColor = Color.Black;
            overlay.Show();
            
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            overlay.Location = new Point(this.Location.X + pbDragLanding.Left + pbDragLanding.Width / 2, this.Location.Y + pbDragLanding.Top + pbDragLanding.Height + (pbDragLanding.Height - overlay.Size.Height) / 2);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.activateKeyPress = 112; // F1
            this.pressing = false;
            this.focused = false;
            this.selectedWindow = IntPtr.Zero;
            this.keysHook = IntPtr.Zero;
            
            LoadKeyInputs();

            foreach (KeyValuePair<char, int> entry in keys_to_direct_input)
            {
                cbKeys.Items.Add(entry.Key);
            }

            cbSpecial.SelectedIndex = 0;
            cbStartStop.SelectedIndex = 0;
            lblFound.Text = "";
            threadPressing = null;
        }

        public FormMain()
        {
            InitializeComponent();

            Init();

            this.keyHookInstance = HookCallback;

            SetHook(this.keyHookInstance);
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                if(vkCode == this.activateKeyPress)
                {
                    if (!this.pressing)
                        startPressing();
                    else
                        reset();
                }
            }
            return CallNextHookEx(keysHook, nCode, wParam, lParam);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
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
            int keyCode = 112; // F1

            keyCode += cbStartStop.SelectedIndex;

            if (keyCode <= 123) // F12
                this.activateKeyPress = keyCode;

            lblError.Text = keyCode + "";

        }

        private void reset()
        {
            pressing = false;

            btnStart.Enabled = true;

            lblError.Text = "Waiting for action";
        }

        private bool validateStart()
        {
            if (this.selectedWindow == null)
            {
                lblError.Text = "No window is selected";
                return false;
            }

            if (cbKeys.SelectedIndex < 0)
            {
                lblError.Text = "No key is selected";
                return false;
            }
            if (this.delay <= 0)
            {
                lblError.Text = "Invalid delay";
                return false;
            }


            return true;
        }

        private void pressKey(IntPtr window, int key, int lval, int delay)
        {
            PostMessage(this.selectedWindow, WM_KEYDOWN, key, lval);

            Thread.Sleep(10);

            PostMessage(this.selectedWindow, WM_KEYUP, key, lval);

            Thread.Sleep(delay);
        }

        private void calculateStats()
        {
            try
            {
                int totalDelay = 0;

                this.repeats = Int32.Parse(tbRepeats.Text);

                totalDelay += Int32.Parse(tbMilliseconds.Text);
                totalDelay += Int32.Parse(tbSeconds.Text) * 1000;
                totalDelay += Int32.Parse(tbMinutes.Text) * 1000 * 60;

                this.delay = totalDelay;
                
            }
            catch
            {
                this.delay = 0;
            }
        }

        public void threadHandler()
        {
            int value = 0;

            keys_to_direct_input.TryGetValue(this.selectedKey, out value);

            if (value == 0)
                return;

            if (this.repeats == 0)
            {
                while (pressing)
                {
                    pressKey(this.selectedWindow, (int)this.selectedKey, value, this.delay);
                }
            }

            else
            {
                for (int i = 0; i < this.repeats && pressing; i++)
                {
                    pressKey(this.selectedWindow, (int)this.selectedKey, value, this.delay);
                }
            }

            reset();
        }

        private void startPressing()
        {
            calculateStats();

            if (!validateStart() || threadPressing != null)
                return;

            pressing = true;

            btnStart.Enabled = false;

            lblError.Text = "Pressing..";

            this.selectedKey = cbKeys.SelectedItem.ToString()[0];

            threadPressing = new Thread(threadHandler);
            threadPressing.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startPressing();
            lblError.Text = Screen.PrimaryScreen.WorkingArea.Width + " " + pbDragLanding.Location.X + " " + pbDragLanding.Width + " " + this.Location;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            reset();
            threadPressing.Join();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            Point p = new Point(this.Location.X + pbDragLanding.Left + pbDragLanding.Width / 2, this.Location.Y + pbDragLanding.Top + pbDragLanding.Height + (pbDragLanding.Height - overlay.Size.Height) / 2);
            overlay.Location = p;

            overlay.setDropLocation(p);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.focused = true;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.focused = false;
        }
    }
}
