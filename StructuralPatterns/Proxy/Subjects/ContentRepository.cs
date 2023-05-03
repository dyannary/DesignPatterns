using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Entities;
using Proxy.Interfaces;

namespace Proxy.Subjects
{
    public class ContentRepository : IContentRepository
    {
        public List<Content> GetContents()
        {
            List<Content> contentList = new List<Content>();
            var adveritements = new List<Advertisement>()
            {
                new Advertisement() {Product="English Courses"},
                new Advertisement() {Product="Game Tickets"},
                new Advertisement() {Product="Nurofen"}
            };

            var content1 = new Content();
            content1.Movies = new Movies
            {
                Title = "Cowboys",
                Time = "01.30.00"
            };
            content1.Category = CategoryEnum.Education;
            content1.Advertisements = adveritements;

            var content2 = new Content();
            content2.Movies = new Movies()
            {
                Title = "Shutter Island",
                Time = "02.18.02"
            };
            content2.Category = CategoryEnum.Health;
            content2.Advertisements = adveritements;

            var content3 = new Content();
            content3.Movies = new Movies()
            {
                Title = "Inception",
                Time = "02.20.02"
            };
            content3.Category = CategoryEnum.Technology;
            content3.Advertisements = adveritements;

            contentList.Add(content1);
            contentList.Add(content2);
            contentList.Add(content3);

            return contentList;
        }
    }
}
