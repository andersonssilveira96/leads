using Leads.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Leads.Infra.Data.Context
{
    public class LeadContext : DbContext
    {
        public LeadContext(DbContextOptions<LeadContext> options) : base(options)
        {
        }

        public DbSet<Lead> Leads { get; set; }
    }
}
