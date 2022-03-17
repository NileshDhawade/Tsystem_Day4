using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day4_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Food> f1 = new List<Food>();

            Food fd = new Food("vadapav", 15.0);
            Food fd1 = new Food("samosa", 20.0);
            Food fd2 = new Food("dosa", 40.0);

            f1.Add(fd);
            f1.Add(fd1);
            f1.Add(fd2);

            foreach (Food item in f1)
            {
                Console.WriteLine(item);

            }
        }
    }
}
