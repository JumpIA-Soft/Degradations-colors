using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color_interpolation
{
    public partial class Form1 : Form
    {
        Bitmap pixelVector = new Bitmap(700, 500); // crear un objeto tipo Bitmap=crear pixel o pixel
        public Form1()
        {
            InitializeComponent();


        }

        private void activeInterpolation_Click(object sender, EventArgs e)
        {
             int Red;
             int Blue;
             int Green;

            //convert text input in input type for 2 RGB colors
            int R1 = Int32.Parse(tbColorR1.Text);
            int R2 = Int32.Parse(tbColorR2.Text);
            int B1 = Int32.Parse(tbColorB1.Text);
            int B2 = Int32.Parse(tbColorB2.Text);
            int G1 = Int32.Parse(tbColorG1.Text);
            int G2 = Int32.Parse(tbColorG2.Text);

            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 700; j++)
                {
                    //interpolation application for Lagrange's method
                    float div1 = (float) (j - 700) / (-700);//only put (float) in division operations of the float variable
                    float div2 = (float) j / (700);

                    Red = (int)(((div1) * R1) + ((div2) * R2));
                    Green = (int)(((div1) * G1) + ((div2) * G2));
                    Blue = (int)(((div1) * B1) + ((div2) * B2));

                    pixelVector.SetPixel(j, i, Color.FromArgb(Red, Green, Blue));
                }
            }

            windowsPixel.Image = pixelVector;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void colorSelections_Click(object sender, EventArgs e)
        {
            //Use two loops for can draw in lienzo of 700x500 with pixels
            for (int i = 100; i < 300; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    //assign the first color in format RGB according to the form values
                    pixelVector.SetPixel(i, j, Color.FromArgb(Int32.Parse(tbColorR1.Text), Int32.Parse(tbColorG1.Text), Int32.Parse(tbColorB1.Text)));
                    if (j >= 251)//start drawing the second color when the J value is 251 or higher
                    {
                        pixelVector.SetPixel(i, j, Color.FromArgb(Int32.Parse(tbColorR2.Text), Int32.Parse(tbColorG2.Text), Int32.Parse(tbColorB2.Text)));
                    }
                }
            }
            windowsPixel.Image = pixelVector;
        }
    }
}
