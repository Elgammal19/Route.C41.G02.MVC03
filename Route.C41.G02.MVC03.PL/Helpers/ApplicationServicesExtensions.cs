﻿using Microsoft.Extensions.DependencyInjection;
using Route.C41.G02.BLL;
using Route.C41.G02.BLL.Interfaces;
using Route.C41.G02.BLL.Repositories;

namespace Route.C41.G02.MVC03.PL.Helpers
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            ///services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            ///services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}