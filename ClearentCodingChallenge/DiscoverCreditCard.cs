using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearentCodingChallenge
{
    public class DiscoverCreditCard : CreditCard
    {
        double interest = .01;

        public DiscoverCreditCard(double amount) : base(amount) { }

        public override double CalculateInterest()
        {
            return amount * interest;
        }
    }
}
