using System.Collections.Generic;

namespace Cafe_Repository.cs
{
    public class Menu
    {
        static void Main(string[] args)
        {
        }

        public int ID { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public List<string> ListOfIngredients { get; set; }
        public double Price { get; set; }

        public Menu() { }
        public Menu(int id, string mealName, string description, List<string> listOfIngredients, double price)
        {
            ID = id;
            MealName = mealName;
            Description = description;
            ListOfIngredients = listOfIngredients;
            Price = Price;

        }

    }
}
