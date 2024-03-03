using Ebook_Project.Models;
using Ebook_Project.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ebook_Project.Controllers
{
    public class ToanBoSachController : Controller
    {
        // GET: ToanBoSach
        public ActionResult Index(int page = 1)
        {
            const int size = 8;

            string res = RequestService.sendReqListBook(page, size);
            string res2 = RequestService.sendReqNumOfPage(size);

            List<SachDTO> lSach = JsonConvert.DeserializeObject<List<SachDTO>>(res);
            dynamic data = JObject.Parse(res2);
            int numOfPage = data.NumOfPage;

            ViewData["NumOfPage"] = numOfPage;
            //string t = lSach[0].TENSACH;
            return View(lSach);
        }

        public ActionResult ChiTiet(string SachId)
        {
            string res = RequestService.sendReqBookDetail(SachId);
            SachDTO sach = JsonConvert.DeserializeObject<SachDTO>(res);

            return View(sach);
        }
    }
}