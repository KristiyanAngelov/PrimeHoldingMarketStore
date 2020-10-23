using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class BronzeCard : Card
    {
        public BronzeCard(string ownerName, double turnover)

        {
            if (turnover < 100)
            {
                base.discountRate = 0;
            }
            else if (turnover >= 100 && turnover <= 300)
            {
                base.discountRate = 1;
            }
            else
            {
                base.discountRate = 2.5;
            }
        }
    }
}
