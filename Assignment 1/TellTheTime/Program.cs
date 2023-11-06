namespace Time;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Greetings from the Time class!");
        Console.WriteLine(" ");
        // Create an instance of the DaysOnEarth class
        DaysOnEarth days = new DaysOnEarth();
        days.Start();
        // Print the number of days on Earth starting from the given date 
        days.PrintDays();
        days.calculateProfit(); 
        

    }
}

