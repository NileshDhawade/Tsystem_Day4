using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day4_Assignments
{
    public class NameException : Exception
    {

        public NameException(string msg):base(msg)
        {

        }
    }
    public class User
    {
        public string acceptName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new NameException("this user has no name");
            }
            return name;
        }
    }
}
