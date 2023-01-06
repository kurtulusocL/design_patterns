using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.CQRS.Results.ProductResults
{
    public class GetProductByIdQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int UnitInStock { get; set; }
        public int Tax { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
