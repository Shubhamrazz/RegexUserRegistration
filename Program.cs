﻿using System;

namespace RegexUserRegistrationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Welcome To User Registration Program----");
            //UserRegistration.ValidateFirstName();
            //UserRegistration.ValidateLastName();
            //UserRegistration.ValidateEmailId();
            //UserRegistration.ValidateMobileNumber();
            UserRegistration.ValidateSpecialCharPassword();
            Console.ReadLine();
        }
    }
}
