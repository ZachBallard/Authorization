using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Authorization.Models;
using Microsoft.AspNet.Identity;

namespace Authorization.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext db = ApplicationDbContext.Create(); 
        // GET: User
        public ActionResult Index()
        {
            var usersList = db.Users.ToList();
            return Json(usersList);
        }
        // GET: User
        [Authorize(Roles = "Admin")]
        public ActionResult Info()
        {
            var currentUser = db.Users.Find(User.Identity.GetUserId());
            
            return Json(currentUser);
        }
    }
}