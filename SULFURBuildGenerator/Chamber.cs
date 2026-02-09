using System;
using System.Collections.Generic;
using System.Text;

namespace SULFURBuildGenerator
{
    class Chamber
    {
        public string Name { get; set; }

        public string AmmoType { get; set; }

        // Weapon DamageMult is applied to this
        public double Damage { get; set; }

        // Projectile count for the chisel, to replace Weapon Projectiles property
        public int Projectiles { get; set; }
    }
}
