using System;
using System.Collections.Generic;
using System.Web.Mvc;
using fuzzy_llama.ViewModels;
using fuzzy_llama.Core.Persistence;

namespace fuzzy_llama.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context = new Context();

        public ActionResult Index()
        {
            ViewBag.Message = "User Accounts List";

            /*User newUser = new User();
            IEnumerable<User> users = _context.Users;

            Tuple<User, IEnumerable<User>> model = Tuple.Create(newUser, users);*/

            var model = new ViewModels.User();

            model.AllUsers = _context.Users;

            return View(model);
            // return View(_context.Users);
        }

        public ActionResult Create(Core.Models.User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a sample app called fuzzy llama for appharbor testing purpose....";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "We're available!";

            return View();
        }
    }
}
