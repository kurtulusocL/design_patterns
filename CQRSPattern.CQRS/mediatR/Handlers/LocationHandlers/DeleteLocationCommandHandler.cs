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
    public class DeleteLocationCommandHandler : IRequestHandler<DeleteLocationCommand>
    {
        private readonly ApplicationDbContext _context;
        public DeleteLocationCommandHandler()
        {
            _context = new ApplicationDbContext();
        }
        public async Task<Unit> Handle(DeleteLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Locations.FindAsync(request.id);
            _context.Locations.Remove(value);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
