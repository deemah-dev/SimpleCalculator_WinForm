using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorProjectWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LblAns.Text = "";
            LblShow.Text = "";
        }

        enum Operation
        {
            Add = 1, Sub = 2, Mul = 3, Dev = 4
        }
        Operation operation;

        private double Ans;
        double FirstNumber, SecondNumber;

        private void CalculateAns()
        {
            switch (operation)
            {
                case Operation.Add:
                    Ans = FirstNumber + SecondNumber;
                    break;
                case Operation.Sub:
                    Ans = FirstNumber - SecondNumber;
                    break;
                case Operation.Mul:
                    Ans = FirstNumber * SecondNumber;
                    break;
                case Operation.Dev:
                    Ans = FirstNumber / SecondNumber;
                    break;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LblAns.Text = "";
            LblShow.Text = "";
        }

        private void ClickButton(Button button)
        {
            if (button == BtnDot && LblAns.Text.Contains("."))
                return;
            if (button == BtnDot && LblAns.Text == "")
            {
                LblAns.Text += "0.";
                LblShow.Text += "0.";
            }
            else
            {
                LblAns.Text += button.Text;
                LblShow.Text += button.Text;
            }
            BtnDel.Enabled = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            ClickButton((Button)sender);
        }

        private void BtnOperation_Click(object sender, EventArgs e)
        {
            if(LblAns.Text  != "")
            {
                FirstNumber = Convert.ToDouble(LblAns.Text);
                LblAns.Text = "";
                BtnDel.Enabled = false;
                Button button = (Button)sender;
                char Symbol = Convert.ToChar(button.Tag);
                if(Symbol == '+')
                {
                    operation = Operation.Add;
                    LblShow.Text += " + ";
                }
                else if(Symbol == '-')
                {
                    operation = Operation.Sub;
                    LblShow.Text += " - ";
                }
                else if(Symbol == '*')
                {
                    operation = Operation.Mul;
                    LblShow.Text += " × ";
                }
                else if(Symbol == '/')
                {
                    operation = Operation.Dev;
                    LblShow.Text += " ÷ ";
                }
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if(LblShow.Text.Length > 0)
            {
                LblShow.Text = LblShow.Text.Substring(0, LblShow.Text.Length - 1);
                LblAns.Text = LblAns.Text.Substring(0, LblAns.Text.Length - 1);
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if(LblAns.Text != "")
            {
                SecondNumber = Convert.ToDouble(LblAns.Text);
                if (!LblShow.Text.Contains("="))
                {
                    LblShow.Text += " =";
                    LblAns.Text = "";
                    CalculateAns();
                    LblAns.Text += Ans.ToString();
                    BtnDel.Enabled = false;
                }
            }
        }
    }
}
