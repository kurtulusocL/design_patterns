using CQRSPattern.CQRS.CQRS.Results.ProductResults;
using CQRSPattern.DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.CQRS.Handlers.ProductHandlers
{
    public class GetAllProductQueryHandler
    {
        private readonly ApplicationDbContext _context;
        public GetAllProductQueryHandler()
        {
            _context = new ApplicationDbContext();
        }
        public List<GetAllProductQueryResult> Handle()
        {
            var values = _context.Products.Select(i => new GetAllProductQueryResult
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description,
                UnitInStock = i.UnitInStock,
                SalePrice = i.SalePrice
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
