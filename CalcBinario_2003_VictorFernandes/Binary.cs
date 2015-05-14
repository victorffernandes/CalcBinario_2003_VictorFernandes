using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcBinario_2003_VictorFernandes
{
    public class Converter
    {
        public static string binaryPlus(string ele1, string ele2)
        {
            char[] e1 = ele1.ToCharArray();
            char[] e2 = ele2.ToCharArray();
            Array.Reverse(e1);
            Array.Reverse(e2);
            string result = "";
            string overflow = "";


            for(int i = 0;i < Math.Max(e1.Length,e2.Length) ;i++)
            {
                if ((e1.Length  <= i) || (e2.Length  <= i))
                {
                    if ((e1.Length < i) && (e1.Length < e2.Length)) { result += e2[i];  }

                    if ((e2.Length < i) && (e2.Length < e1.Length)) { result += e1[i];  }
                }
                else if(string.IsNullOrWhiteSpace(overflow))
                {
                     if (e1[i].Equals('0') && e2[i].Equals('0')) result += "0";
                     if (e1[i].Equals('0') && e2[i].Equals('1')) result += "1";
                     if (e1[i].Equals('1') && e2[i].Equals('0')) result += "1";
                     if (e1[i].Equals('1') && e2[i].Equals('1'))
                     {
                         result += "0";
                         overflow = "1";
                     }
                }
                else
                {
                    result += "1";
                    overflow = "";
                }
            }
            result += overflow;
            Console.WriteLine(e1.ToString());
            return reverseString(result);

        }






        static string reverseString(string Word)
        {
            char[] arrChar = Word.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);

            return invertida;
        }
        
        static string hexLetters(string str)
        {
            Console.WriteLine(str);
            switch(str)
            {
                case "10":
                    return "A";
                    break;

                case "11": return "B"; break;
                case "12": return "C"; break;
                case "13": return "D"; break;
                case "14": return "E"; break;
                case "15": return "F"; break;
                default: return str;
            }
            
        }

        public static string binaryToHexadecimal(string str)
        {
            double r = Converter.binaryToDecimal(str);

            return Converter.decimalToHexadecimal(r);
        }


        public static string decimalToHexadecimal(double b)
        {
            double rest = b % 16;
            double result = (b - rest) / 16;

            if (b == 0)
            {
               // return hexChanger(rest.ToString());
                return "";
            }
            else
            {
                return decimalToHexadecimal(result) + hexLetters(rest.ToString());
            }
        }

        public static double binaryToDecimal(string s,int index = 0)
        {
            if (index == 0) s = reverseString(s);

            if (index > s.Length - 1)
                return 0;
            else
            {
                return binaryToDecimal(s, index + 1) + int.Parse(s.ElementAt(index).ToString()) * (Math.Pow(2, index));
            }
        }

        public static string decimalToBinary(double b)
        {
            double rest = b % 2;
            double result = (b - rest) / 2;
            
            if (b == 1)
            {
                return rest.ToString();
            }
            else
            {
                return decimalToBinary(result) + rest.ToString();
            }
        }

    }
}
