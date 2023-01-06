using CQRSPattern.CQRS.CQRS.Commands.ProductCommands;
using CQRSPattern.DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.CQRS.Handlers.ProductHandlers
{
    public class DeleteProductCommandHandler
    {
        private readonly ApplicationDbContext _context;
        public DeleteProductCommandHandler()
        {
            _context = new ApplicationDbContext();
        }
        public void Handle(DeleteProductCommand command)
        {
            var value = _context.Products.Find(command.id);
            _context.Products.Remove(value);
            _context.SaveChanges();
        }
    }
}
