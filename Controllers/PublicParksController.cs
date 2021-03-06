using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Park.Models;
using Microsoft.EntityFrameworkCore;

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
        public void Post([FromBody] PublicPark publicpark)
        {
            _db.PublicParks.Add(publicpark);
            _db.SaveChanges();
        }
        [HttpGet("{id}")]
        public ActionResult<PublicPark> Get(int id)
        {
            return _db.PublicParks.FirstOrDefault(entry => entry.PublicParkId == id);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PublicPark publicPark)
        {
            publicPark.PublicParkId =id;
            _db.Entry(publicPark).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.PublicParks.FirstOrDefault(entry => entry.PublicParkId == id);
            _db.PublicParks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}