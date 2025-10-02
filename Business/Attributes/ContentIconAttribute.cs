using cms_episerver.Business.Enums;

namespace cms_episerver.Business.Attributes
{
    public class ContentIconAttribute : Attribute
    {
        public ContentIcon Icon { get; set; }

        public ContentIconAttribute(ContentIcon icon)
        {
            Icon = icon;
        }
    }
}
