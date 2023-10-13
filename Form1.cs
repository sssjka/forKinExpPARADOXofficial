using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Calc : Form
    {
        double result = 0;
        double num = 0;
        char sign;
        bool buttonsIsAdded = false;

        public Calc()
        {
            InitializeComponent();
            this.MaximumSize = new Size(262, 406);
            this.MinimumSize = new Size(262, 406);
            this.Width = 262;
            addedButtonsPanel.Hide();
            var nums = new List<double>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!buttonsIsAdded)
            {
                this.MaximumSize = new Size(374, 406);
                this.MinimumSize = new Size(374, 406);
                this.Width = 374;
                screen.Location = new Point(125, 9);
                screen.Size = new Size(225, 49);
                addedButtonsPanel.Show();
                buttonsIsAdded = true;
                addButton.Text = "Del";
            }
            else
            {
                this.MaximumSize = new Size(262, 406);
                this.MinimumSize = new Size(262, 406);
                this.Width = 262;
                screen.Location = new Point(67, 9);
                screen.Size = new Size(163, 49);
                addedButtonsPanel.Hide();
                buttonsIsAdded = false;
                addButton.Text = "Add";
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            memoryScreen.Text = "";
            result = 0;
            num = 0;
            devideButton.BackColor = Color.SandyBrown;
            additionButton.BackColor = Color.SandyBrown;
            subtructionButton.BackColor = Color.SandyBrown;
            multiplyButton.BackColor = Color.SandyBrown;
        }

        private void changeSignButton_Click(object sender, EventArgs e)
        {
            screen.Text = Convert.ToString(Convert.ToDouble(screen.Text) * (-1));
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(screen.Text);
            memoryScreen.Text = "";
            devideButton.BackColor = Color.SandyBrown;
            additionButton.BackColor = Color.SandyBrown;
            subtructionButton.BackColor = Color.SandyBrown;
            multiplyButton.BackColor = Color.SandyBrown;
            Count();
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(screen.Text);
            sign = '/';
            memoryScreen.Text += screen.Text + " " + devideButton.Text + " ";
            devideButton.BackColor = Color.DarkOrange;
            screen.Text = "0";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (result == 0)
            {
                num = Convert.ToDouble(screen.Text);
                result += num;
                sign = '*';
                memoryScreen.Text += screen.Text + " " + multiplyButton.Text + " ";
                multiplyButton.BackColor = Color.DarkOrange;
                screen.Text = "0";
            }
            else
            {
                num = Convert.ToDouble(screen.Text);
                result *= num;
                num = 0;
                memoryScreen.Text += screen.Text + " " + multiplyButton.Text + " ";
                multiplyButton.BackColor = Color.DarkOrange;
                screen.Text = "0";
            }
        }

        private void subtructionButton_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(screen.Text);
            sign = '-';
            memoryScreen.Text += screen.Text + " " + subtructionButton.Text + " ";
            subtructionButton.BackColor = Color.DarkOrange;
            screen.Text = "0";
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(screen.Text);
            sign = '+';
            memoryScreen.Text += screen.Text + " " + additionButton.Text + " ";
            additionButton.BackColor = Color.DarkOrange;
            screen.Text = "0";
        }

        private void Count()
        {
            if (sign == '/')
                screen.Text = Convert.ToString(result / num);
            if (sign == '*')
                screen.Text = Convert.ToString(result * num);
            if (sign == '+')
                screen.Text = Convert.ToString(result + num);
            if (sign == '-')
                screen.Text = Convert.ToString(result - num);
        }

            private void numButton_Click(string text)
        {
            if (screen.Text != "0")
                screen.Text += text;
            else
                screen.Text = text;
        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            if (screen.Text[screen.Text.Length - 1] != ',')
                screen.Text += commaButton.Text;
        }

//-------------------------------------------------------------------------------------------------------

        private void numNineButton_Click(object sender, EventArgs e)
        {
            numButton_Click(numNineButton.Text);
        }

        private void numEightButton_Click(object sender, EventArgs e)
        {
            numButton_Click(numEightButton.Text);
        }

        private void numSevenButton_Click(object sender, EventArgs e)
        {
            numButton_Click(numSevenButton.Text);
        }

        private void numSixButton_Click(object sender, EventArgs e)
        {
            numButton_Click(numSixButton.Text);
        }

        private void numFiveButton_Click(object sender, EventArgs e)
        {
            numButton_Click(numFiveButton.Text);
        }

        private void numFourButton_Click(object sender, EventArgs e)
        {
            numButton_Click(numFourButton.Text);
        }

        private void numThreeButton_Click(object sender, EventArgs e)
        {
            numButton_Click(numThreeButton.Text);
        }

        private void numTwoButton_Click(object sender, EventArgs e)
        {
            numButton_Click(numTwoButton.Text);
        }

        private void numOneButton_Click(object sender, EventArgs e)
        {
            numButton_Click(numOneButton.Text);
        }

        private void numZeroButton_Click(object sender, EventArgs e)
        {
            numButton_Click(numZeroButton.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
