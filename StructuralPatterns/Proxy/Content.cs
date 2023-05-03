using Proxy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Content
    {
        public Content()
        {
            Advertisements = new List<Advertisement>();
        }
        public int Id { get; set; }
        public Movies Movies { get; set; }
        public List<Advertisement> Advertisements { get; set; }
        public CategoryEnum Category { get; set; }
    }

    public enum CategoryEnum
    {
        Technology = 1,
        Education = 2,
        Health = 3,
        Lifestyle = 4,
    }
}
