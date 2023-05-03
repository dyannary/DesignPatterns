using AbstractFactory.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal interface ISharingNotesFactory
    {
        NotesRoom CreateRoom();

        //IShoppingList CreateShoppingList();
        //IToToList CreateToDoList();
        //IEventList CreateEventList();
    }
}
