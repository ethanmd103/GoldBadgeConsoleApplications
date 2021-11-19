using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoInsurance_Repo
{
   public class BadgeRepo
    {

        protected readonly Dictionary<int, Badge> _badgeRepo = new Dictionary<int, Badge>();
            
        //Create a new badge
        public bool AddBadge(Badge badge)
        {
            if (badge == null)
            {
                return false; 
            }
            int StartingCount = _badgeRepo.Count;
            _badgeRepo.Add(StartingCount, badge); 
            if (_badgeRepo.Count > StartingCount)
            {
                return true; 
            }
            return false; 
        }

        //Update doors on existing badge
        public bool UpdateDoor(int key, string door)
        {
            Badge badge = GetBadge(key);
            if (badge == null)
            {
                badge.Doors.Add(door);
                return true;

            }
            return false; 
        }
          
        //Delete all doors from existing badge

        public bool DeleteExistingBadge(Badge badge)
        {
            if (badge == null)
            { return false; 
            
            }
            _badgeRepo.Remove(badge.BadgeNumber);
            return true; 
                
              
        }
        
        //Show all badge numbers 
        public Dictionary<int, Badge> GetBadges()
        {
            return _badgeRepo;
        }

        public Badge GetBadge(int ID)
        {
            foreach (KeyValuePair<int, Badge> kvp in _badgeRepo)
            {
                if (kvp.Key == ID)
                { return kvp.Value; }
            }
            return null; 
        }

        public void Seed()
        {
            Badge badge1 = new Badge(1, new List<string> {"A1", "A2", "A3"});
            Badge badge2 = new Badge(1, new List<string> { "A1", "B1", "A3" });
            Badge badge3 = new Badge(1, new List<string> { "A1", "B3", "A3" });
            Badge badge4 = new Badge(1, new List<string> { "A1", "AB5", "A3" });
            _badgeRepo.Add(badge1.BadgeNumber, badge1);
            _badgeRepo.Add(badge2.BadgeNumber, badge2);
            _badgeRepo.Add(badge3.BadgeNumber, badge3);
            _badgeRepo.Add(badge4.BadgeNumber, badge4); 

        }






    }
           
        

   
}
