using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpFishUtil;

namespace ListifyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListifyController : ControllerBase
    {
        public ListifyController()
        {

        }

        [HttpGet]
        public IActionResult Get(int start, int end, int index)
        {
            var myList = new ListiFy(start, end);

            return Ok(myList[index]);
        }
    }
}