
using Cepdi.Business.Jwt;
using Cepdi.Business.Medicines;
using Cepdi.Business.Pharmacies;
using Cepdi.Business.Users;
using Cepdi.Data.Medicines;
using Cepdi.Data.Pharmacy;
using Cepdi.Data.Users;
using Cepdi.Models.Interfaces.Medicines;
using Cepdi.Models.Interfaces.Pharmacies;
using Cepdi.Models.Interfaces.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Cepdi.WebApi.Extensions
{
    public static class ConfigureDependecies
    {
        public static void ConfigureDependencies(this IServiceCollection services) {
            
            services.AddScoped<IMedicinesData, MedicinesData>();
            services.AddScoped<IMedicinesBusiness, MedicinesBussines>();
            services.AddScoped<IPharmaciesData, PharmaciesData>();
            services.AddScoped<IPharmaciesBussines, PharmaciesBussines>();
            services.AddScoped<IUsersData, UsersData>();
            services.AddScoped<IUsersBusiness, UsersBussines>();
            services.AddSingleton<TokenService>();
        }
    }
}
