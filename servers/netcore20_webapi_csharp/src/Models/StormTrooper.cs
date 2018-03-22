using System;

namespace DevOdd.UltimateDeatStar.Models
{    public class StormTrooper 
    {
        public Guid Id { get; private set;}

        public StormTrooper()
        {
            Id = Guid.NewGuid();
        }
    }
}