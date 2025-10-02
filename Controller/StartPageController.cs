using cms_episerver.Models.Pages;
using cms_episerver.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace cms_episerver.Controller
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public IActionResult Index(StartPage currentPage)
        {
            var model = new StartPageViewModel(currentPage);
            
                return View(model);
            
        }
    }
}
