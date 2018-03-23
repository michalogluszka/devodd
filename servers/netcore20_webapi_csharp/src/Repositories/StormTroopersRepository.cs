using System;
using System.Collections.Generic;

using DevOdd.UltimateDeatStar.Models;

namespace DevOdd.UltimateDeatStar.Repositories
{
    public class StormTroopersRepository : IStormTroopersRepository
    {
        private List<StormTrooper> _stormTroopers;

        public StormTroopersRepository()
        {
            _stormTroopers = new List<StormTrooper>()
            {
                new StormTrooper { Id = 1 } ,
                new StormTrooper { Id = 2 },
                new StormTrooper { Id = 3 }
            };
        }

        public IEnumerable<StormTrooper> GetAll()
        {
            return _stormTroopers;
        }
    }

    public interface IStormTroopersRepository
    {
        IEnumerable<StormTrooper> GetAll();
    }
}