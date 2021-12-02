using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string resultString = "";
            string reversString = "";
            foreach (string s in stringArray)
            {
                resultString += s.Substring(0, 1).ToLower() + s.Substring(1) + ' ';
            }
            resultString = resultString.Replace(" ", string.Empty);
            for (int i = resultString.Length - 1; i >= 0; i--)
            {
                reversString += resultString[i];
            }
            if (resultString == reversString)
            {
                Console.WriteLine("Текст является полиндромом");
            }
            else
            {
                Console.WriteLine("Текст не является полиндромом");
            }
            Console.ReadKey();
        }
    }
}
