using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample
{
    class MoneyTownCreditCardProcessor : AbstractCreditCardProcessor
    {
        public MoneyTownCreditCardProcessor(CreditCard creditcard) : base(creditcard)
        {
        }

        public override void RegisterCard()
        {
            Console.WriteLine(string.Format($"MT registers card number {ClientCreditcard.CardNumber}"));
        }

        public override void ValidateCard()
        {
            Console.WriteLine(string.Format($"MT validates Mr/Mrs {ClientCreditcard.LastName}'s card."));
        }

        public override void SaveCardAPIToken()
        {
            Console.WriteLine("Save API Token to MongoDB.");
        }

    }
}
