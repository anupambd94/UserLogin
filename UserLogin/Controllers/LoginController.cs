using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserLogin.Models;

namespace UserLogin.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        //public JsonResult UserLogin(user u)
        //{
        //    using (Entities en = new Entities())
        //    {
        //        var user = en.users.Where(a => a.username.Equals(u.username) && a.password.Equals(u.password)).FirstOrDefault();
        //        return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        //    }
        //}
	}
}