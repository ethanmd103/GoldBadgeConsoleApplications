using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoInsurance_Repo
{

    public class Badge
    {

        public int BadgeNumber { get; set; }
        public List<string> Doors { get; set; }

        public Badge() { }
        public Badge(int badgeNumber, List<string> doors)
        {
            BadgeNumber = badgeNumber;
            Doors = doors;
        }


    }

}

