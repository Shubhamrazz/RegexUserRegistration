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
        public static void ValidateFirstName()//UC1
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

        public static void ValidateLastName()//UC2
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
        public static void ValidateEmailId()//UC3
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
        public static void ValidateMobileNumber()//UC4
        {
            string Pattern = "^[91]{2} [6-9][0-9]{9}$";
            string[] inputs = { "91 7865328943", "91 6789431234", "91 7435238978", "91 9897674532", "91 89324156890", "91 5643784532", "91 7783245690", "91 77908578435", "91 6743245897" };
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
        public static void ValidateSpecialCharPassword()
        {
            string Pattern = "^([a-zA-Z0-9])*[!@#$%^&*]{1}([a-zA-Z0-9])*$";
            //string Pattern = "^([A-Z 0-9]*[!@#$%^&*]{1}.{8,}$";

            string[] inputs = { "345E6$7a892", "9823s4*51", "A012346&7598", "88943267%%41", "9#876548EE723", "T879^0542345", "67435Sj2@3512", "9808#9432145" };

            foreach (string input in inputs)
            {
                bool result = Regex.IsMatch(input, Pattern);

                if (result)
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                    Console.WriteLine("{0} is invalid", input);
            }
        }
    }
}
