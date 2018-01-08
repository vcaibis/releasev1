using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AGP2Application.Controllers
{
    public class HomeController : Controller
    {

        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                using (AGPModel db = new AGPModel())
                {
                    var obj = db.Users.Where(a => a.email.Equals(user.email) && a.password.Equals(user.password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["ID"] = obj.ID.ToString();
                        Session["lastname"] = obj.lastname.ToString();
                        Session["firstname"] = obj.firstname.ToString();
                        Session["password"] = obj.password.ToString();
                        Session["email"] = obj.email.ToString();
                        Session["highschool"] = obj.highschool.ToString();
                        Session["institution"] = obj.institution.ToString();
                        Session["domain"] = obj.domain.ToString();
                        Session["filiere"] = obj.filiere.ToString();

                        //db.Users.Add(user);
                        //db.SaveChanges();
                        return RedirectToAction("Home");
                    }
                }

            }
            return View(user);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SignUp()
        {
            ViewBag.Message = "Your sign up page.";

            return View();
        }
        public ActionResult Home()
        {
            if (Session["ID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public ActionResult Project()
        {
            ViewBag.Message = "Project creation page";

            return View();
        }
    }
}