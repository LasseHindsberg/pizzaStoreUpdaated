using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaStoreUpdaated
{
    internal class Order
    {
        // Instance Fields
        #region Instance Fields
        private Pizza _Pizza;
        private Customer _Customer;
        private Drinks _Drinks;

        #endregion
        // Constructor
        #region Constructor
        public Order(Pizza pizza, Drinks drinks, Customer customer)
        {
            _Pizza = pizza;
            _Drinks = drinks;
            _Customer = customer;
        }

        #endregion
        // Properties
        #region Properties
        public Pizza Pizza
        {
            get
            {
                return _Pizza;
            }
        }
        public Drinks Drinks
        {
            get
            {
                return _Drinks;
            }
        }
        public Customer Customer
        {
            get
            {
                return _Customer;
            }
        }
        #endregion
        // methods
        #region Methods
        public override string ToString()
        {
            return $"{Pizza.Name} & {Drinks.Name} has been ordered by {Customer.Name}   ";
        }

        public double CalculateTotalPrice()
        {
            return (Pizza.Price + Drinks.Price) * 1.25 + 40;
        }
    }
    #endregion
}

