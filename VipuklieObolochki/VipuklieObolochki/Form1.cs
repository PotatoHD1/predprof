using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VipuklieObolochki
{
    public partial class MainForm : Form
    {
        List<Point> points = new List<Point>();
        List<Point> obolochka = new List<Point>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            points = new List<Point>();
            mainPB.Refresh();
        }
        private double GetPolarAngle(Point a, Point b)
        {
            return Math.Acos((a.X * b.X + a.Y * b.Y)/(Math.Sqrt(Math.Pow(a.X,2) + Math.Pow(a.Y,2)))
                * Math.Sqrt(Math.Pow(b.X,2) + Math.Pow(b.Y,2)));
        }
        private void Process()
        {
            obolochka = new List<Point>();

        }

        private async void mainPB_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            points.Add(coordinates);
            if (debugCB.Checked)
            {
                Process();

            }
        }

        private void debugCB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
