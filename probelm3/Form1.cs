using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probelm3
{
    public partial class Form1 : Form
    {
        

        Pen str = new Pen(Color.Orange, 2);
        public Form1()
        {
            InitializeComponent();
        }

        

        private void clock_psint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Orange, 8), 50, 50, 200, 200);
            e.Graphics.DrawArc(new Pen(Color.Green, 3), 70,70,160,160, 150, 200);
            e.Graphics.DrawArc(new Pen(Color.Yellow, 3), 80,80, 140, 140, 150, 200);
            e.Graphics.DrawArc(new Pen(Color.Red, 3), 80, 80, 140, 140, 310, 40);

            e.Graphics.DrawLine(new Pen(Color.Black, 1), 89, 184, 81, 188);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 219, 136, 229, 134);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 210, 114, 218, 110);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 195, 96, 201, 89);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 135, 83,132, 73);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 88, 121, 79, 117);

            using (Font font1 = new Font("Times New Roman", 10, FontStyle.Bold, GraphicsUnit.Pixel))
            {
                PointF pointF1 = new PointF(92, 176);
                e.Graphics.DrawString("0", font1, Brushes.Blue, pointF1);
            }



            str.StartCap = LineCap.RoundAnchor;
            e.Graphics.DrawLine(str,150,150,104,177);

        }

        private void mouse(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
        }
    }
}
