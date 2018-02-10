using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearentCodingChallenge
{
    public class VisaCreditCard : CreditCard
    {
        double interest = .1;

        public VisaCreditCard(double amount) : base(amount) { }

        public override double CalculateInterest()
        {
            return amount * interest;
        }
    }
}
