using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAL;

namespace DestinyPlacements.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        private readonly ItestService _service;
        public TestController(ItestService service)
        {
            _service = service;
        }
        public ActionResult Index()
        {
            _service.GetData();
            return View();
        }

    }
}
