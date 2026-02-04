using System;
using System.Collections.Generic;
using System.Text;

namespace SULFURBuildGenerator
{
    class Chamber
    {
        public string AmmoType;

        // Weapon DamageMult is applied to this
        public int Damage;

        // Projectile count for the chisel, to replace Weapon Projectiles property
        public int Projectiles;


        public Chamber()
        {
            AmmoType = "";
            Damage = 0;
            Projectiles = 1;
        }
    }
}
