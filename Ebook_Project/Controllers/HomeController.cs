using Ebook_Project.Models;
using Ebook_Project.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace Ebook_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //if (Session["user"] == null)
            //    return RedirectToAction("Index", "Login");
            
            return View();
        }

        public string TempAISuggest(string desc)
        {
            string temp = RequestService.MakeRequestGet("/api/Util/suggestAI?desc=" + desc);
            JObject json = JObject.Parse(temp);
            string result = json.ToString();
            return result; 
        }
    }
}