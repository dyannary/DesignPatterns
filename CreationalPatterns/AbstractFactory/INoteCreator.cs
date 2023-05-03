using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface INoteCreator
    {
        INote CreateNote(string title, string description, Priority priority);
    }
}
