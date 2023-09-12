using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Service;

namespace Test.Controllers
{
    [ApiController]
    public class PalindromController : ControllerBase
    {
        private readonly IPalindrom service;
        public PalindromController(IPalindrom _service) 
        {
            service = _service;
        }

        [HttpPost]
        [Route("api/Polindrom")]
        public IActionResult GetString([FromBody]string Input)
        {
            try
            {
               return Ok(new { GetString = service.ChekPolindrom(Input) });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
