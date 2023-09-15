using System;
using System.Net.NetworkInformation;

namespace Assignment_2
{
	//Assignment 2C -- required for grade B. z<8
	public class TemperatureConverter
	{
		String rak = "\n---------------------------------\n";

		public void Start()
		{
			ShowMenu();
            Converter(); 

        }

        private void ShowMenu()
        {
			Console.WriteLine(rak);
            string s = ("TEMPERATUR CONVERTER");
            Console.WriteLine("{0," + ((rak.Length / 2) + (s.Length / 2)) + "}", s);
            Console.WriteLine(rak);
            Console.WriteLine("{0,-20}{1,10}\t{2,0}", "Celsius to Fahrenheit", ":", "1");
            Console.WriteLine("{0,-20}{1,10}\t{2,0}", "Fahrenheit to Celsius", ":", "2");
            Console.WriteLine("{0,-20}{1,11}\t{2,0}", "Exit", ":", "0");
            Console.WriteLine(rak);
        }
        private void Converter()
        {
            Console.Write("Your choice: ");
            int choice = CheckInput(Console.ReadLine()); 
            while ( choice != 1 && choice != 2 && choice != 0 )
            {
                Console.WriteLine("You did not choose 0 or 1 or 2. Try again.");
                Console.Write("Your choice: ");
                choice = CheckInput(Console.ReadLine());
            }
            switch(choice)
            {
                case 0:
                    Console.WriteLine("Exit program."); 
                    break;
                case 1:
                    Console.Write("\n");
                    CelsiusToFahrenheit();
                    break;
                case 2:
                    Console.Write("\n");
                    FahrenheitToCelsius();
                    break;
                default:
                    Console.WriteLine("Default.");
                    break;
            }
            
        }

        private void CelsiusToFahrenheit()
        {
            const int max = 101;
            for ( int c = 0; c < max; c += 4 )
            {
                double d = CelsiusToFahrenheitCalc( (double) c); 
                Console.WriteLine("{0,10} C = {1,10} F", c.ToString("0.00"), d.ToString("0.00")); 
            }
        }
        private void FahrenheitToCelsius()
        {
            const int max = 211;
            for (int c = 0; c < max; c = c + 10)
            {
                double d = FahrenheitToCelsiusCalc((double)c);
                Console.WriteLine("{0,10} F = {1,10} C", c.ToString("0.00"), d.ToString("0.00"));
            }
        }

        private double CelsiusToFahrenheitCalc(double c)
        {
            return ((double)9 / 5.0) * c + (double)32; 
        }
        private double FahrenheitToCelsiusCalc(double f)
        {
            return ((double)5 / 9.0) * (f - (double)32);
        }

        private int CheckInput(string? v)
        {
            int x;
            string temp = v; 
            while ( !Int32.TryParse(temp, out x) )
            {
                Console.WriteLine("Not a valid number, try again.");
                Console.Write("Your choice: "); 
                temp = Console.ReadLine();
            }
            return Int32.Parse(temp);
        }
    }
}

