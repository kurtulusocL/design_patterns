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
    public class GetLocationByIdForUpdateQueryHandler : IRequestHandler<GetLocationByIdForUpdateQuery, GetLocationByIdForUpdate>
    {
        private readonly ApplicationDbContext _context;
        public GetLocationByIdForUpdateQueryHandler()
        {
            _context=new ApplicationDbContext();
        }
        public async Task<GetLocationByIdForUpdate> Handle(GetLocationByIdForUpdateQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Locations.FindAsync(request.id);
            return new GetLocationByIdForUpdate
            {
                Id = value.Id,
                City = value.City,
                Province = value.Province,
                Country = value.Country,
                Continental = value.Continental
            };          
        }
    }
}
