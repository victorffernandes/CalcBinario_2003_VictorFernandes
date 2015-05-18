using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcBinario_2003_VictorFernandes
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Pressed(object sender, KeyPressEventArgs e)
        {
            string valid = "01";
            e.Handled = (valid.IndexOf(e.KeyChar) == -1);
            if (e.KeyChar.Equals((char)8))
            {
                e.Handled = false;
            }
        }

        private void ResultClick(object sender, EventArgs e)
        {
            switch(operation.Text)
            {
                case "+":
                    result.Text = Converter.binaryPlus(higher.Text, smaller.Text);
                    resultDec.Text = Converter.binaryToDecimal(result.Text).ToString();
                    resultHex.Text = Converter.binaryToHexadecimal(result.Text);
                    break;
                case "*":
                    result.Text = Converter.binaryMultiply(higher.Text, smaller.Text);
                    resultDec.Text = Converter.binaryToDecimal(result.Text).ToString();
                    resultHex.Text = Converter.binaryToHexadecimal(result.Text);
                    break;
                case "-":
                    if (higher.Text != smaller.Text && !(Converter.binaryIsGreater(higher.Text, smaller.Text))) alert.Text = "First TextBox need higher value than the second.";
                    else
                    {
                        result.Text = Converter.binarySubtraction(higher.Text, smaller.Text);
                        resultDec.Text = Converter.binaryToDecimal(result.Text).ToString();
                        resultHex.Text = Converter.binaryToHexadecimal(result.Text);
                    }
                    break;
                case "/":
                    if (higher.Text != smaller.Text && !(Converter.binaryIsGreater(higher.Text, smaller.Text))) alert.Text = "First TextBox need higher value than the second.";
                    else
                    { 
                        string[] r = Converter.binaryDivision(higher.Text,smaller.Text);
                        result.Text = r[0] + " + Rest:" + r[1];
                        resultDec.Text = Converter.binaryToDecimal(r[0]) + " + Rest:" + Converter.binaryToDecimal(r[1]);
                        resultHex.Text = Converter.binaryToHexadecimal(r[0]) + " + Rest:" + Converter.binaryToHexadecimal(r[1]);
                    }
                    break;
            }
        }

        private void firstTb(object sender, EventArgs e)
        {
            firstDec.Text = Converter.binaryToDecimal(higher.Text).ToString();
            firstHex.Text = Converter.binaryToHexadecimal(higher.Text);
        }

        private void secondTb(object sender, EventArgs e)
        {
            secondDec.Text = Converter.binaryToDecimal(smaller.Text).ToString();
            secondHex.Text = Converter.binaryToHexadecimal(smaller.Text);
        }

        private void decimalToBin(object sender, EventArgs e)
        {
            resultDecToBin.Text = Converter.decimalToBinary(double.Parse(decToBin.Text));
        }

        private void PressedDecimal(object sender, KeyPressEventArgs e)
        {
            string valid = "0123456789";
            e.Handled = (valid.IndexOf(e.KeyChar) == -1);
            if (e.KeyChar.Equals((char)8))
            {
                e.Handled = false;
            }
        }
    }
}
