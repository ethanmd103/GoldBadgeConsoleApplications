using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_KomodoOutings_Repository
{
    public class EventRepo
    {
        protected readonly List<Event> _Event = new List<Event>();  
        
        
        //Get all outings 

        public List<Event> GetEvents()
        {
            return _event;
        }
        
        //Add outings to list

        public bool AddOutingsToList(Event events)
        
        {
            int eventType = _event.Count;
            _event.Add(events);

            bool wasAdded = (_event.Count);




            

            
        }
        //Calculate cost 
    }
}
