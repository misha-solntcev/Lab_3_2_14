using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*14. Напечатать в возрастающем порядке все трехзначные числа, 
    в десятичной записи которых нет одинаковых цифр. 
    Операции деления, целочисленного деления и определения 
    остатка не использовать.*/

namespace Lab_3_2_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 999; i++)
            {
                char[] digit = Convert.ToString(i).ToCharArray();                
                if ((digit[0] == digit[1]) || (digit[1] == digit[2]) || (digit[0] == digit[2]))
                    continue;
                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
