using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Ranger";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Dexterity { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}