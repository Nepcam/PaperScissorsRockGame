using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string answer = "";
            int count = 0;
            int count1 = 0;
            //Welcome screen
            Console.WriteLine("Welcome to RPS game");

            while (answer != "NO")
            {
                //Player choice
                Console.WriteLine("Select any one:\n1->ROCK\n2->PAPER\n3->SCISSOR");
                //choices string array[]
                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
                //declare random variable 
                Random rand = new Random();
                //declare variable and set random and range of values 
                int number = rand.Next(0, 3);
                Console.WriteLine("Enter your choice:");
                string user = Console.ReadLine().ToUpper();
                Console.WriteLine("Computer:" + choices[number]);
                //if statements on choice combinations
                if (user == "ROCK" && choices[number] == "SCISSOR")
                {
                    Console.WriteLine("User wins");
                    count += 1;
                }
                else if (user == "ROCK" && choices[number] == "PAPER")
                {
                    Console.WriteLine("Computer wins");
                    count1 += 1;
                }
                else if (user == "PAPER" && choices[number] == "ROCK")
                {
                    Console.WriteLine("User wins");
                    count += 1;
                }
                else if (user == "PAPER" && choices[number] == "SCISSOR")
                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                else if (user == "SCISSOR" && choices[number] == "ROCK")
                {
                    Console.WriteLine("Computer Wins");
                    count1 += 1;
                }
                else if (user == "SCISSOR" && choices[number] == "PAPER")
                {
                    Console.WriteLine("User wins");
                    count += 1;
                }
                else
                {
                    Console.WriteLine("Same choices");
                }
                Console.WriteLine("Do you want to continue(YES/NO):");
                answer = Console.ReadLine().ToUpper();
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("User wins " + count + " times");
            Console.WriteLine("Computer wins " + count1 + " times");
        }
    }
}
