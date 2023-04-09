using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControleHorasApp.Components
{
    public partial class TaskUserControl : UserControl
    {
        public int TaskId { get; set; }

        public string TaskName
        {
            get { return lblTaskName.Text; }
            set { lblTaskName.Text = value; }
        }

        public string CurrentTime
        {
            get { return lblCurrentTime.Text; }
            set { lblCurrentTime.Text = value; }
        }

        public string EstimatedTime
        {
            get { return lblEstimatedTime.Text; }
            set { lblEstimatedTime.Text = value; }
        }

        public TaskUserControl() => InitializeComponent();

        public void EnableButtons(bool enable)
        {
            btnStart.Enabled = enable;
            btnStop.Enabled = !enable;
        }

        public void EnableTimer(bool enable) => timerTask.Enabled = enable;


        private void timerTask_Tick(object sender, EventArgs e)
        {
            // Incrementa label de tempo atual
            var tempoAtual = TimeSpan.Parse(lblCurrentTime.Text);

            tempoAtual += TimeSpan.FromSeconds(1);
            lblCurrentTime.Text = string.Format("{0:hh\\:mm\\:ss}", tempoAtual);

            // Incrementa progressbar
            pgbTask.Value += 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            EnableButtons(true);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
        } 

        private void TaskUserControl_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.FromArgb(220, 220, 220), 2);
            e.Graphics.DrawLine(pen, 0, this.Height-10, this.Width, this.Height-10);
        }
    }
}
