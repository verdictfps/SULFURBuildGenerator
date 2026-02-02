using SULFURBuildGenerator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SULFURBuildGenerator
{
    class Weapon
    {
        // Name speaks for itself
        public string Name;

        // Type should start at the weapon type stat for each specific weapon, e.g. Shotgun
        public string Type;

        // Ammo Type should start at the ammo type for each specific weapon
        public string AmmoType;

        // Damage should start at the damage stat for each specific weapon
        public int Damage;

        // Projectiles should start at the projectile stat for each specific weapon, marked as x# after Damage if >1
        public int Projectiles;

        // RPM should start at the RPM stat for each specific weapon
        public int RPM;

        // Spread should start at the spread stat for each specific weapon
        public int Spread;

        // This will be activated when switching to or from 12ga
        public int SpreadModified;

        // Durability should start at the durability stat for each specific weapon
        public int Durability;

        // Crit Chance should start at 0, needs specified as base to differentiate from ADS Crit Chance
        public decimal BaseCritChance;

        // ADS Crit Chance should start at 0, put in parentheses next to base as +0%
        public decimal ADSCritChance;

        // Bounces should start at 0
        public int Bounces;

        // Penetrations should start at 0
        public int Penetrations;

        // Reload Speed should start at 100% (could do measurements for actual speed?), has a lower cap but don't know what yet
        public decimal ReloadSpeed;

        // Bullet Speed should start at 100%, but never go lower than 20%
        public decimal BulletSpeed;

        // Recoil Base should be 100%
        public decimal RecoilBase;

        // Recoil Multiplier should be 1, only modified by Dead Center
        public int RecoilMult;

        // Can ADS is yes or no
        public string CanADS;

        // Money Drops are yes or no
        public string MoneyDrops;

        // Organ Drops are yes or no
        public string OrganDrops;

        // Loot Drop stat should start at 100%
        public decimal LootDropChance;

        // Weapon Weight should start at weapon weight stat for each weapon
        public int WeaponWeight;

        // Movement speed should technically start at 100%, but should be modified by weapon weight - maybe mark armor movement speed change in parentheses?
        public decimal MovementSpeed;

        // Bullet Consume Chance should start at 100% and cap at 0%
        public decimal BulletConsumeChance;

        // Extra Ammo Use chance should start at 0% and cap at 100%
        public decimal ExtraAmmoUseChance;

        // Bullet Drop stat should effectively start at 0, except for Impala
        public int BulletDrop;

        // Jump Power should start at 100%, maybe mark armor jump power change in parentheses?
        public decimal JumpPower;

        // Drag should start at 0
        public int Drag;

        // Durability per shot should start at 1
        public int DurabilityUsage;

        public Weapon()
        {
            Name = "";
            Type = "";
            AmmoType = "";
            Damage = 0;
            Projectiles = 0;
            RPM = 0;
            Spread = 0;
            SpreadModified = 0;
            Durability = 0;
            BaseCritChance = (decimal)0.0;
            ADSCritChance = (decimal)0.0;
            Bounces = 0;
            Penetrations = 0;
            ReloadSpeed = (decimal)1.0;
            RecoilBase = (decimal)0.0;
            RecoilMult = 0;
            CanADS = "Yes";
            MoneyDrops = "Yes";
            OrganDrops = "Yes";
            LootDropChance = (decimal)1.0;
            WeaponWeight = 0;
            MovementSpeed = (decimal)1.0;
            BulletConsumeChance = (decimal)1.0;
            ExtraAmmoUseChance = (decimal)0.0;
            BulletDrop = 0;
            JumpPower = (decimal)1.0;
            Drag = 0;
            DurabilityUsage = 1;
        }

    }

}


