using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCAsting.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() //opçao para criar o objo sem passar os dados 
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLlimit) : base(number, holder, balance)
        {
            LoanLimit = loanLlimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += LoanLimit;
            }
        }
    }

}
