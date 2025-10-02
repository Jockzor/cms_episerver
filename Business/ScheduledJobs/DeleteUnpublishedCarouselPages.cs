using cms_episerver.Business.Services;
using cms_episerver.Business.Services.Interfaces;
using cms_episerver.Models.Pages;
using EPiServer.PlugIn;
using EPiServer.Scheduler;
using EPiServer.Web;

namespace cms_episerver.Business.ScheduledJobs
{
    [ScheduledPlugIn(
        GUID = "AB20C471-2A43-4A63-9AC2-50D706E8F165",
        DisplayName = "Delete Unpublished Carousel Pages"
        )]
    public class DeleteUnpublishedCarouselPages : ScheduledJobBase
    {
        private readonly IContentLoader _contentLoader;
        private readonly ISiteDefinitionRepository _siteDefinitionRepository;
        private readonly IContentRepository _contentRepository;
        private readonly IDescendantService _descendantService;
        private bool _stopSignaled;

        public DeleteUnpublishedCarouselPages(IContentLoader contentLoader, ISiteDefinitionRepository siteDefinitionRepository, IContentRepository contentRepository, IDescendantService descendantService)
        {
            _contentLoader = contentLoader;
            _siteDefinitionRepository = siteDefinitionRepository;
            _contentRepository = contentRepository;
            _descendantService = descendantService;
            IsStoppable = true;
        }

        public override void Stop()
        {
            _stopSignaled = true;
        }

        public override string Execute()
        {
            var carouselPages = GetCarouselPages();
            var status = 0;

            foreach(var item in carouselPages)
            {
                if(item.StopPublish != null)
                {
                    _contentRepository.Delete(item.ContentLink, true, EPiServer.Security.AccessLevel.NoAccess);
                    status ++;
                }
            }
            if(_stopSignaled)
            {
                return $"Job was stopped";
            }
            return $"Unpublished Carousel Pages deleted: {status}";
        }

        private IEnumerable<CarouselPage> GetCarouselPages()
        {
            var contentReference = _siteDefinitionRepository.List().FirstOrDefault().StartPage;
            var startPage = _contentLoader.Get<StartPage>(contentReference);
            var carouselPages = _descendantService.GetDescendantsOfType<CarouselPage>(startPage).ToList();
       
            return carouselPages;
        }
    }
}
