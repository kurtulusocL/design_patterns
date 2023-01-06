using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.mediatR.Results.LocationResults
{
    public class GetLocationByIdQueryResult
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
