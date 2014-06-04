using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Beeminder_Integrations.Controllers
{
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Web.Script.Serialization;

    using Beeminder_Integrations.Models;

    public class BeeminderController : Controller
    {
        //
        // GET: /Beeminder/

        public ActionResult AuthorizeDev(string client_id, string redirect_uri, string response_type)
        {
            int start = redirect_uri.IndexOf("App", System.StringComparison.Ordinal);
            string appid = redirect_uri.Substring(start, 10);

            return
                this.RedirectPermanent(
                    "https://www.beeminder.com/apps/authorize?client_id=nsf67x744sgg3szchbva5v4njkvhso0&redirect_uri=http://beeminder.scramblejam.com/beeminder/returncodedev&response_type=token");
        }

        public ActionResult AuthorizeBeta(string client_id, string redirect_uri, string response_type)
        {
            int start = redirect_uri.IndexOf("App", System.StringComparison.Ordinal);
            string appid = redirect_uri.Substring(start, 10);

            return
                this.RedirectPermanent(
                    "https://www.beeminder.com/apps/authorize?client_id=nsf67x744sgg3szchbva5v4njkvhso0&redirect_uri=http://beeminder.scramblejam.com/beeminder/returncodebeta&response_type=token");
        }

        public ActionResult ReturnCodeBeta(string access_token, string appid)
        {
            ////ViewData["appid"] = appid;

            ////return this.View("AppIDView");

            return
                this.RedirectPermanent(
                    "https://zapier.com/dashboard/auth/oauth/return/App5832API/" + "?code=" + access_token);
        }

        public ActionResult ReturnCodeDev(string access_token, string appid)
        {
            ////ViewData["appid"] = appid;

            ////return this.View("AppIDView");

            return
                this.RedirectPermanent(
                    "https://zapier.com/dashboard/auth/oauth/return/App6318API/" + "?code=" + access_token);
        }

        [HttpPost]
        public ActionResult GetTokenDev(string code, string client_secret, string client_id, string grant_type, string redirect_uri)
        {
            return this.Json(new { access_token = code });
        }

        [HttpPost]
        public ActionResult GetTokenBeta(string code, string client_secret, string client_id, string grant_type, string redirect_uri)
        {
            return this.Json(new { access_token = code });
        }

        public ActionResult TestTriggerDev()
        {
            return this.Json(new { test_trigger = "success" }, JsonRequestBehavior.AllowGet);
        }

        public static double DateTimeToUnixTimestamp(DateTime dateTime)
        {
            return (dateTime - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
        }
    }
}
