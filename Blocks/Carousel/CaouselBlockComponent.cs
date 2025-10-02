using cms_episerver.Models.Blocks;
using cms_episerver.Models.Pages;
using cms_episerver.Models.ViewModels;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace cms_episerver.Blocks.Carousel
{
    public class CaouselBlockComponent : AsyncBlockComponent<CarouselBlock>
    {
        protected override async Task<IViewComponentResult> InvokeComponentAsync(CarouselBlock currentContent)
        {
            var model = new CarouselViewModel();

            if (currentContent.Carousel != null)
            {
                foreach(var item in currentContent.Carousel.FilteredItems.Select(x => x.LoadContent()))
                {
                  if(item is CarouselPage page)
                  {
                      model.Pages.Add(page);
                    }
                }
            }
            return await Task.FromResult(View("~/views/shared/Carousel.cshtml", model));
        }
    }
}
