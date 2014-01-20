using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealTimeLogging.Controllers
{
    public class PersonController : Controller
    {
        PersonContext context = new PersonContext(); 
        //
        // GET: /Person/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult FirstPersonName()
        {
            var firstPerson = context.People.FirstOrDefault();
            return Json(firstPerson.FirstName + " " + firstPerson.LastName);
        }

        public JsonResult NumberOfPeople()
        {
            var numPeople = context.People.Count();
            return Json(numPeople);
        }
	}
}