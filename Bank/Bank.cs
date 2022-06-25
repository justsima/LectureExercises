using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecEx
{
    internal class Bank
    {
        public int AccountNo;
        public String fname;
        public String lname;
        public double amount;
        public double CurrentBalance;
        public static List<Bank> banks = new List<Bank>();
        public Bank()
        {

        }
        public Bank(int accountNo, string fname, string lname, double amount, double currentBalance)
        {
            AccountNo = accountNo;
            this.fname = fname;
            this.lname = lname;
            this.amount = amount;
            CurrentBalance = currentBalance;
        }
    }
}
