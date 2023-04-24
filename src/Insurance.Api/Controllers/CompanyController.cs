using Insurance.Application.UseCases.Admin.Commands;
using Insurance.Application.UseCases.Admin.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Insurance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCompanyCommand command)
        {
            var responce = await _mediator.Send(command);

            return Ok(responce);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCompanyCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var companies = await _mediator.Send(new GetAllCompaniesQuery());

            return Ok(companies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] long id)
        {
            var company = await _mediator.Send(new GetByIdCompanyQuery { Id = id });

            return Ok(company);
        }

    }
}
