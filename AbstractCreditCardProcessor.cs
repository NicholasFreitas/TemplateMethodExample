using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample
{
    public abstract class AbstractCreditCardProcessor
    {
        public CreditCard ClientCreditcard;

        protected AbstractCreditCardProcessor(CreditCard creditcard)
        {
            ClientCreditcard = creditcard;
        }

        public void BindCreditCardtoAPI()
        {

            ValidateCard();

            RegisterCard();

            SaveCardAPIToken();
            
        }

        abstract public void RegisterCard();

        abstract public void ValidateCard();

        virtual public void SaveCardAPIToken()
        {
            Console.WriteLine(string.Format($"Saving {ClientCreditcard.FirstName} {ClientCreditcard.LastName}'s credit card token to the Oracle DB."));
        }

        

    }
}
