using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NhaTro.Controllers
{
    public class NhathueController : Controller
    {
        // GET: Nhathue
        public ActionResult NhathuePartial()
        {
            return PartialView();
        }
    }
}