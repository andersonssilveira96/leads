using Leads.Domain.Enums;
using Leads.SharedKernel.ValueObjects;

namespace Leads.Domain.Entities
{
    public class Lead
    {
        public Lead()
        {

        }

        public int Id { get; private set; }
        public string ContactFirstName { get; private set; }
        public string ContactLastName { get; private set; }
        public string ContactPhoneNumber { get; private set; }
        public Email ContactEmail { get; private set; }
        public DateTime DateCreated { get; private set; }
        public Status Status { get; private set; }
        public string Suburb { get; private set; }
        public Category Category { get; private set; }
        public string Description { get; private set; }
        public string Price { get; private set; }
    }
}
