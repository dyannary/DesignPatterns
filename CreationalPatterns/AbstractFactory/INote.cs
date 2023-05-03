using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public enum Priority
    {
        Red,
        Yellow,
        Green
    }
}
