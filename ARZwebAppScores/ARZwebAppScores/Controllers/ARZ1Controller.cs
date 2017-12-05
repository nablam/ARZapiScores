using ARZwebAppScores.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARZwebAppScores.Controllers
{
    public class ARZ1Controller : Controller
    {
        private IServerDataRestClient _restClient;

        public ARZ1Controller(IServerDataRestClient restClient)
        {
            _restClient = restClient;
        }

        // GET: ARZ1
        public ActionResult Index()
        {
            return View(_restClient.GetSessionRoot());
        }
    }
}