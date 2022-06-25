using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCWebAPIWithoutDb.Helper;
using System.Net;

namespace MVCWebAPIWithoutDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminApiController : ControllerBase
    {

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

        //[HttpGet("id")]
        //public async Task<IActionResult< GetByID(int id)
        //{
        //    var responce = await _context.BootcampServise.FindAsync(id);
        //    return responce == null ? NotFound() : Ok(responce);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create()
        //{
        //    await _context.DictionaryHelper


        //}


    }
}