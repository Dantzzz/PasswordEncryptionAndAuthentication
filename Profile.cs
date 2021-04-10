using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace PasswordEncryptionAndAuthentication
{
    class Profile
    {

        public Profile(string usernameEntry, string passwordEntry)
        {
            string username = usernameEntry;
            string password = passwordEntry; 
        }
        internal static void Create()
        {
            Console.WriteLine("Create a new account...");

            Console.WriteLine("Please enter a username: ");
            string uname = Console.ReadLine(); 
             
            Console.WriteLine("Please enter a password: ");
            string pwrd = Console.ReadLine();

            Profile newProfile = new Profile(uname, pwrd);
            UserRepository.AddUser(newProfile);

            // TODO: Refactor later to prevent blank entries and/or duplicates
        }
        internal static void Login()
        {
            Console.WriteLine("Username: ");
            string uname = Console.ReadLine();

            Console.WriteLine("Password: ");
            string pwrd = Console.ReadLine();

            Profile profileEntry = new Profile(uname, pwrd);

            UserRepository.VerifyLogin(profileEntry);
        }
        internal static string EncryptPassword(string pwrdInput)
        {

        }
    }
}
