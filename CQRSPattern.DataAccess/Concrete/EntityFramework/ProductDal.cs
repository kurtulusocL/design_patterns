using CQRSPattern.Core.DataAccess.EntityFramework;
using CQRSPattern.DataAccess.Abstract;
using CQRSPattern.DataAccess.Concrete.EntityFramework.Context;
using CQRSPattern.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.DataAccess.Concrete.EntityFramework
{
    public class ProductDal : EntityRepositoryBase<Product, ApplicationDbContext>, IProductDal
    {
    }
}
