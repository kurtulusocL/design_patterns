using CQRSPattern.Business.Abstract;
using CQRSPattern.Entities.Concrete;
using CQRSPattern.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CQRSPattern.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }
        public IActionResult Detail(int id)
        {
            return View(_productService.GetById(id));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                var success = _productService.Create(model);
                if (success)
                {
                    TempData["success"] = "Added";
                    return RedirectToAction(nameof(Create));
                }
                else
                {
                    TempData["error"] = "Mistake";
                    return RedirectToAction(nameof(Create));
                }
            }
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Edit(int id)
        {
            var updateProduct = _productService.GetById(id);
            if (updateProduct != null)
            {
                return View(updateProduct);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product model)
        {
            if (ModelState.IsValid)
            {
                var success = _productService.Update(model);
                if (success)
                {
                    TempData["success"] = "Updated";
                    return RedirectToAction(nameof(Edit), new { id = model.Id });
                }
                else
                {
                    TempData["error"] = "Mistake";
                    return RedirectToAction(nameof(Edit), new { id = model.Id });
                }
            }
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Delete(int id)
        {
            var deleteProduct= _productService.GetById(id);
            if (deleteProduct!=null)
            {
                var success = _productService.Delete(deleteProduct);
                if (success)
                {
                    TempData["success"] = "Deleted";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["error"] = "Mistake";
                    return RedirectToAction(nameof(Index));
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}