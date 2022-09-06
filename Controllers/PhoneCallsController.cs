using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace EbossApp.Controllers
{
    [Route("/phone")]
    [ApiController]
    public class PhoneCallsController : ControllerBase
    {
        [HttpPost("")]
        public IActionResult Post()
        {
            try
            {
                foreach (var header in Request.Headers)
                {
                    Console.WriteLine($"{header.Key}={header.Value}");
                }

                return new ContentResult
                {
                    ContentType = "text/xml",
                    Content =
                        $"<Response><Start><Stream url='ws://{Request.Headers.Origin}' /></Start><Say>Hafiz Rahman Sir, I will stream for 60 seconds</Say><Pause length='60' /></Response>",
                    StatusCode = 200
                };
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
