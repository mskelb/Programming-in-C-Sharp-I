using System;
namespace KidsFair
{
    public class TicketSeller
    {
        private string name;
        private double price = 99; 
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay; 

        public void Start()
        {
            Console.WriteLine("\nWelcome to KIDS' FAIR!\nChildren " +
                "always get a 75% discount!\n\nYour name please:");
            name = Console.ReadLine();
            while (string.IsNullOrEmpty(name) || name.All(char.IsDigit))
            {
                Console.WriteLine("Your input is null or an integer. Try again.");
                Console.WriteLine("Your name please:");
                name = Console.ReadLine();
            }
            Console.WriteLine("Number of adults: ");
            String temp = Console.ReadLine();
            while (string.IsNullOrEmpty(temp) || !temp.All(char.IsDigit))
            {
                Console.WriteLine("Your input is null or not an integer. Try again.");
                Console.WriteLine("Number of adults: ");
                temp = Console.ReadLine();
            }
            numOfAdults = Int32.Parse(temp);
            Console.WriteLine("Number of children: ");
            temp = Console.ReadLine();
            while (string.IsNullOrEmpty(temp) || !temp.All(char.IsDigit))
            {
                Console.WriteLine("Your input is null or not an integer. Try again.");
                Console.WriteLine("Number of children: ");
                temp = Console.ReadLine();
            }
            numOfChildren = Int32.Parse(temp);
            CalculateTicketPrice();
            PrintRecipiet(); 
        }
        public void CalculateTicketPrice()
        {
            amountToPay = (price* numOfAdults) + ((price * 0.75) * numOfChildren);

        }
        public void PrintRecipiet()
        {
            Console.WriteLine("\n+++ Your receipt +++\n+++ Amount to pay = " +
                amountToPay + "\n\nThank you " + name + " and please come back! +++\n"); 

        }
    }
}

