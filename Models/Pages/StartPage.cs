using cms_episerver.Business;
using cms_episerver.Models.Blocks;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace cms_episerver.Models.Pages
{
    [ContentType(
        GUID = "38881825-F66D-4A09-849E-8DCE83A7ED64",
        GroupName = Globals.Groupnames.Specialized
        )]
    [ImageUrl("/pages/CMS-icon-page-02.png")]
    public class StartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
            )]
        [CultureSpecific]
        public virtual string Heading { get; set; } = string.Empty;

        [Display(
          GroupName = SystemTabNames.Content,
          Order = 20
          )]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]

        public virtual string Preamble { get; set; } = string.Empty;

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30
            )]
        [CultureSpecific]
        [ScaffoldColumn(false)]
        public virtual XhtmlString Mainbody { get; set; }

        [Display(
          GroupName = SystemTabNames.Content,
          Order = 40
          )]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(
           GroupName = SystemTabNames.Content,
           Order = 50
           )]
        [CultureSpecific]
        [AllowedTypes(typeof(CarouselPage), typeof(CarouselBlock))]
        public virtual ContentArea Carousel { get; set; }
    }
}
