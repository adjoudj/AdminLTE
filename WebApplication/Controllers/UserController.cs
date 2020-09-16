using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace NewIdentity.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        // GET: Test  
        /// <summary>  
        /// Identity With Role only for Identity action method.  
        /// </summary>  
        /// <returns></returns>  
        ///   
        [Authorize(Roles = "User")] // Admin only can access  
        public ActionResult Identity()
        {
            return Content("We are using Identity");
        }
        [Authorize(Roles = "DPQ")] // Admin only can access  
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NonIdentiy()
        {
            return Content("We are not using Identity");
        }
    }
}
