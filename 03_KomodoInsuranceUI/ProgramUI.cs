using _03_KomodoInsurance_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoInsuranceUI
{
    public class ProgramUI
    {
        private readonly BadgeRepo _badge = new BadgeRepo();
        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "Hello Security Admin, What would you like to do? \n" +
                    "1. Add a badge \n" +
                    "2. Edit a badge \n" +
                    "3. List all badges \n");

                String Input = Console.ReadLine();

                switch (Input)
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        UpdateBadge();
                        break;
                    case "3":
                        ListAllBadges();
                        break;

                }
            }
        }

        private void AddBadge()
        {
            Console.Clear();
            Badge badge = new Badge();
            Console.WriteLine("What is the number on the badge: ");
            badge.BadgeNumber = int.Parse(Console.ReadLine());
            bool isRunning = true;
            while (isRunning)
            {

                Console.Write("Add a door for access:(type 'quit' to exit): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    isRunning = false;
                }
                 badge.Doors.Add(input);
            }
            bool wasAdded = _badge.AddBadge(badge);
            if (wasAdded)
            {
                Console.WriteLine("Successfully added badge");
            }
            else
            {
                Console.WriteLine("Badge was NOT added.");
                Console.Write("Press any key to continue");
                Console.ReadKey();
                RunMenu();
            }







        }

        private void UpdateBadge()
        {
            Console.Clear();
            Console.WriteLine("What is badge number to update?: ");
            int num = int.Parse(Console.ReadLine());
            Badge badgetoUpdate = _badge.GetBadge(num);
            Console.WriteLine("What would you like to do?" +
                "\n1. Remove a door" +
                "\n2. Add a door" +
                "\n3. Exit");
            int input = int.Parse(Console.ReadLine());
            List<string> Access = badgetoUpdate.Doors;
            if (input == 1)
            {
                Console.WriteLine($"{badgetoUpdate.BadgeNumber} contains the following doors: ");
                foreach (string door in Access)
                {
                    Console.Write($"{door} ");


                }
                Console.WriteLine("\n Which door do you want to remove?");
                string Input = Console.ReadLine();
                if (Access.Contains(Input.ToLower()))
                {
                    badgetoUpdate.Doors.Remove(Input);
                }
            }
            if (input == 2)
            {
                Console.WriteLine("Which door do you want to add?");
                string Input=Console.ReadLine();
                if (Access.Contains(Input.ToLower()))
                {
                    Console.WriteLine("Door already exists press any key to return to main menu");
                    Console.ReadKey();
                    RunMenu(); 
                }
                else
                {
                    Access.Add(Input);
                    Console.WriteLine("Added successfully. Press any key to return to the main menu.");
                    Console.ReadKey();
                    RunMenu();

                }
                   
            }
            if (input == 3)
            {
                RunMenu();
            }
            else
            {
                Console.WriteLine("Invalid selection. Press enter to return to main menu.");
                Console.ReadKey();
                RunMenu();
            }
        }

        private void ListAllBadges()
        {
            Dictionary<int, Badge> badgeRepo = _badge.GetBadges();

            foreach (var item in badgeRepo)
            {

            }

        }
    }
}
