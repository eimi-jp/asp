using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Tx1.Models;

namespace Tx1.Controllers
{
    public class SanPhamController : Controller
    {
        List<Sanpham> sanpham;

        public SanPhamController()
        {
            sanpham = new List<Sanpham>()
            {
                new Sanpham("sp1", "Apple", "Iphone X", 20, 200),
                new Sanpham("sp2", "Xiaomi", "Xiaomi Ultra 15", 10, 500),
                new Sanpham("sp3", "Apple", "Apple", 30, 320),
                new Sanpham("sp4", "Apple", "Iphone 15", 40, 300),
                new Sanpham("sp5", "Xiaomi", "Xiaomi 14 pro", 10, 200),
                new Sanpham("sp6", "Xiaomi", "Iphone 15 pro", 15, 250),
            };
        }

        // GET: SanPham
        public ActionResult Index()
        {
            ViewBag.ds1 = sanpham.Where(s => s.giatien >= 250).ToList();
            ViewBag.ds2 = sanpham.Where(s => s.hangsx == "Xiaomi").ToList();

            return View();
        }

        [HttpGet]
        public ActionResult Input()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Output(Sanpham sp)
        {
            return View(sp);
        }
    }
}