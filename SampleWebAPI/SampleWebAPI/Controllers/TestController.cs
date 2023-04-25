using Microsoft.AspNetCore.Mvc;
using SampleBLClass;
using SampleModel;

namespace SampleWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IClass1 _class;
        public TestController(IClass1 cls)
        {
            _class = cls;
        }

        [HttpGet, Route("ping-server/{name}")]
        public IActionResult PingServer(string name)
        {

            var test = _class.Return1(name);
            return Ok(test);
        }

        [HttpPost, Route("post-request-sample")]
        public IActionResult PostRequestSample(Class1Model request)
        {

            var test = _class.ReturnClassModel(request);
            return Ok(test);
        }

        [HttpGet, Route("get-single-data/{id}")]
        public IActionResult GetSingleData(int id)
        {

            var test = _class.GetSingleData(id);
            return Ok(test);
        }

        [HttpGet, Route("get-all-data")]
        public IActionResult GetAllData()
        {

            var test = _class.GetAllData();
            return Ok(test);
        }
    }
}
