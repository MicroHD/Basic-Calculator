using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        private void Btn0_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + 0;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + 1;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + 2;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + 3;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + 4;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + 5;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + 6;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + 7;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + 8;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(UserInputBox.Text);
            UserInputBox.Clear();
            UserInputBox.Focus();
            count = 2;

        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (UserInputBox.Text != "")
            {
                num1 = float.Parse(UserInputBox.Text);
                UserInputBox.Clear();
                UserInputBox.Focus();
                count = 1;
            }
        }

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(UserInputBox.Text);
            UserInputBox.Clear();
            UserInputBox.Focus();
            count = 3;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(UserInputBox.Text);
            UserInputBox.Clear();
            UserInputBox.Focus();
            count = 4;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(UserInputBox.Text);
                    UserInputBox.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(UserInputBox.Text);
                    UserInputBox.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(UserInputBox.Text);
                    UserInputBox.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(UserInputBox.Text);
                    UserInputBox.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            UserInputBox.Clear();
            count = 0;
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {

        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + 9;
        }
    }
}
