using System.ComponentModel.DataAnnotations;

namespace cms_episerver.Business
{
    public class Globals
    {
        [GroupDefinitions]
        public static class Groupnames
        {
            [Display(
                Name = "Metadata",
                Order = 40
                )]
            public const string Metadata = "Metadata";



            [Display(
                Name = "Specialized",
                Order = 90
                )]
            public const string Specialized = "Specialized";

        }
    }
}
