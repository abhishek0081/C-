using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_input
{
     class New
    {
        static void Main(string[] LetsFuckIt)
        {
            Console.Write("Enter Your Name :  ");
            string name = Console.ReadLine();
            Console.Write("Enter Your Age :  ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello  " + name +" Your age is " +age);

            Console.ReadLine();
        }
    }
}
