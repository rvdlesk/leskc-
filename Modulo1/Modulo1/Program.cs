using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Name");
            String user = Console.ReadLine();


            Console.WriteLine("How mant of slee did you get last night");
            int HoursOfSleep =  int.Parse(Console.ReadLine());

            Console.WriteLine("hello, "  + user);

            if (HoursOfSleep > 8)
            {

                Console.WriteLine("you are well rested ");
            }
            else {
                Console.WriteLine("you need more sleep ");
            }
        }
    }
}
