using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace KidsFair
{
    public class Pet
    {
        // Pet name, age, gender
        private string? name;
        private int age;
        private string? gender;
        private bool isFemale;

        public void Start()
        {
            GetName();
            GetAge();
            GetGender();
            DisplayPetInfo();
        }
        public void GetName()
        {
            Console.Write("What is the name of your pet? ");
            name = Console.ReadLine();
            while (string.IsNullOrEmpty(name) || name.All(char.IsDigit))
            {
                Console.WriteLine("Your input is null or an integer. Try again.");
                Console.Write("What is the name of your pet? ");
                name = Console.ReadLine();
            }
        }
        public void GetAge()
        {
            Console.Write("What's " + name + "'s" + " age? ");
            String temp = Console.ReadLine();
            while (string.IsNullOrEmpty(temp) || !temp.All(char.IsDigit))
            {
                Console.WriteLine("Your input is null or not an integer. Try again.");
                Console.Write("What's " + name + "'s" + " age? ");
                temp = Console.ReadLine();
            }
            age = Int32.Parse(temp);
        }
        public void GetGender()
        {
            Console.Write("Is your pet a female? (y/n) ");
            gender = Console.ReadLine();
            while (string.IsNullOrEmpty(gender) || !gender.Equals("y") && !gender.Equals("n"))
            {
                Console.WriteLine("You typed something else than y/n. Try again.");
                Console.WriteLine("Is your pet a female? (y/n) ");
                gender = Console.ReadLine();
            }
            isFemale = (gender.Equals("y"));
            if (isFemale)
            {
                gender = "girl"; 
            }
            else
            {
                gender = "boy"; 
            }
        }
        public void DisplayPetInfo()
        {
            Console.WriteLine("\n++++++++++++++++++++++++++++");
            Console.WriteLine("Name: " + name + " Age: " + age);
            Console.WriteLine(name + " is a good " + gender + "!");
            Console.WriteLine("++++++++++++++++++++++++++++"); 
        }
    }
}

