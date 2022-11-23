using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ATM_app
{
    public class LoginUser
    {
        public string UserName;
       
        public void LoginRegisteredUser()
        {
            Console.Clear();
            Console.WriteLine("choose a language to login:\n Enter 1 for English\n pia 2 maka igbo\n te 3 fun yoruba");
            var Selected = int.Parse(Console.ReadLine());

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
                default: Console.WriteLine("Invalid Input"); return;
            }
          
            string loginPassword = Console.ReadLine();

            CreateNewUser createNewUser = new CreateNewUser();

            foreach (KeyValuePair<string, string> userLogin in createNewUser.User)
            {
                if (!string.IsNullOrEmpty(loginPassword) || userLogin.Value == loginPassword)
                {
                    if (userLogin.Value == loginPassword)
                    {
                        UserName = userLogin.Key;

                        switch (Selected)
                        {
                            case 1:
                                   Console.WriteLine("you have successfully logged in {0}", UserName); continue;
                            case 2:
                                Console.WriteLine("i banyela nke oma {0}", UserName); continue;
                            case 3:
                                Console.WriteLine("o ti wole ni aseyori {0}", UserName); continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("empty input");
                }
            }
            Languages New = new Languages();
            New.Language();
        }
    }
}
