using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;

namespace VSfirst
{
    public class Program
    {

        static void Main(string[] args)
        {

            using (var writer = File.CreateText("some.csv"))
            {
                writer.WriteLine("year, profit");
                writer.WriteLine("2015, $20");
                writer.WriteLine("2016, $200");
                writer.WriteLine("2017, $20000000");
            }
        }



        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
    
}
