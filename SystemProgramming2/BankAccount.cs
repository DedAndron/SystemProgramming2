using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming2
{
    public class BankAccount
    {
        public decimal Cash { get; set; }
        public bool IsLocked { get; set; }
        public void Replenishment(int cash)
        {
            if (cash > 0)
            {
                Cash += cash;
            }
            else
            {
                return;
            }
        }
        public void Withdrawal(int cash)
        {
            if (cash > 0)
            {
                Cash -= cash;
            }
            else
            {
                return;
            }
        }
    }
}
