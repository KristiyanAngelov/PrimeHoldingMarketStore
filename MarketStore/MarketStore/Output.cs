using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Output
    {
        public double purchaseValue { get; set; }
        public double discountRate { get; set; }
        public double discount { get; set; }
        public double totalPrice { get; set; }
        public Card card { get; set; }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("   Purchase value: $" + purchaseValue);
            Console.WriteLine();
            Console.WriteLine("   Discount rate: " + discountRate.ToString("0.0") + "%");
            Console.WriteLine();
            Console.WriteLine("   Discount: $" + discount.ToString("0.00"));
            Console.WriteLine();
            Console.WriteLine("   Total: $" + totalPrice.ToString("0.00"));
        }
    }
}
