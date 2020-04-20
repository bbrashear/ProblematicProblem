using System;
using System.Collections.Generic;


namespace ProblematicProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            string cont = Console.ReadLine().ToLower();

            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            string seeList = Console.ReadLine().ToLower();

            if (seeList == "sure")
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                string addToList = Console.ReadLine().ToLower();
                Console.WriteLine();

                while (addToList == "yes")
                {
                    Console.Write("What would you like to add?");
                    string userAddition = Console.ReadLine();

                    activities.Add(userAddition);

                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    addToList = Console.ReadLine().ToLower();
                }

            }
            
            while (cont == "yes" || cont == "redo")
            {
                Console.Write("Connecting to the database");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                }

                Console.WriteLine();

                int randomNumber = rng.Next(activities.Count);

                string randomActivity = activities[randomNumber];

                if (userAge < 21 && randomActivity == "Wine Tasting")
                {

                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                    activities.Remove(randomActivity);

                }

                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                Console.WriteLine();
                cont = Console.ReadLine().ToLower();
            }
        }
    }
}
