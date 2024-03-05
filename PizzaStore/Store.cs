using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    public class Store
    {
        #region Instance Field
        #endregion

        #region Constructor
        #endregion

        #region Properties
        #endregion

        #region Methods        
        public static void start()
        {
            Pizza pizza1 = new Pizza("Magerita", 95);
            Pizza pizza2 = new Pizza("Calzone", 80);
            Pizza pizza3 = new Pizza("Quatro Stragioni", 85);

            Customer customer1 = new Customer("Jens", "12345678");
            Customer customer2 = new Customer("Peter", "87654321");
            Customer customer3 = new Customer("Søren", "56781234");

            Order order1 = new Order("#123", pizza1, customer1);
            Order order2 = new Order("#321", pizza2, customer2);
            Order order3 = new Order("#231", pizza3, customer3);

            Console.WriteLine(order1 + "\n");        
            Console.WriteLine(order2 + "\n");
            Console.WriteLine(order3);            
    }
        
        #endregion
    }
}
