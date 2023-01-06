using CQRSPattern.CQRS.CQRS.Handlers.ProductHandlers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Business.DependencyInjection.CQRS
{
    public static class CQRSContainerDependency
    {
        public static void CQRSContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<GetAllProductQueryHandler>();
            services.AddScoped<GetProductByIdQueryHandler>();
            services.AddScoped<CreateProductCommandHandler>();
            services.AddScoped<UpdateProductCommandHandler>();
            services.AddScoped<DeleteProductCommandHandler>();
            services.AddScoped<GetProductByIdForEditQueryHandler>();
        }
    }
}
