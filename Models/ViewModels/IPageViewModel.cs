using cms_episerver.Models.Pages;

namespace cms_episerver.Models.ViewModels
{
    public interface IPageViewModel <out T> where T : SitePageData
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; }
    }
}
