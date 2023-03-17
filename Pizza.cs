using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaStoreUpdaated
{
    internal class Pizza
    {
        // Instance Fields
        #region Instance Fields
        private string _Name;
        private string _Type;

        private int _Price;
        private int _PizzaID;


        #endregion
        // Constructor
        #region Constructor
        public Pizza(string Name, string Type, int Price, int PizzaID)
        {
            _Name = Name;
            _Type = Type;
            _Price = Price;
            _PizzaID = PizzaID;
        }
        #endregion
        // Properties
        #region Properties

        public string Name { get { return _Name; } }
        public string Type
        {
            get
            {
                return _Type;
            }
        }

        public int Price
        {
            get
            {
                return _Price;
            }
        }

        public int PizzaID
        {
            get
            {
                return _PizzaID;
            }
        }


        #endregion
        // methods
        #region Methods
        public override string ToString()
        {
            return $"{Name} {Type} {Price} {PizzaID}";
        }
        #endregion
    }
}
