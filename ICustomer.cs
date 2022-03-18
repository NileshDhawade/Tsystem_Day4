using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day4_Assignments
{
    public  interface ICustomer
    {
        string DisplayDetails();
    }
    public interface IOrder
    {
        string DisplayDetails();
    }
    public class Transaction : ICustomer, IOrder
    {
        string ICustomer.DisplayDetails()
        {
            return "customer details";
        }

        string IOrder.DisplayDetails()
        {
            return "order details";
        }
    }
}
