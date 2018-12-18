using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample
{
    public class CreditCard
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        public string VerificationCode { get; set; }

        public CreditCard(string firstName, string lastName, string cardNumber, string verificationCode)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            VerificationCode = verificationCode;
        }



    }
}
