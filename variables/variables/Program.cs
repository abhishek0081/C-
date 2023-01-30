using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Abhishek";
            int characterAge;
            characterAge = 20;

            Console.WriteLine("There once was a man named " +characterName);
            Console.WriteLine("He was "+characterAge+" years old");
            characterName = "Mike";
            characterAge = 53;
            Console.WriteLine("He really liked the mame " + characterName);
            Console.WriteLine("But he didn`t like to be "+characterAge+" years old");

            Console.ReadLine();
        }
    }
}
