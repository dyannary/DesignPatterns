using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Proxy.Entities;
using Proxy.Interfaces;

namespace Proxy.Subjects
{
    public class ContentRepositoryProxy : IContentRepository
    {
        private DeviceType _deviceType;
        ContentRepository contentRepository = new ContentRepository();

        public ContentRepositoryProxy(DeviceType deviceType)
        {
            _deviceType = deviceType;
        }
        public List<Content> GetContents()
        {
            List<Content> contentList = contentRepository.GetContents();

            switch (_deviceType)
            {
                case DeviceType.Mobile:
                    contentList.ForEach(dt => { dt.Advertisements = new List<Advertisement>(); });
                    break;
                case DeviceType.Web:
                    contentList = contentList.Where(dt => dt.Category != CategoryEnum.Lifestyle).ToList();
                    break;
            }

            return contentList;
        }
    }

    public enum DeviceType
    {
        Desktop = 1,
        Mobile = 2,
        Web = 3
    }
}
