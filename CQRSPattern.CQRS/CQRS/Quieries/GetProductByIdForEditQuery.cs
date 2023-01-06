using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.CQRS.Quieries
{
    public class GetProductByIdForEditQuery
    {
        public int id { get; set; }

        public GetProductByIdForEditQuery(int id)
        {
            this.id = id;
        }
    }
}
