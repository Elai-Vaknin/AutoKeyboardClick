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
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.tbSeconds = new System.Windows.Forms.TextBox();
            this.tbMilliseconds = new System.Windows.Forms.TextBox();
            this.tbRepeats = new System.Windows.Forms.TextBox();
            this.lblInfinite = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.pbWhite = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbKey = new System.Windows.Forms.GroupBox();
            this.gbDelay = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.gbActivation = new System.Windows.Forms.GroupBox();
            this.gbDragging = new System.Windows.Forms.GroupBox();
            this.gbLocate = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhite)).BeginInit();
            this.gbKey.SuspendLayout();
            this.gbDelay.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbName.SuspendLayout();
            this.gbActivation.SuspendLayout();
            this.gbDragging.SuspendLayout();
            this.gbLocate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(112, 16);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(65, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(6, 48);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(7, 21);
            this.lblMessage.MaximumSize = new System.Drawing.Size(80, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(78, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Winodw name:";
            // 
            // cbKeys
            // 
            this.cbKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeys.FormattingEnabled = true;
            this.cbKeys.Location = new System.Drawing.Point(88, 55);
            this.cbKeys.Name = "cbKeys";
            this.cbKeys.Size = new System.Drawing.Size(121, 21);
            this.cbKeys.Sorted = true;
            this.cbKeys.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.MaximumSize = new System.Drawing.Size(70, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select keys to automate:";
            // 
            // cbSpecial
            // 
            this.cbSpecial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecial.FormattingEnabled = true;
            this.cbSpecial.Items.AddRange(new object[] {
            "None",
            "Shift",
            "Ctrl",
            "Alt"});
            this.cbSpecial.Location = new System.Drawing.Point(88, 28);
            this.cbSpecial.Name = "cbSpecial";
            this.cbSpecial.Size = new System.Drawing.Size(121, 21);
            this.cbSpecial.TabIndex = 6;
            this.cbSpecial.SelectedIndexChanged += new System.EventHandler(this.cbSpecial_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 27);
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
            this.cbStartStop.Location = new System.Drawing.Point(112, 22);
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
            this.lblFound.Location = new System.Drawing.Point(44, 179);
            this.lblFound.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(90, 13);
            this.lblFound.TabIndex = 10;
            this.lblFound.Text = "No target window";
            this.lblFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 49);
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
            this.lblError.Location = new System.Drawing.Point(299, 86);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(90, 13);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Waiting for action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.MaximumSize = new System.Drawing.Size(60, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 39);
            this.label3.TabIndex = 13;
            this.label3.Text = "Delay between pressses";
            // 
            // tbMinutes
            // 
            this.tbMinutes.Location = new System.Drawing.Point(12, 19);
            this.tbMinutes.MaxLength = 5;
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.Size = new System.Drawing.Size(55, 20);
            this.tbMinutes.TabIndex = 15;
            this.tbMinutes.Tag = "";
            this.tbMinutes.Text = "0";
            this.tbMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDelay_KeyPress);
            // 
            // tbSeconds
            // 
            this.tbSeconds.Location = new System.Drawing.Point(12, 19);
            this.tbSeconds.MaxLength = 5;
            this.tbSeconds.Name = "tbSeconds";
            this.tbSeconds.Size = new System.Drawing.Size(55, 20);
            this.tbSeconds.TabIndex = 17;
            this.tbSeconds.Tag = "";
            this.tbSeconds.Text = "0";
            this.tbSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDelay_KeyPress);
            // 
            // tbMilliseconds
            // 
            this.tbMilliseconds.Location = new System.Drawing.Point(12, 19);
            this.tbMilliseconds.MaxLength = 5;
            this.tbMilliseconds.Name = "tbMilliseconds";
            this.tbMilliseconds.Size = new System.Drawing.Size(55, 20);
            this.tbMilliseconds.TabIndex = 19;
            this.tbMilliseconds.Tag = "";
            this.tbMilliseconds.Text = "250";
            this.tbMilliseconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDelay_KeyPress);
            // 
            // tbRepeats
            // 
            this.tbRepeats.Location = new System.Drawing.Point(6, 19);
            this.tbRepeats.MaxLength = 5;
            this.tbRepeats.Name = "tbRepeats";
            this.tbRepeats.Size = new System.Drawing.Size(55, 20);
            this.tbRepeats.TabIndex = 21;
            this.tbRepeats.Tag = "";
            this.tbRepeats.Text = "0";
            this.tbRepeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDelay_KeyPress);
            // 
            // lblInfinite
            // 
            this.lblInfinite.AutoSize = true;
            this.lblInfinite.Location = new System.Drawing.Point(67, 14);
            this.lblInfinite.MaximumSize = new System.Drawing.Size(75, 0);
            this.lblInfinite.Name = "lblInfinite";
            this.lblInfinite.Size = new System.Drawing.Size(71, 26);
            this.lblInfinite.TabIndex = 22;
            this.lblInfinite.Text = "0 => Infinite Until Stopped";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 172);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 34);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start key pressing";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(127, 172);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 34);
            this.btnStop.TabIndex = 24;
            this.btnStop.Text = "Stop key pressing";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.Color.Black;
            this.pbBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBlack.Location = new System.Drawing.Point(78, 19);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(30, 30);
            this.pbBlack.TabIndex = 26;
            this.pbBlack.TabStop = false;
            // 
            // pbWhite
            // 
            this.pbWhite.BackColor = System.Drawing.Color.White;
            this.pbWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWhite.Location = new System.Drawing.Point(80, 21);
            this.pbWhite.Name = "pbWhite";
            this.pbWhite.Size = new System.Drawing.Size(26, 26);
            this.pbWhite.TabIndex = 28;
            this.pbWhite.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(112, 46);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbKey
            // 
            this.gbKey.Controls.Add(this.label1);
            this.gbKey.Location = new System.Drawing.Point(6, 2);
            this.gbKey.Name = "gbKey";
            this.gbKey.Size = new System.Drawing.Size(221, 94);
            this.gbKey.TabIndex = 30;
            this.gbKey.TabStop = false;
            this.gbKey.Text = "Key Settings";
            // 
            // gbDelay
            // 
            this.gbDelay.Controls.Add(this.groupBox6);
            this.gbDelay.Controls.Add(this.groupBox5);
            this.gbDelay.Controls.Add(this.groupBox3);
            this.gbDelay.Controls.Add(this.groupBox4);
            this.gbDelay.Controls.Add(this.lblError);
            this.gbDelay.Location = new System.Drawing.Point(6, 95);
            this.gbDelay.Name = "gbDelay";
            this.gbDelay.Size = new System.Drawing.Size(479, 119);
            this.gbDelay.TabIndex = 31;
            this.gbDelay.TabStop = false;
            this.gbDelay.Text = "Delay Settings";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbRepeats);
            this.groupBox6.Controls.Add(this.lblInfinite);
            this.groupBox6.Location = new System.Drawing.Point(328, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(142, 51);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Repeats";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbMilliseconds);
            this.groupBox5.Location = new System.Drawing.Point(241, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(81, 51);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Milliseconds";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMinutes);
            this.groupBox3.Location = new System.Drawing.Point(67, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(81, 51);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Minutes";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbSeconds);
            this.groupBox4.Location = new System.Drawing.Point(154, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(81, 51);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seconds";
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.lblMessage);
            this.gbName.Controls.Add(this.btnClear);
            this.gbName.Controls.Add(this.btnFind);
            this.gbName.Controls.Add(this.tbInput);
            this.gbName.Location = new System.Drawing.Point(6, 16);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(185, 78);
            this.gbName.TabIndex = 32;
            this.gbName.TabStop = false;
            this.gbName.Text = "By Name";
            // 
            // gbActivation
            // 
            this.gbActivation.Controls.Add(this.label2);
            this.gbActivation.Controls.Add(this.cbStartStop);
            this.gbActivation.Controls.Add(this.btnSave);
            this.gbActivation.Location = new System.Drawing.Point(233, 2);
            this.gbActivation.Name = "gbActivation";
            this.gbActivation.Size = new System.Drawing.Size(252, 94);
            this.gbActivation.TabIndex = 33;
            this.gbActivation.TabStop = false;
            this.gbActivation.Text = "Activation Settings";
            // 
            // gbDragging
            // 
            this.gbDragging.Controls.Add(this.pbWhite);
            this.gbDragging.Controls.Add(this.pbBlack);
            this.gbDragging.Location = new System.Drawing.Point(6, 93);
            this.gbDragging.Name = "gbDragging";
            this.gbDragging.Size = new System.Drawing.Size(185, 67);
            this.gbDragging.TabIndex = 34;
            this.gbDragging.TabStop = false;
            this.gbDragging.Text = "By Dragging";
            // 
            // gbLocate
            // 
            this.gbLocate.Controls.Add(this.gbName);
            this.gbLocate.Controls.Add(this.gbDragging);
            this.gbLocate.Controls.Add(this.lblFound);
            this.gbLocate.Location = new System.Drawing.Point(491, 2);
            this.gbLocate.Name = "gbLocate";
            this.gbLocate.Size = new System.Drawing.Size(198, 211);
            this.gbLocate.TabIndex = 35;
            this.gbLocate.TabStop = false;
            this.gbLocate.Text = "Locate Target";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 219);
            this.Controls.Add(this.gbLocate);
            this.Controls.Add(this.gbActivation);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFound);
            this.Controls.Add(this.cbSpecial);
            this.Controls.Add(this.cbKeys);
            this.Controls.Add(this.gbKey);
            this.Controls.Add(this.gbDelay);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elai Free Auto Keyboard Clicker";
            this.Move += new System.EventHandler(this.FormMain_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhite)).EndInit();
            this.gbKey.ResumeLayout(false);
            this.gbKey.PerformLayout();
            this.gbDelay.ResumeLayout(false);
            this.gbDelay.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.gbActivation.ResumeLayout(false);
            this.gbActivation.PerformLayout();
            this.gbDragging.ResumeLayout(false);
            this.gbLocate.ResumeLayout(false);
            this.gbLocate.PerformLayout();
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
        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.TextBox tbSeconds;
        private System.Windows.Forms.TextBox tbMilliseconds;
        private System.Windows.Forms.TextBox tbRepeats;
        private System.Windows.Forms.Label lblInfinite;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.PictureBox pbWhite;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbKey;
        private System.Windows.Forms.GroupBox gbDelay;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.GroupBox gbActivation;
        private System.Windows.Forms.GroupBox gbDragging;
        private System.Windows.Forms.GroupBox gbLocate;
    }
}

