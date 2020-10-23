using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number:");
            Console.WriteLine("1.Bronze");
            Console.WriteLine("2.Silver");
            Console.WriteLine("3.Gold");
            Console.WriteLine("4.Exit");


            int inputNumber = int.Parse(Console.ReadLine());
            Output output = new Output();

            while (inputNumber != 4)
            {
                try
                {
                    if (inputNumber < 1 || inputNumber > 4 || inputNumber == null)
                    {
                        throw new Exception();
                    }

                    switch (inputNumber)
                    {
                        case 1:
                            output.card = new BronzeCard("Kristiyan", 0);
                            output.purchaseValue = 150;
                            output.discountRate = output.card.DiscountRate;
                            output.discount = output.purchaseValue * (output.card.DiscountRate / 100);
                            output.totalPrice = output.purchaseValue - output.discount;
                            Console.WriteLine("1. Bronze:");
                            Console.WriteLine("   a. Mock data: turnover $0, purchase value $150;");
                            Console.WriteLine("   b. Output:");
                            output.Print();
                            break;

                        case 2:
                            output.card = new SilverCard("Kristiyan", 600);
                            output.purchaseValue = 850;
                            output.discountRate = output.card.DiscountRate;
                            output.discount = output.purchaseValue * (output.card.DiscountRate / 100);
                            output.totalPrice = output.purchaseValue - output.discount;
                            Console.WriteLine("2. Silver:");
                            Console.WriteLine("   a. Mock data: turnover $600, purchase value $850;");
                            Console.WriteLine("   b. Output:");
                            output.Print();
                            break;

                        case 3:
                            output.card = new GoldCard("Kristiyan", 1500);
                            output.purchaseValue = 1300;
                            output.discountRate = output.card.DiscountRate;
                            output.discount = output.purchaseValue * (output.card.DiscountRate / 100);
                            output.totalPrice = output.purchaseValue - output.discount;
                            Console.WriteLine("3. Gold:");
                            Console.WriteLine("   a. Mock data: turnover $1500, purchase value $1300;");
                            Console.WriteLine("   b. Output:");
                            output.Print();
                            break;

                        case 4:
                            break;

                    }

                    inputNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("The number should be between 1 and 4!");
                    inputNumber = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
