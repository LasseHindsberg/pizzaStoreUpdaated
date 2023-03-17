using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaStoreUpdaated
{
    internal class Customer
    {
        // Instance Fields
        #region Instance Fields
        string _Name;
        string _Address;
        int _CustomerID;

        #endregion

        // Constructor
        #region Constructor
        public Customer(string Name, string Address, int CustomerID)
        {
            _Name = Name;
            _Address = Address;
            _CustomerID = CustomerID;
        }
        #endregion

        // Properties
        #region Properties

        public string Name
        {
            get { return _Name; }
        }
        public string Address
        {
            get { return _Address; }
        }

        public int CustomerID
        {
            get { return _CustomerID; }
        }
        #endregion

        // methods
        #region Methods
        public override string ToString()
        {
            return $"{Name} {Address} {CustomerID}";
        }
    }
    #endregion
}
