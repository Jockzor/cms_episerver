using cms_episerver.Business;
using System.ComponentModel.DataAnnotations;

namespace cms_episerver.Models.Pages
{
    public class SitePageData : PageData
    {
        [Display(
            GroupName = Globals.Groupnames.Metadata,
            Order = 120
            )]
        [CultureSpecific]
        public virtual string MetaDescription
        {
            get
            {
                var metaDesciption = this.GetPropertyValue(p => p.MetaDescription);
                return !string.IsNullOrWhiteSpace(metaDesciption) ? metaDesciption : this.Name;
            }
            set => this.SetPropertyValue(p => p.MetaDescription, value);

        }
    }
}
