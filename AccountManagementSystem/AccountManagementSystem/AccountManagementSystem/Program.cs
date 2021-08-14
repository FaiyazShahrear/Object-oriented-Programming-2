using System;

namespace AccountManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings savingacc = new Savings("Faiyaz",1838502,10000.0, new AccountOpeningDate("January", 01, 2010), 5);

            savingacc.ShowAccountInfo();

            savingacc.DepositMoney(1000);
            savingacc.DepositMoney(400);
            savingacc.WithdrawMoney(1000);
            savingacc.WithdrawMoney(9600);


            Current currAcc = new Current("Shahrear", 1838503, 10000.0, new AccountOpeningDate("February", 25, 2015), 2);

            currAcc.ShowAccountInfo();

            currAcc.DepositMoney(1000);
            currAcc.DepositMoney(400);
            currAcc.WithdrawMoney(1000);
            currAcc.WithdrawMoney(9600);

        }
    }
}
