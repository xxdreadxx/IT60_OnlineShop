using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT60_OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChiTietSanPham()
        {
            return View();
        }

        public ActionResult DanhMuc()
        {
            return View();
        }
        public ActionResult GioHang()
        {
            return View();
        }

        public ActionResult DatHang()
        {
            return View();
        }
    }
}