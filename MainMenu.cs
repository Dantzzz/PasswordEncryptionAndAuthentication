using System;

namespace PasswordEncryptionAndAuthentication
{
    class MainMenu
    {
        public static void Initialize()
        {
            Display();
        }

        private static void Display()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Please select an option below...");
            Console.WriteLine("Press 1 to create account.");
            Console.WriteLine("Press 2 to login to account.");
            Console.WriteLine("Press 3 to exit.");

            try
            {
                int selectedOption = Int32.Parse(Console.ReadLine());
                if (selectedOption > 3 || selectedOption == 0)
                {
                    Console.WriteLine("Invalid. Try again.\n");
                    Console.Clear();
                    Initialize();
                }
                else
                {
                    Console.Clear();
                    RouteOption(selectedOption);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid. Try again.");
                Console.Clear();
                Initialize();
            }
        }

        private static void RouteOption(int selectedOption)
        {
            switch (selectedOption)
            {
                case 1:
                    Profile.Create();
                    break;
                case 2:
                    Profile.Login();
                    break;
                case 3:
                    Console.WriteLine("Goodbye...");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
