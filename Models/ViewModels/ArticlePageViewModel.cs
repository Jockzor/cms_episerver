using cms_episerver.Models.Pages;

namespace cms_episerver.Models.ViewModels
{
    public class ArticlePageViewModel : PageViewModel<ArticlePage>
    {
        public ArticlePageViewModel(ArticlePage currentPage) : base(currentPage)
        {
        }
    }
}
