namespace Timer_and_Stopper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabPage2 = new TabPage();
            reset = new Button();
            stop1 = new Button();
            start1 = new Button();
            Time1 = new Label();
            Tabs = new TabPage();
            stop = new Button();
            start = new Button();
            minutes_txt = new TextBox();
            Time = new Label();
            label4 = new Label();
            label3 = new Label();
            seconds = new Label();
            minutes = new Label();
            seconds_txt = new TextBox();
            tabControl1 = new TabControl();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            tabPage2.SuspendLayout();
            Tabs.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(reset);
            tabPage2.Controls.Add(stop1);
            tabPage2.Controls.Add(start1);
            tabPage2.Controls.Add(Time1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(667, 326);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Timer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            reset.Font = new Font("Segoe UI", 20F);
            reset.Location = new Point(266, 232);
            reset.Name = "reset";
            reset.Size = new Size(128, 53);
            reset.TabIndex = 3;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // stop1
            // 
            stop1.Font = new Font("Segoe UI", 20F);
            stop1.Location = new Point(433, 232);
            stop1.Name = "stop1";
            stop1.Size = new Size(128, 53);
            stop1.TabIndex = 2;
            stop1.Text = "Stop";
            stop1.UseVisualStyleBackColor = true;
            stop1.Click += stop1_Click;
            // 
            // start1
            // 
            start1.Font = new Font("Segoe UI", 20F);
            start1.Location = new Point(94, 232);
            start1.Name = "start1";
            start1.Size = new Size(128, 53);
            start1.TabIndex = 1;
            start1.Text = "Start";
            start1.UseVisualStyleBackColor = true;
            start1.Click += start1_Click;
            // 
            // Time1
            // 
            Time1.AutoSize = true;
            Time1.Font = new Font("Segoe UI", 50F);
            Time1.Location = new Point(229, 56);
            Time1.Name = "Time1";
            Time1.Size = new Size(197, 89);
            Time1.TabIndex = 0;
            Time1.Text = "00:00";
            Time1.Click += Time1_Click;
            // 
            // Tabs
            // 
            Tabs.Controls.Add(stop);
            Tabs.Controls.Add(start);
            Tabs.Controls.Add(minutes_txt);
            Tabs.Controls.Add(Time);
            Tabs.Controls.Add(label4);
            Tabs.Controls.Add(label3);
            Tabs.Controls.Add(seconds);
            Tabs.Controls.Add(minutes);
            Tabs.Controls.Add(seconds_txt);
            Tabs.Location = new Point(4, 24);
            Tabs.Name = "Tabs";
            Tabs.Padding = new Padding(3);
            Tabs.Size = new Size(667, 326);
            Tabs.TabIndex = 0;
            Tabs.Text = "Stopper";
            Tabs.UseVisualStyleBackColor = true;
            Tabs.Click += Tabs_Click;
            // 
            // stop
            // 
            stop.Font = new Font("Segoe UI", 14F);
            stop.Location = new Point(372, 138);
            stop.Name = "stop";
            stop.Size = new Size(93, 32);
            stop.TabIndex = 8;
            stop.Text = "stop";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // start
            // 
            start.Font = new Font("Segoe UI", 14F);
            start.Location = new Point(181, 135);
            start.Name = "start";
            start.Size = new Size(93, 35);
            start.TabIndex = 7;
            start.Text = "start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // minutes_txt
            // 
            minutes_txt.Font = new Font("Segoe UI", 18F);
            minutes_txt.Location = new Point(182, 69);
            minutes_txt.Name = "minutes_txt";
            minutes_txt.Size = new Size(100, 39);
            minutes_txt.TabIndex = 6;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 50F);
            Time.ForeColor = SystemColors.Desktop;
            Time.Location = new Point(229, 207);
            Time.Name = "Time";
            Time.Size = new Size(197, 89);
            Time.TabIndex = 5;
            Time.Text = "00:00";
            Time.Click += Time_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(287, 116);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(243, 95);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 3;
            // 
            // seconds
            // 
            seconds.AutoSize = true;
            seconds.Font = new Font("Segoe UI", 18F);
            seconds.Location = new Point(365, 24);
            seconds.Name = "seconds";
            seconds.Size = new Size(103, 32);
            seconds.TabIndex = 2;
            seconds.Text = "Seconds";
            // 
            // minutes
            // 
            minutes.AutoSize = true;
            minutes.Font = new Font("Segoe UI", 18F);
            minutes.Location = new Point(182, 24);
            minutes.Name = "minutes";
            minutes.Size = new Size(101, 32);
            minutes.TabIndex = 1;
            minutes.Text = "Minutes";
            minutes.Click += label1_Click;
            // 
            // seconds_txt
            // 
            seconds_txt.Font = new Font("Segoe UI", 18F);
            seconds_txt.Location = new Point(365, 69);
            seconds_txt.Name = "seconds_txt";
            seconds_txt.Size = new Size(100, 39);
            seconds_txt.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Tabs);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(50, 38);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(675, 354);
            tabControl1.TabIndex = 0;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            Tabs.ResumeLayout(false);
            Tabs.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage Tabs;
        private Label minutes;
        private TextBox seconds_txt;
        private TabControl tabControl1;
        private Label Time;
        private Label label4;
        private Label label3;
        private Label seconds;
        private TextBox minutes_txt;
        private Label Time1;
        private Button stop;
        private Button start;
        private Button stop1;
        private Button start1;
        private Button reset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
