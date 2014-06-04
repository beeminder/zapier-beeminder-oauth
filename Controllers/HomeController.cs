using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Beeminder_Integrations.Controllers
{        
    using System.Net;

    public class HomeController : Controller
    {
        /// <summary>
        /// Simple Http Response-only Index View
        /// </summary>
        /// <returns>An Http Status code of 200</returns>
        public ActionResult Index()
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}
