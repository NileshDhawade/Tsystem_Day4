using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day4_Assignments
{
    public  class Category
    {
        int id;
        string name;

        public Category()
        {
            id = 0;
            name = "";
        }
        public Category(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return "product catagory id is : " + id + "\nproduct category name is : " + name; 
        }
    }
}
