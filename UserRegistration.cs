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
    }
}
