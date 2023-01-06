using CQRSPattern.CQRS.CQRS.Commands.ProductCommands;
using CQRSPattern.CQRS.CQRS.Handlers.ProductHandlers;
using CQRSPattern.CQRS.CQRS.Quieries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPattern.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetAllProductQueryHandler _getAllProductQueryHandler;
        private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly DeleteProductCommandHandler _deleteProductCommandHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;
        private readonly GetProductByIdForEditQueryHandler _getProductByIdForEditQueryHandler;
        public ProductController(GetAllProductQueryHandler getAllProductQueryHandler, GetProductByIdQueryHandler getProductByIdQueryHandler, CreateProductCommandHandler createProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler, UpdateProductCommandHandler updateProductCommandHandler, GetProductByIdForEditQueryHandler getProductByIdForEditQueryHandler)
        {
            _getAllProductQueryHandler = getAllProductQueryHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
            _getProductByIdForEditQueryHandler= getProductByIdForEditQueryHandler;
        }
        public IActionResult Index()
        {
            return View(_getAllProductQueryHandler.Handle());
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            return View(_getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id)));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateProductCommand command)
        {
            if (ModelState.IsValid)
            {
                _createProductCommandHandler.Handle(command);
                return RedirectToAction(nameof(Index));
            }
            TempData["error"] = "Mistake";
            return RedirectToAction(nameof(Create));
        }       
        public IActionResult Edit(int id)
        {
            return View(_getProductByIdForEditQueryHandler.Handle(new GetProductByIdForEditQuery(id)));
        }

        [HttpPost]
        public IActionResult Edit(UpdateProductCommand command)
        {
            if (ModelState.IsValid)
            {
                _updateProductCommandHandler.Handle(command);
                return RedirectToAction(nameof(Index));
            }
            TempData["error"] = "Mistake";
            return RedirectToAction(nameof(Detail), new { id = command.Id });
        }
        public IActionResult Delete(int id)
        {
            _deleteProductCommandHandler.Handle(new DeleteProductCommand(id));
            return RedirectToAction(nameof(Index));
        }
    }
}
