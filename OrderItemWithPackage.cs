using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    internal class OrderItemWithPackage : OrderItem
    {
        public string PackageName { get; set; }
        public decimal PackagePrice { get; set; }
        public OrderItemWithPackage(string name, int quantity, decimal price, string packageName, decimal packagePrice) : base(name, quantity, price)
        {
            PackageName = packageName;
            PackagePrice = packagePrice;
        }

        public override decimal GetValue()
        {
            return base.GetValue() + PackagePrice * base.Quantity;
        }

        public override string ToString()
        {
            return $"{base.Name}, {base.UnitPrice} PLN, package:{PackageName}, package price: {PackagePrice} PLN, value: {GetValue()}";
        }
    }
}
