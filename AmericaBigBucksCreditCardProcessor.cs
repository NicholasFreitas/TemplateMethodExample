using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample
{
    class AmericaBigBucksCreditCardProcessor : AbstractCreditCardProcessor
    {

        public AmericaBigBucksCreditCardProcessor(CreditCard creditcard) : base(creditcard)
        {            
        }


        public override void RegisterCard()
        {
            Console.WriteLine(string.Format($"ABB registers {ClientCreditcard.FirstName} {ClientCreditcard.LastName}'s credit card."));
        }

        public override void ValidateCard()
        {
            Console.WriteLine(string.Format($"{ClientCreditcard.CardNumber} is a valid cart number."));            
        }
    }
}
