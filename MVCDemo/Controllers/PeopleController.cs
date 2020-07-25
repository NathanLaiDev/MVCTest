using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            PersonModel p = new PersonModel("Nathan", "ls", 0);

            return View();
        }

        public ActionResult ListPeople()
        {
            List <PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel("Nathan", "Lai", 20));
            people.Add(new PersonModel("Tatsuya", "Shiba", 21));
            people.Add(new PersonModel("Peppa", "Oink", 2));

            return View(people);

        }
    }
}