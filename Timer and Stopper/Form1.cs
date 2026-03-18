using System;
using System.Windows.Forms;

namespace Timer_and_Stopper
{
    public partial class Form1 : Form
    {

        int allseconds = 0;        
        int all_seconds_stoper = 0; 

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer2.Interval = 1000;

            timer1.Tick += timer1_Tick;
        }


        private void start_Click(object sender, EventArgs e)
        {
 
            if (int.TryParse(minutes_txt.Text, out int minutes) && int.TryParse(seconds_txt.Text, out int seconds))
            {
                allseconds = minutes * 60 + seconds;
                Time.Text = TimeSpan.FromSeconds(allseconds).ToString(@"mm\:ss");

                timer1.Start();
            }
            else
            {
                MessageBox.Show("Poda³eœ nieprawid³owy format czasu.");
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {

            timer1.Stop();
        }

  
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (allseconds > 0)
            {
                allseconds--;
                Time.Text = TimeSpan.FromSeconds(allseconds).ToString(@"mm\:ss");
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Time ended");
            }
        }


        private void start1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void stop1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void reset_Click(object sender, EventArgs e)
        {

            timer2.Stop();
            all_seconds_stoper = 0;
            Time1.Text = "00:00";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            all_seconds_stoper++;
            Time1.Text = TimeSpan.FromSeconds(all_seconds_stoper).ToString(@"mm\:ss");
        }

        private void tabPage1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Tabs_Click(object sender, EventArgs e) { }
        private void Time1_Click(object sender, EventArgs e) { }
        private void Time_Click(object sender, EventArgs e) { }
    }
}