using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using MyTMS.Domain.Interfaces.Service;
using MyTMS.Domain.Dto;
using MyTMS.Api.Models.Project;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyTMS.Api.Controllers
{
    [Route("api/[controller]")]
    public class PartnerController : Controller
    {
        private readonly IMediator _mediator;

        public PartnerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<PartnerDto>> GetAsync()
        {
            return await _mediator.Send(new PartnerQuery());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<PartnerDto>> GetAsync(string name)
        {
            return await _mediator.Send(new PartnerQuery { SearchName = name });
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]PartnerCreateCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
