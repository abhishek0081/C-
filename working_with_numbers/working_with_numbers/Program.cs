using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            num++;
            Console.WriteLine(num);
            ++num;
            Console.WriteLine(num++);
            Console.WriteLine(++num);
            Console.WriteLine(Math.Pow(9.56,1000));
            Console.ReadLine();
        }
    }
}
