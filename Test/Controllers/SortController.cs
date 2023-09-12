using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Test.Service;

namespace Test.Controllers
{
    [ApiController]
    public class SortController : ControllerBase
    {
        private readonly ISortArray<int> service;
        public SortController(ISortArray<int> _service)
        {
            this.service = _service;
        }

        [HttpPost]
        [Route("api/sort-array")]
        public IActionResult SortingArray([FromBody]int[] arr)
        {
            try
            {
                return Ok(new { SortedArray = service.ArraySorter(arr) });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
