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
        IParticipantService _participantService;

        public AdminApiController(IBootcampService boottCampService, IParticipantService participantService)
        {
            _boottCampService = boottCampService;
            _participantService = participantService;
        }

        [HttpPost]
        public IActionResult AddBootCamp(BootcampEntity entity)
        {
            _boottCampService.AddBootCamp(entity);
            return StatusCode((int)HttpStatusCode.OK, entity);
        }


        [HttpGet(template: "get_participant")]
        public IActionResult GetParticipant()
        {
            var response = _participantService.GetParticipantList();
            return StatusCode((int)HttpStatusCode.OK, response);
        }

        [HttpDelete]
        public IActionResult RemoveBootCamp(int Id)
        {
            var bootCamp = _boottCampService.GetBootcampList();
            var bootId = bootCamp.FirstOrDefault(x => x.Id == Id);
            bootCamp.Remove(bootId);
            return StatusCode((int)HttpStatusCode.OK);
        }


        [HttpDelete(template: "remove_participant")]
        public IActionResult RemoveParticipant(int Id)
        {
            var participant = _participantService.GetParticipantList();
            var participantId = participant.FirstOrDefault(x => x.Id == Id);
            participant.Remove(participantId);
            return StatusCode((int)HttpStatusCode.OK, participantId);
        }

    }
}