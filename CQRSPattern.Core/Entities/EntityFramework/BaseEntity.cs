using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Core.Entities.EntityFramework
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id{ get; set; }
        public DateTime CreatedDate { get; set; }

        public void SetCreatedDate()
        {
            CreatedDate= DateTime.Now.ToLocalTime();
        }
        public BaseEntity()
        {
            SetCreatedDate();
        }
    }
}
