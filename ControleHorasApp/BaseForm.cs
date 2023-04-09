using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControleHorasApp
{
    public partial class BaseForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public string TituloForm
        {
            get { return lblTituloForm.Text; }
            set { lblTituloForm.Text = value; }
        }

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.FromArgb(12, 109, 179), 10);
            e.Graphics.DrawLine(pen, 0, 1, this.Width, 1);
        }

        private void btnMinimizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnFechar_Click(object sender, EventArgs e) => Close();

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void BaseForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
