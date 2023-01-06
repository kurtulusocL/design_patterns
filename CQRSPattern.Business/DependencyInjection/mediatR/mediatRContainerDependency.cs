using CQRSPattern.CQRS.mediatR.Handlers.LocationHandlers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Business.DependencyInjection.mediatR
{
    public static class mediatRContainerDependency
    {
        public static void mediatRContainerDependencies(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllLocationQueryHandler));
            services.AddTransient<GetAllLocationQueryHandler>();

            services.AddMediatR(typeof(GetLocationByIdQueryHandler));
            services.AddTransient<GetLocationByIdQueryHandler>();

            services.AddMediatR(typeof(CreateLocationCommandHandler));
            services.AddTransient<CreateLocationCommandHandler>();

            services.AddMediatR(typeof(GetLocationByIdForUpdateQueryHandler));
            services.AddTransient<GetLocationByIdForUpdateQueryHandler>();

            services.AddMediatR(typeof(UpdateLocationCommandHandler));
            services.AddTransient<UpdateLocationCommandHandler>();

            services.AddMediatR(typeof(DeleteLocationCommandHandler));
            services.AddTransient<DeleteLocationCommandHandler>();
        }
    }
}
