using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HexToDecimalChallenge
{
    public class HexToDecimal
    {

        static void Main(string[] args)
        {

            string[] names = new string[] { "9f", "11", "fe54", "4286f4", "42f4"};
            using (StreamWriter sw = new StreamWriter("hex.txt"))
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

            string line = "";
            int i = 0;
            List<string> hexList = new List<string>();
            using (StreamReader sr = new StreamReader("hex.txt"))
            {
                

                while ((line = sr.ReadLine()) != null)
                {
                    hexList.Insert(i, line);
                    
                    i++;
                }
            }

            List<int> toBase10 = new List<int>();

            foreach (string hex in hexList)
            {
                Console.WriteLine("Hexidecimal| " + hex);
                char[] charArray = hex.ToCharArray();
                
                Array.Reverse(charArray);
                

                i = 0;
                int hexTotal = 0;

                while (i < charArray.Length)
                {
                    
                    char currentChar = charArray[i];
                    switch (currentChar)
                    {
                        case 'a':
                            
                            int aValue = 10;
                            int aResult = calculateExponent(i, aValue);
                            hexTotal += aResult;
                            break;
                        case 'b':
                            
                            int bValue = 11;
                            int bResult = calculateExponent(i, bValue);
                            hexTotal += bResult;
                            break;
                        case 'c':
                            
                            int cValue = 12;
                            int cResult = calculateExponent(i, cValue);
                            hexTotal += cResult;
                            break;
                        case 'd':
                            
                            int dValue = 13;
                            int dResult = calculateExponent(i, dValue);
                            hexTotal += dResult;
                            break;
                        case 'e':
                            
                            int eValue = 14;
                            int eResult = calculateExponent(i, eValue);
                            hexTotal += eResult;
                            break;
                        case 'f':
                            
                            int fValue = 15;
                            int fResult = calculateExponent(i, fValue);
                            hexTotal += fResult;
                            break;
                        default:
                            
                            int charValue = int.Parse(currentChar.ToString());
                            int charResult = calculateExponent(i, charValue);
                            hexTotal += charResult;
                            break;
                    }

                    i++;
                }
                Console.WriteLine("Base 10 Conversion| " + hexTotal + "\n");
            }

            Console.ReadKey();
        }

        static int calculateExponent(int i, int charValue)
        {
            if (i == 0)
            {
                return charValue;
            }
            else if (i == 1)
            {
                return charValue * 16;
            }
            else
            {
                int placeHolder = (int)Math.Pow(16, i);
                return charValue * placeHolder;
            }
        }
    }
}

