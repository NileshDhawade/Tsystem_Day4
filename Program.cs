using System;
using System.Collections;
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
            Console.WriteLine("========category class implementation=========");

            ArrayList list = new ArrayList();

            Category c = new Category(111, "Veg_Food_Category");
            Category c1 = new Category(222, "NonVeg_Food_Category");

            list.Add(c);
            list.Add(c1);

            foreach (Category item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========Employee class implementation=========");

            

            Employee e1 = new Employee(111, "nilesh", 35000);
            Employee e2 = new Employee(222, "ganesh", 40000);
            Employee e3 = new Employee(333, "rahul", 43000);
            Employee e4 = new Employee(444, "geeta", 44000);

            Employee[] emp = new Employee[] {e1,e2,e3,e4};

            foreach (Employee item in emp)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("========Product class with auto implemened property implementation========");

            List<Product> pList = new List<Product>();

            Product p1 = new Product();
            p1.PId = 111;
            p1.PName = "milk product";

            Product p2 = new Product();
            p2.PId = 222;
            p2.PName = "veg products";

            Product p3 = new Product();
            p3.PId = 333;
            p3.PName = "non veg product";

            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

            foreach (Product item1 in pList)
            {
                Console.WriteLine(item1.PId+"\n"+item1.PName);

            }
            Console.WriteLine("========Student class with auto implemened property implementation========");

            List<Student> sList = new List<Student>();

            //intializing by using object initializer
            Student s1 = new Student { SId = 444, SName = "Nlesh" };
            


            Student s2 = new Student { SId = 555, SName = "Vikrant" };



            Student s3 = new Student { SId = 777, SName = "pravin" };

            sList.Add(s1);
            sList.Add(s2);
            sList.Add(s3);

            foreach (Student item2 in sList)
            {
                Console.WriteLine(item2.SId+"\n"+item2.SName);

            }














        }
    }
}
