using System.Xml.Linq;

namespace KidsFair;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Greetings from MyPet class!");
        Console.WriteLine(" ");
        // Create an instance of the Pet class
        Pet pet = new Pet();
        pet.Start();
        Console.WriteLine("\n\nPress enter to start next part!");
        var userInput = Console.ReadKey();
        while ( !(userInput.Key == ConsoleKey.Enter ) )
        {
            Console.WriteLine("You pressed something else. Try again.");
            Console.WriteLine("Press enter to start next part!");
            userInput = Console.ReadKey();
        }
        Console.WriteLine("\nStarting the Album Program!"); 
        // Create an instance of the Album class
        Album album = new Album();
        album.Start(); 
        // Create an instance of the TicketSeller class
        TicketSeller ticketseller = new TicketSeller();
        ticketseller.Start();
        Console.WriteLine("Press Enter to exit!");
        userInput = Console.ReadKey();
        while (!(userInput.Key == ConsoleKey.Enter))
        {
            Console.WriteLine("You pressed something else. Try again.");
            Console.WriteLine("Press enter to start next part!");
            userInput = Console.ReadKey();
        }
    }
}

