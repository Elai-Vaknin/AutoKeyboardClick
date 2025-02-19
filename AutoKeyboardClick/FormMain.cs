﻿using System;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace AutoKeyboardClick
{       
    public partial class FormMain : Form
    {
        [DllImport("User32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

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

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        Dictionary<char, int> keys_to_direct_input = new Dictionary<char, int>();

        private int delay;
        private int repeats;
        private int activateKeyPress;
        private int selectedSpecial;

        private IntPtr selectedWindow;
        private IntPtr keysHook;

        private char selectedKey;

        private bool pressing;

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        /* Not needed
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        */

        private const int WH_KEYBOARD_LL = 0xD;
        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;

        /* Not needed
        private const int WM_CHAR = 0x0102;
        private const int WM_COMMAND = 0x111;
        private const int WM_LBUTTONDOWN = 0x201;
        private const int WM_LBUTTONUP = 0x202;
        private const int WM_LBUTTONDBLCLK = 0x203;
        private const int WM_RBUTTONDOWN = 0x204;
        private const int WM_RBUTTONUP = 0x205;
        private const int WM_RBUTTONDBLCLK = 0x206;
        */

        private readonly int[] diSpecial = new int[] { 0x2A, 0x1D, 0x38 };
        private readonly int[] vkSpecial = new int[] { 0xA0, 0xA2, 0xA4 };

        public const int KEYEVENTF_KEYDOWN = 0x0001;
        public const int KEYEVENTF_KEYUP = 0x0002;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);


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

            foreach (KeyValuePair<char, int> entry in keys_to_direct_input)
                cbKeys.Items.Add(entry.Key);
        }

        /* Creates the dragging window */
        private void createOverlay()
        {
            overlay = new FormMouseTracer(mouseTracerCallback);
            overlay.FormBorderStyle = FormBorderStyle.None;
            overlay.ShowInTaskbar = false;
            overlay.Owner = this;
            overlay.Size = new Size(3, 3);
            overlay.BackColor = Color.Black;
            overlay.Show();
            overlay.Location = getOverlayLocation();
        }
        private void Init()
        {
            createOverlay();
            LoadKeyInputs();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2); // Center of the screen
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            this.activateKeyPress = 112; // F1
            this.pressing = false;
            this.selectedWindow = IntPtr.Zero;
            this.keysHook = IntPtr.Zero;
            this.selectedSpecial = 0;
            this.threadPressing = null;

            cbSpecial.SelectedIndex = 0;
            cbStartStop.SelectedIndex = 0;
        }

        public FormMain()
        {
            InitializeComponent();

            Init();
            
            this.keyHookInstance = HookCallback;

            SetHook(this.keyHookInstance);
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                if(vkCode == this.activateKeyPress)
                {
                    if (!this.pressing)     startPressing();
                    else                    reset();
                }
            }

            return CallNextHookEx(keysHook, nCode, wParam, lParam);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private int mouseTracerCallback()
        {
            DoMouseClick();

            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            while (milliseconds + 200 > DateTimeOffset.Now.ToUnixTimeMilliseconds())
                continue;

            IntPtr handle = GetForegroundWindow();

            const int count = 512;

            var text = new StringBuilder(count);

            if (GetWindowText(handle, text, count) > 0)     findWindowByName(text.ToString());
            else                                            lblFound.Text = "Error";

            return 1;
        }

        private void findWindowByName(String name)
        {
            if (name.Equals("") || name.Equals(overlay.Text))
                return;

            IntPtr zero = IntPtr.Zero;

            for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
            {
                zero = FindWindow(null, name);
            }

            if (zero != IntPtr.Zero)
            {
                var text = new StringBuilder(32);

                GetWindowText(zero, text, 32);

                lblFound.Text = text.ToString() + " - " + zero;

                this.selectedWindow = zero;
            }
            else
            {
                lblFound.Text = "Can't Find";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String name = tbInput.Text;

            findWindowByName(name);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int keyCode = 0x70; // F1

            keyCode += cbStartStop.SelectedIndex;

            if (keyCode <= 0x7B) // F12
                this.activateKeyPress = keyCode;
        }

        private void reset()
        {
            this.pressing = false;

            ChangeButtonState(true);

            WriteTextSafe("Waiting for action");
        }

        private bool validateStart()
        {
            if (cbKeys.SelectedIndex < 0)
            {
                lblError.Text = "No key is selected";
                return false;
            }

            if (this.delay <= 0)
            {
                lblError.Text = "Invalid delay or repeats";
                return false;
            }


            return true;
        }

        public void WriteTextSafe(string text)
        {
            if (lblError.InvokeRequired)
            {
                Action safeWrite = delegate { WriteTextSafe($"{text}"); };
                lblError.Invoke(safeWrite);
            }
            else
                lblError.Text = text;
        }

        public void ChangeButtonState(bool state)
        {
            if (btnStart.InvokeRequired)
            {
                Action stateAct = delegate { ChangeButtonState(state); };
                btnStart.Invoke(stateAct);
            }
            else
                btnStart.Enabled = state;
        }

        private void pressKey(IntPtr window, int key, int lval, int delay)
        {
            int indexSpecial = this.selectedSpecial - 1;

            if (this.selectedWindow != IntPtr.Zero)
            {
                if(indexSpecial >= 0)
                    PostMessage(this.selectedWindow, WM_KEYDOWN, diSpecial[indexSpecial], diSpecial[indexSpecial] << 16 | 0x1);

                PostMessage(this.selectedWindow, WM_KEYDOWN, key, lval);

                Thread.Sleep(10);

                if (indexSpecial >= 0)
                    PostMessage(this.selectedWindow, WM_KEYUP, diSpecial[indexSpecial], diSpecial[indexSpecial] << 16 | 0x1);

                PostMessage(this.selectedWindow, WM_KEYUP, key, lval);

                Thread.Sleep(delay);
            }
            else
            {
                Byte keyByte = (Byte)this.selectedKey;

                Thread.Sleep(10);

                if (indexSpecial >= 0)
                    keybd_event((Byte)vkSpecial[indexSpecial], 0, KEYEVENTF_KEYDOWN, 0);

                keybd_event(keyByte, 0, KEYEVENTF_KEYDOWN, 0);

                Thread.Sleep(10);

                if (indexSpecial >= 0)
                    keybd_event((Byte)vkSpecial[indexSpecial], 0, KEYEVENTF_KEYUP, 0);

                keybd_event(keyByte, 0, KEYEVENTF_KEYUP, 0);

                Thread.Sleep(delay);
            }
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

        public void threadPressKeys()
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

            if (!validateStart())
                return;

            pressing = true;

            ChangeButtonState(false);

            WriteTextSafe("Pressing...");

            this.selectedKey = cbKeys.SelectedItem.ToString()[0];

            threadPressing = new Thread(threadPressKeys);
            threadPressing.Start();
        }

        public void DoMouseClick()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;

            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startPressing();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void textBoxDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private Point getOverlayLocation()
        {
            const int topBarLen = 20;

            return new Point(this.Location.X + gbLocate.Location.X + gbDragging.Location.X + pbWhite.Location.X + pbWhite.Width / 2,
                topBarLen + this.Location.Y + gbLocate.Location.Y + gbDragging.Location.Y + pbWhite.Location.Y + pbBlack.Height / 2);
        }

        private void setOverlayLocation(Point l)
        {
            overlay.Location = l;
            overlay.setDropLocation(l);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.selectedWindow = IntPtr.Zero;

            lblFound.Text = "No target window";
        }

        private void cbSpecial_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedSpecial = cbSpecial.SelectedIndex;
        }

        private void FormMain_Move(object sender, EventArgs e)
        {
            setOverlayLocation(getOverlayLocation());
        }
    }
}
