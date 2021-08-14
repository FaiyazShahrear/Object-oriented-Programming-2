using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagementSystem
{
    struct AccountOpeningDate
    {
        private string month;
        private byte date;
        private ushort year;

        public AccountOpeningDate(string month, byte date, ushort year)
        {
            this.month = month;
            this.date = date;
            this.year = year;
        }
        public void PrintDate()
        {
            Console.WriteLine("Opening date :");
            Console.WriteLine("Month name :{0}", this.month);
            Console.WriteLine("Date :{0}", this.date);
            Console.WriteLine("Year :{0}", this.year);
        }

    }
    class Account
    {
        private string name;
        private uint id;
        private double balance;
        public double minimumBalance;
        public AccountOpeningDate openingDate;
        
        

        public string CustomerName
        {
            get { return name; }
            set { name = value; }
        }
        public uint CustomerId
        {
            get { return id; }
            set { id = value; }
        }
       public double AccountBalance
        {
            get { return balance; }
            set { balance = value; }
        }
        public double MinimumBalance {
            get { return minimumBalance; }
            set { minimumBalance = value; }
        }
      
        public AccountOpeningDate OpeningDate
        {
            get { return openingDate; }
            set { openingDate = value; }
        }
        

        public Account(string name, uint id, double balance, AccountOpeningDate openingDate)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;
            this.openingDate = openingDate;

        }

        public Account()
        { }
        public bool DepositMoney (double amount)

        {
            if (amount>=500)
            {
                this.balance = amount + balance;
                Console.WriteLine("depositted:{0}", amount);
                Console.WriteLine("New Balance : {0}",balance);
                return true;
            }
            else
            {
                Console.WriteLine("At least 500 must be depositted"); 
                return false; }
        }
       public bool WithdrawMoney (double amount)
        {
            if(this.balance-minimumBalance >= amount)
            {
                this.balance = balance - amount;
                Console.WriteLine("Withdrawn:{0}", amount);
                Console.WriteLine("New Balance : {0}", balance);
                return true;
            }
            else
            {
                Console.WriteLine("Account balance must be at least 500");
                return false;
            }
        }

       



    }
}
