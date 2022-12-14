using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Commands.ProductCommands;
using UpSchool_CQRS_Projects.CQRS.Handler.ProductHandlers;
using UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries;

namespace UpSchool_CQRS_Projects.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductAccounterQueryHandler _getProductAccounterQueryHandler;
        private readonly GetProductstoragerQueryHandler _getProductStoragerQueryHandler;
        private readonly GetProductHumanResourceByIdQueryHandler _getProductHumanResourceByIdQueryHandler;
        private readonly GetProductAccounterByIdQueryHandler _getProductAccounterByIdQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;

        public ProductController(GetProductAccounterQueryHandler getProductAccounterQueryHandler, GetProductstoragerQueryHandler getProductStoragerQueryHandler, GetProductHumanResourceByIdQueryHandler getProductHumanResourceByIdQueryHandler, GetProductAccounterByIdQueryHandler getProductAccounterByIdQueryHandler, CreateProductCommandHandler createProductCommandHandler)
        {
            _getProductAccounterQueryHandler = getProductAccounterQueryHandler;
            _getProductStoragerQueryHandler = getProductStoragerQueryHandler;
            _getProductHumanResourceByIdQueryHandler = getProductHumanResourceByIdQueryHandler;
            _getProductAccounterByIdQueryHandler = getProductAccounterByIdQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductAccounterQueryHandler.Handle();
            return View(values);
        }

        public IActionResult StorgerIndex()
        {
            var values =_getProductStoragerQueryHandler.Handle();
            return View(values);
        }

        public IActionResult GetHumanResourceIndex(int id)
        {
            var values = _getProductHumanResourceByIdQueryHandler.Handle(new GetProductHumanResourceByIdQuery(id));
            return View(values);
        }

        public IActionResult AccounterIndexByID(int id) 
        {
            var values = _getProductAccounterByIdQueryHandler.Handle(new GetProductAcounterByIdQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
