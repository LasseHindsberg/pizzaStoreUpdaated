using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaStoreUpdaated
{
    internal class Drinks
    {
        // Instance Fields
        #region Instance Fields
        private string _Name;
        private string _Type;
        private string _Size;

        private int _DrinkID;
        private int _Price;

        #endregion
        // Constructor
        #region Constructor
        public Drinks(string Name, string Type, string Size, int Price, int DrinkID)
        {
            _Name = Name;
            _Type = Type;
            _Size = Size;
            _Price = Price;
            _DrinkID = DrinkID;

        }
        #endregion
        // Properties
        #region Properties
        public string Name
        {
            get { return _Name; }
        }

        public string Type
        {
            get { return _Type; }
        }

        public string Size
        {
            get { return _Size; }
        }

        public int DrinkID
        {
            get { return _DrinkID; }
        }

        public int Price
        {
            get { return _Price; }
        }

        #endregion
        // methods
        #region Methods
        public override string ToString()
        {
            return $"{Name} {Type} {Size} {DrinkID} {Price} ";
        }
    }
    #endregion
}
