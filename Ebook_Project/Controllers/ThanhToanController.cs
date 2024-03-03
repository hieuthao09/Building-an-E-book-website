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
    public class ThanhToanController : Controller
    {
        // GET: GioHang
        public ActionResult GioHang()
        {
            Account acc = (Account)Session["user"];
            if(acc != null)
            {
                string token = (string)Session["token"];
                var res = RequestService.sendReqGetListGioHang(acc.Email, token);

                JObject json = JObject.Parse(res);
                if (json["statusCode"].Value<int>().Equals(0))
                {
                    if (json["ListBooksOrder"].ToString() != null)
                    {
                        List<SachDTO> sach = JsonConvert.DeserializeObject<List<SachDTO>>(json["ListBooksOrder"].ToString());
                        if(sach.Count > 0)
                        {
                            ViewBag.tong = long.Parse(sach.Sum(t => t.GIABAN).ToString("00"));
                            return View(sach);
                        }
                        else
                        {
                            ViewBag.tong = 0;
                            return View(sach);
                        }
                    }
                }
                else if (json["statusCode"].Value<int>().Equals(-1))
                {
                    ViewBag.tong = 0;

                    List<SachDTO> sach = null;
                    return View(sach);
                }
                else
                {
                    return View("Index","Error");
                }
            }
            return RedirectToAction("Index","Login");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToCart(string maSach)
        {
            Account acc = (Account)Session["user"];
            if (acc != null)
            {
                string token = (string)Session["token"];
                var res = RequestService.sendReqAddToCart(acc.Email, maSach, token);

                JObject json = JObject.Parse(res);
                if (json["statusCode"].Value<int>().Equals(0) || json["statusCode"].Value<int>().Equals(1))
                    return RedirectToAction("GioHang", "ThanhToan");
                else
                {
                    return RedirectToAction("Index", "Error");
                }
            }
            else
                return RedirectToAction("Index", "Login");
        }

        public ActionResult ConfirmPay()
        {
            Account acc = (Account)Session["user"];
            if(acc != null)
            {
                string token = (string)Session["token"];
                var res = RequestService.sendReqConfirmPay(acc.Email, token);

                JObject json = JObject.Parse(res);

                if (json["statusCode"].Value<int>().Equals(0))
                {
                    ViewBag.mess = "success";
                    return View();
                }
                else
                {
                    ViewBag.mess = "fail";
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult RemoveItemFromCart(string SachId)
        {
            Account acc = (Account)Session["user"];
            if(acc != null)
            {
                string token = (string)Session["token"];
                var res = RequestService.sendReqRemoveItemFromCart(SachId, acc.Email, token);
                return RedirectToAction("GioHang", "ThanhToan");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}