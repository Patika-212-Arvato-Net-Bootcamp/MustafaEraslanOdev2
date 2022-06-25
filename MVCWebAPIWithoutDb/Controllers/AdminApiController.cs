using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCWebAPIWithoutDb.Entities;
using MVCWebAPIWithoutDb.Helper;
using System.Net;

namespace MVCWebAPIWithoutDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminApiController : ControllerBase
    {
        //Admin api için methodlarımı burada tanımladım.
        IBootcampService _boottCampService;

        public AdminApiController(IBootcampService boottCampService)
        {
            _boottCampService = boottCampService;
        }

        [HttpPost]
        public IActionResult AddBootCamp(BootcampEntity entity)
        {
            _boottCampService.AddBootCamp(entity);
            return StatusCode((int)HttpStatusCode.OK, entity);
        }

        [HttpDelete]
        public IActionResult RemoveBootCamp(int Id)
        {
            var bootCamp = _boottCampService.GetBootcampList();
            var bootId = bootCamp.FirstOrDefault(x => x.Id == Id);
            bootCamp.Remove(bootId);
            return StatusCode((int)HttpStatusCode.OK);
        }




    }
}