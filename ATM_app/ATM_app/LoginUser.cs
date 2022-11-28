using System;
using System.Collections.Generic;

namespace ATM_app
{
    public class LoginUser
    {
        public static string UserName;

        public Dictionary<string, string> user = CreateNewUser.user;

        public void LoginRegisteredUser(Dictionary<string, string> user)
        {
            Console.Clear();
            Console.WriteLine("  choose a language to login:\n\n  Enter 1 for English\n\n  pia 2 maka igbo\n\n  te 3 fun yoruba");
            var Selected = int.Parse(Console.ReadLine());


            switch (Selected)
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
                default:
                    Console.WriteLine("Invalid Input");

                    break;
            }

            string loginUsername = Console.ReadLine();

            switch (Selected)
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
                default: Console.WriteLine("Invalid Input"); break;
            }
          
            string loginPassword = Console.ReadLine();



            foreach (KeyValuePair<string, string> userLogin in user)
            {
                if ((!string.IsNullOrEmpty(loginPassword) && !string.IsNullOrEmpty(loginUsername) || userLogin.Key == loginUsername))
                {
                    if (userLogin.Value == loginPassword && userLogin.Key == loginUsername)
                    {
                        UserName = userLogin.Key;

                        switch (Selected)
                        {
                            case 1:
                                   Console.WriteLine("you have successfully logged in {0}", userLogin.Key); break;
                            case 2:
                                Console.WriteLine("i banyela nke oma {0}", userLogin.Key); break;
                            case 3:
                                Console.WriteLine("o ti wole ni aseyori {0}", userLogin.Key); break;
                        }

                        Console.WriteLine();

                        var New = new Languages();
                        New.Language();
                    }
                    
                }
                else
                {
                    Console.WriteLine("empty input");
                    switch (Selected)
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
                            Console.WriteLine();
                            return;
                    }

                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "y":
                            LoginRegisteredUser(user);
                            break;
                        case "n":
                            break;
                    }
                }
            }    
        }
        
    }
}
