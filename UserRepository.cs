using System;
using System.Collections.Generic;

namespace PasswordEncryptionAndAuthentication
{
    internal class UserRepository
    {
        internal static List<Profile> users = new List<Profile>();
        internal static void AddUser(Profile user)
        {
            users.Add(user);
        }

        internal static void VerifyLogin(Profile profileEntry)
        {
            if (users.Contains(profileEntry))
            {
                Console.WriteLine("Login Successful!");
            }
            else
            {
                Console.WriteLine("Invalid Entry. \nTry again.");
                Console.Clear();
                Profile.Login();
            }
        }

        internal static bool IsUnique(Profile entry)
        {
            if (users.Contains(entry))
            {
                return false;
            }
            else return true;
        }

    }
}
