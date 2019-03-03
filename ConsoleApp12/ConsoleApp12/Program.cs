using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Camp camping1 = new Camp(500, 400, 4, 30, 35);
            Camp camping2 = new Camp(600, 300, 8, 14, 65);

            if (camping1 > camping2)
                Console.WriteLine("camping1 is bigger");
            else
                Console.WriteLine("camping2 is bigger");
            
            if (camping1.NumberOfPoeple == camping2.NumberOfPoeple)
            {
                Console.WriteLine("the size of both campings is same");
            }
            

            Camp camping3 = camping1 + camping2;
            Console.WriteLine($"the value of camping3 is : {camping3}");

           

           

            
        }
    }
}
