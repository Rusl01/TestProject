using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumArrayController : ControllerBase
    {
        [HttpPost]
        public int GetArray(int[] array)
        {
            int sum = 0;
            int count = 0;

            for (int i = 1; i < array.Length; i += 1)
                if (array[i] % 2 != 0)
                {
                    count++;
                    if (count == 2)
                    {
                        sum += array[i];
                        count = 0;
                    }
                }

            return sum;
        }
    }
}
