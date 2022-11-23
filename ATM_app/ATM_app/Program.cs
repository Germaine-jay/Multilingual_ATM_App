using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateNewUser loginUser = new CreateNewUser();
            //loginUser.CreateUser();

            //LoginUser loginUSer = new LoginUser();

            //loginUSer.LoginRegisteredUser();
            //Console.WriteLine(loginUSer.Select());

            Languages New = new Languages();
            New.Language();
            //Console.WriteLine(a + 5);


            //BankAccount account = new BankAccount(loginUSer.UserName);
            //account.Deposit(120, DateTime.Now, "paga");
            //Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}");
            //account.Withdrawal(500, DateTime.Now, "paga");
            //account.Transfer(500, DateTime.Now, "paga");
            //Console.WriteLine(account.Balance);
        }
    }
}
