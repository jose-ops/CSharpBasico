﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCAsting.Entities
{
    class SavingAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) //SEALED somente em methodo sobreposto
        {
            base.Withdraw(amount);//o valor da super classe (Base) mais a regra do SavingAccount
            Balance -= 2.0;
        }
    }
}
