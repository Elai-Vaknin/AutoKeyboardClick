namespace AutoKeyboardClick
{
    partial class FormMain
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
            this.lblError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.tbSeconds = new System.Windows.Forms.TextBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.tbMilliseconds = new System.Windows.Forms.TextBox();
            this.lblMilli = new System.Windows.Forms.Label();
            this.tbRepeats = new System.Windows.Forms.TextBox();
            this.lblRepeats = new System.Windows.Forms.Label();
            this.lblInfinite = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pbDragLanding = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDragLanding)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(460, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(50, 50);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(354, 53);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "MapleMS";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(354, 23);
            this.lblMessage.MaximumSize = new System.Drawing.Size(80, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(79, 26);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Locate window by name";
            // 
            // cbKeys
            // 
            this.cbKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeys.FormattingEnabled = true;
            this.cbKeys.Location = new System.Drawing.Point(12, 52);
            this.cbKeys.Name = "cbKeys";
            this.cbKeys.Size = new System.Drawing.Size(121, 21);
            this.cbKeys.Sorted = true;
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
            this.cbSpecial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbStartStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            "F10",
            "F11",
            "F12"});
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
            this.lblFound.Location = new System.Drawing.Point(516, 25);
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
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(249, 156);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(90, 13);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Waiting for action";
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
            // tbMinutes
            // 
            this.tbMinutes.Location = new System.Drawing.Point(92, 107);
            this.tbMinutes.MaxLength = 5;
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.Size = new System.Drawing.Size(55, 20);
            this.tbMinutes.TabIndex = 15;
            this.tbMinutes.Tag = "";
            this.tbMinutes.Text = "0";
            this.tbMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbSeconds
            // 
            this.tbSeconds.Location = new System.Drawing.Point(185, 107);
            this.tbSeconds.MaxLength = 5;
            this.tbSeconds.Name = "tbSeconds";
            this.tbSeconds.Size = new System.Drawing.Size(55, 20);
            this.tbSeconds.TabIndex = 17;
            this.tbSeconds.Tag = "";
            this.tbSeconds.Text = "0";
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
            // tbMilliseconds
            // 
            this.tbMilliseconds.Location = new System.Drawing.Point(273, 107);
            this.tbMilliseconds.MaxLength = 5;
            this.tbMilliseconds.Name = "tbMilliseconds";
            this.tbMilliseconds.Size = new System.Drawing.Size(55, 20);
            this.tbMilliseconds.TabIndex = 19;
            this.tbMilliseconds.Tag = "";
            this.tbMilliseconds.Text = "250";
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
            // tbRepeats
            // 
            this.tbRepeats.Location = new System.Drawing.Point(357, 107);
            this.tbRepeats.MaxLength = 5;
            this.tbRepeats.Name = "tbRepeats";
            this.tbRepeats.Size = new System.Drawing.Size(55, 20);
            this.tbRepeats.TabIndex = 21;
            this.tbRepeats.Tag = "";
            this.tbRepeats.Text = "0";
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
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(127, 145);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 34);
            this.btnStop.TabIndex = 24;
            this.btnStop.Text = "Stop key pressing";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pbDragLanding
            // 
            this.pbDragLanding.BackColor = System.Drawing.Color.Red;
            this.pbDragLanding.Location = new System.Drawing.Point(460, 145);
            this.pbDragLanding.Name = "pbDragLanding";
            this.pbDragLanding.Size = new System.Drawing.Size(30, 30);
            this.pbDragLanding.TabIndex = 26;
            this.pbDragLanding.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 145);
            this.label4.MaximumSize = new System.Drawing.Size(80, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Locate window by dragging";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 208);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbDragLanding);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInfinite);
            this.Controls.Add(this.tbRepeats);
            this.Controls.Add(this.lblRepeats);
            this.Controls.Add(this.tbMilliseconds);
            this.Controls.Add(this.lblMilli);
            this.Controls.Add(this.tbSeconds);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.tbMinutes);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblError);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elai Free Auto Keyboard Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pbDragLanding)).EndInit();
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
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.TextBox tbSeconds;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.TextBox tbMilliseconds;
        private System.Windows.Forms.Label lblMilli;
        private System.Windows.Forms.TextBox tbRepeats;
        private System.Windows.Forms.Label lblRepeats;
        private System.Windows.Forms.Label lblInfinite;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pbDragLanding;
        private System.Windows.Forms.Label label4;
    }
}

