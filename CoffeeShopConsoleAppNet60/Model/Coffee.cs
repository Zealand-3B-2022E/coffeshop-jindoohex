using CoffeeShopConsoleAppNet60.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.Model
{
    public abstract class Coffee
    {
        #region Instance Fields
        private int _price;         // The likely hood of this being used is minimal
        private string? _strength;  // --------------      ||      -----------------
        #endregion

        #region Properties
        protected int Discount { get; private set; }
        protected List<Coffee> theCoffeeList => MockData.CoffeeList();
        #endregion

        #region Constructors
        public Coffee()             // Default
            :this(0)
        {

        }
        public Coffee(int discount)
        {
            if (discount > 5)
            {
                throw new ArgumentException("The discount value exceeds acceptable limitation.");
            }
            if (discount < 1)
            {
                throw new ArgumentException("Discount value needs to be within range: 1-5");
            }
            this.Discount = discount;
        }
        #endregion

        #region Methods
        public virtual int CoffeePrice()
        {
            return 20 - Discount;
        }
        public abstract string Strength();      // informs the strength of the coffee object

        public abstract string CoffeeType();    // informs what type of coffee the object is

        public override string ToString()       // prints a formatted string out with the information of the object
        {
            return $"Item: \t\t{this.CoffeeType()}\nStrength: \t{this.Strength()}\nPrice: \t\t{this.CoffeePrice()},-";
        }
        #endregion
    }
}
