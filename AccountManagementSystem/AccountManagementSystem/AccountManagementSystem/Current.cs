using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagementSystem
{
    internal class Current : Account
    {
        int accountType;

        public int AccountType {
            get { return accountType; }
            set { accountType = value; }
        }

        public String Type(int key)
        {
            if (this.accountType == 1)
            {
                return "Personal";
            }
            else if (this.accountType == 2)
            {
                return "Salary";
            }
            else if (this.accountType == 3)
            {
                return "Student";
            }
            else
            {
                return "Unspecified";
            }
        }
        
        public Current()
        {
            this.minimumBalance = 500;

        }

        public Current(string name, uint id, double balance, AccountOpeningDate openingDate, int accountType) : base(name, id, balance, openingDate)
        {
            this.accountType = accountType;
            this.minimumBalance = 500;
        }

        public void ShowAccountInfo()
        {

            Console.WriteLine("Account info(Current): ");
            Console.WriteLine("Customer Name: {0}",this.CustomerName);
            Console.WriteLine("Customer Id: {0}", this.CustomerId);
            Console.WriteLine("Check Balance : {0}", this.AccountBalance);
            Console.WriteLine("Account Type : {0}", this.Type(accountType));
            this.OpeningDate.PrintDate();


        }
    }
}
