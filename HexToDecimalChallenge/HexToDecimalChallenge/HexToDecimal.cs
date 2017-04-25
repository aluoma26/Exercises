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

            // Read and show each line from the file.
            string line = "";
            int i = 0;
            List<string> hexList = new List<string>();
            using (StreamReader sr = new StreamReader("hex.txt"))
            {
                

                while ((line = sr.ReadLine()) != null)
                {
                    hexList.Insert(i, line);
                    //Console.WriteLine(line);
                    i++;
                }
            }

            List<int> toBase10 = new List<int>();

            foreach (string hex in hexList)
            {
                Console.WriteLine("Hexidecimal| " + hex);
                char[] charArray = hex.ToCharArray();
                
                Array.Reverse(charArray);
                //Console.WriteLine(charArray[1]);

                i = 0;
                int hexTotal = 0;

                while (i < charArray.Length)
                {
                    //Console.WriteLine(i);
                    char currentChar = charArray[i];
                    switch (currentChar)
                    {
                        case 'a':
                            //Console.WriteLine("works " + 10);
                            int aValue = 10;
                            int aResult = calculateExponent(i, aValue);
                            hexTotal += aResult;
                            break;
                        case 'b':
                            //Console.WriteLine("works " + 11);
                            int bValue = 11;
                            int bResult = calculateExponent(i, bValue);
                            hexTotal += bResult;
                            break;
                        case 'c':
                            //Console.WriteLine("works " + 12);
                            int cValue = 12;
                            int cResult = calculateExponent(i, cValue);
                            hexTotal += cResult;
                            break;
                        case 'd':
                            //Console.WriteLine("works " + 13);
                            int dValue = 13;
                            int dResult = calculateExponent(i, dValue);
                            hexTotal += dResult;
                            break;
                        case 'e':
                            //Console.WriteLine("works " + 14);
                            int eValue = 14;
                            int eResult = calculateExponent(i, eValue);
                            hexTotal += eResult;
                            break;
                        case 'f':
                            //Console.WriteLine("works " + 15);
                            int fValue = 15;
                            int fResult = calculateExponent(i, fValue);
                            hexTotal += fResult;
                            break;
                        default:
                            //Console.WriteLine("NUMBER");
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

