using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Properties
{
    public static class Helper
    {
        public static bool IsValidName(string name)
        {
            bool isValid = false;
            try
            {
                isValid = !string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name, @"^[A-Z][a-zA-Z\s]");
            }
            catch { isValid = false; }
            return isValid;
        }
        public static int GetNum(string prompt, bool canBeNegative = false)
        {
            int num = 0;
            bool isValid = false;
            do
            {
                Console.Write(prompt);
                isValid = int.TryParse(Console.ReadLine(), out num);
                if (!canBeNegative && num <= 0)
                {
                    isValid = false;
                    Console.WriteLine("Age must not be a non-negative number.");
                }
            } while (!isValid);
            return num;

        }
        public static int GetNumSib(string prompt, bool canBeNegative = false)
        {
            int num = 0;
            bool isValid = false;
            do
            {
                Console.Write(prompt);
                isValid = int.TryParse(Console.ReadLine(), out num);
                if (!canBeNegative && num < 0 )
                {
                    isValid = false;
                    Console.WriteLine("Age must not be a non-negative number.");
                }
            } while (!isValid);
            return num;
        }
        public static string GetName(string prompt)
        { 
            bool isValid = false;
            string name1;
            do
            {
                Console.Write(prompt);
                name1 = Console.ReadLine();
                if (Helper.IsValidName(name1))
                {
                    isValid = true;
                }
            } while (!isValid);
            return name1;
        }
        public static string GetGender(string prompt)
        {
            bool isValid = false;
            string gender1;
            do
            {
                Console.Write(prompt);
                gender1 = Console.ReadLine().ToLower();
                if (gender1 == "male" || gender1 == "female" || gender1 == "m" || gender1 == "f")
                {
                    isValid = true;
                }
            } while (!isValid);
            return gender1;
        }
        public static string GetParent(string prompt)
        {
            bool isValid = false;
            string name;
            do
            {
                Console.Write(prompt);
                name = Console.ReadLine().ToUpper();
                if (name == "N/A" || Helper.IsValidName(name))
                {
                    isValid = true;
                }
            } while (!isValid);
            return name;
        }
        public static int GetParentAge(string prompt)
        {
            bool isValid = false;
            int age = 0;
            do
            {
                Console.Write(prompt);
                isValid = int.TryParse(Console.ReadLine(), out age);
                if (age < 0)
                {
                    isValid = true;
                }
            } while (!isValid);
            return age;
        }
        public static bool Game(string name)
        {
            bool isValid = false;
            try
            {
                isValid = !string.IsNullOrWhiteSpace(name);
            }
            catch { isValid = false; }
            return isValid;
        }
        public static string GetfaveGame(string prompt)
        {
            bool isValid = false;
            string name1;
            do
            {
                Console.Write(prompt);
                name1 = Console.ReadLine();
                if (Helper.Game(name1))
                {
                    isValid = true;
                }
            } while (!isValid);
            return name1;
        }
    }
}
