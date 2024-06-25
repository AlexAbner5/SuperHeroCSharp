using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroP.Models
{
    internal class AntiHero : SuperHero
    {
        public string AccionOfAntiHero(string Acction)
        {
            return $"{Name} is doing {Acction}";
        }
    }
}
