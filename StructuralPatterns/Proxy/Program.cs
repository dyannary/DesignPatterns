using Proxy.Subjects;

ContentRepositoryProxy contentRepositoryProxy = new ContentRepositoryProxy(DeviceType.Web);

var contentListForWeb = contentRepositoryProxy.GetContents();

Console.WriteLine("Web: " + contentListForWeb.Count +
    " \nHas ads: " + contentListForWeb.Any(clw => clw.Advertisements.Count > 0));

contentRepositoryProxy = new ContentRepositoryProxy(DeviceType.Desktop);

var contentListForDesktop = contentRepositoryProxy.GetContents();

Console.WriteLine("Desktop: " + contentListForDesktop.Count +
    " \nHas ads: " + contentListForDesktop.Any(cld => cld.Advertisements.Count > 0));

contentRepositoryProxy = new ContentRepositoryProxy(DeviceType.Mobile);

var contentListForMobile = contentRepositoryProxy.GetContents();

Console.WriteLine("Mobile: " + contentListForMobile.Count +
    " \nHas ads: " + contentListForMobile.Any(clm => clm.Advertisements.Count > 0));