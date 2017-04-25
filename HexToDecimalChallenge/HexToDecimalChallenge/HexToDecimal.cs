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
                    Console.WriteLine(line);
                    i++;
                }
            }

            List<int> toBase10 = new List<int>();

            foreach (string hex in hexList)
            {
                Console.WriteLine("LIST WORKS " + hex);
                char[] charArray = hex.ToCharArray();
                
                Array.Reverse(charArray);
                Console.WriteLine(charArray[1]);
                i = 0;

                while (i < charArray.Length)
                {
                    Console.WriteLine(i);
                    char currentChar = charArray[i];
                    switch (currentChar)
                    {
                        case 'a':
                            Console.WriteLine("works " + 10);
                            break;
                        case 'b':
                            Console.WriteLine("works " + 11);
                            break;
                        case 'c':
                            Console.WriteLine("works " + 12);
                            break;
                        case 'd':
                            Console.WriteLine("works " + 13);
                            break;
                        case 'e':
                            Console.WriteLine("works " + 14);
                            break;
                        case 'f':
                            Console.WriteLine("works " + 15);
                            break;
                        default:
                            Console.WriteLine("NUMBER");
                            break;
                    }

                    i++;
                }

            }

            Console.ReadKey();
        }

    }
}

