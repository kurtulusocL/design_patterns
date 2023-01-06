using CQRSPattern.CQRS.mediatR.Commands.LocationCommands;
using CQRSPattern.DataAccess.Concrete.EntityFramework.Context;
using CQRSPattern.Entities.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.mediatR.Handlers.LocationHandlers
{
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand>
    {
        private readonly ApplicationDbContext _context;
        public CreateLocationCommandHandler()
        {
            _context = new ApplicationDbContext();
        }
        public async Task<Unit> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            _context.Locations.Add(new Location
            {
                City = request.City,
                Province = request.Province,
                Country = request.Country,
                Continental = request.Continental,
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
