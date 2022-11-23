using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_app
{
    public class CreateNewUser
    {
        
        public Dictionary<string, string> User = new Dictionary<string, string>()
        {
            { "germaine", "1234"}, {"ositadimma", "3456"}
        };

        public void CreateUser()
        {
            Console.WriteLine("Create a new account ");

            Console.WriteLine("Enter username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password");
            string password = Console.ReadLine();


            bool StillAlive = true;
            while (StillAlive)
            {
                if (password.Length != 4 || int.TryParse(password, out _) == false)
                {
                    Console.WriteLine("password should be only 4 digits");
                    Console.WriteLine("Try Another Username..........." + "y/n");
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
                else if(User.ContainsKey(username))
                {
                    Console.WriteLine("username already exist");

                    Console.WriteLine("Try Another Username..........." + "y/n");
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
                    User.Add(username, password);
                    Console.WriteLine("Account Created Successfully, you can Login now");
                    break;
                }
            }
            var loginUSer = new LoginUser();
            loginUSer.LoginRegisteredUser();

        }
    }
}
