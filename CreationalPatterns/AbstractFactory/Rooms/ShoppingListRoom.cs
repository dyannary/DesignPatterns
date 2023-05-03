using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Rooms
{
    class ShoppingListRoom : NotesRoom
    {
        public ShoppingListRoom()
        {
            Title = "Market";
            Description = "Buy butter";
        }

        public override string getPriority()
        {
            
        }

        public override void getList()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Description: {0}", Description);
            priority = Priority.Important;
        }
    }
}
