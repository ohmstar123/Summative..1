using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Summative._._1
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

        private void button1_Click(object sender, EventArgs e)
        {
            //button pressed
            Title.Visible = false;
            Image_button.Visible = false;

            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Pen drawPen = new Pen(Color.White, 5);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //each dot on constellation
            g.FillEllipse(drawBrush, 346,126 , 10, 10);
            //Thread.Sleep(500);
            g.FillEllipse(drawBrush, 319, 113, 10, 10);
            //Thread.Sleep(500);
            g.FillEllipse(drawBrush, 279, 167, 10, 10);
           // Thread.Sleep(500);
            g.FillEllipse(drawBrush, 290, 206, 10, 10);// connector
            //Thread.Sleep(500);
            g.FillEllipse(drawBrush, 332, 221, 10, 10);
            //Thread.Sleep(500);
            g.FillEllipse(drawBrush, 351, 267, 10, 10);
            //Thread.Sleep(500);
            g.FillEllipse(drawBrush, 187, 305, 10, 10);
            //Thread.Sleep(500);
            g.FillEllipse(drawBrush, 109, 346, 10, 10);
            //Thread.Sleep(500);
            g.FillEllipse(drawBrush, 166, 255, 10, 10);
            //Thread.Sleep(500);

            //connecting lines
            g.DrawLine(drawPen, 348, 128, 321, 115);
            g.DrawLine(drawPen, 323, 115, 281, 171);
            g.DrawLine(drawPen, 281, 171, 292, 208);
            g.DrawLine(drawPen, 292, 208, 334, 223);
            g.DrawLine(drawPen, 335, 223, 353, 269);
            g.DrawLine(drawPen, 355, 271, 189, 309);
            g.DrawLine(drawPen, 189, 309, 111, 348);




        } 

    }
}
