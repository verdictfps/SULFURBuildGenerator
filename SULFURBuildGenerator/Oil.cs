using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace SULFURBuildGenerator
{
    class Oil
    {
        // Names the oil
        public string Name { get; set; }

        // Sets the main stat modifier of the oil
        public string TypePositive1 { get; set; }

        public string TypePositive2 { get; set; }

        public string TypePositive3 { get; set; }

        public string TypePositive4 { get; set; }

        public string TypeNegative1 { get; set; }

        public string TypeNegative2 { get; set; }

        public string TypeNegative3 { get; set; }

        public string TypeNegative4 { get; set; }

        public double AmmoConsumeChance { get; set; }

        public double Bounces { get; set; }

        public double BulletDrop { get; set; }

        public double BulletSpeed { get; set; }

        public double ExtraAmmoUseChance { get; set; }

        public double BaseCritChance { get; set; }

        public double DamageAdd { get; set; }

        public double DamageMult { get; set; }

        public string CanADS { get; set; }

        public double JumpPower { get; set; }

        public double LootDropChance { get; set; }

        public double DurabilityMult { get; set; }

        public double MovementSpeedMult { get; set; }

        public string MoneyDrops { get; set; }

        public string OrganDrops { get; set; }

        public double Penetrations { get; set; }

        public double ProjectileMult { get; set; }

        public double RPM { get; set; }

        public double RecoilAdd { get; set; }

        public double RecoilMult { get; set; }

        public double ReloadSpeed {  get; set; }

        public double SpreadAdd { get; set; }

        public double SpreadMult { get; set; }

        public double Drag { get; set; }

        public double DurabilityUsage { get; set; }

        public double BulletBounciness { get; set; }

        public double MovingAccuracy { get; set; }
    }
}
