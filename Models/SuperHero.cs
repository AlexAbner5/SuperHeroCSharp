using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroP.Models
{
    class SuperHero
    {
        private string _name;
        public Guid Id;
        public string Name // Propiedad Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value.Trim();
            }
        }


        public string SecretIdentity;
        public string City;
        public List<SuperPower> SuperPowers; // Lista donde se almacenan los super poderes. El objeto SuperPowe esta dentro de la clase SuperHero
        public bool CanFly;

        public SuperHero()
        {
            Id = Guid.NewGuid();
            Name = "Unknown";
            SecretIdentity = "john doe";
            City = "Nowhere";
            SuperPowers = new List<SuperPower>();
            CanFly = false;
        }

        public string UseSuperPower()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var power in SuperPowers)
            {
                sb.AppendLine($"{Name} is using the power {power.Name}");
            }
            return sb.ToString();
        }
    }
}
