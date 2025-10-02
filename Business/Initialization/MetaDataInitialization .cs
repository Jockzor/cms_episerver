using cms_episerver.Business.Extenders;
using cms_episerver.Models.Pages;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;

namespace cms_episerver.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(CmsCoreInitialization))]
    public class MetaDataInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if(context.HostType == HostType.WebApplication)
            {
                var regisrty = context.Locate.Advanced.GetInstance<MetadataHandlerRegistry>();
                regisrty.RegisterMetadataHandler(typeof(ContentData), new MetaDataExtender());
            }
        }
        public void Uninitialize(InitializationEngine context)
        {
        }
    }

}
