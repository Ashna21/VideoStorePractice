using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoStore.Infrastructure;
using VideoStore.Models;
using System.Data.Linq;
namespace VideoStore.Controllers
{
    public class HomeController : Controller
    {
        DataContext context;
          public HomeController()
        {
             this.context = new DataContext(Connections.connection);
        }
        // GET: Home
        public ActionResult Index()
        {
            Table<CustomerBaseView> users = context.GetTable<CustomerBaseView>();
           // CustomerBaseView[] users = context.GetTable().ToArray();
            return View(users);
        }
    }
}