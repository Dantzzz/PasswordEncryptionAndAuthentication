using System;
using System.Text;
using System.Security.Cryptography;

namespace PasswordEncryptionAndAuthentication
{
    class Profile : IEquatable<Profile>
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Profile(string usernameEntry, string passwordEntry)
        {
            Username = usernameEntry;
            Password = passwordEntry; 
        }

        internal static void Create()
        {
            Console.WriteLine("Create a new account...");

            Console.WriteLine("Please enter a username: ");
            string uname = Console.ReadLine(); 
             
            Console.WriteLine("Please enter a password: ");
            string entry = Console.ReadLine();
            string pwrd = EncryptPassword(entry);

            Profile newProfile = new Profile(uname, pwrd);
            bool uniqueProfile = UserRepository.IsUnique(newProfile);
            
            if(uniqueProfile == true)
            {
                UserRepository.AddUser(newProfile);
                Console.WriteLine("Profile created. \nPress any key to return to main menu...");
                MainMenu.Initialize();
            }
            else
            {
                Console.WriteLine("Invalid. Profile already exists. \nPress any key to return to return...");
                Console.ReadKey();
                Console.Clear();
                Create();
            }
        }
        internal static void Login()
        {
            
            Console.WriteLine("Username: ");
            string uname = Console.ReadLine();

            Console.WriteLine("Password: ");
            string entry = Console.ReadLine();
            string pwrd = EncryptPassword(entry);

            Profile profileEntry = new Profile(uname, pwrd);

            UserRepository.VerifyLogin(profileEntry);
        }
        internal static string EncryptPassword(string pwrdInput)
        {
            byte[] encodePwrd = new UTF8Encoding().GetBytes(pwrdInput);
            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(encodePwrd);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public bool Equals(Profile other)
        {
            return this.Username == other.Username &&
                   this.Password == other.Password;
        }
    }
}
