using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Core.Entities
{
    public interface IEntity
    {
        void SetCreatedDate();
    }
}
