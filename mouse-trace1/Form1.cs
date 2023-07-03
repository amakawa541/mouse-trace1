using System;
using System.Windows.Forms;

namespace mouse_trace1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            textBox1.Text = "X = " + e.X + ", Y = " + e.Y;
        }


        private Point previousPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            /*Å@ê¸Ç≈Ç¬Ç»ÇÆÅ@*/
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            if (previousPoint != null)
            {
                g.DrawLine(pen, previousPoint, e.Location);
            }

            g.DrawEllipse(pen, e.X -10 , e.Y-10 , 20, 20);

            previousPoint = e.Location;

            /*
            ì_Çë≈Ç¬
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, e.X, e.Y, 2, 2);
            */
        }
    }
}