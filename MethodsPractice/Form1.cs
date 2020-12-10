using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsPractice
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //TODO - Place method calls here

            PrintSignature();
            RectangleArea();
            Adder();
            AreaCircle();
            MaxValue();

        }

        // 1. Print a signature to the screen

        public void PrintSignature()
        {
            q1Output.Text = "Your's truly, \n\nGrace Hopper.";
        }

        // 2. Create a method to calculate the area of a rectangle with
        //    dimensions 5x7, and then use the variables to display:
        //
        //    The area of a 5 x 7 rectangle is 35 units squared

        public void RectangleArea()
        {
            int length = 7;
            int width = 5;
            int area = length * width;

            q2Output.Text = $"The area of {width} x {length} rectangle is {area} units squared.";

        }

        // 3. Create a method to get numbers from q3Num1Input and q3Num2Input,
        //    add them together, and then display output as follows, (use the variables):
        //
        //    5 + 4 = 9 
        public void Adder()
        {
            int num1 = Convert.ToInt32(q2Num1Input.Text);
            int num2 = Convert.ToInt32(q2Num2Input.Text);
            int answer = num1 + num2;
            q3Output.Text = $"{num1} + {num2} = {answer}";
        }

        // 4. Create a method to calculate the area of a circle based on  
        //    the radius entered in radiusInput, then display output as follows:
        //
        //    The area of a circle with radius of 4 is 50.24 units squared

        public void AreaCircle()
        {
            double radius = Convert.ToInt32(radiusInput.Text);
            double pi = 3.14;
            double areaOfCircle = pi * radius * radius;

            q4Output.Text = $"The area of a circle with a radius of {radius} is {areaOfCircle} units squared.";

        }


        // 5. 3U Only - Create a method that will determine and display   
        //    the maximum of 3 values entered into q5Num1Input, q5Num2Input,
        //    and q5Num3Input. Sample input and output is shown below:
        //
        //    Inputs: 5, 7, 2
        //    The largest value is 7

        public void MaxValue()
        {
            int num1 = Convert.ToInt32(q5Num1Input.Text);
            int num2 = Convert.ToInt32(q5Num2Input.Text);
            int num3 = Convert.ToInt32(q5Num3Input.Text);

            int max = 0;

            if (num1 > max)
            {
                max = num1;
            }

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            q5Output.Text = $"The largest value is {max}";
        }
    }
}
