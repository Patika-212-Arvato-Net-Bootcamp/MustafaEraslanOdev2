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
        //private readonly DataContext _context;

        //public BootCampApiController(DataContext context)
        //{
        //    _context = context;
        //}
        //private static List<IBootcampService> bootcamp = new List<BootcampService>
        //{
        //    new BootcampEntity
        //    {
        //        Id ,
        //        Name = "arvato bootcamp",
        //        Description = "Istanbul"
        //    }
        //};// başlangıç değeri vermeye çalıştım ancak hata aldığım için bu bloğu şimdilik yorum satırına alıyorum.
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

        //[HttpPut("{id}")]
        //public IActionResult Update(int id, Issue issue)
        //{
        //    var response = _bootcampService.GetBootcampList();
        //    return StatusCode((int)HttpStatusCode.OK, response);
        //}
    }
}