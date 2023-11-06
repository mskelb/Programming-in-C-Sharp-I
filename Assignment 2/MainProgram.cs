namespace Assignment_2;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Title = "Strings, selection and iteration in C#"; 
        Console.WriteLine("My name is Molly, and I am a student of the HT2023 semester!\n");
        FunFeatures funObj = new FunFeatures();
        funObj.Start(); 
        ContinueToNextPart();
        Console.Title = "Let's work with some numbers";
        MathWork calc = new MathWork();
        calc.Start();
        ContinueToNextPart();
        TemperatureConverter tempObject = new TemperatureConverter();
        tempObject.Start();
        ContinueToNextPart();
        WorkingSchedule work = new WorkingSchedule();
        work.Start();
    }
    private static void ContinueToNextPart()
    {
        Console.WriteLine("\nPRESS ENTER TO CONTINUE TO THE NEXT PART");
        Console.ReadLine();
        //Console.Clear() only clears visual part of Terminal window...
        Console.Clear();
    }
}

