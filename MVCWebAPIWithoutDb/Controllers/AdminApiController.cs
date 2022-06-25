using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCWebAPIWithoutDb.Helper;
using System.Net;

namespace MVCWebAPIWithoutDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminApiController : ControllerBase
    { //Admin api için methodlarımı burada tanımladım.

        [HttpGet]
        public IActionResult GetBootCamp()
        {
            var response = DictionaryHelper.GetList();
            return StatusCode((int)HttpStatusCode.OK, response);
        }

        [HttpPost]
        public IActionResult AddBootCamp()
        {
            var response = DictionaryHelper.GetList();
            return StatusCode((int)HttpStatusCode.OK, response);
        }

        [HttpDelete]
        public IActionResult RemoveBootCamp(Guid Id)
        {
            var response = DictionaryHelper.GetList();
            return StatusCode((int)HttpStatusCode.OK, response);
        }




    }
}