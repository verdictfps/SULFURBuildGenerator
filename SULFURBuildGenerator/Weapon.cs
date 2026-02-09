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
        public double DamageMult { get; set; }

        // Damage should start at the damage stat for each specific weapon, based off the results of DamageMult
        // weapon.Damage = chamber.Damage * weapon.DamageMult
        public double Damage { get; set; }

        // Projectiles should start at the projectile stat for each specific weapon, marked as x# after Damage if >1
        public double Projectiles { get; set; }

        // RPM should start at the RPM stat for each specific weapon
        public double RPM { get; set; }

        // Mag Size will probably never change, but...
        public double MagSize { get; set; }

        // Spread should start at the spread stat for each specific weapon
        public double Spread { get; set; }

        // This will be activated when switching to or from 12ga
        public double Spread12ga { get; set; }

        // Durability should start at the durability stat for each specific weapon
        public double Durability { get; set; }

        // Crit Chance should start at 0, needs specified as base to differentiate from ADS Crit Chance
        public double BaseCritChance { get; set; }

        // ADS Crit Chance should start at 0, put in parentheses next to base as +0%
        public double ADSCritChance { get; set; }

        // Bounces should start at 0
        public double Bounces { get; set; }

        // Penetrations should start at 0
        public double Penetrations { get; set; }

        // Reload Speed should start at 100% (could do measurements for actual speed?), has a lower cap but don't know what yet
        public double ReloadSpeed { get; set; }

        // Bullet Speed should start at 100%, but never go lower than 20%
        public double BulletSpeed { get; set; }

        // Recoil Base is the final calculation after Recoil Base (Caliber) multiplied by RecoilMult (modified by oils)
        public double RecoilBase { get; set; }

        // Recoil Base Energy should be 9mm value on wiki (this needs datamined)
        public double RecoilBaseEnergy { get; set; }

        // Recoil Base 9mm should be 9mm rechamber value on wiki (this needs datamined)
        public double RecoilBase9mm { get; set; }

        // Recoil Base 556 should be 5.56 rechamber value on wiki (this needs datamined)
        public double RecoilBase556 { get; set; }

        // Recoil Base 762 should be 7.62 rechamber value on wiki (this needs datamined)
        public double RecoilBase762 { get; set; }

        // Recoil Base 50bmg should be .50bmg value on wiki (this needs datamined)
        public double RecoilBase50bmg { get; set; }

        // Recoil Base 12ga should be 12ga rechamber value on wiki (this needs datamined)
        public double RecoilBase12ga { get; set; }

        // Recoil Multiplier should be 1, only modified by Dead Center
        public double RecoilMult { get; set; }

        // Can ADS is yes or no
        public string CanADS { get; set; }

        // Money Drops are yes or no
        public string MoneyDrops { get; set; }

        // Organ Drops are yes or no
        public string OrganDrops { get; set; }

        // Loot Drop stat should start at 100%
        public double LootDropChance { get; set; }

        // Weapon Weight should start at weapon weight stat for each weapon
        public double WeaponWeight { get; set; }

        // Hidden Weight Class stat for calculations
        public double WeightClassFactor { get; set; }

        // Modifier from oils to calculate FinalMovementSpeed
        public double MovementSpeedModifier { get; set; }

        // Movement speed should technically start at 100%, but should be modified by weapon weight - maybe mark armor movement speed change in parentheses?
        public double FinalMovementSpeed { get; set; }

        // Bullet Consume Chance should start at 100% and cap at 0%
        public double BulletConsumeChance { get; set; }

        // Extra Ammo Use chance should start at 0% and cap at 100%
        public double ExtraAmmoUseChance { get; set; }

        // Bullet Drop stat should effectively start at 0, except for Impala
        public double BulletDrop { get; set; }

        // Jump Power should start at 100%, maybe mark armor jump power change in parentheses?
        public double JumpPower { get; set; }

        // Drag should start at 0
        public double Drag { get; set; }

        // Durability per shot should start at 1
        public double DurabilityUsage { get; set; }

        public double TotalDamage { get; set; }
    }

}


