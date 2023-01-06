using CQRSPattern.CQRS.CQRS.Commands.ProductCommands;
using CQRSPattern.DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.CQRS.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly ApplicationDbContext _context;
        public UpdateProductCommandHandler()
        {
            _context = new ApplicationDbContext();
        }
        public void Handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.Id);
            value.Name=command.Name;
            value.Description  =command.Description;
            value.PurchasePrice = command.PurchasePrice;
            value.SalePrice = command.SalePrice;
            value.Tax =command.Tax;
            value.UnitInStock= command.UnitInStock;

            _context.SaveChanges();
        }
    }
}
