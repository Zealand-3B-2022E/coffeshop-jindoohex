using CoffeeShopConsoleAppNet60.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.Service
{
    public class Order
    {
        #region Instance Fields
        private int _orderID;
        private int _tableID;
        private string _baristaOrder;
        private string _customerName;
        private bool _takeAway;
        #endregion

        #region Properties
        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }

        public int TableID
        {
            get { return _tableID; }
            set { _tableID = value; }
        }
        
        public string BaristaOrder 
        { 
            get { return _baristaOrder; }
            set
            {
                if (_baristaOrder != null)
                {
                    _baristaOrder = value;
                }
                else
                {
                    throw new ArgumentException($"INVALID");
                }
            }
        }

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        public bool TakeAway
        {
            get { return _takeAway; }
            set { _takeAway = value; }
        }

        public List<Coffee> CoffeeOrders { get; set; }
        #endregion

        #region Constructors
        public Order()
        {

        }

        public Order(int orderID, int tableID, string baristaOrder, string customerName, bool takeAway, List<Coffee> coffeeOrders)
        {
            _orderID = orderID;
            _tableID = tableID;
            _baristaOrder = baristaOrder;
            _customerName = customerName;
            _takeAway = takeAway;
            CoffeeOrders = coffeeOrders;
        }
        #endregion

        #region Methods
        // List of all ordered coffees


        // Count total items
        public int ItemCount()
        {
            return CoffeeOrders.Count;
        }

        // Calculate total price
        public int TotalPrice()
        {
            return 0;
        }

        // Calculate discount of each item + total
        public int OrderDiscountTotal()
        {
            return 0;
        }

        public int OrderDiscountPerItem()
        {
            return 0;
        }

        public void AddMenuItem(Coffee coffeeItem)
        {
            CoffeeOrders.Add(coffeeItem);
        }

        #endregion
    }
}
