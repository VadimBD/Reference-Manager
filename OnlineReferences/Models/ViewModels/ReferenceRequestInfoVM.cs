using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnlineReferences.Models.ViewModels
{
    public class ReferenceRequestInfoVM
    {
        public SessionReferenceRequestInfo Info { get; set; }
        public IEnumerable<SelectListItem> GroupsSLI { get; set; }
    }
}
