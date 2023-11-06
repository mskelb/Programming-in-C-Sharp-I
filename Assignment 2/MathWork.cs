using System;
namespace Assignment_2
{
    public class MathWork
    {
        public void Start()
        {
            PrintMultiplicationTable(); 
            Calculate();
        }

        private void Calculate()
        {
            bool done = true; 
            Console.WriteLine("\nNow let us do some calculations!" );
            while (done)
            {
                Console.Write("Give start number: ");
                int startNum = CheckInput(Console.ReadLine());
                Console.Write("Give end number: ");
                int endNum = CheckInput(Console.ReadLine());
                if (endNum < startNum)
                {
                    int temp = endNum;
                    endNum = startNum;
                    startNum = temp;
                    Console.WriteLine("End number < Start number. Swapping the two.");
                }
                //Get the sum and display it on the Prompt Window
                int total = SumNumbers(startNum, endNum);
                Console.Write("The sum of numbers between {0} and {1} is: {2}", startNum, endNum, total);
                //Dtermine and display the even numbers in the range startNum to endNum
                PrintEvenNumbers(startNum, endNum);
                //Do the same for odd numbers in the range
                PrintOddNumbers(startNum, endNum);
                //Call a method to calculate and display the square root of
                //each number in the range startNum to endNum and in every
                //iteration, also calculate from the current number to endNum
                CalculateSquareRoots(startNum, endNum);
                //Ask the user whether to exit or continue
                done = ExitCalculation();
            }
            Console.Clear(); 
        }

        private int CheckInput(string? v)
        {
            int x; 
            while (!Int32.TryParse(v, out x))
            {
                Console.WriteLine("Not a valid number, try again.");

                v = Console.ReadLine();
            };
            return Int32.Parse(v); 
        }

        private bool ExitCalculation()
        {
            string s = (" Do you want to exit Math Work (or do some more calculations)? (yes / no)");
            string pad = s.PadLeft(s.Length + 4, '*'); 
            Console.WriteLine("\n\n" + pad);
            string answer = Console.ReadLine().ToLower();

            switch (answer)
            {
                case "y":
                case "yes":
                    return false;
                    break;
                default:
                    Console.WriteLine("Invalid answer or 'no'... continues with Math Work.\n"); 
                    return true;
                    break;
            }
        }

        private void PadWithStarsPrint ( string s, int i )
        {
            string pad1 = s.PadRight(s.Length + 20, '*');
            string pad2 = pad1.PadLeft(pad1.Length + 20, '*');
            Console.WriteLine("\n{0," + (((6 * i) / 2) + (pad2.Length / 2)) + "}", pad2);
        }

        private void CalculateSquareRoots(int startNum, int endNum)
        {
            PadWithStarsPrint(" Square Roots ", 6);
            for (int i = startNum; i <= endNum; i++)
            {
                Console.Write("\nSqrt(  {0,2} to {1})  ", i, endNum);
                for (int j = i; j <= endNum; j++)
                {
                    Console.Write(String.Format("{0,6}", Math.Round(Math.Sqrt(j),2).ToString("0.00")));
                }
            }
        }

        private void PrintOddNumbers(int startNum, int endNum)
        {

            Console.WriteLine("\n\n****" + " Odd numbers between {0} and {1}\n ", startNum, endNum);
            int sum = 0;
            for (int num = startNum; num <= endNum; num++)
            {
                if (!(num % 2 == 0))
                    Console.Write(String.Format("{0,5}", num));
            }
            Console.WriteLine("\n"); 
        }

        private void PrintEvenNumbers(int startNum, int endNum)
        {
            Console.WriteLine("\n\n****" + " Even numbers between {0} and {1}\n ", startNum, endNum);
            int sum = 0;
            for (int num = startNum; num <= endNum; num++)
            {
                if (num % 2 == 0)
                    Console.Write(String.Format("{0,5}", num)); 
            }
        }

        private int SumNumbers(int startNum, int endNum)
        {
            int sum = 0; 
            for (int i = startNum; i <= endNum; i++)
            {
                sum = sum + i; 
            }
            return sum; 
        }

        private void PrintMultiplicationTable()
        {
            PadWithStarsPrint(" Multiplication Table ", 13); 
            for (int index = 1; index < 13; index++)
            {
                for (int j = 1; j < 13; j++)
                {
                    int sum = (index * j);
                    Console.Write(String.Format("{0,6}", sum));
                }
                Console.WriteLine("   ");

            }
        }
    }
}
