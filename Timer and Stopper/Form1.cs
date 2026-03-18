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
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tabs_Click(object sender, EventArgs e)
        {

        }

        private void Time1_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            if (int.TryParse(minutes_txt.Text, out int minutes ))
            {
                if (int.TryParse(seconds_txt.Text, out int seconds))
                {
                    allseconds = minutes * 60 + seconds;
                    Time.Text = TimeSpan.FromSeconds(allseconds).ToString(@"mm\:ss");
                }
                else
                {
                    MessageBox.Show("Poda³eœ nie prawid³owy format czasu");
                    return;
                }
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {

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
            timer2.Dispose();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int allseconds = 0;
            
        }

        private void Time_Click(object sender, EventArgs e)
        {
            
        }
    }
}
