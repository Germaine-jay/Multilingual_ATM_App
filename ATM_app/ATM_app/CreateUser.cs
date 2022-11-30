using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_app
{
    public class CreateNewUser
    {
        
        public static Dictionary<string, string> user = new Dictionary<string, string>()
        {
            { "germaine", "1234"}, {"ositadimma", "3456"}
        };

        private static int _LengthOfPassword = 4;
        public static int _Selected;

        public static void CreateUser()
        {          
            Console.Clear();

            switch (_Selected)
            {
                case 1:
                    Console.WriteLine("Create a new account ");
                    break;

                case 2:
                    Console.WriteLine("Meputa akauntu ohuru");
                    break;

                case 3:
                    Console.WriteLine("Ṣẹda iroyin titun");
                    break;

                default: Console.WriteLine("Invalid Input");
                    return;
            }

            switch (_Selected)
            {
                case 1:
                    Console.WriteLine("Enter username");
                    break;

                case 2:
                    Console.WriteLine("tinye aha njirimara");
                    break;

                case 3:
                    Console.WriteLine("tẹ orukọ olumulo");
                    break;
                default: Console.WriteLine("Invalid Input");

                    return;
            }

            string username = Console.ReadLine();

            switch (_Selected)
            {
                case 1:
                    Console.WriteLine("Enter password");
                    break;

                case 2:
                    Console.WriteLine("tinye paswọọdụ");
                    break;

                case 3:
                    Console.WriteLine("te oroigbaniwole");
                    break;

                default: Console.WriteLine("Invalid Input"); 
                    return;
            }         


            string password = Console.ReadLine();


            bool validation = true;
            while (validation)
            {

                if (password.Length != _LengthOfPassword || int.TryParse(password, out int value)==false)
                {
               
                    switch (_Selected)
                    {
                        case 1:
                            Console.WriteLine("password should be only 4 digits");
                            break;

                        case 2:
                            Console.WriteLine("okwuntughe kwesịrị ịbụ naanị nkeji anọ");
                            break;

                        case 3:
                            Console.WriteLine("ọrọigbaniwọle yẹ ki o jẹ awọn nọmba 4 nikan");
                            break;

                        default: Console.WriteLine("Invalid Input"); 
                            break;
                    }

                    Console.WriteLine("\n Try again.........y/n");
                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "y":
                            CreateUser();
                            break;
                        case "n":
                            break;
                    }
                }

                else if(user.ContainsKey(username))
                {

                    switch (_Selected)
                    {
                        case 1:
                            Console.WriteLine("username already exist");
                            break;

                        case 2:
                            Console.WriteLine("nwaa ọzọ \n gbiyanju lẹẹkansi.............y/n");
                            break;

                        case 3:
                            Console.WriteLine("orukọ olumulo ti wa tẹlẹ \n aha njirimara adịlarị........y/n");
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }


                    switch (_Selected)
                    {
                        case 1:
                            Console.WriteLine("Try Another Username..........." + "y/n");
                            break;

                        case 2:
                            Console.WriteLine("Gbalia aha njirimara ozo..........." + "y/n");
                            break;

                        case 3:
                            Console.WriteLine("Gbiyanju Orukọ olumulo miiran..........." + "y/n");
                            break;

                        default:
                            Console.WriteLine("Invalid Input");
                            return;
                    }

                    Console.WriteLine();
                    Console.Clear();

                    var option = Console.ReadLine();
                    switch (option)
                    {
                        case "y":
                            CreateUser();
                            break;
                        case "n":
                            break;
                    }
                }
                else
                    {
                        user.Add(username, password);
                        Console.WriteLine("Account Created Successfully, you can Login now");
                        break;
                    }
            }
            var loginUSer = new LoginUser();
            loginUSer.LoginRegisteredUser(user);
        }

        public static void UserOption()
        {
            Console.WriteLine("\n  choose a language to continue:\n\n  Enter 1 for English\n\n  pia 2 maka igbo\n\n  te 3 fun yoruba");
            Console.WriteLine();

            var selectLanguage = int.Parse(Console.ReadLine());
           _Selected = selectLanguage;

           
            switch (_Selected)
            {
                case 1:
                    Console.WriteLine("Already hav an account?...........y/n");
                    break;

                case 2:
                    Console.WriteLine("enweela akaụntụ ?..........." + "y/n");
                    break;

                case 3:
                    Console.WriteLine("ti ni iroyin tẹlẹ?..........." + "y/n");
                    break;

                default:
                    UserOption();
                    return;
            }

            var payoption = Console.ReadLine();

            switch (payoption)
            {
                case "y":
                    var loginUSer = new LoginUser();
                    loginUSer.LoginRegisteredUser(user);
                    break;
                case "n":
                    CreateUser();
                    break;
                default:
                    Console.WriteLine("invalid input"); UserOption();
                    break;
            }
        }
    }

}
