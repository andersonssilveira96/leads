using Leads.Domain.Entities;
using Leads.Domain.Interfaces.Repositories;
using Leads.Infra.Data.Context;

namespace Leads.Infra.Data.Repositories
{
    public class LeadRepository : Repository<Lead>, ILeadRepository
    {
        public LeadRepository(LeadContext context) : base(context)
        {
        }
    }
}
