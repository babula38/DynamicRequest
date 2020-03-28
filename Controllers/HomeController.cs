using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRequest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok();

        [HttpPost]
        public void Post(dynamic request)
        {
            //json request
            //{
            // "Foo":"Value"
            //}
            var expected = request.Foo;
            //expected should contain the value for Foo.
            //But the object structure is different
        }

    }
}
