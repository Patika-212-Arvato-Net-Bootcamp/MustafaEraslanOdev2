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
        IBootcampService _bootcampService;

        public BootCampApiController(IBootcampService bootcampService)
        {
            _bootcampService = bootcampService;
        }

        [HttpGet("{id}")]
        public BootcampEntity GetById(int Id)
        {
            var bootCamp = _bootcampService.GetBootcampList();
            return bootCamp.Where(x => x.Id == Id).SingleOrDefault();
        }
        //Bootcampapi için methodlarımı tanımladım.
        

        
        [HttpGet]
        public IActionResult GetBootCamp()
        {
            var response = _bootcampService.GetBootcampList();
            return StatusCode((int)HttpStatusCode.OK, response);
        }




    }
}