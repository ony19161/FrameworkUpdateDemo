using DotNetCoreRestAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        private readonly ICounterRepository counterRepository;

        public CounterController(ICounterRepository counterRepository)
        {
            this.counterRepository = counterRepository;
        }


        [HttpGet(Name = "GetCount")]
        public IActionResult Get()
        {
            return Ok(this.counterRepository.GetCount());
        }


    }
}
