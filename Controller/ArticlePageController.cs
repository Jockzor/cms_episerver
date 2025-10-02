using cms_episerver.Models.Pages;
using cms_episerver.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace cms_episerver.Controller
{
    public class ArticlePageController : PageControllerBase<ArticlePage>
    {
        public IActionResult Index(ArticlePage currentPage)
        {
            var model = new ArticlePageViewModel(currentPage);
            
                return View(model);
            
        }
    }
}
