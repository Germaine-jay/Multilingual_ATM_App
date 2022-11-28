using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ATM_app
{
    public class Languages
    {

        public BankAccount account = new BankAccount(LoginUser.UserName);
        public void Language()
        {
            
            Console.WriteLine("choose a language:\n\n Enter 1 for English\n pịa 2 maka igbo\n te 3 fun yoruba");
            int SelectedLanguage = int.Parse(Console.ReadLine());

            Console.WriteLine(SelectedLanguage);
            switch (SelectedLanguage)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("English");
                    Console.WriteLine("\nEnter\n 1 for withdrawal\n 2 for Deposit\n 3 for Transfer\n 4 Check Balance");
                    int EnglishOption = int.Parse(Console.ReadLine());

                    EnglishAction(EnglishOption);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Igbo");
                    Console.WriteLine("\n pia 1 ka idoral\n pia 2 itinye ego\n pia 3 ị ga-ebufe\n pia 4 lelee itule");
                    int IgboOption = int.Parse(Console.ReadLine());

                    IgboAction(IgboOption);

                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("yoruba");
                    Console.WriteLine("\n te 1 fun yokuro\n te 2 fun idogo\n te 3 fun gbigbe\n te 4 ṣayẹwo iwontunwonsi");
                    int YorubaIption = int.Parse(Console.ReadLine());

                    YorubaAction(YorubaIption);

                    break;

                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }

        public void EnglishAction(int action)
        {
            
            switch (action)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter Amount to withdraw");
                    decimal withdrawInenglish = decimal.Parse(Console.ReadLine());

                    account.Withdrawal(withdrawInenglish, DateTime.Now, "paga");
                    Console.WriteLine("Withdrawal sucessful, Your new balance is {0}", account.Balance);

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Enter Amount to Deposit");
                    decimal DepositInenglish = decimal.Parse(Console.ReadLine());

                    account.Deposit(DepositInenglish, DateTime.Now, "paga");
                    Console.WriteLine("Deposition sucessful, Your new balance is {0}",account.Balance);

                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Enter Amount to transfer");
                    decimal Transferinyoruba = decimal.Parse(Console.ReadLine());

                    account.Transfer(Transferinyoruba, DateTime.Now, "paga");
                    Console.WriteLine("Transfer sucessful, Your new balance is {0}", account.Balance);

                    break;
                case 4:
                    Console.Clear();
                    BankAccount balance = new BankAccount(LoginUser.UserName);
                    Console.WriteLine("Your Current Account Balance is ${0},{1}",balance.Balance, balance.Owner);

                    break;
                default:
                    Console.WriteLine("invalid input");
                    Console.WriteLine("ntinye na-ezighi ezi");
                    break;
            }
        }

        public void IgboAction(decimal action)
        {
            switch (action)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Tinye ego iji wepụ");
                    decimal WithdrawInIgbo = decimal.Parse(Console.ReadLine());

                    account.Withdrawal(WithdrawInIgbo, DateTime.Now, "paga");
                    Console.WriteLine("ndoro ego na-aga nke oma, nguzozi ọhuru gi bu {0}", account.Balance);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Tinye ego na nkwụnye ego");
                    decimal DepositInIgbo = decimal.Parse(Console.ReadLine());

                    account.Deposit(DepositInIgbo, DateTime.Now, "paga");
                    Console.WriteLine("Ntinye ego, ihe iga nke oma, nguzozi ohuru gi bu {0}", account.Balance);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Tinye ego ị ga-ebufe");
                    decimal TransferInIgbo = decimal.Parse(Console.ReadLine());

                    account.Transfer(TransferInIgbo, DateTime.Now, "paga");
                    Console.WriteLine("nyefee ịga nke oma, nguzozi ohuru gi bu {0}", account.Balance);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("lelee itule");
                    
                    break;
                default:
                    Console.WriteLine("ntinye na-ezighi ezi");
                    break;
            }
        }

        public void YorubaAction(decimal action)
        {
            switch (action)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Elo ni o fe lati yokuro");
                    decimal TransferInYoruba = decimal.Parse(Console.ReadLine());

                    account.Withdrawal(TransferInYoruba, DateTime.Now, "paga");
                    Console.WriteLine("Yiyo kuro ni aseyori, ati pe iwontunwonsi tuntun re je {0}", account.Balance);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Elo ni o fe lati beebe");
                    decimal DepositInYoruba = decimal.Parse(Console.ReadLine());

                    account.Deposit(DepositInYoruba, DateTime.Now, "paga");
                    Console.WriteLine("Ifipamo je aseyori, iwontunwọnsi tuntun re je {0}", account.Balance);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Elo ni o fe lati gbe");
                    decimal TransferInyoruba = decimal.Parse(Console.ReadLine());

                    account.Transfer(TransferInyoruba, DateTime.Now, "paga");
                    Console.WriteLine("gbigbe aseyori, titun re iwontunwonsi ni  {0}", account.Balance);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("sayewo iwontunwonsi");
                    
                    break;
                default:
                    Console.WriteLine("aisedeede igbewole");
                    break;                 
            }
        }
    }
}
