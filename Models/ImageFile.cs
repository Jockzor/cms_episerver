using EPiServer.Framework.DataAnnotations;

namespace cms_episerver.Models
{
    [ContentType(GUID = "ADC16A75-B037-42EC-96B5-51A0E669F359")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,png,gif,bmp,tiff,svg")]
    public class ImageFile : ImageData
    {
    }
}
