using CQRSPattern.CQRS.mediatR.Queries.LocationQueries;
using CQRSPattern.CQRS.mediatR.Results.LocationResults;
using CQRSPattern.DataAccess.Concrete.EntityFramework.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.mediatR.Handlers.LocationHandlers
{
    public class GetAllLocationQueryHandler : IRequestHandler<GetAllLocationQuery, List<GetAllLocationQueryResult>>
    {
        private readonly ApplicationDbContext _context;
        public GetAllLocationQueryHandler()
        {
            _context = new ApplicationDbContext();
        }

        public async Task<List<GetAllLocationQueryResult>> Handle(GetAllLocationQuery request, CancellationToken cancellationToken)
        {
            return await _context.Locations.Select(i => new GetAllLocationQueryResult
            {
                Id = i.Id,
                City = i.City,
                Province = i.Province,
                Country = i.Country,
                Continental = i.Continental,
                CreatedDate=i.CreatedDate
            }).AsNoTracking().ToListAsync();
        }
    }
}
