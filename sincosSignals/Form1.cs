using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sincosSignals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Graphics g;
        public Font font0;
        public Font fontmin;
        public Pen pen0 = new Pen(Color.Black);
        public Pen pen2 = new Pen(Color.Silver, 1);
       
        public Brush brush0 = new SolidBrush(Color.DimGray);
        
        public static int posx = 20;
        public static int posy = 20;
        public int xwidth = 100;
        public int yheight = 100;
        public double rad = (180 / Math.PI);
        public int cx = posx + 50;
        public int cy = posy + 50;
        public double sint = Math.Sin((1) / (180 / Math.PI)) * (100 / 2) + 70;
        public double scos = Math.Cos((1) / (180 / Math.PI)) * (100 / 2) + 70;
        public double prevx;
        public double prevy;

        public void clear()
        {
            g.Clear(BackColor);
        }

        public void drawcircle()
        {
          
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                g.DrawLine(pen0, Convert.ToInt16(scos), 100 + Convert.ToInt16(sint), Convert.ToInt16(prevx), 100 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
        }
        public void drawsin()
        {
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                //g.DrawLine(pen0, Convert.ToInt16(scos), Convert.ToInt16(sint), Convert.ToInt16(prevx), Convert.ToInt16(prevy));
                g.DrawLine(pen0, i, 100 + Convert.ToInt16(sint), i, 270);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 270);

                prevx = scos;
                prevy = sint;

            }
        }
        public void drawcos()
        {
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                //g.DrawLine(pen0, Convert.ToInt16(scos), Convert.ToInt16(sint), Convert.ToInt16(prevx), Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                g.DrawLine(pen0, i, 100 + Convert.ToInt16(scos), i, 270);

                prevx = scos;
                prevy = sint;

            }
        }
        public void drawcosplussin()
        {
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                //g.DrawLine(pen0, Convert.ToInt16(scos), Convert.ToInt16(sint), Convert.ToInt16(prevx), Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                g.DrawLine(pen0, i, 100 + Convert.ToInt16(scos)+ Convert.ToInt16(sint), i, 270);

                prevx = scos;
                prevy = sint;

            }
        }
        public void drawcosminussin()
        {
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                //g.DrawLine(pen0, Convert.ToInt16(scos), Convert.ToInt16(sint), Convert.ToInt16(prevx), Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                g.DrawLine(pen0, i, 100+Convert.ToInt16(scos) - Convert.ToInt16(sint), i, 270);

                prevx = scos;
                prevy = sint;

            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //font0 = Font;
            font0 = new Font("Tahoma", 8);
            fontmin = new Font("Tahoma", 2);
            g = CreateGraphics();

             prevx = scos;
             prevy = sint;


    }

        private void button1_Click(object sender, EventArgs e)
        {
            drawcircle();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawcos();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawsin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            drawcosplussin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            drawcosminussin();
        }
    }
}
