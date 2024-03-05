using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    public class Order
    {
        #region Instance Field
        string _orderId;
        double taxPct = 1.25;
        double deliveryCosts = 40;
        Pizza _pizza;
        Customer _customer;
        
        #endregion

        #region Constructor
        public Order(string orderId, Pizza pizza, Customer customer)
        {
            _pizza = pizza;
            _orderId = orderId;
            _customer = customer;
        }
        #endregion

        #region Properties
        public string OrderID
        { 
            get { return _orderId; }
        }       
                  
        #endregion

        #region Methods
        public double CalculateTotalPrice()
        {         
            Double totalPrice = (_pizza.Price + deliveryCosts) * taxPct;
            return totalPrice;
        }

        public override string ToString()
        {
            return $"Order: {OrderID}\n" + _customer + "\n" + _pizza + $"\nTotal Pris: {CalculateTotalPrice()} incl. tax og deliveryfee.";
        }
        #endregion
    }
}
