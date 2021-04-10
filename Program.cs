using System;

namespace PasswordEncryptionAndAuthentication
{
    class Program
    {
        public static void Main(string[] args)
        {
            MainMenu.Initialize();
        }
    }
}

//Console Application does two things:
//1. collects a plain text password from an individual user and stores the password in a string cipher
//2. verifies a user by username and password.

// User interface Requirements
// 1. save a new password for a specific username,
// 2. authenticate a specific username / password pair, or
// 3. exit the application.

// Three challenges of the assignment:
// 1. construct a user interface that presents the user with the three options listed above.
// 2. discover how you can convert strings to unintelligible collections of random characters.
// 3. define a data structure (collection) that can insert values and search values very rapidly.