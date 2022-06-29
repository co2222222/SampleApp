using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleClassController : ControllerBase
    {
        [HttpGet]
        [Route("GetSampleClass/{start:int}/{end:int}")]
        public string GetSampleClass(int start, int end)
        {
            SampleClass sc = new SampleClass();
            sc.StartRange = start;
            sc.EndRange = end;
            sc.GetResult();
            string json = JsonConvert.SerializeObject(sc);

            return json;
        }
    }

}