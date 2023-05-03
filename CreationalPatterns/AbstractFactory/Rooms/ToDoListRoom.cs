using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactory.Rooms.NotesRoom;

namespace AbstractFactory.Rooms
{
    internal class ToDoListRoom: NotesRoom
    {
        public ToDoListRoom()
        {
            Title = "Cleaning";
            Description = "Clean in the bathroom";
        }

        public override void getList()
        {
            priority = Priority.VeryImportant;
        }
    }
}
