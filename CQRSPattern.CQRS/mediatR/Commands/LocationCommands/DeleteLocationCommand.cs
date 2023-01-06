using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.mediatR.Commands.LocationCommands
{
    public class DeleteLocationCommand : IRequest
    {
        public int id { get; set; }
        public DeleteLocationCommand(int id)
        {
            this.id = id;
        }
    }
}
