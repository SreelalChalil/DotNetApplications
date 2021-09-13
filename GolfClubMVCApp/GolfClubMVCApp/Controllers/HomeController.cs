using GolfClubMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GolfClubMVCApp.Controllers
{
    public class HomeController : Controller
    {
        GolfClubEntities db = new GolfClubEntities();
        // GET: Home
        public ActionResult Index()
        {
            List<sp_view_members_Result> slist = new List<sp_view_members_Result>();
            slist = db.sp_view_members().ToList();
            return View(slist);
        }
    }
}