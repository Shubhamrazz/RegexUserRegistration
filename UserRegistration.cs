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
    }
}
