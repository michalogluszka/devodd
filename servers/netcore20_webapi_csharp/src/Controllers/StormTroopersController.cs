using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using DevOdd.UltimateDeatStar.Models;

namespace DevOdd.UltimateDeatStar.Controllers
{
    [Route("api/[controller]")]
    public class StormTroopersController : Controller
    {
        private List<StormTrooper> _stormTroopers;

        public StormTroopersController()
        {
            _stormTroopers = new List<StormTrooper>()
            {
                new StormTrooper { Id = 1 } ,
                new StormTrooper { Id = 2 },
                new StormTrooper { Id = 3 }
            };
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return new ObjectResult(_stormTroopers);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var trooper = _stormTroopers.FirstOrDefault(p => p.Id == id);
            if (trooper == null)
                return NotFound();
            return new ObjectResult(trooper);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
