using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using DevOdd.UltimateDeatStar.Models;
using DevOdd.UltimateDeatStar.Repositories;

namespace DevOdd.UltimateDeatStar.Controllers
{
    [Route("api/[controller]")]
    public class StormTroopersController : Controller
    {
        private IStormTroopersRepository _stormTroopersRepository;


        public StormTroopersController(IStormTroopersRepository stormTroopersRepository)
        {
            _stormTroopersRepository = stormTroopersRepository;        
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<StormTrooper> stormTroopers = _stormTroopersRepository.GetAll();
            return new ObjectResult(stormTroopers);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            StormTrooper trooper = _stormTroopersRepository.GetAll().FirstOrDefault(p => p.Id == id);
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
