using SC601_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SC601_MVC.Controllers
{
    public class BrandController : Controller
    {
        static IList<Brand> brands = new List<Brand>
        {
            new Brand(){ brand_id=1,brand_Name="FOX"},
            new Brand(){ brand_id=2,brand_Name="SAFARI"},
            new Brand(){ brand_id=3,brand_Name="IRONMAN"},
            new Brand(){ brand_id=4,brand_Name="TJM"},
            new Brand(){ brand_id=5,brand_Name="PROFENDER"}
        };


        // GET: Brand
        public ActionResult Index()
        {
            return View(brands);
        }

        // Edit: Brand

        public ActionResult Edit(int id)
        {
            var newBrand = brands.Where(b => b.brand_id == id).FirstOrDefault();

            return View(newBrand);
        }

        //Delete: Brand
        public ActionResult Delete(int id)
        {
            var newBrand = brands.Where(b => b.brand_id == id).FirstOrDefault();

            return View(newBrand);
        }

        //Details: Brand
        public ActionResult Details(int id)
        {
            var newBrand = brands.Where(b => b.brand_id == id).FirstOrDefault();

            return View(newBrand);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Edit(Brand brand)
        {
            var editBrand = brands.Where(b => b.brand_id == brand.brand_id).FirstOrDefault();
            brands.Remove(editBrand);
            brands.Add(brand);
            return RedirectToAction("Index");
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var deleteBrand = brands.Where(b => b.brand_id == id).FirstOrDefault();
            brands.Remove(deleteBrand);
            return RedirectToAction("Index");
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateConfirmed(Brand brand)
        {
            var createBrand = brands.Where(b => b.brand_id == brand.brand_id).FirstOrDefault();
            if (createBrand != null)
            {
                TempData["Message"] = "Brand already exists";

            }
            else
            {
                brands.Add(brand);
                return RedirectToAction("Index");

            }
            return View();
        }
    }
}