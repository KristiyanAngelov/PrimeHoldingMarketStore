using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public abstract class Card
    {
        protected string ownerName;
        protected double turnover;
        protected double discountRate;




        public string OwnerName
        {
            get => this.ownerName;
            set => this.ownerName = value;
        }

        public double Turnover
        {
            get => this.turnover;
            set => this.turnover = value;
        }

        public double DiscountRate
        {
            get => this.discountRate;
            set => this.discountRate = value;
        }



    }
}
