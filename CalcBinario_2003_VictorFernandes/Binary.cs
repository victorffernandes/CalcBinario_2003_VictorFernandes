using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcBinario_2003_VictorFernandes
{
    public class Converter
    {

        public static string binaryMultiply(string str1 ,string str2)
        {
            string result = str2;
            for(int i = 0; i < binaryToDecimal(str1) - 1;i++)
            {
                result = binaryPlus(str2, result);

            }
            return result;
        }

        public static string binarySubtraction(string str1,string str2)
        {
            string e1 = normalizeString(str1, str2)[0];
            string e2 = normalizeString(str1, str2)[1];

            e2 = binaryPlus( substituteBinary(e2),"1");

            string result = binaryPlus(e1, e2);
            Console.WriteLine(result);
            result = result.Remove(0, 1);
            return result;
        }
        
        public static string substituteBinary(string str)
        {
            string result = str;
            result = result.Replace('1', 'b');
            result =  result.Replace('0', '1');
            result = result.Replace('b', '0');

            return result;
        }


        public static string[] normalizeString(string ele1, string ele2)
        {
            int estranha1 = ele1.Length;
            int estranha2 = ele2.Length;

            if (ele1.Length > ele2.Length)
            {
                for (int i = 0; i < (estranha1 - estranha2); i++)
                {
                    ele2 = "0" + ele2;
                }
            }
            else if (ele1.Length < ele2.Length)
            {
                for (int i = 0; i < (estranha2 - estranha1); i++)
                {
                    ele1 = "0" + ele1;
                }
            }
            string[] r = new string[] { ele1, ele2 };
            return r;
        }


        public static string binaryPlus(string ele1, string ele2)
        {
            char[] h = (normalizeString(ele1, ele2))[0].ToCharArray();
            char[] s = (normalizeString(ele1, ele2))[1].ToCharArray();
            string overflow = "";

            string result = "";
            for (int i = h.Length - 1; i >= 0; i--)
            {
                if (string.IsNullOrWhiteSpace(overflow))
                {
                    if (h[i].Equals('0') && s[i].Equals('0')) result = '0' + result;
                    if (h[i].Equals('0') && s[i].Equals('1')) result = '1' + result;
                    if (h[i].Equals('1') && s[i].Equals('0')) result = '1' + result;
                    if (h[i].Equals('1') && s[i].Equals('1'))
                    {
                        overflow = "1";
                        result = "0" + result;
                    }
                }
                else if ((h[i].Equals('1') && s[i].Equals('0')) || h[i].Equals('0') && s[i].Equals('1'))
                {
                    overflow = "1";
                    result = "0" + result;
                }
                else if ((h[i].Equals('0') && s[i].Equals('0')))
                {
                    overflow = "";
                    result = "1" + result;
                }
                else if (h[i].Equals('1') && s[i].Equals('1'))
                {
                    overflow = "1";
                    result = "1" + result;
                }
            }


            return overflow + result;
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
