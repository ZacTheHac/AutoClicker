namespace AutoClicker
{
    partial class Main
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
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_startText = new System.Windows.Forms.Label();
            this.lblstart_time = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_delay = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.rdio_RightClick = new System.Windows.Forms.RadioButton();
            this.rdio_LeftClick = new System.Windows.Forms.RadioButton();
            this.chkHold = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Process = new System.Windows.Forms.TextBox();
            this.txt_WindowName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(145, 180);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(88, 51);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_action_Click);
            // 
            // lbl_startText
            // 
            this.lbl_startText.AutoSize = true;
            this.lbl_startText.Location = new System.Drawing.Point(13, 65);
            this.lbl_startText.Name = "lbl_startText";
            this.lbl_startText.Size = new System.Drawing.Size(77, 13);
            this.lbl_startText.TabIndex = 1;
            this.lbl_startText.Text = "Started Action:";
            // 
            // lblstart_time
            // 
            this.lblstart_time.AutoSize = true;
            this.lblstart_time.Location = new System.Drawing.Point(105, 65);
            this.lblstart_time.Name = "lblstart_time";
            this.lblstart_time.Size = new System.Drawing.Size(0, 13);
            this.lblstart_time.TabIndex = 2;
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(46, 180);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(88, 51);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "STOP!";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // lbl_delay
            // 
            this.lbl_delay.AutoSize = true;
            this.lbl_delay.Location = new System.Drawing.Point(33, 93);
            this.lbl_delay.Name = "lbl_delay";
            this.lbl_delay.Size = new System.Drawing.Size(62, 13);
            this.lbl_delay.TabIndex = 4;
            this.lbl_delay.Text = "Delay (ms): ";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(111, 90);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(70, 20);
            this.txtDelay.TabIndex = 5;
            this.txtDelay.Text = "300";
            // 
            // rdio_RightClick
            // 
            this.rdio_RightClick.AutoSize = true;
            this.rdio_RightClick.Checked = true;
            this.rdio_RightClick.Location = new System.Drawing.Point(51, 123);
            this.rdio_RightClick.Name = "rdio_RightClick";
            this.rdio_RightClick.Size = new System.Drawing.Size(76, 17);
            this.rdio_RightClick.TabIndex = 6;
            this.rdio_RightClick.TabStop = true;
            this.rdio_RightClick.Text = "Right Click";
            this.rdio_RightClick.UseVisualStyleBackColor = true;
            // 
            // rdio_LeftClick
            // 
            this.rdio_LeftClick.AutoSize = true;
            this.rdio_LeftClick.Location = new System.Drawing.Point(140, 123);
            this.rdio_LeftClick.Name = "rdio_LeftClick";
            this.rdio_LeftClick.Size = new System.Drawing.Size(69, 17);
            this.rdio_LeftClick.TabIndex = 7;
            this.rdio_LeftClick.Text = "Left Click";
            this.rdio_LeftClick.UseVisualStyleBackColor = true;
            // 
            // chkHold
            // 
            this.chkHold.AutoSize = true;
            this.chkHold.Location = new System.Drawing.Point(29, 151);
            this.chkHold.Name = "chkHold";
            this.chkHold.Size = new System.Drawing.Size(139, 17);
            this.chkHold.TabIndex = 8;
            this.chkHold.Text = "Hold Click Button Down";
            this.chkHold.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Process Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Window Name:";
            // 
            // txt_Process
            // 
            this.txt_Process.Location = new System.Drawing.Point(98, 6);
            this.txt_Process.Name = "txt_Process";
            this.txt_Process.Size = new System.Drawing.Size(153, 20);
            this.txt_Process.TabIndex = 11;
            this.txt_Process.Text = "javaw";
            // 
            // txt_WindowName
            // 
            this.txt_WindowName.Location = new System.Drawing.Point(98, 32);
            this.txt_WindowName.Name = "txt_WindowName";
            this.txt_WindowName.Size = new System.Drawing.Size(153, 20);
            this.txt_WindowName.TabIndex = 12;
            this.txt_WindowName.Text = "Minecraft";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 236);
            this.Controls.Add(this.txt_WindowName);
            this.Controls.Add(this.txt_Process);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkHold);
            this.Controls.Add(this.rdio_LeftClick);
            this.Controls.Add(this.rdio_RightClick);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.lbl_delay);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.lblstart_time);
            this.Controls.Add(this.lbl_startText);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Auto-Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_startText;
        private System.Windows.Forms.Label lblstart_time;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lbl_delay;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.RadioButton rdio_RightClick;
        private System.Windows.Forms.RadioButton rdio_LeftClick;
        private System.Windows.Forms.CheckBox chkHold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Process;
        private System.Windows.Forms.TextBox txt_WindowName;
    }
}

