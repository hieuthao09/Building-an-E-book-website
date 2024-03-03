using Ebook_Project.Models;
using Ebook_Project.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebook_Project.Controllers
{
    public class TimKiemController : Controller
    {
        // GET: TimKiem
        public ActionResult Index(string valueSearch)
        {
            var res = RequestService.sendReqSearch(valueSearch);

            JObject json = JObject.Parse(res);
            List<SachDTO> lSach;
            if (json["statusCode"].Value<int>().Equals(0))
            {
                var temp = json["listEbooks"].ToString();
                lSach = JsonConvert.DeserializeObject<List<SachDTO>>(temp);
            }
            else
                lSach = null;

            return View(lSach);
        }
    }
}