using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaStoreUpdaated
{
    internal class Store
    {
        // Instance Fields
        #region Instance Fields

        #endregion
        // Constructor
        #region Constructor

        #endregion
        // Properties
        #region Properties


        #endregion
        // methods
        #region Methods
        public void Start()
        {
            //Create new objects - pizza
            Pizza p1 = new Pizza("Hawaii", "Deep pan", 89, 1);
            Pizza p2 = new Pizza("Pepperoni", "family", 119, 2);
            Pizza p3 = new Pizza("Margherita", "normal", 59, 3);

            Drinks d1 = new Drinks("Carlsberg", "alkohol", "330ml", 25, 1);
            Drinks d2 = new Drinks("Pepsi", "sodavand", "500ml", 28, 2);
            Drinks d3 = new Drinks("Kildevæld", "vand", "500ml", 25, 3);

            // Create new objects - Customer
            Customer c1 = new Customer("John Doe", "lykkevej 23", 1);
            Customer c2 = new Customer("Jane Doe", "trøffelvej 45", 2);
            Customer c3 = new Customer("Annita", "fjordbakken 21", 3);

            // Create new objects - order  
            Order o1 = new Order(p1, d1, c1);
            Order o2 = new Order(p2, d2, c2);
            Order o3 = new Order(p3, d3, c3);
        }
        #endregion
    }
}
