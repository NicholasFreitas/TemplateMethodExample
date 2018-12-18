using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var creditCard = new CreditCard("John","Smith","11112222333344","999");


            var moneyTown = new MoneyTownCreditCardProcessor(creditCard);
            var americaBigBucks = new AmericaBigBucksCreditCardProcessor(creditCard);

            moneyTown.BindCreditCardtoAPI();
            Console.WriteLine("===========================================================================");
            americaBigBucks.BindCreditCardtoAPI();









        }
    }
}
