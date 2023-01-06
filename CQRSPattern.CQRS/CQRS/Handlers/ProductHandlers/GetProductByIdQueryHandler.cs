using CQRSPattern.CQRS.CQRS.Quieries;
using CQRSPattern.CQRS.CQRS.Results.ProductResults;
using CQRSPattern.DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.CQRS.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly ApplicationDbContext _contex;
        public GetProductByIdQueryHandler()
        {
            _contex = new ApplicationDbContext();
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var value = _contex.Products.Find(query.id);
            return new GetProductByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                Description = value.Description,
                PurchasePrice = value.PurchasePrice,
                SalePrice = value.SalePrice,
                Tax = value.Tax,
                UnitInStock = value.UnitInStock,
                CreatedDate = value.CreatedDate
            };
        }
    }
}
