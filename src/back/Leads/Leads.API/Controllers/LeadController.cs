using Leads.Domain.Interfaces.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leads.API.Controllers
{
    [Route("lead")]
    public class LeadController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILeadRepository _leadRepository;
        public LeadController(IMediator mediator, ILeadRepository leadRepository)
        {
            _mediator = mediator;
            _leadRepository = leadRepository;
        }
        public IActionResult Index()
        {
            return Ok(_leadRepository.GetAll());
        }
    }
}
