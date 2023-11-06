using System;
namespace Assignment_2
{
	public class WorkingSchedule
	{
        const int max = 52;
        int size = ("YOUR WORK SCHEDULE").Length; 

        public void Start()
		{

            MakeChoice();

        }

        private void MakeChoice()
        {
            string textToEnter = "YOUR WORK SCHEDULE";
            PadText(textToEnter);
            bool repeat = true;

            while (repeat)
            {
                ShowTable(); 
                Console.Write("Your choice: ");
                int choice = CheckInput(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exit program.");
                        repeat = false;
                        break;
                    case 1:
                        Console.Write("\n");
                        ShowScheduale(2);
                        continue;
                    case 2:
                        Console.Write("\n");
                        ShowScheduale(3);
                        continue;
                    default:
                        Console.WriteLine("You did not choose 0 or 1 or 2. Try again.\n");
                        continue;
                }
            }
        }

        private void ShowScheduale(int offset)
        {
            bool repeat = true;
            int breakindex = 0;
            int index = 1;
            while (repeat)
            {
                Console.Write("Week {0,2}\t\t", index);
                index += offset;
                breakindex++;
                if (breakindex == 4)
                { 
                    Console.Write("\n");
                    breakindex = 0; 
                }
                if ( index > max )
                    repeat = false; 
            }
            Console.WriteLine("\n");
            GenerateDashs(); 

        }

        private void ShowTable()
        {
            Console.WriteLine("1 Show a list of the weekends to work.");
            Console.WriteLine("2 Show a list of the nights to work.");
            Console.WriteLine("0 Exit program.\n");
        }

        private void PadText(string textToEnter)
        {
            string pad = ("").PadLeft(textToEnter.Length + 12, '-');
            string pad2 = pad.PadRight(pad.Length + 12, '-');
            Console.WriteLine("{0," + ((pad2.Length / 2) + (textToEnter.Length / 2)) + "}", textToEnter);
            Console.WriteLine(pad2 + "\n");
        }

        private void GenerateDashs()
        {
            string pad = ("").PadLeft(size + 12, '-');
            string pad2 = pad.PadRight(pad.Length + 12, '-');
            Console.WriteLine(pad2 + "\n");

        }

        private int CheckInput(string? v)
        {
            int x;
            string temp = v;
            while (!Int32.TryParse(temp, out x))
            {
                Console.WriteLine("Not a valid number, try again.\n");
                ShowTable(); 
                Console.Write("Your choice: ");
                temp = Console.ReadLine();
            }
            return Int32.Parse(temp);
        }
    }
}

