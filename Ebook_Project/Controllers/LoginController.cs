using Ebook_Project.Models;
using Ebook_Project.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web.Mvc;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ebook_Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logon(string email, string password)
        {
            try
            {
                Account acc = new Account(email, password);
                JObject res = RequestService.sendReqLogin(acc);

                //create JWT
                
                int statusCode = res["statusCode"].Value<int>();
                if (statusCode.Equals(0))
                {
                    string name = res["nameUser"].Value<string>();
                    acc.NameUser = name;

                    var token = RequestService.sendReqJWT(acc.Email);

                    var resp = new HttpResponseMessage();


                    Session["user"] = acc;
                    Session["token"] = JObject.Parse(token)["token"].Value<string>();
                }
                else
                {
                    Session["user"] = null;
                    Session["token"] = null;
                    return Redirect("/Login/Index");
                }

                return Redirect("/Home/Index");
            }
            catch(Exception err)
            {

                return RedirectToAction("Index","Error");
            }
            
        }

        public ActionResult GoogleLogin(string code)
        {
            if (code != null)
            {

                var user = GoogleProvider.loginGoogle(code);

                Account newAcc = new Account(user["email"].Value<string>(), "123456", user["name"].Value<string>(), "");

                string jsonStr = RequestService.sendReqRegister(newAcc);

                var json = JObject.Parse(jsonStr);

                if (json["statusCode"].Value<int>().Equals(0))
                {
                    Session["user"] = newAcc;
                    string token = RequestService.sendReqJWT(newAcc.Email);
                    return RedirectToAction("Index", "Home");
                }
                else if(json["statusCode"].Value<int>().Equals(-1))
                {
                    Session["user"] = newAcc;
                    string token = RequestService.sendReqJWT(newAcc.Email);
                    Session["token"] = JObject.Parse(token)["token"].Value<string>();

                    return RedirectToAction("Index", "Home");
                }
                else
                    return RedirectToAction("Index", "Login");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult Profile()
        {
            try
            {
                Account acc = (Account)Session["user"];
                if (acc != null)
                {
                    string token = (string)Session["token"];
                    string res = RequestService.sendReqShowEbookOwner(acc.Email, token);
                    JObject json = JObject.Parse(res);

                    if (json.ContainsKey("lSachOwner"))
                        ViewBag.SachOwner = JsonConvert.DeserializeObject<List<SachDTO>>(json["lSachOwner"].ToString());
                    else
                        ViewBag.SachOwner = null;
                    return View(acc);
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            catch(Exception err)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Logout()
        {
            try
            {
                Session["user"] = null;
                Session["token"] = null;
                return RedirectToAction("Index", "Login");
            }
            catch(Exception err)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult DownOwnerEBook(string fileName)
        {
            try
            {
                Account acc = (Account)Session["user"];
                if (acc != null)
                {
                    //string token = (string)Session["token"];
                    string url = RequestService.sendReqDownloadEbookOwner(fileName);
                    return Redirect(url);
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            catch (Exception err)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}