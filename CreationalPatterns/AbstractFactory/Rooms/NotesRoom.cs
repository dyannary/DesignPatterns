using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Rooms
{
    abstract class NotesRoom
    {
        public string Title { get; set; }   
        public string Description { get; set; }
        public Priority priority { get; set; }

        public enum Priority
        {
            VeryImportant,
            Important,
            Optional
        }

        public abstract void getPriority();


        public abstract void getList();
    }
}
