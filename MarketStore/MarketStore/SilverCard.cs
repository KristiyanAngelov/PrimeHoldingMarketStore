using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class SilverCard : Card
    {
        public SilverCard(string ownerName, double turnover)

        {
            if (turnover > 300)
            {
                base.discountRate = 3.5;
            }
            else
            {
                base.discountRate = 2.0;
            }
        }
    }
}
