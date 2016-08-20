using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MY_DEMO_BLOG.Models;
using System.Data.Entity;  // Using the possibility to connect with different tables

namespace MY_DEMO_BLOG.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var latestPosts = db.Posts
                .Include(p => p.Author)
                .OrderByDescending(p => p.Date).Take(5);

            return View(latestPosts);

            //ViewBag.SideBarPosts = "latestFivePosts";

            //var latestFivePosts = db.Posts.Include(p => p.Author).OrderByDescending(p => p.Date).Take(5).ToList();
            //return View(latestFivePosts);
        }
    }
}