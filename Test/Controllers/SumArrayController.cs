using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Service;

namespace Test.Controllers
{
    [ApiController]
    public class SumArrayController : ControllerBase
    {
        private readonly ISumArray service;

        public SumArrayController(ISumArray service)
        {
            this.service = service;
        }

        [Route("api/sum-array")]
        [HttpPost]
        public IActionResult GetArray([FromBody]int[] array)
        {
            try
            {
                return Ok( new { SumArray = service.GetSumArray(array) });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
