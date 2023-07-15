namespace shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderItem apple = new OrderItem("apple", 5, (decimal)0.80);
            OrderItem bread = new OrderItem("bread", 2, (decimal)1.5);
            OrderItemWithPackage milk = new OrderItemWithPackage("milk", 4, (decimal)3.2, "bootle", (decimal)0.2);
            OrderItemWithPackage jelly = new OrderItemWithPackage("jelly", 8, (decimal)4.3, "bag", (decimal)0.1);
            List<OrderItem> list = new List<OrderItem>();
            list.Add(apple);
            list.Add(bread);
            list.Add(milk);
            list.Add(jelly);
            decimal sum = 0;
            foreach (var item in list)
            {
                Console.WriteLine(item);
                sum += item.GetValue();
            }
            Console.WriteLine($"Total: {sum}");
        }
    }
}