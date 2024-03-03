using Ebook_Project.Models;
using Ebook_Project.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebook_Project.Controllers
{
    public class TinTucController : Controller
    {
        // GET: TinTuc
        public ActionResult Index()
        {
            string res = RequestService.sendReqListTinTuc(1, 8);

            List<TinTucDTO> lTT = JsonConvert.DeserializeObject<List<TinTucDTO>>(res);
            return View(lTT);
        }
    }
}