using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearentCodingChallenge
{
    class Person
    {
        private List<Wallet> wallets;

        public Person(List<Wallet> wallets)
        {
            this.wallets = wallets;
        }

        public List<Wallet> Wallets {
            get { return wallets; }
        }

    }
}
