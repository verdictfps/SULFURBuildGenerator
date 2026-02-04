using SULFURBuildGenerator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SULFURBuildGenerator
{
    class Weapon
    {
        // Name speaks for itself
        public string Name { get; set; }

        // Type should start at the weapon type stat for each specific weapon, e.g. Shotgun
        public string Type { get; set; }

        // Ammo Type should start at the ammo type for each specific weapon
        public string AmmoType { get; set; }

        // Damage multiplier 
        public decimal DamageMult { get; set; }

        // Damage should start at the damage stat for each specific weapon, based off the results of DamageMult
        // weapon.Damage = chamber.Damage * weapon.DamageMult
        public int Damage { get; set; }

        // Projectiles should start at the projectile stat for each specific weapon, marked as x# after Damage if >1
        public int Projectiles { get; set; }

        // RPM should start at the RPM stat for each specific weapon
        public int RPM { get; set; }

        // Mag Size will probably never change, but...
        public int MagSize { get; set; }

        // Spread should start at the spread stat for each specific weapon
        public int Spread { get; set; }

        // This will be activated when switching to or from 12ga
        public int Spread12ga { get; set; }

        // Durability should start at the durability stat for each specific weapon
        public int Durability { get; set; }

        // Crit Chance should start at 0, needs specified as base to differentiate from ADS Crit Chance
        public decimal BaseCritChance { get; set; }

        // ADS Crit Chance should start at 0, put in parentheses next to base as +0%
        public decimal ADSCritChance { get; set; }

        // Bounces should start at 0
        public int Bounces { get; set; }

        // Penetrations should start at 0
        public int Penetrations { get; set; }

        // Reload Speed should start at 100% (could do measurements for actual speed?), has a lower cap but don't know what yet
        public decimal ReloadSpeed { get; set; }

        // Bullet Speed should start at 100%, but never go lower than 20%
        public decimal BulletSpeed { get; set; }

        // Recoil Base is the final calculation after Recoil Base (Caliber) multiplied by RecoilMult (modified by oils)
        public decimal RecoilBase { get; set; }

        // Recoil Base Energy should be 9mm value on wiki (this needs datamined)
        public decimal RecoilBaseEnergy { get; set; }

        // Recoil Base 9mm should be 9mm rechamber value on wiki (this needs datamined)
        public decimal RecoilBase9mm { get; set; }

        // Recoil Base 556 should be 5.56 rechamber value on wiki (this needs datamined)
        public decimal RecoilBase556 { get; set; }

        // Recoil Base 762 should be 7.62 rechamber value on wiki (this needs datamined)
        public decimal RecoilBase762 { get; set; }

        // Recoil Base 50bmg should be .50bmg value on wiki (this needs datamined)
        public decimal RecoilBase50bmg { get; set; }

        // Recoil Base 12ga should be 12ga rechamber value on wiki (this needs datamined)
        public decimal RecoilBase12ga { get; set; }

        // Recoil Multiplier should be 1, only modified by Dead Center
        public int RecoilMult { get; set; }

        // Can ADS is yes or no
        public string CanADS { get; set; }

        // Money Drops are yes or no
        public string MoneyDrops { get; set; }

        // Organ Drops are yes or no
        public string OrganDrops { get; set; }

        // Loot Drop stat should start at 100%
        public decimal LootDropChance { get; set; }

        // Weapon Weight should start at weapon weight stat for each weapon
        public int WeaponWeight { get; set; }

        // Hidden Weight Class stat for calculations
        public decimal WeightClassFactor { get; set; }

        // Modifier from oils to calculate FinalMovementSpeed
        public decimal MovementSpeedModifier { get; set; }

        // Movement speed should technically start at 100%, but should be modified by weapon weight - maybe mark armor movement speed change in parentheses?
        public decimal FinalMovementSpeed { get; set; }

        // Bullet Consume Chance should start at 100% and cap at 0%
        public decimal BulletConsumeChance { get; set; }

        // Extra Ammo Use chance should start at 0% and cap at 100%
        public decimal ExtraAmmoUseChance { get; set; }

        // Bullet Drop stat should effectively start at 0, except for Impala
        public int BulletDrop { get; set; }

        // Jump Power should start at 100%, maybe mark armor jump power change in parentheses?
        public decimal JumpPower { get; set; }

        // Drag should start at 0
        public int Drag { get; set; }

        // Durability per shot should start at 1
        public int DurabilityUsage { get; set; }

        /*public Weapon()
        {
            Name = "";
            Type = "";
            AmmoType = "";
            Damage = 0;
            DamageMult = 0;
            Projectiles = 0;
            RPM = 0;
            MagSize = 0;
            Spread = 0;
            Spread12ga = 0;
            Durability = 0;
            BaseCritChance = (decimal)0.0;
            ADSCritChance = (decimal)0.0;
            Bounces = 0;
            Penetrations = 0;
            ReloadSpeed = 1.0M;
            RecoilBase = (decimal)0.0;
            RecoilMult = 0;
            CanADS = "Yes";
            MoneyDrops = "Yes";
            OrganDrops = "Yes";
            LootDropChance = (decimal)1.0;
            WeaponWeight = 0;
            WeightClassFactor = (decimal)0.0;
            MovementSpeedModifier = (decimal)1.0;
            FinalMovementSpeed = (decimal)1.0;
            BulletConsumeChance = (decimal)1.0;
            ExtraAmmoUseChance = (decimal)0.0;
            BulletDrop = 0;
            JumpPower = (decimal)1.0;
            Drag = 0;
            DurabilityUsage = 1;
        }*/

    }

}


