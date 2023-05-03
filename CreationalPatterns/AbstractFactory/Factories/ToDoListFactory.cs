using AbstractFactory.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    class ToDoListFactory: ISharingNotesFactory
    {
        public NotesRoom CreateRoom()
        {
            return new ToDoListRoom();
        }
    }
}
