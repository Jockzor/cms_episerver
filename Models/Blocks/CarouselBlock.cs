using cms_episerver.Business;
using cms_episerver.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace cms_episerver.Models.Blocks
{


    [ContentType(
    GUID = "5BE12BEA-CC85-48F6-9909-ACBEDF1901DA",
        DisplayName = "Carousel"
    )]
    public class CarouselBlock : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
            )]
        [AllowedTypes(typeof(CarouselPage))] // Restrict to CarouselPage type
        public virtual ContentArea Carousel { get; set; }
    }
}

