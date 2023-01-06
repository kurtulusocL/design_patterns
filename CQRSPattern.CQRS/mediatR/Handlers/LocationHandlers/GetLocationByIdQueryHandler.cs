using CQRSPattern.CQRS.mediatR.Queries.LocationQueries;
using CQRSPattern.CQRS.mediatR.Results.LocationResults;
using CQRSPattern.DataAccess.Concrete.EntityFramework.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.mediatR.Handlers.LocationHandlers
{
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly ApplicationDbContext _context;
        public GetLocationByIdQueryHandler()
        {
            _context = new ApplicationDbContext();
        }
        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Locations.FindAsync(request.id);
            return new GetLocationByIdQueryResult
            {
                Id = value.Id,
                City = value.City,
                Country = value.Country
            };
        }
    }
}
