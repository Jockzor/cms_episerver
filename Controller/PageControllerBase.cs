using cms_episerver.Models.Pages;
using EPiServer.Web.Mvc;

namespace cms_episerver.Controller
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
    }
}
