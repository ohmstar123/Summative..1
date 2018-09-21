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
using System.Media;

/// <summary>
/// Created by Ohm Patel
/// Date: Sept 24, 2018
/// Information: Leo constellation and information about it
/// </summary>


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
        {  //button pressed
            Title.Visible = false;
            Image_button.Visible = false;

            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Pen drawPen = new Pen(Color.White, 5);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //each dot on constellation
            g.FillEllipse(drawBrush, 346,126 , 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 319, 113, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 279, 167, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 290, 206, 10, 10);// connector
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 332, 221, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 351, 267, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 187, 305, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 109, 346, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 166, 255, 10, 10);
            Thread.Sleep(500);
            
            //connecting lines
            g.DrawLine(drawPen, 348, 128, 321, 115);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 323, 115, 281, 171);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 281, 171, 292, 208);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 292, 208, 334, 223);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 335, 223, 353, 269);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 355, 271, 189, 309);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 189, 309, 111, 351);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 111, 351, 170, 257);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 170, 257, 292, 208);
            Thread.Sleep(500);

            //Paragraph
            SolidBrush parabrush = new SolidBrush(Color.Red);
            Font parafont = new Font("segoe script", 14, FontStyle.Bold);

            g.DrawString(" Leo is one of the constellations of the\n" +
                " zodiac, lying between Cancer the crab to \n" +
                " the west and Virgo the maiden to the \n" +
                " east. Its name is Latin for lion, and to\n" +
                " the ancient Greeks represented the\n" +
                " Nemean Lion killed by the mythical \n" +
                " Greek hero Heracles as one of his\n" +
                " twelve labors", parafont, parabrush, 370, 100);
            Thread.Sleep(1000);

            //color change 1
            g.Clear(Color.Black);
            SolidBrush SecondBrush = new SolidBrush(Color.Gold);
            Pen SecondPen = new Pen(Color.Gold, 5);

            g.FillEllipse(SecondBrush, 346, 126, 10, 10);
            g.FillEllipse(SecondBrush, 319, 113, 10, 10);
            g.FillEllipse(SecondBrush, 279, 167, 10, 10);
            g.FillEllipse(SecondBrush, 290, 206, 10, 10);
            g.FillEllipse(SecondBrush, 332, 221, 10, 10);
            g.FillEllipse(SecondBrush, 351, 267, 10, 10);
            g.FillEllipse(SecondBrush, 187, 305, 10, 10);
            g.FillEllipse(SecondBrush, 109, 346, 10, 10);
            g.FillEllipse(SecondBrush, 166, 255, 10, 10);

            g.DrawLine(SecondPen, 348, 128, 321, 115);
            g.DrawLine(SecondPen, 323, 115, 281, 171);
            g.DrawLine(SecondPen, 281, 171, 292, 208);
            g.DrawLine(SecondPen, 292, 208, 334, 223);
            g.DrawLine(SecondPen, 335, 223, 353, 269);
            g.DrawLine(SecondPen, 355, 271, 189, 309);
            g.DrawLine(SecondPen, 189, 309, 111, 351);
            g.DrawLine(SecondPen, 111, 351, 170, 257);
            g.DrawLine(SecondPen, 170, 257, 292, 208);

            g.DrawString(" Leo is one of the constellations of the\n" +
                " zodiac, lying between Cancer the crab to \n" +
                " the west and Virgo the maiden to the \n" +
                " east. Its name is Latin for lion, and to\n" +
                " the ancient Greeks represented the\n" +
                " Nemean Lion killed by the mythical \n" +
                " Greek hero Heracles as one of his\n" +
                " twelve labors", parafont, parabrush, 370, 100);

            Thread.Sleep(1000);

            //color change 2
            g.Clear(Color.Black);
            SecondBrush = new SolidBrush(Color.White);
            SecondPen = new Pen(Color.White, 5);

            g.FillEllipse(SecondBrush, 346, 126, 10, 10);
            g.FillEllipse(SecondBrush, 319, 113, 10, 10);
            g.FillEllipse(SecondBrush, 279, 167, 10, 10);
            g.FillEllipse(SecondBrush, 290, 206, 10, 10);
            g.FillEllipse(SecondBrush, 332, 221, 10, 10);
            g.FillEllipse(SecondBrush, 351, 267, 10, 10);
            g.FillEllipse(SecondBrush, 187, 305, 10, 10);
            g.FillEllipse(SecondBrush, 109, 346, 10, 10);
            g.FillEllipse(SecondBrush, 166, 255, 10, 10);

            g.DrawLine(SecondPen, 348, 128, 321, 115);
            g.DrawLine(SecondPen, 323, 115, 281, 171);
            g.DrawLine(SecondPen, 281, 171, 292, 208);
            g.DrawLine(SecondPen, 292, 208, 334, 223);
            g.DrawLine(SecondPen, 335, 223, 353, 269);
            g.DrawLine(SecondPen, 355, 271, 189, 309);
            g.DrawLine(SecondPen, 189, 309, 111, 351);
            g.DrawLine(SecondPen, 111, 351, 170, 257);
            g.DrawLine(SecondPen, 170, 257, 292, 208);

            g.DrawString(" Leo is one of the constellations of the\n" +
                " zodiac, lying between Cancer the crab to \n" +
                " the west and Virgo the maiden to the \n" +
                " east. Its name is Latin for lion, and to\n" +
                " the ancient Greeks represented the\n" +
                " Nemean Lion killed by the mythical \n" +
                " Greek hero Heracles as one of his\n" +
                " twelve labors", parafont, parabrush, 370, 100);

            Thread.Sleep(1000);

            //color change 3
            g.Clear(Color.Black);
            SecondBrush = new SolidBrush(Color.Gold);
            SecondPen = new Pen(Color.Gold, 5);

            g.FillEllipse(SecondBrush, 346, 126, 10, 10);
            g.FillEllipse(SecondBrush, 319, 113, 10, 10);
            g.FillEllipse(SecondBrush, 279, 167, 10, 10);
            g.FillEllipse(SecondBrush, 290, 206, 10, 10);
            g.FillEllipse(SecondBrush, 332, 221, 10, 10);
            g.FillEllipse(SecondBrush, 351, 267, 10, 10);
            g.FillEllipse(SecondBrush, 187, 305, 10, 10);
            g.FillEllipse(SecondBrush, 109, 346, 10, 10);
            g.FillEllipse(SecondBrush, 166, 255, 10, 10);

            g.DrawLine(SecondPen, 348, 128, 321, 115);
            g.DrawLine(SecondPen, 323, 115, 281, 171);
            g.DrawLine(SecondPen, 281, 171, 292, 208);
            g.DrawLine(SecondPen, 292, 208, 334, 223);
            g.DrawLine(SecondPen, 335, 223, 353, 269);
            g.DrawLine(SecondPen, 355, 271, 189, 309);
            g.DrawLine(SecondPen, 189, 309, 111, 351);
            g.DrawLine(SecondPen, 111, 351, 170, 257);
            g.DrawLine(SecondPen, 170, 257, 292, 208);

            g.DrawString(" Leo is one of the constellations of the\n" +
                " zodiac, lying between Cancer the crab to \n" +
                " the west and Virgo the maiden to the \n" +
                " east. Its name is Latin for lion, and to\n" +
                " the ancient Greeks represented the\n" +
                " Nemean Lion killed by the mythical \n" +
                " Greek hero Heracles as one of his\n" +
                " twelve labors", parafont, parabrush, 370, 100);

            Thread.Sleep(1000);

            //color change 4
            g.Clear(Color.Black);
            SecondBrush = new SolidBrush(Color.White);
            SecondPen = new Pen(Color.White, 5);

            g.FillEllipse(SecondBrush, 346, 126, 10, 10);
            g.FillEllipse(SecondBrush, 319, 113, 10, 10);
            g.FillEllipse(SecondBrush, 279, 167, 10, 10);
            g.FillEllipse(SecondBrush, 290, 206, 10, 10);
            g.FillEllipse(SecondBrush, 332, 221, 10, 10);
            g.FillEllipse(SecondBrush, 351, 267, 10, 10);
            g.FillEllipse(SecondBrush, 187, 305, 10, 10);
            g.FillEllipse(SecondBrush, 109, 346, 10, 10);
            g.FillEllipse(SecondBrush, 166, 255, 10, 10);

            g.DrawLine(SecondPen, 348, 128, 321, 115);
            g.DrawLine(SecondPen, 323, 115, 281, 171);
            g.DrawLine(SecondPen, 281, 171, 292, 208);
            g.DrawLine(SecondPen, 292, 208, 334, 223);
            g.DrawLine(SecondPen, 335, 223, 353, 269);
            g.DrawLine(SecondPen, 355, 271, 189, 309);
            g.DrawLine(SecondPen, 189, 309, 111, 351);
            g.DrawLine(SecondPen, 111, 351, 170, 257);
            g.DrawLine(SecondPen, 170, 257, 292, 208);

            g.DrawString(" Leo is one of the constellations of the\n" +
                " zodiac, lying between Cancer the crab to \n" +
                " the west and Virgo the maiden to the \n" +
                " east. Its name is Latin for lion, and to\n" +
                " the ancient Greeks represented the\n" +
                " Nemean Lion killed by the mythical \n" +
                " Greek hero Heracles as one of his\n" +
                " twelve labors", parafont, parabrush, 370, 100);

            Thread.Sleep(1000);

            //color change 5
            g.Clear(Color.Black);
            SecondBrush = new SolidBrush(Color.Gold);
            SecondPen = new Pen(Color.Gold, 5);

            g.FillEllipse(SecondBrush, 346, 126, 10, 10);
            g.FillEllipse(SecondBrush, 319, 113, 10, 10);
            g.FillEllipse(SecondBrush, 279, 167, 10, 10);
            g.FillEllipse(SecondBrush, 290, 206, 10, 10);
            g.FillEllipse(SecondBrush, 332, 221, 10, 10);
            g.FillEllipse(SecondBrush, 351, 267, 10, 10);
            g.FillEllipse(SecondBrush, 187, 305, 10, 10);
            g.FillEllipse(SecondBrush, 109, 346, 10, 10);
            g.FillEllipse(SecondBrush, 166, 255, 10, 10);

            g.DrawLine(SecondPen, 348, 128, 321, 115);
            g.DrawLine(SecondPen, 323, 115, 281, 171);
            g.DrawLine(SecondPen, 281, 171, 292, 208);
            g.DrawLine(SecondPen, 292, 208, 334, 223);
            g.DrawLine(SecondPen, 335, 223, 353, 269);
            g.DrawLine(SecondPen, 355, 271, 189, 309);
            g.DrawLine(SecondPen, 189, 309, 111, 351);
            g.DrawLine(SecondPen, 111, 351, 170, 257);
            g.DrawLine(SecondPen, 170, 257, 292, 208);

            g.DrawString(" Leo is one of the constellations of the\n" +
                " zodiac, lying between Cancer the crab to \n" +
                " the west and Virgo the maiden to the \n" +
                " east. Its name is Latin for lion, and to\n" +
                " the ancient Greeks represented the\n" +
                " Nemean Lion killed by the mythical \n" +
                " Greek hero Heracles as one of his\n" +
                " twelve labors", parafont, parabrush, 370, 100);

            Thread.Sleep(1000);

            //color change 6
            g.Clear(Color.Black);
            SecondBrush = new SolidBrush(Color.White);
            SecondPen = new Pen(Color.White, 5);

            g.FillEllipse(SecondBrush, 346, 126, 10, 10);
            g.FillEllipse(SecondBrush, 319, 113, 10, 10);
            g.FillEllipse(SecondBrush, 279, 167, 10, 10);
            g.FillEllipse(SecondBrush, 290, 206, 10, 10);
            g.FillEllipse(SecondBrush, 332, 221, 10, 10);
            g.FillEllipse(SecondBrush, 351, 267, 10, 10);
            g.FillEllipse(SecondBrush, 187, 305, 10, 10);
            g.FillEllipse(SecondBrush, 109, 346, 10, 10);
            g.FillEllipse(SecondBrush, 166, 255, 10, 10);

            g.DrawLine(SecondPen, 348, 128, 321, 115);
            g.DrawLine(SecondPen, 323, 115, 281, 171);
            g.DrawLine(SecondPen, 281, 171, 292, 208);
            g.DrawLine(SecondPen, 292, 208, 334, 223);
            g.DrawLine(SecondPen, 335, 223, 353, 269);
            g.DrawLine(SecondPen, 355, 271, 189, 309);
            g.DrawLine(SecondPen, 189, 309, 111, 351);
            g.DrawLine(SecondPen, 111, 351, 170, 257);
            g.DrawLine(SecondPen, 170, 257, 292, 208);

            g.DrawString(" Leo is one of the constellations of the\n" +
                " zodiac, lying between Cancer the crab to \n" +
                " the west and Virgo the maiden to the \n" +
                " east. Its name is Latin for lion, and to\n" +
                " the ancient Greeks represented the\n" +
                " Nemean Lion killed by the mythical \n" +
                " Greek hero Heracles as one of his\n" +
                " twelve labors", parafont, parabrush, 370, 100);  
        }
    }
}
