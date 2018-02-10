using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClearentCodingChallenge
{
    [TestFixture]
    public class CreditCardTests
    {
        [Test]
        public void FirstTest()
        {
            CreditCard visa = new VisaCreditCard(100);
            CreditCard mc = new MCCreditCard(100);
            CreditCard discover = new DiscoverCreditCard(100);
            List<CreditCard> CCList = new List<CreditCard>() { visa, mc, discover };
            Wallet wallet = new Wallet(CCList);
            List<Wallet> walletList = new List<Wallet>() { wallet };
            Person person = new Person(walletList);

            double visaExpectedResult = person.Wallets[0].CreditCards[0].CalculateInterest();
            double mcExpectedResult = person.Wallets[0].CreditCards[1].CalculateInterest();
            double dExpectedResult = person.Wallets[0].CreditCards[2].CalculateInterest();
            double totalExpectedResult = visaExpectedResult + mcExpectedResult + dExpectedResult;

            Assert.That(dExpectedResult, Is.EqualTo(1));
            Assert.That(mcExpectedResult, Is.EqualTo(5));
            Assert.That(visaExpectedResult, Is.EqualTo(10));
            Assert.That(totalExpectedResult, Is.EqualTo(16));
        }

        [Test]
        public void SecondTest()
        {
            CreditCard visa = new VisaCreditCard(100);
            CreditCard mc = new MCCreditCard(100);
            CreditCard discover = new DiscoverCreditCard(100);
            List<CreditCard> CCList1 = new List<CreditCard>() { visa, discover};
            Wallet wallet1 = new Wallet(CCList1);

            List<CreditCard> CCList2 = new List<CreditCard>() { mc };
            Wallet wallet2 = new Wallet(CCList2);

            List<Wallet> walletList = new List<Wallet>() { wallet1, wallet2 };
            Person person = new Person(walletList);

            double wallet1ExpectedResult = 0;
            double wallet2ExpectedResult = 0;

            foreach (CreditCard card in person.Wallets[0].CreditCards)
            {
                wallet1ExpectedResult += card.CalculateInterest();
            }

            foreach (CreditCard card in person.Wallets[1].CreditCards)
            {
                wallet2ExpectedResult += card.CalculateInterest();
            }

            double personExpectedResult = wallet1ExpectedResult + wallet2ExpectedResult;

            Assert.That(wallet1ExpectedResult, Is.EqualTo(11));
            Assert.That(wallet2ExpectedResult, Is.EqualTo(5));
            Assert.That(personExpectedResult, Is.EqualTo(16));
        }

        [Test]
        public void ThirdTest()
        {
            CreditCard visa = new VisaCreditCard(100);
            CreditCard mc = new MCCreditCard(100);
            CreditCard discover = new DiscoverCreditCard(100);

            List<CreditCard> CCList1 = new List<CreditCard>() { mc, visa };
            Wallet wallet1 = new Wallet(CCList1);
            List<Wallet> wallets1 = new List<Wallet>() { wallet1 };

            List<CreditCard> CCList2 = new List<CreditCard>() { visa, mc };
            Wallet wallet2 = new Wallet(CCList2);
            List<Wallet> wallets2 = new List<Wallet>() { wallet2 };

            Person person1 = new Person(wallets1);
            Person person2 = new Person(wallets2);

            double wallet1ExpectedResult = 0;
            double wallet2ExpectedResult = 0;

            foreach (CreditCard card in person1.Wallets[0].CreditCards)
            {
                wallet1ExpectedResult += card.CalculateInterest();
            }

            foreach (CreditCard card in person2.Wallets[0].CreditCards)
            {
                wallet2ExpectedResult += card.CalculateInterest();
            }

            double totalInterestResult = wallet1ExpectedResult + wallet2ExpectedResult;

            Assert.That(wallet1ExpectedResult, Is.EqualTo(15));
            Assert.That(wallet2ExpectedResult, Is.EqualTo(15));
            Assert.That(totalInterestResult, Is.EqualTo(30));

        }
    }
}
