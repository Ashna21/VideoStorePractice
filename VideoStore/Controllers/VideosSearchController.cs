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
    public class VideosSearchController : Controller
    {
        VideoStoreEntities db = new VideoStoreEntities();

        // Index Action that returns a search page
        public ActionResult Index()
        {
            return View();
        }

        //Search action being implemented
        public ActionResult Details(string search)
        {
            if (String.IsNullOrEmpty(search))
            {
                return HttpNotFound();
            }
            else
            {
                return View(db.Videos.Where(x => x.VideoName.Contains(search)).ToList());
            }
                

        }

        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Video video = db.Videos.Find(id);
        //    if (video == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(video);
        //}


    }
}
