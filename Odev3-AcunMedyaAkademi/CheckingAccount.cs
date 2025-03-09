using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_AcunMedyaAkademi
{
    public class CheckingAccount : BankAccount
    {
        
        public override double CalculateInterest()
        {
            Console.WriteLine("Vadesiz hesaplar faiz kazandırmaz");
            return 0;
        }
    }

}
