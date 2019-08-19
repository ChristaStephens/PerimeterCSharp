using System;

namespace Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Friend! Welcome to the Home Calculator!");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Thank you " + name + "!" + "\r\n");
            Console.WriteLine("Let's get to your room, what is the name of your room?");
            string room = Console.ReadLine();
            Console.WriteLine("Awesome " + name + "!"+" Let's get to measuring your " + room + ".");

        }
    }
}
