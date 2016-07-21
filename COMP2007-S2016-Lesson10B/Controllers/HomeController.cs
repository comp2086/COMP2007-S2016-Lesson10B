using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/**
 * @author: Tom Tsilipoulos
 * @date: July 21, 2016
 * @description: MVC Music Store
 */

namespace COMP2007_S2016_Lesson10B.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

       
    }
}