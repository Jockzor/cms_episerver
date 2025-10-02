using cms_episerver.Business;
using cms_episerver.Business.Attributes;
using cms_episerver.Business.Enums;
using System.ComponentModel.DataAnnotations;

namespace cms_episerver.Models.Pages
{
    [ContentType(
        GUID = "530656F6-B888-4B76-8EC8-85186830F7D4",
        GroupName = Globals.Groupnames.Specialized,
        DisplayName = "Carousel",
        Description = ""
        )]
    [ContentIcon(ContentIcon.ObjectImage)]
    public class CarouselPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
            )]
        public virtual ContentReference Image { get; set; }


    }
}
