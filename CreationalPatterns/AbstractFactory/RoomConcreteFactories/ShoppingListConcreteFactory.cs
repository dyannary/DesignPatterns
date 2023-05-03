using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.RoomConcreteFactories
{
    public class ShoppingListConcreteFactory: Note
    {
        public void ShoppingListRedNote()
        {
            Priority = Priority.Red;
            CreatedAt = DateTime.Now;
        }

        //public void ShoppingListYellowNote()
        //{
        //    Priority = Priority.Yellow;
        //    CreatedAt = DateTime.Now;
        //}

        //public void ShoppingListGreenNote()
        //{
        //    Priority = Priority.Green;
        //    CreatedAt = DateTime.Now;
        //}

    }
}
