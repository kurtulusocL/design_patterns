using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.CQRS.Quieries
{
    public class GetProductByIdQuery
    {
        public int id { get; set; }

        public GetProductByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
