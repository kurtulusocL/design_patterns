using CQRSPattern.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Entities.Concrete
{
    public class Location : BaseEntity
    {
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Continental{ get; set; }
    }
}
