using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCWebAPIWithoutDb.Entities;
using System.Net;
using MVCWebAPIWithoutDb.Helper;

namespace MVCWebAPIWithoutDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BootCampApiController : ControllerBase
    {
        //Bootcampapi için methodlarımı tanımladım.
        IBootcampService _bootcampService;
        public BootCampApiController(IBootcampService bootcampService)
        {
            _bootcampService = bootcampService;
        }
        [HttpGet]
        public IActionResult GetBootCamp()
        {
            var response = _bootcampService.GetBootcampList();
            return StatusCode((int)HttpStatusCode.OK, response);
        }

        [HttpPost]
        public IActionResult AddBootCamp()
        {
            var response = _bootcampService.GetBootcampList();
            return StatusCode((int)HttpStatusCode.OK, response);
        }

        [HttpDelete]
        public IActionResult RemoveBootCamp()
        {
            var response = _bootcampService.GetBootcampList();
            return StatusCode((int)HttpStatusCode.OK, response);
        }

        //[HttpPut("{id}")]
        //public IActionResult Update(int id, Issue issue)
        //{
        //    var response = _bootcampService.GetBootcampList();
        //    return StatusCode((int)HttpStatusCode.OK, response);
        //}
    }
}