using System.Collections.Generic;

namespace Cafe_Repository.cs
{
    public class MenuRepo
    {
        private readonly List<Menu> _menu = new List<Menu>();

        //Create
        public bool AddToMenu(Menu menu)
        {
            int menuItem = _menu.Count;
            _menu.Add(menu);

            bool wasSuccessfull = (_menu.Count > menuItem) ? true : false;
            return wasSuccessfull;
        }

        // Read
        // Get All 
        public List<Menu> GetMenu()
        {
            return _menu;
        }

        // Get Single

        public Menu GetMenuByMealID(int ID)
        {
            foreach (Menu menu in _menu)
            {
                if (menu.ID == ID)
                    return menu;
            }
            return null;
        }


        //Delete
        public bool DeleteExistingMenuItem(Menu menu)
        {
            bool deleteResult = _menu.Remove(menu);
            return deleteResult;

        }


    }
}
