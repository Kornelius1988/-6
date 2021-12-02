using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тест
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "hello world";
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
