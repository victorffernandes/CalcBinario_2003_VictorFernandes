using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcBinario_2003_VictorFernandes
{
    public class Binary
    {

        public double onDecimal;
        public string onBinary;

        

        public Binary (string b)
        {
            convertToDecimal(reverseString(b), 0);
            convertToBinary(this.onDecimal);
        }

        public static string reverseString(string Word)
        {
            char[] arrChar = Word.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);

            return invertida;
        }

        public double convertToDecimal(string s,int index)
        {
            if (index > s.Length - 1)
                return 0;
            else
            {
                convertToDecimal(s, index + 1);
                this.onDecimal += int.Parse(s.ElementAt(index).ToString()) * (Math.Pow(2, index));
                return 0;
            }
        }

        public string convertToBinary(double b)
        {
            double rest = b % 2;
            double result = (b - rest) / 2;
            
            if (b == 1)
            {
                this.onBinary += rest.ToString();
                return "";
            }
            else
            {
                string z = convertToBinary(result);
                this.onBinary += rest.ToString();
                return z;
            }
        }

    }
}
