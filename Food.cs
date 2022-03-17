using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day4_Assignments
{
    public class Food
    {
        string fName;
        double fprice;

        public Food()
        {
            fName = "";
            fprice = 0.0;
        }
        public Food(string fname,double fprice)
        {
            this.fName = fname;
            this.fprice = fprice;
        }
        public override string ToString()
        {
            return "name of the food is " + fName + " food price is " + fprice; 
        }
    }
}
