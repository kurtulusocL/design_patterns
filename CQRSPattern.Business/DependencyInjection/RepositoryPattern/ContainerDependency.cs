using CQRSPattern.Business.Abstract;
using CQRSPattern.Business.Concrete;
using CQRSPattern.DataAccess.Abstract;
using CQRSPattern.DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Business.DependencyInjection.RepositoryPattern
{
    public static class ContainerDependency
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductDal, ProductDal>();
            services.AddScoped<IProductService, ProductManager>();
        }
    }
}
