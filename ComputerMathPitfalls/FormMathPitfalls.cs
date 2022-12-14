using System;
using System.Windows.Forms;

namespace ComputerMathPitfalls
{
    public partial class FormMathPitfalls : Form
    {
        public FormMathPitfalls()
        {
            InitializeComponent();
        }

        private void BtnProblem1_Click(object sender, EventArgs e)
        {
            double x = -10;
            double numerator;
            double denumerator;
            double y; 

            while (x < 10)
            {
                
                numerator = Math.Pow(x, 3) - 4 * Math.Pow(x, 2);
                denumerator = Math.Pow(x, 2) - 7 * x + 12;

                if (Math.Abs(denumerator) <= 0.00001)
                {
                    TxtResult.Text += "x = " + x.ToString("n2") + ", y is undefined - can't divide by 0" + Environment.NewLine;
                }
                else
                {
                    y = numerator / denumerator;
                    TxtResult.Text += "x = " + x.ToString("n2") + ", y = " + y.ToString("n2") + Environment.NewLine;
                }

                x += 0.1;
            }

        }

        private void BtnProblem2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter side 'a'", "Side 'a'"));
            double b = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter side 'b'", "Side 'b'"));
            double c = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter side 'c'", "Side 'c'"));

            if (Math.Abs(Math.Pow(c, 2) - Math.Pow(a, 2) - Math.Pow(b, 2)) <= 0.00001)
            {
                TxtResult.Text = "The triangle is right angled.";
            }
            else
            {
                TxtResult.Text = "The triangle is not right angled.";
            }
        }

        private void BtnProblem3_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter point 'x1'", "Point 'x1'"));
            double y1 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter point 'y1'", "Point 'y1'"));
            double x2 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter point 'x2'", "Point 'x2'"));
            double y2 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter point 'y2'", "Point 'y2'"));
            double x3 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter point 'x3'", "Point 'x3'"));
            double y3 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter point 'y3'", "Point 'y3'"));

            if (Math.Abs(((x2 - x1) / (y2 - y1)) - ((x3 - x1) / (y3 - y1))) <= 0.00001)
            {
                TxtResult.Text = "The points are collinear.";
            }
            else
            {
                TxtResult.Text = "The points are not collinear.";
            }
        }

        private void BtnProblem4_Click(object sender, EventArgs e)
        {

            //Sqrt of 9 is 3,
            //but sqrt of 10 is not 3, it's 3.1622...
            //If we subtract the sqrt of the number with the int of the number, if it's a perfect sqrt it should be = 0.
            //So sqrt of 9 is 3, - 3 is 0,
            //and sqrt of 10 is 3.1622, - 3 is not 0.
            for (double i = 1; i <= 1000; i++)
            {
                if (Math.Abs(Math.Sqrt(i) - (int)Math.Sqrt(i)) <= 0.00001)
                {
                    TxtResult.Text += i + " is a perfect square." + Environment.NewLine;
                }
                else
                {
                    TxtResult.Text += i + Environment.NewLine;
                }
            }
        }
    }
}
