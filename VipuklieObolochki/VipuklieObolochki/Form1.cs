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
        List<Point> points = new List<Point> { };
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
        private double GetAngle(Point a, Point b)
        {
            return Math.Acos((a.X * b.X + a.Y * b.Y) / Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2))
                / Math.Sqrt(Math.Pow(b.X, 2) + Math.Pow(b.Y, 2)));
        }
        private int GetPolarAngle(Point a, Point b, Point c)
        {
            return (b.X - a.X) * (c.Y - b.Y) - (b.Y - a.Y) * (c.X - b.X);
        }
        private void Process()
        {
            List<Point> temp = new List<Point>(points);            
            obolochka = new List<Point> { new Point(int.MaxValue, 0) };
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].X < obolochka[0].X)
                    obolochka[0] = temp[i];
                else if (temp[i].X == obolochka[0].X)
                    if (temp[i].Y > obolochka[0].Y)
                        obolochka[0] = temp[i];
            }
            temp.Remove(obolochka[0]);
            for (int i = 0; i < temp.Count; i++)
            {
                for (int j = 0; j < temp.Count - 1 - i; j++)
                {
                    double firstAngle = GetAngle(new Point(0, 1),
                        Point.Subtract(temp[j], new Size(obolochka[0].X, obolochka[0].Y)));
                    double secondAngle = GetAngle(new Point(0, 1),
                        Point.Subtract(temp[j + 1], new Size(obolochka[0].X, obolochka[0].Y)));
                    if (firstAngle > secondAngle)
                    {
                        Point tmp = temp[j];
                        temp[j] = temp[j + 1];
                        temp[j + 1] = tmp;
                    }
                    else if (firstAngle == secondAngle)
                    {
                        if (Math.Sqrt(temp[j].X * temp[j].X + temp[j].Y * temp[j].Y) >
                             Math.Sqrt(temp[j + 1].X * temp[j + 1].X + temp[j + 1].Y * temp[j + 1].Y))
                        {
                            Point tmp = temp[j];
                            temp[j] = temp[j + 1];
                            temp[j + 1] = tmp;
                        }
                    }
                }
            }
            obolochka.Add(temp[0]);
            temp.RemoveAt(0);
            for (int i = 0; i < temp.Count; i++)
            {
                int polarAngle = GetPolarAngle(obolochka[obolochka.Count - 2], obolochka[obolochka.Count - 1], temp[i]);
                if (polarAngle <= 0)
                {
                    obolochka.Add(temp[i]);
                }
                else if (polarAngle > 0 && obolochka.Count!= 2)
                {
                    obolochka.RemoveAt(obolochka.Count - 1);
                    i--;
                }
            }
        }

        private void mainPB_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            Graphics gr = mainPB.CreateGraphics();
            Pen pen = new Pen(Brushes.Black);
            gr.DrawEllipse(pen, coordinates.X - 2, coordinates.Y - 2, 5, 5);
            if (!points.Contains(coordinates))
            {
                List<Point> temp = new List<Point>(obolochka);
                points.Add(coordinates);
                if (points.Count > 2)
                {
                    if (points.Count != 3)
                    {
                        Process();
                        if (temp.Count <= obolochka.Count)
                        {
                            bool equals = temp.Count == obolochka.Count;
                            for (int i = 0; i < temp.Count && equals; i++)
                            {
                                if (temp[i].X != obolochka[i].X || temp[i].Y != obolochka[i].Y)
                                {
                                    equals = false;
                                    break;
                                }
                            }
                            if (!equals)
                            {
                                mainPB.Refresh();
                                for (int i = 0; i < obolochka.Count - 1; i++)
                                {
                                    gr.DrawLine(pen, obolochka[i], obolochka[i + 1]);
                                }
                                gr.DrawLine(pen, obolochka[0], obolochka[obolochka.Count - 1]);
                                foreach (var item in points)
                                {
                                    gr.DrawEllipse(pen, item.X - 2, item.Y - 2, 5, 5);
                                }
                            }
                        }
                    }
                    else
                    {
                        mainPB.Refresh();
                        obolochka = new List<Point>(points);
                        for (int i = 0; i < obolochka.Count - 1; i++)
                        {
                            gr.DrawLine(pen, obolochka[i], obolochka[i + 1]);
                        }
                        gr.DrawLine(pen, obolochka[0], obolochka[obolochka.Count - 1]);
                        foreach (var item in points)
                        {
                            gr.DrawEllipse(pen, item.X - 2, item.Y - 2, 5, 5);
                        }
                    }
                }
                
            }

        }

    }
}
