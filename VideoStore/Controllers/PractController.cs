using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoStore.Models;

namespace VideoStore.Controllers
{
    public class PractController : Controller
    {
        VideoStoreEntities db = new VideoStoreEntities();
        // GET: Pract
        public ActionResult Index(string option, string search )
        {
            if(option == "name")
            {
                return View(db.Videos.Where(x => x.VideoName == search).ToList());
            }
            List<Video> VideosList = db.Videos.ToList();
            return View(VideosList);
        }
    }
}