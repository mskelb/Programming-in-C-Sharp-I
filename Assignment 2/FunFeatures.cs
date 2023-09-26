using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace Assignment_2
{
	public class FunFeatures
    {
		private String firstname;
		private String lastname;
        private String email;

        public void Start()
		{
            bool repeat = false;
            Console.Write("\n\n****** FORTUNE TELLER ******");
            do
            {
                FurtuneTeller();
                CalculateStrengthLength();
                repeat = RunAgain();

            } while (repeat);
        }

        private void CalculateStrengthLength()
        {
            Console.WriteLine("\n---- STRENGTH LENGTH ----\nWrite a text with any number of characters and press Enter.");
            string text = Console.ReadLine();
            Console.WriteLine(text.ToUpper() + "\nNumber of chars: " + text.Count(c => !Char.IsWhiteSpace(c)));
        }

        private bool RunAgain()
        {
            Console.WriteLine("\nContinue with another round? (yes/no)");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "y":
                case "yes":
                    return true; 
                    break;
                default:
                    return false; 
                    break;
            }
        }

        public void Introduce()
		{
			Console.Write("Let me know about yourself!\nYour first name please: ");
			firstname = Console.ReadLine(); 
            Console.Write("Your last name please: ");
            lastname = Console.ReadLine();
            Console.Write("Your email please: ");
			email = Console.ReadLine();
			//Check if email is valid
            if (!(IsValid(email)))
            {
                Console.Write("Your email seems to be invalid. Please typ your email again: ");
                email = Console.ReadLine();
            }
			Console.WriteLine($"Yes, the email: {email} {(IsValid(email) ? "is valid" : "is invalid")}"); 
            Console.Write("\nNice to meet you " + lastname.ToUpper() + ", " + firstname + "\nYour email is " + email);
        }

        private static bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|nu|se)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
        public void FurtuneTeller()
        {
            Console.Write("\nSelect a number between 1 and 7: "); 
            int temp = CheckInput(Console.ReadLine());
            CheckDayofWeek(temp); 
            
        }
        public void CheckDayofWeek(int day)
        {
            
            switch (day)
            {
                case 1:
                    Console.WriteLine("Oh no not Monday again!");
                    break;
                case 2:
                    Console.WriteLine("The day is Tuesday... what day?");
                    break;
                case 3:
                    Console.WriteLine("The day is Wednesday! Did I hear Lillördag? Yes you did!");
                    break;
                case 4:
                    Console.WriteLine("The day is Thursday, the weekend is approaching...tick tack...");
                    break;
                case 5:
                    Console.WriteLine("Thank god it is Friday! We're leaving the office early!");
                    break;
                case 6:
                    Console.WriteLine("The day is Saturday, do nothing and do plenty of it!");
                    break;
                case 7:
                    Console.WriteLine("The day is Sunday >> SPA day, yay!");
                    break;
                default:
                    Console.WriteLine("No day? is a good day but it doesn't exist!");
                    break; 
            }
        }
        private int CheckInput(string? v)
        {
            int x;
            while (!Int32.TryParse(v, out x))
            {
                Console.Write("Not a valid number, try again. ");

                v = Console.ReadLine();
            };
            return Int32.Parse(v);
        }
    }
}

