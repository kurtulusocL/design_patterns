using CQRSPattern.CQRS.mediatR.Commands.LocationCommands;
using CQRSPattern.DataAccess.Concrete.EntityFramework.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.mediatR.Handlers.LocationHandlers
{
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand>
    {
        private readonly ApplicationDbContext _context;
        public UpdateLocationCommandHandler()
        {
            _context = new ApplicationDbContext();
        }
        public async Task<Unit> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Locations.FindAsync(request.Id);
            value.City = request.City;
            value.Province = request.Province;
            value.Country = request.Country;
            value.Continental = request.Continental;

            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
