using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationProgram
{
    class UserRegistration
    {
        public static void ValidateFirstName()
        {
            string Pattern = "^[A-Z][a-z]{2,}?";//[^!@#$%^&*0-9]
            string[] inputs = { "Om", "Shubham", "Adyasha", "Priyanka", "Akansha", "Raj", "Shalini", "Mehek", "6nupur", "@Gagan", "Sim" };
            foreach (string input in inputs)
            {
                bool Result = Regex.IsMatch(input, Pattern);
                if (Result)
                {
                   Console.WriteLine("{0} is valid", input);
                }
                else
                  Console.WriteLine("{0} is invalid", input);
            }
        }

        public static void ValidateLastName()
        {
            string Pattern = "^[A-Z][a-z]{2,}?";//[^!@#$%^&*0-9]
            string[] inputs = { "Om", "Raj", "Priyadarshini", "Kumari", "Gupta", "Agarwal", "Ahmed", "Akhther", "6rehmani", "@Sawan", "jim" };
            foreach (string input in inputs)
            {
                bool Result = Regex.IsMatch(input, Pattern);
                if (Result)
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                    Console.WriteLine("{0} is invalid", input);
            }
        }
        public static void ValidateEmailId()
        {
            string Pattern = "^[a-zA-Z0-9][-a-zA-Z0-9._]+[@][a-z]+[.][a-z]{2,3}$";
            string[] inputs = { "sr99845@gmail.com","56Shyam.@gmail.in","08meghna-@gmail.in", "Joey07@gmail.in", "Sam_1@gmail.com", "Kumari99#gmail.in", "Gupta*@gmail.com", "9Agarwal@gmail.com", "Ahmed76@gmail.in", "Akhther2342@gmail.com"};
            foreach (string input in inputs)
            {
                bool Result = Regex.IsMatch(input, Pattern);
                if (Result)
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                    Console.WriteLine("{0} is invalid", input);
            }
        }
        public static void ValidateMobileNumber()
        {
            string Pattern = "^[6-9][0-9]{9}$";
            string[] inputs = { "7865328943", "6789431234", "7435238978", "9897674532", "89324156890", "5643784532", "7783245690", "77908578435", "6743245897" };
            foreach (string input in inputs)
            {
                bool Result = Regex.IsMatch(input, Pattern);
                if (Result)
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                    Console.WriteLine("{0} is invalid", input);
            }
        }
    }
}
