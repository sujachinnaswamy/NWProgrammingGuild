using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name here:");
            string name = Console.ReadLine() ;
            Console.WriteLine("Hello " + name +"!");
        }
    }
}
