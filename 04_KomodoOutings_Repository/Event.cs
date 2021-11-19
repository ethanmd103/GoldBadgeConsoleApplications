using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_KomodoOutings_Repository
{
    public class Event
    {
        public enum EventType (string Golf, string Bowling, string AmusementPark, string Concert)
        static void Main(string[] args)
        {
        }

        public int TotalAttended { get; set; }
        public DateTime Date { get; set; }
        public double CostPerPerson { get; set; }
        public double TotalCost { get; set; }

        public Event() { }
        public Event (int totalAttended, DateTime date, double costPerPerson, double totalCost )
        {
            TotalAttended = totalAttended;
            Date = date;
            CostPerPerson = costPerPerson;  
            TotalCost = totalCost;

        }

    }
}
