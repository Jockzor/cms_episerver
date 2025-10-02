using cms_episerver.Business;
using cms_episerver.Business.Attributes;
using cms_episerver.Business.Enums;
using cms_episerver.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace cms_episerver.Models.Pages
{
    [ContentType(
        GUID = "B71E2424-6F46-4728-9614-EB40F8AD0E89",
        GroupName = Globals.Groupnames.Specialized,
        DisplayName = "Container"
        )]

    [AvailableContentTypes(
        Availability.Specific,
        Include = [typeof(CarouselPage)]
        )]

    [ContentIcon(ContentIcon.Folder)]
    public class ContainerPage : PageData, IContainerPage
    {
    }
}
