using System;
using Nakov.TurtleGraphics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turtle_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//draw
            Turtle.PenColor = Color.Blue;
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 200;

            // Draw a equilateral triangle
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            // Draw a line in the triangle
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);


        }

        private void button2_Click(object sender, EventArgs e)
        {//reset
            Turtle.Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {//show/hide
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.button3.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.button3.Text = "Hide Turtle";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {//hexagon
            Turtle.PenColor = Color.Purple;
            for (int i = 0; i < 6; i++)
            {
                Turtle.Delay = 200;
                Turtle.Rotate(60);
                Turtle.Forward(100);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {//star
            Turtle.PenColor = Color.Green;
            for (int i = 0; i < 5; i++)
            {
                Turtle.Delay = 200;
                Turtle.Rotate(144);
                Turtle.Forward(200);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {//spiral
            Turtle.PenColor = Color.Purple;
            for (int i = 0; i < 20; i++)
            {
                Turtle.Delay = 100;
                Turtle.Forward(i * 10 + 10);
                Turtle.Rotate(60);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {//sun
            Turtle.PenColor = Color.Blue;
            for (int i = 0; i < 36; i++)
            {
                Turtle.Delay = 100;
                Turtle.Forward(250);
                Turtle.Rotate(170);
                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {//Triangle
            Turtle.PenColor = Color.Red;
            Turtle.Delay = 100;
            for (int i = 0; i < 22; i++)
            {
                Turtle.Forward(i * 10 + 10);
                Turtle.Rotate(120);
            }
            Turtle.Rotate(120);
            for (int i = 0; i < 21; i++)
            {
                Turtle.Forward(i * 10 + 10);
                Turtle.Rotate(120);
            }
            Turtle.Rotate(120);
            for (int i = 0; i < 21; i++)
            {
                Turtle.Forward(i * 10 + 10);
                Turtle.Rotate(120);
            }
        }
    }
}

