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
        IParticipantService _participantService;

        public BootCampApiController(IBootcampService bootcampService, IParticipantService participantService)
        {
            _bootcampService = bootcampService;
            _participantService = participantService;
        }

        [HttpGet("{id}")]
        public BootcampEntity GetById(int id)
        {
            var bootCamp = _bootcampService.GetBootcampList();
            return bootCamp.Where(x => x.Id == id).SingleOrDefault();
        }
        //Bootcampapi için methodlarımı tanımladım.
        

        
        [HttpGet]
        public IActionResult GetBootCamp()
        {
            var response = _bootcampService.GetBootcampList();
            return StatusCode((int)HttpStatusCode.OK, response);
        }

        [HttpPost(template: "add_participant")]
        public IActionResult AddParticipant(ParticipantEntity entity)
        {
            _participantService.AddParticipant(entity);
            return StatusCode((int)HttpStatusCode.OK, entity);
        }




    }
}