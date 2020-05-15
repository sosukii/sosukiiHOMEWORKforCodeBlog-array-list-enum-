using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace sosukiiHOMEWORKforCodeBlog_array_list_enum_
{
    class Program
    {
        enum step
        {
            stepOne,
            stepTwo,
            stepThree,
            stepFor,
            stepFive
        }
        
        static void Main(string[] args)
        {
            /* Array. */
            int[] array = new int[5] { 100, 200, 300, 400, 500 };
            foreach (int n in array)
                Console.WriteLine(n);
            Console.WriteLine(array.Length + " - linght array numbers");

            /* List. */
            List<int> num = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int a in num)
                Console.WriteLine(a);
            Console.WriteLine(num.Count + " - lenght list numbers");

            /* Enum. */

            
      

        


              //Console.WriteLine("im a little star for u");
        } 
    }
}
