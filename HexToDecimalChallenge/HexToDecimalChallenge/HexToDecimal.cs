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

            //using (var writer = File.CreateText("hex.csv"))
            //{
            //    writer.WriteLine("9f");
            //    writer.WriteLine("11");
            //    writer.WriteLine("fe54");
            //    writer.WriteLine("4286f4");
            //    writer.WriteLine("42f4");
            //}

            //using (var fs = File.OpenRead("hex.csv"))
            //using (var reader = new StreamReader(fs))
            //{
            //    List<string> hexList = new List<string>();

            //    int i = 0;

            //    while (!reader.EndOfStream)
            //    {

            //        var line = reader.ReadLine();
            //        var values = line.Split(';');

            //        hexList.Add(values[i]);

            //        Console.WriteLine(hexList[i]);

            //        i++;
            //    }
            //}

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
            using (StreamReader sr = new StreamReader("hex.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.ReadKey();
        }

    }
}

