using System;
using System.Globalization;
namespace Time
{
    public class DaysOnEarth
    {
        private int year;
        private int month;
        private int day;
        private DateTime birthDate;
        private int daysOld;
        private double profit;
        private double initialBalance;
        private double interestrate; 

        public void Start()
        {
            GetInfo();
        }
        public void GetInfo()
        {
            Console.WriteLine("\nWelcome to the Days on Earth Finder!\n\nFirst, in what year were you born (between 0 and 2023)? ");
            String temp = Console.ReadLine();
            year = Int32.Parse(CheckValidTime(0, 2023, temp, "year").PadLeft(4, '0'));
            Console.WriteLine("And in what month?");
            temp = Console.ReadLine();
            month = Int32.Parse(CheckValidTime(1, 12, temp, "month").PadLeft(2, '0'));
            Console.WriteLine("And on what day?");
            temp = Console.ReadLine();
            // Check if it's a valid date
            day = Int32.Parse(CheckValidTime(0, DateTime.DaysInMonth(year, month), temp, "day").PadLeft(2, '0'));
            birthDate = new DateTime(year, month, day);
            Console.WriteLine("Your day of birth is: " + birthDate); 

        }
        // Check if the year, month and day are valid 
        public String CheckValidTime(int lower, int higher, String temp, String s)
        {
            while (string.IsNullOrEmpty(temp) || !temp.All(char.IsDigit) ||
                Int32.Parse(temp) > higher || Int32.Parse(temp) < lower)
            {
                Console.WriteLine("Your input is null or not an integer, " +
                    "or you were born in the future or invalid month or day. Try again.");
                Console.Write("What " + s + " were you born? ");
                temp = Console.ReadLine();
            }
            return temp; 
        }
        // Function that prints the number of days up until now, starting from the given birth date 
        public void PrintDays()
        {
            //Today's date 
            DateTime today = DateTime.Now;
            daysOld = (today - birthDate).Days; 
            Console.WriteLine("You are {0} days old", daysOld);
        }
        public void calculateProfit()
        {
            // Calculate how much the profit will be if you invested X kr (initial balance)
            // the day of your birth, with a yearly interest rate of 8.2%
            Console.WriteLine("\nTo calculate the profit, we first need to know your initial balance/investment? " );
            initialBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nWhat is the yearly interest rate? e.g. 8.2% ");
            interestrate = Convert.ToDouble(Console.ReadLine());
            // The formula for calculating the profit: investerat belopp x (1 + ränta)^tidsintervall.
            profit = initialBalance *  Math.Pow( (1 + (interestrate/100)), (2023 - year));
            Console.WriteLine("The profit up until now 2023 is: " + String.Format("{0:0}", profit) + " kr"); 
        }
    }
}
            
