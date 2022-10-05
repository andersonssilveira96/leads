using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Leads.API.Controllers
{
    public class LeadController : Controller
    {
        private readonly IMediator _mediator;
        public LeadController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
