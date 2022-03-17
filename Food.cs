using System;
//question-- Create a class Food with food name & price. create a list of foods available
//& display using foreach

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
            return "name of the food is " + fName + "\nfood price is " + fprice; 
        }
    }
}
