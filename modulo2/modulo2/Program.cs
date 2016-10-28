using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo2
{
    class Program
    {
        static void Main(string[] args)// hi
        {



            Gradebook book = new Gradebook();

            book.addGrade(91);
            book.addGrade(89.5f);
            book.addGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

        }
    }
    
}
