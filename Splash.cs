using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfraCodeEditor
{
    public partial class Splash : Form
    {
        Timer timer = new Timer();

        bool isPanelDragged = false;
        Point offset;

        public Splash()
        {
            InitializeComponent();
            SetAndStartTimer();
        }

        private void SetAndStartTimer()
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        static int count = 0;

        void timer_Tick(object sender, EventArgs e)
        {
            count += 2;

            if (count == 100)
            {
                timer.Stop();
                this.Close();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isPanelDragged = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (isPanelDragged)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                Point newPoint = panel1 .PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isPanelDragged = false;
        }
    }
}
