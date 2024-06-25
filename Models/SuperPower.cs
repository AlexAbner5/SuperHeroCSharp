using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroP.Models
{
    class SuperPower
    {
        public string Name;
        public string Description;
        public LevelPower Level;

        public SuperPower()
        {
            Name = "Unknown Power";
            Description = "Dengerous Power";
            Level = LevelPower.LevelOne;

        }
    }
}
