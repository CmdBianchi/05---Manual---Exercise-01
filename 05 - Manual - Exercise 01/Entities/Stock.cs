using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Stock {
        private string _name;
        public double Price { get; set; }
        public int Amount { get; set; }
        public Stock() { }
        public Stock(string name, double price, int amount) {
            _name = name;
            Price = price;
            Amount = amount;
        }
        public string Name {
            get { return _name; }
        }
        public double PriceAmount {
            get { return Price * Amount; }
        }
        public void AddAmount(int amount) {
             Amount += amount;
        }
        public void RemoveAmount(int amount) {
             Amount -= amount;
        }
        public override string ToString() {
            return Name + ", $ " + Price.ToString("F2") + ", " + Amount + " Unidades, TOTAL R$ " + PriceAmount;
        }
    }
}
