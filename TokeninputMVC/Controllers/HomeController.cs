using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TokeninputMVC.Models;
using TokeninputMVC.ViewModels;

namespace TokeninputMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FormWithTokenboxVM vm = new FormWithTokenboxVM();


            return View(vm);
        }

    
        //For tokenInput
        public async Task<JsonResult> SearchTokens(string q)
        {

            //Fake implementation
            //Add some fake data
            List<Area> areas = new List<Area>();
            areas.Add(new Area { id = 1, name = "Athens Center" });
            areas.Add(new Area { id = 2, name = "Athens North" });
            areas.Add(new Area { id = 3, name = "Athens South" });
            areas.Add(new Area { id = 4, name = "Athens Abelokipoi" });
            areas.Add(new Area { id = 5, name = "Thessaloniki" });
            areas.Add(new Area { id = 6, name = "Thessaloniki Center" });
            areas.Add(new Area { id = 7, name = "Thessaloniki Suburbs" });
            var results = new List<Area>();
            results.AddRange(areas.Where(m => m.name.ToLower().Contains(q.ToLower())));
            //Fake implementation End

            //When you have database or api implementation
            //IEnumerable<Area> areas = await _yourDatabaseContext.SearchAreas(q);

            var searchResult = results;
            return Json(searchResult, JsonRequestBehavior.AllowGet);
        }


        public async Task<JsonResult> GetPrepopulate(string selected)
        {
            //Fake implementation
            List<Area> areas = new List<Area>();
            areas.Add(new Area { id = 1, name = "Athens Center" });
            areas.Add(new Area { id = 2, name = "Athens North" });
            areas.Add(new Area { id = 3, name = "Athens South" });
            areas.Add(new Area { id = 4, name = "Athens Abelokipoi" });
            areas.Add(new Area { id = 5, name = "Thessaloniki" });
            areas.Add(new Area { id = 6, name = "Thessaloniki Center" });
            areas.Add(new Area { id = 7, name = "Thessaloniki Suburbs" });

            string[] selectedArr = selected.Split(',');
            var searchTokens = new List<Area>();

            foreach (var item in selectedArr)
            {
                searchTokens.Add(areas.Where(m => m.id.ToString() == item).FirstOrDefault());
            }
            //Fake implementation End

            //When you have database or api implementation
            //IEnumerable<Area> searchTokens = await _yourDatabaseContext.GetSelectedAreas(selected);

            var selectedTokens = searchTokens;

            return Json(selectedTokens, JsonRequestBehavior.AllowGet);
        }

    }
}