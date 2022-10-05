using Leads.Domain.Interfaces.Repositories;
using Leads.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Leads.Infra.CrossCutting.IoC
{
    public static class Injection
    {
        public static void AddInjection(this IServiceCollection service)
        {
            service.AddScoped<ILeadRepository, LeadRepository>();
        }
    }
}
