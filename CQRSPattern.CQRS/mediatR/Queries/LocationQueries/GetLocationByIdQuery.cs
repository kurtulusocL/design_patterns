using CQRSPattern.CQRS.mediatR.Results.LocationResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.mediatR.Queries.LocationQueries
{
    public class GetLocationByIdQuery:IRequest<GetLocationByIdQueryResult>
    {
        public int id { get; set; }
        public GetLocationByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
