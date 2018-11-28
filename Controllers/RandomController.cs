using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace k8sfirstapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return $"{{ randomGuid: {Guid.NewGuid().ToString()} }}";
        }
    }
}
