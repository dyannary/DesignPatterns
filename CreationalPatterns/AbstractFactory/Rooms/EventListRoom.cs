using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactory.Rooms.NotesRoom;

namespace AbstractFactory.Rooms
{
    public class EventListRoom: NotesRoom
    {
        private DateTime toDate;
        public EventListRoom()
        {
            Title = "Cinema";
            toDate= DateTime.Now;
            Description = "Go to cineplex mall";
        }

        public override void getList()
        {
            priority = Priority.Important;
        }
    }
}
