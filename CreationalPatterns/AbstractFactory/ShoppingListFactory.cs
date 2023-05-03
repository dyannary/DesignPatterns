using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ShoppingListFactory: NoteFactory
    {
        public override Note CreateNote(string title, string content, Priority priority)
        {
            switch (priority)
            {
                case Priority.Red:
                    return new ShoppingListRedNote { Title = title, Content = content };
                case Priority.Yellow:
                    return new ShoppingListYellowNote { Title = title, Content = content };
                case Priority.Green:
                    return new ShoppingListGreenNote { Title = title, Content = content };
                default:
                    throw new ArgumentException("Invalid priority");
            } 
        }
    }
}
