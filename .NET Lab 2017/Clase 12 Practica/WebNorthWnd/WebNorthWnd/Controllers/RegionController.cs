using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebNorthWnd.Controllers
{
    [RouteArea("regions")]
    public class RegionController : Controller
    {
        // GET: Region
        public ActionResult Index()
        {
            List<Region> regions;

            using (var context = new Context())
            {
                regions = context.Regions.ToList();
            }

            return View(regions);
        }

        [HttpPost]
        public ActionResult Create(Region region)
        {

            using (var context = new Context())
            {
                context.Regions.Add(
                    new Region() {
                        RegionID = context.Regions.Count() + 1,
                        RegionDescription = region.RegionDescription
                    });
                context.SaveChanges();
            }

                return View();
        }
        

        public ActionResult Create()
        {

            return View();
        }


    }
}