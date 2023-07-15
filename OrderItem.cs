using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    internal class OrderItem

    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public OrderItem(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            UnitPrice = price;
        }

        public virtual decimal GetValue() { return Quantity * UnitPrice; }
        public override string ToString() { return $"{Name} price: {UnitPrice} PLN, {Quantity} szt, value: {GetValue()}"; }
    }
}
