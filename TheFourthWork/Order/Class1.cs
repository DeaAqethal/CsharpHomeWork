using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Order
    {
        public int OrderNumber;
        public string OrderName;
        public string OrderCustomer;
        void SetOrderNumber(ref Order order,ref int a)
        {
            order.OrderNumber = a;
        }
        void SetOrderName(ref Order order, ref string name)
        {
            order.OrderName = name;
        }
        void SetOrderCustomer(ref Order order, ref string customer)
        {
            order.OrderCustomer = customer;
        }
    }
    class OrderSet : Order
    {
        int length = 0;
        Order []order;
        void Order(Order order,int number, string name, string customer)
        {
            order.OrderNumber = number;
            order.OrderName = name;
            order.OrderCustomer = customer;
        }
        
        void AddOrder(OrderSet orderset,Order order)
        {
            length++;
            orderset.order[length-1] = order;
        }
        void DelOrder(OrderSet orderset, int n)
        {
            if (n < length)
            {
                orderset.order[length - 1].OrderNumber = 0;
                orderset.order[length - 1].OrderName = null;
                orderset.order[length - 1].OrderCustomer = null;           
            }
            else Console.WriteLine("There is something wrong about your input");

        }
        Order SelectByNumber(OrderSet orderset,int number)
        {
            for(int i = 0; i < orderset.length; i++)
            {
                if (orderset.order[i].OrderNumber == number)
                {
                    return orderset.order[i];
                }           
            }
            return orderset.order[0];
        }
        Order SelectByName(OrderSet orderset, string name)
        {
            for (int i = 0; i < orderset.length; i++)
            {
                if (orderset.order[i].OrderName == name)
                {
                    return orderset.order[i];
                }
            }
            return orderset.order[0];
        }
        Order SelectByCust(OrderSet orderset, string cust)
        {
            for (int i = 0; i < orderset.length; i++)
            {
                if (orderset.order[i].OrderCustomer == cust)
                {
                    return orderset.order[i];
                }
            }
            return orderset.order[0];
        }
    }
  
}
