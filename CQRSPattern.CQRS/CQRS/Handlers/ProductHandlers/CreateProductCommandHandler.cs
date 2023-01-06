using CQRSPattern.CQRS.CQRS.Commands.ProductCommands;
using CQRSPattern.DataAccess.Concrete.EntityFramework.Context;
using CQRSPattern.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly ApplicationDbContext _context;
        public CreateProductCommandHandler()
        {
            _context = new ApplicationDbContext();
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                Name = command.Name,
                Description = command.Description,
                PurchasePrice = command.PurchasePrice,
                SalePrice = command.SalePrice,
                UnitInStock = command.UnitInStock,
                Tax = command.Tax,
                //CreatedDate=command.CreatedDate
            });;
            _context.SaveChanges();
        }
    }
}
