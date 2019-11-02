using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ParksLookup.Models;
using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NativeSpeciesController : ControllerBase
    {
        private ParksLookupContext _db;

        public NativeSpeciesController(ParksLookupContext db)
        {
            _db = db;
        }

        [HttpPost]
        public void Post([FromBody] NativeSpecies nativeSpecies)
        {
            _db.NativeSpecies.Add(nativeSpecies);
            Park foundPark = _db.Parks.FirstOrDefault(park => park.ParkId == nativeSpecies.ParkId);
            foundPark.NativeSpecies.Add(nativeSpecies);
            _db.SaveChanges();
        }
        
        [HttpGet("{id}")]
        public ActionResult<NativeSpecies> Get(int id)
        {
            return _db.NativeSpecies.FirstOrDefault(entry => entry.NativeSpeciesId == id);
        }
        [HttpGet]
        public ActionResult<IEnumerable<NativeSpecies>> Get(string commonName, string conservationStatus, string parkName)
        {
            var query = _db.NativeSpecies.AsQueryable();

            if (commonName != null)
            {
                query = query.Where(entry => entry.CommonName == commonName);
            }
            if (conservationStatus != null)
            {
                query = query.Where(entry => entry.ConservationStatus == conservationStatus);
            }
            if (parkName != null)
            {
                query = query.Where(entry => entry.Park.ParkName == parkName);
            }


            return query.ToList();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] NativeSpecies nativeSpecies)
        {
            nativeSpecies.NativeSpeciesId = id;
            _db.Entry(nativeSpecies).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var reviewToDelete = _db.NativeSpecies.FirstOrDefault(entry => entry.NativeSpeciesId == id);
            _db.NativeSpecies.Remove(reviewToDelete);
            _db.SaveChanges();
        }

    }
}