using Cafe_Repository.cs;
using System;
using System.Collections.Generic;

namespace KomodoCafe
{
    public class ProgramUI
    {
        //Method that starts application
        private readonly MenuRepo _menu = new MenuRepo();
        public void Run()
        {
            RunMenu();
        }

        //Menu
        private void RunMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter a menu option: \n" +
                    "1. AddMenuItems\n" +
                    "2. DeleteMenuItems\n" +
                    "3. SeeAllMenuItems\n" +
                    "4. GetMenuItemByID\n" +
                    "5. Exit\n");

                String Input = Console.ReadLine();

                switch (Input)
                {
                    case "1":
                        AddMenuItems();
                        break;
                    case "2":
                        DeleteMenuItems();
                        break;
                    case "3":
                        SeeMenuItems();
                        break;
                    case "4":
                        GetMenuItemByID();
                        break;
                    case "5":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 3.\n" + "Press any key to continue...");
                        Console.ReadKey();
                        break;

                }
            }

        }
        //Add new items
        public void AddMenuItems()
        {
            Console.Clear();
            Menu menu = new Menu();
            Console.WriteLine("Please enter a ID for the item: ");
            menu.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a MealName for the item: ");
            menu.MealName = Console.ReadLine();

            Console.WriteLine("Please enter a description: ");
            menu.Description = Console.ReadLine();
            bool HasAllIngredients = false;
            List<string> ingredientItems = new List<string>();
            while (!HasAllIngredients)
            {
                Console.WriteLine("Please enter a ingredient: ");
                var userInput = Console.ReadLine();
                ingredientItems.Add(userInput);
                Console.WriteLine("Do you want to add another ingredient y/n");
                var userInputYorN = Console.ReadLine();
                if (userInputYorN == "Y".ToLower())
                {
                    HasAllIngredients = false;
                }
                else
                {
                    HasAllIngredients = true;
                }

            }

            menu.ListOfIngredients = ingredientItems;

            Console.WriteLine("Please enter a price: ");
            menu.Price = double.Parse(Console.ReadLine());

            var Success = _menu.AddToMenu(menu);
            if (Success)
                Console.WriteLine("Item was added to menu.");
            else
                Console.WriteLine("Item was not added.");
            Console.ReadKey();



        }

        //See current items
        public void SeeMenuItems()
        {
            Console.Clear();
            List<Menu> list = _menu.GetMenu();
            foreach (Menu menu in list)
            {
                DisplayMenuItem(menu);

            }

            Console.ReadKey();




        }
        private void DisplayMenuItem(Menu menu)
        {
            Console.WriteLine($"ID: {menu.ID}\n" +
                    $"Name: {menu.MealName}\n" +
                    $"Description: {menu.Description}\n" +
                    $"-------------------------------\n");
            Console.WriteLine("Ingredients: ");
            foreach (var item in menu.ListOfIngredients)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------\n");
            Console.WriteLine($"Price: {menu.Price}\n" +
                $"--------------------\n");
        }
        public void GetMenuItemByID()
        {
            Console.Clear();
            foreach (var item in _menu.GetMenu())
            {
                Console.WriteLine($"{item.ID}. {item.MealName}");

            }
            Console.WriteLine("Please select a menu item\n");
            int input = int.Parse(Console.ReadLine());
            Menu menu = _menu.GetMenuByMealID(input);
            DisplayMenuItem(menu);
            Console.ReadKey();
        }

        //Delete current items 
        public void DeleteMenuItems()
        {
            Console.Clear();

            foreach (var item in _menu.GetMenu())
            {
                Console.WriteLine($"{item.ID}. {item.MealName}");

            }
            // Get the mealname they want to delete
            Console.WriteLine("Which item would you like to remove\n");
            int input = int.Parse(Console.ReadLine());
            Menu menu = _menu.GetMenuByMealID(input);
            // Call the delete method
            bool wasDeleted = _menu.DeleteExistingMenuItem(menu);

            //If the content was deleted, say so
            if (wasDeleted)
            {
                Console.WriteLine("The item was successfully deleted.");
            }
            else
            {
                Console.WriteLine("Could not be deleted");
            }

            Console.ReadKey();
        }




    }
}
