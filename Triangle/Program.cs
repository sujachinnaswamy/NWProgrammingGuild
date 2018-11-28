using System;

namespace Triangle
{
    class Program
    {
        static void Main()
        {   
            Console.WriteLine("Enter the max number of *s "); 
            int star = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i<= star; i++)
            {
               Console.WriteLine(new string('*', (i < star) ? i:star));
                           
            }
        }
    }
}
