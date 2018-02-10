using System.Collections.Generic;

namespace ClearentCodingChallenge
{
    public class Wallet
    {
        private List<CreditCard> creditCards;

        public Wallet(List<CreditCard> creditCards)
        {
            this.creditCards = creditCards;
        }

        public List<CreditCard> CreditCards
        {
            get { return creditCards; }
        }

    }
}