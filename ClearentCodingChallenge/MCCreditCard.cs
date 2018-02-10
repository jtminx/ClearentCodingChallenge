using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearentCodingChallenge
{
    public class MCCreditCard : CreditCard
    {
        double interest = .05;

        public MCCreditCard (double amount) : base(amount) { }

        public override double CalculateInterest()
        {
            return amount * interest;
        }
    }
}
