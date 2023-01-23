using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro text
            Console.WriteLine("Welcome to the dice throwing simulator! \n");
            Console.WriteLine("How many dice rolls would you like to simulate?");

            //user input
            int rolls = Convert.ToInt32(Console.ReadLine());

            //text output
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls. \nTotal number of rolls = " + rolls + '\n');
           
            //create array to store roll results
            int[] dice = new int[13];
            
            //instantiate each die value to 0
            for (int i = 0; i < 13; i++)
            {
                dice[i] = 0;
            }

            //create random for rolls
            Random r = new Random();
            for (int i = 0; i < rolls; i++)
            {
                //roll1 for die 1, roll2 for die 2
                int roll1 = r.Next(1, 7);
                int roll2 = r.Next(1, 7);

                //add sum the dice
                int rolltotal = roll1 + roll2;

                //increment value for total in array
                dice[rolltotal]++;
            }
            //loop to go through each number rolled
            for (int i = 2; i < 13; i++)
            {
                //finds the percentage of times number was rolled
                float pct = ((dice[i] / (float)rolls) * 100);

                //round pct
                int roundedTotal = Convert.ToInt32(Math.Round(pct));
                string stringOutput = "";

                //for loop to create the strings containing "*"
                for (int z = 0; z < roundedTotal; z++)
                {
                    //adds a "*" for every percentage
                    stringOutput = (stringOutput + "*");
                }
                //prints "*"
                Console.WriteLine(i + ": " + stringOutput);
            }
            //goodbye message
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
