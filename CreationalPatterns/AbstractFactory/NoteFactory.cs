using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class NoteFactory
    {
        public abstract Note CreateNote(
            string title,
            string content,
            Priority priority );
    }
}
