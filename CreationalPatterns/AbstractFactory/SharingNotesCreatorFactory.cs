using AbstractFactory.RoomConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class SharingNotesCreatorFactory : INoteCreatorFactory
    {
        public INoteCreator CreateShoppingNoteCreator() //CreateShoppingNoteCreator();
        {
            return new;
        }

        public INoteCreator CreateToDoNoteCreator()
        {
            return new ToDoListConcreteFactory();
        }

        public INoteCreator CreateEventNoteCreator()
        {
            return new EventNoteCreator();
        }
    }
}
