using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class GoldCard : Card
    {
        public GoldCard(string ownerName, double turnover)

        {
            if (turnover > 1000)
            {
                base.discountRate = 10.0;
            }
            else
            {
                base.discountRate = 2 + (int)(turnover / 100);
            }
        }
    }
}
