using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroP.Interfaces
{
    internal interface ISuperHero
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string SecretIdentity { get; set; }
        string City { get; set; }
        bool CanFly { get; set; }
        string UseSuperPower();
    }
}
