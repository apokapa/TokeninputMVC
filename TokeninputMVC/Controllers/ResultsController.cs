using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TokeninputMVC.ViewModels;

namespace TokeninputMVC.Controllers
{
    public class ResultsController : Controller
    {
        // GET: Results

 
        public ActionResult Index(FormWithTokenboxVM SearchData)
        {

            FormWithTokenboxVM vm = new FormWithTokenboxVM();
            vm.tokenbox = SearchData.tokenbox;

            return View(vm);
        }
    }
}