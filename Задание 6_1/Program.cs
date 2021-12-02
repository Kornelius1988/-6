using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string stringMax = string.Empty;
            string[] words = startString.Split(' ');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > stringMax.Length)
                    stringMax = words[i];
            Console.WriteLine(stringMax);
            Console.ReadKey();
        }
    }
}
