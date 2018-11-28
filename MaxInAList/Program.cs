using System;
using System.Linq;
using System.Collections.Generic;

namespace Search
{
    class Program
    {
        static void Main()
        {            
            int[] arrayofNumbers= new int[100];
            int i, arraysize;
            
            Console.Write("Input the number of elements to be stored in the array :");
	        arraysize= Convert.ToInt32(Console.ReadLine());  
   	
            Console.Write("Input {0} elements in the array :\n",arraysize);
            for(i=0;i<arraysize;i++)
            {
	          Console.Write("element {0} : ",i);
		      arrayofNumbers[i] = Convert.ToInt32(Console.ReadLine());
	        }
            int max = arrayofNumbers.Max();
            
            Console.Write($"Largest number in the array is {max}");          
            
        }
    }
}
