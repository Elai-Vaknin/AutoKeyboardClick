namespace AutoKeyboardClick
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFind = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cbKeys = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSpecial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStartStop = new System.Windows.Forms.ComboBox();
            this.cbFound = new System.Windows.Forms.Label();
            this.lblFound = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblMilli = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblRepeats = new System.Windows.Forms.Label();
            this.lblInfinite = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(460, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(59, 44);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(354, 48);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "MapleMS";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(354, 29);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(100, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Enter window name";
            // 
            // cbKeys
            // 
            this.cbKeys.FormattingEnabled = true;
            this.cbKeys.Location = new System.Drawing.Point(12, 52);
            this.cbKeys.Name = "cbKeys";
            this.cbKeys.Size = new System.Drawing.Size(121, 21);
            this.cbKeys.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Key to automate:";
            // 
            // cbSpecial
            // 
            this.cbSpecial.FormattingEnabled = true;
            this.cbSpecial.Items.AddRange(new object[] {
            "None",
            "Ctrl",
            "Alt",
            "Shift"});
            this.cbSpecial.Location = new System.Drawing.Point(12, 25);
            this.cbSpecial.Name = "cbSpecial";
            this.cbSpecial.Size = new System.Drawing.Size(121, 21);
            this.cbSpecial.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 29);
            this.label2.MaximumSize = new System.Drawing.Size(70, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Shortcut key to start / stop pressing";
            // 
            // cbStartStop
            // 
            this.cbStartStop.FormattingEnabled = true;
            this.cbStartStop.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10"});
            this.cbStartStop.Location = new System.Drawing.Point(216, 23);
            this.cbStartStop.Name = "cbStartStop";
            this.cbStartStop.Size = new System.Drawing.Size(121, 21);
            this.cbStartStop.TabIndex = 8;
            // 
            // cbFound
            // 
            this.cbFound.AutoSize = true;
            this.cbFound.Location = new System.Drawing.Point(525, 37);
            this.cbFound.Name = "cbFound";
            this.cbFound.Size = new System.Drawing.Size(0, 13);
            this.cbFound.TabIndex = 9;
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Location = new System.Drawing.Point(531, 29);
            this.lblFound.MaximumSize = new System.Drawing.Size(65, 0);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(65, 26);
            this.lblFound.TabIndex = 10;
            this.lblFound.Text = "Locate a window first!";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(249, 156);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 13);
            this.lblTest.TabIndex = 12;
            this.lblTest.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.MaximumSize = new System.Drawing.Size(60, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 39);
            this.label3.TabIndex = 13;
            this.label3.Text = "Delay between pressses";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(89, 88);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 14;
            this.lblMinutes.Text = "Minutes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "0";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(182, 88);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(49, 13);
            this.lblSeconds.TabIndex = 16;
            this.lblSeconds.Text = "Seconds";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(273, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "0";
            // 
            // lblMilli
            // 
            this.lblMilli.AutoSize = true;
            this.lblMilli.Location = new System.Drawing.Point(270, 88);
            this.lblMilli.Name = "lblMilli";
            this.lblMilli.Size = new System.Drawing.Size(64, 13);
            this.lblMilli.TabIndex = 18;
            this.lblMilli.Text = "Milliseconds";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(357, 107);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(55, 20);
            this.textBox4.TabIndex = 21;
            this.textBox4.Text = "1";
            // 
            // lblRepeats
            // 
            this.lblRepeats.AutoSize = true;
            this.lblRepeats.Location = new System.Drawing.Point(354, 88);
            this.lblRepeats.Name = "lblRepeats";
            this.lblRepeats.Size = new System.Drawing.Size(94, 13);
            this.lblRepeats.TabIndex = 20;
            this.lblRepeats.Text = "Number of repeats";
            // 
            // lblInfinite
            // 
            this.lblInfinite.AutoSize = true;
            this.lblInfinite.Location = new System.Drawing.Point(418, 110);
            this.lblInfinite.Name = "lblInfinite";
            this.lblInfinite.Size = new System.Drawing.Size(62, 13);
            this.lblInfinite.TabIndex = 22;
            this.lblInfinite.Text = "0 => Infinite";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 145);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 34);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start key pressing";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Stop key pressing";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInfinite);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblRepeats);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblMilli);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.cbFound);
            this.Controls.Add(this.cbStartStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSpecial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKeys);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnFind);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cbKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSpecial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStartStop;
        private System.Windows.Forms.Label cbFound;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblMilli;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblRepeats;
        private System.Windows.Forms.Label lblInfinite;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
    }
}

