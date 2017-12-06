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
        IServerDataRestClient RestClient = new ServerDataRestClient();
        public ARZ1Controller(IServerDataRestClient restClient)
        {
            _restClient = RestClient;
        }

        // GET: ARZ1
        [HttpGet]
        public ActionResult Index()
        {
            return View(_restClient.GetSessionRoot());
        }
    }
}