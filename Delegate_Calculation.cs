using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day4_Assignments
{
    public delegate int MyDelegate(int n1, int n2);
    public delegate string MyStringDelegate(string name1);
    public class Delegate_Calculation
    {
        public int Addition(int a,int b)
        {
            return a + b;
        }
        public string AcceptNames(string name1)
        {
            return name1;
            
        }
    }
}
