using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalindromController : ControllerBase
    {
        [HttpPost]
        public bool GetString(string Input)
        {
            Input = Input.Replace(" ", "").ToLower();

            for (int i = 0; i < Input.Length / 2; i++)
                if (Input[i] != Input[Input.Length - i - 1])
                    return false;

            return true;
        }
    }
}
