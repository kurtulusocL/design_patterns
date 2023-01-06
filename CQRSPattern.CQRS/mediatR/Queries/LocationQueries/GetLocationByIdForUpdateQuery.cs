using CQRSPattern.CQRS.mediatR.Results.LocationResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.mediatR.Queries.LocationQueries
{
    public class GetLocationByIdForUpdateQuery:IRequest<GetLocationByIdForUpdate>
    {
        public int id { get; set; }
        public GetLocationByIdForUpdateQuery(int id)
        {
            this.id = id;
        }
    }
}
