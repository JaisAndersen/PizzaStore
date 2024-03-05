using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {
        #region Instance Field
        string _name;
        string _phone;
        #endregion

        #region Constructor
        public Customer(string name, string phone)
        {
            _name = name;
            _phone = phone;
        }
        #endregion

        #region Properties
        public string Name
        { 
            get { return _name; }
        }

        public string Phone
        { 
            get { return _phone; }
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Kunde: {Name} - tlf.: {Phone}";
        }
        #endregion
    }
}
