using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.mediatR.Commands.LocationCommands
{
    public class UpdateLocationCommand : IRequest
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Continental { get; set; }
    }
}
