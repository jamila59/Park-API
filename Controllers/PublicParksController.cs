using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Park.Models;

namespace Park.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicParksController : ControllerBase
    {
        private ParkContext _db;

        public PublicParksController(ParkContext db)
        {
            _db =db;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PublicPark>> Get()
        {
            return _db.PublicParks.ToList();
        }
        [HttpPost]
        public void Post ([FromBody] PublicPark publicpark)
        {
            _db.PublicParks.Add(publicpark);
            _db.SaveChanges();
        }
        [HttpGet("{id}")]
        public ActionResult<PublicPark> Get(int id)
        {
            return _db.PublicParks.FirstOrDefault(entry => entry.PublicParkId == id);
        }
    }
}