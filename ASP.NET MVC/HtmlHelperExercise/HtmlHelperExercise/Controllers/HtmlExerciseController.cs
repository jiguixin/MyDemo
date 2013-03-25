using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelperExercise.Controllers
{
    public class HtmlExerciseController : Controller
    {
        //
        // GET: /HtmlExercise/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ActionLinkExercise(string UserName)
        {
            if (string.IsNullOrEmpty(UserName))
                return View();
            else
            {
                ViewBag.UserName = UserName;
                ViewData["Age"] = 10;
                ViewData.TemplateInfo.HtmlFieldPrefix = "_jimtest";
                return View("ActionLinkExerciseParameter");
            }
        }

    }
}
