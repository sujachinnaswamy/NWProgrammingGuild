using System;
using System.Linq;
using System.Collections.Generic;

namespace Search
{
    class Program
    {
        static void Main()
        {            
            List<int> listOfNumbers = new List<int>();
            int i, listsize;
            
            Console.Write("Input the number of elements to be stored in the list :");
	        listsize= Convert.ToInt32(Console.ReadLine());  
   	
            for(i=0;i<listsize;i++)
            {
	          Console.Write("Enter the number");
              listOfNumbers.Add(Convert.ToInt32(Console.ReadLine())); 
	        }
            int max = listOfNumbers.Max();
            
            Console.Write($"Largest number in the array is {max}");          
            
        }
    }
}
