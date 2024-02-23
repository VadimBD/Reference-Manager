using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineReferences.Models;
using OnlineReferences.Models.ViewModels;

namespace OnlineReferences.Controllers
{
    public class ReferencesController : Controller
    {
        private IDbContext dbContext;
        private ReferenceRequestInfo referensRequest;
        public ReferencesController(IDbContext dbContext, ReferenceRequestInfo referensRequest) 
        { 
            this.dbContext = dbContext;
            this.referensRequest=referensRequest;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RequestReference(int id)
        {
            var vm = new ReferenceRequestInfoVM();
          
            vm.GroupsSLI = dbContext.GetStudentGroups().Select(g => new SelectListItem(g.Name, g.Id.ToString()));
            vm.Info = new SessionReferenceRequestInfo();
            vm.Info.Type = (ReferenceType)id;
            string name = ((ReferenceType)id).ToString();
            return View(name,vm);
        }

        [HttpPost]
        public ActionResult RequestReference(ReferenceRequestInfoVM requestInfo)
        {
            //TODO: Add Validation

            referensRequest.FirstName = requestInfo.Info.FirstName;
            referensRequest.LastName = requestInfo.Info.LastName;
            referensRequest.MiddleName = requestInfo.Info.MiddleName;
            referensRequest.CustomFields = requestInfo.Info.CustomFields;
            referensRequest.Email = requestInfo.Info.Email;
            if (requestInfo.Info.Group != null)
            {
                referensRequest.Group = dbContext.GetStudentGroups().First(g => g.Id == requestInfo.Info.Group.Id);
            }
            referensRequest.Type= requestInfo.Info.Type;
            if (referensRequest is ISessionSave sr )
            {
                sr.SaveInSession();
            }
            return RedirectToAction("Review");

        }

        [HttpGet]
        public ViewResult Review()
        {
            return View(referensRequest);
        }

        [HttpPost]
        public ActionResult SaveRequest(ReferenceRequestInfo requestInfo)
        {
            //TODO: Add Validation
            dbContext.SaveReferenceRequest(requestInfo);
            return RedirectToAction("Confirm");
            
        }

       
        
        [HttpGet]
        public ViewResult Confirm()=>View();
   

    }
 
}
