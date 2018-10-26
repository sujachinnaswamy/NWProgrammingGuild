using System;

namespace Triangle
{
    class Program
    {
        static void Main()
        {            
            for (int i = 0; i< 5; i++)
            {
               Console.WriteLine(new string('*', (i < 5) ? i:5));
            }
        }
    }
}
