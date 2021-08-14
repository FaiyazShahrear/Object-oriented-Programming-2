using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagementSystem
{
   internal class Savings : Account
    {
        private int duration;
        public int TimeDuration
        {
            get { return duration; }
            set { duration = value; }
        }
        public Savings(string name, uint id, double balance,AccountOpeningDate openingDate,int duration) : base (name,id,balance,openingDate)
        {
            this.TimeDuration = duration;
            this.MinimumBalance = 0.0;
        }
        public Savings() 
        {
            this.MinimumBalance = 0.0;
        }

        public  void ShowAccountInfo()
        {
            Console.WriteLine("Account info(Saving): ");
            Console.WriteLine("Customer Name: {0}", this.CustomerName);
            Console.WriteLine("Customer Id: {0}", this.CustomerId);
            Console.WriteLine("Check Balance : {0}", this.AccountBalance);
            Console.WriteLine("Time Duration : {0}", this.TimeDuration);
            this.OpeningDate.PrintDate();


        }
    }
}
