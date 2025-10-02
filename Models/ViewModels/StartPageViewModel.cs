using cms_episerver.Models.Pages;

namespace cms_episerver.Models.ViewModels
{
    public class StartPageViewModel : PageViewModel<StartPage>
    {
        public StartPageViewModel(StartPage currentPage) : base(currentPage)
        {
        }
    }
}
