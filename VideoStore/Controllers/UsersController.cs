using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VideoStore.Models;


namespace VideoStore.Controllers
{
    public class UsersController : Controller
    {
        private VideoStoreEntities db = new VideoStoreEntities();

        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogIn(User user)
        {
            //var UserNameTemp = user.UserName;
            //var UserEmailTemp = user.UserEmail;
            //adding sessions 
     
            string usr = user.UserName;
            Session["name"] = usr; //stores object to it, need to remember what type is passed when calling.

            if (db.Users.Any(x => x.UserName == user.UserName && x.UserEmail == user.UserEmail))
            {
                return View("Edit");
            }
            else
                return View("Index");

            //return View(db.Users.Where(x => x.UserName == UserNameTemp && x.UserEmail == UserEmailTemp).ToList());
           

        }

        //Register View
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Add(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            var usr = user.UserName;
            Session["name"] = usr;
            return RedirectToAction("Welcome");

        }
        public ActionResult Welcome()
        {
            return View();
        }




        
    }
}
