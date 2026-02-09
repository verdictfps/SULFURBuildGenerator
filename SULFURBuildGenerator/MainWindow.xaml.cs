using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;






namespace SULFURBuildGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        
        List<string> listOils = new List<string> { 
    "Action Oil", 
    "Add Damage Oil",
    "Aimless Oil",
    "Airsoft Oil",
    "Altruistic Oil",
    "Arkanoid Oil",
    "Arrow Oil",
    "Artery Oil",
    "Artillery Oil",
    "Ascetic Oil",
    "Assassin Dart Oil",
    "Attack Speed Oil",
    "Axe Oil",
    "BB Oil",
    "Bad Planet Oil",
    "Bandit Oil",
    "Big Oil",
    "Black Friday Oil",
    "Blindfold Oil",
    "Blurt Oil",
    "Bolt Oil",
    "Bombard Oil",
    "Boomstick Oil",
    "Boulder Oil",
    "Bowl Oil",
    "Braced Oil",
    "Brute Oil",
    "Bulk Oil",
    "Bystander Oil",
    "Carefree Oil",
    "Careful Oil",
    "Careless Splitter Oil",
    "Cartoon Oil",
    "Casual Oil",
    "Cheap Oil",
    "Collateral Oil",
    "Complicated Oil",
    "Compo Oil",
    "Confidence Oil",
    "Considerate Oil",
    "Contained Force Oil",
    "Critical Oil",
    "Cycle Oil",
    "Damage Oil",
    "Dart Oil",
    "Dead Center Oil",
    "Delayed Hyper Tube Oil",
    "Dense Oil",
    "Detune Oil",/*
    "Diesel Oil",
    "Discharge Oil",
    "Disposable Oil",
    "Division Oil",
    "Do-over Oil",
    "Double Fire Oil",
    "Double Lock Oil",
    "Double Nothing Oil",
    "Dum Dum Oil",
    "Dynamic Oil",
    "Easy Oil",
    "Easy Plop Oil",
    "Elephant Oil",
    "Exotic Barrel Oil",
    "Expander Oil",
    "Extra Powder Oil",
    "Farsighted Oil",
    "Fast Bet Oil",
    "Feature Gun Oil",
    "Fidget Lord Oil",
    "Fidget Oil",
    "First Blood Oil",
    "Flea Oil",
    "Flow Funnel Oil",
    "Food Stamp Oil",
    "Fragile System Oil",
    "Franciscan Oil",
    "Frugal Oil",
    "Gambler Oil",
    "Gemini Oil",
    "Gentle Oil",
    "Glass Cannon Oil",
    "Great Oil",
    "Grounded Oil",
    "Gunslinger Oil",
    "Happy Accident Oil",
    "Heavy Lead Oil",
    "Heavy Oil",
    "Heavy Pockets Oil",
    "Hefty Oil",
    "Helium Oil",
    "High Grade Oil",
    "Hip Blaster Oil",
    "Hip Marksman Oil",
    "Hoop Oil",
    "Hunter Oil",
    "Hustler Oil",
    "Hyper Lead Oil",
    "Imperfect Oil",
    "Inconsiderate Oil",
    "Inherited Oil",
    "Instant Oil",
    "Judgement Oil",
    "Jungian Oil",
    "Keep Oil",
    "Kicker Oil",
    "Kinetic Oil",
    "Last Drop Oil",
    "Late Boom Oil",
    "Launcher Oil",
    "Lazy Oil",
    "Less Recoil Oil",
    "Lightweight Oil",
    "Longshot Oil",
    "Lost In Focus Oil",
    "Low Roller Oil",
    "Machine Oil",
    "Main Discipline Oil",
    "Main Focus Oil",
    "Manifestation Oil",
    "Matrix Oil",
    "Micro Wing Oil",
    "Modern Technology Oil",
    "Mosquito Oil",
    "Multichamber Oil",
    "Multishot Oil",
    "Needleye Oil",
    "Nerf Oil",
    "No Look Oil",
    "No Need Oil",
    "Out of the Box Oil",
    "Overclock Oil",
    "Overdose Oil",
    "Parallel Mag Oil",
    "Peashooter Oil",
    "Penetration Oil",
    "Perfect Bounce Oil",
    "Perforate Oil",
    "Plinker Oil",
    "Plop Back Oil",
    "Pool Oil",
    "Potshot Oil",
    "Puncher Oil",
    "Puncture Oil",
    "Purse Gun Oil",
    "Rapid Internals Oil",
    "Ready Oil",
    "Rebound Oil",
    "Recycle Oil",
    "Relax Oil",
    "Release Oil",
    "Reload Oil",
    "Ricochet Oil",
    "Rigid System Oil",
    "Rigor Oil",
    "Robust Mechanics Oil",
    "Rookie Oil",
    "Rubber Oil",
    "Rush Job Oil",
    "Safety Oil",
    "Satiety Oil",
    "Saviour Oil",
    "Scatter Oil",
    "Scramble Oil",
    "Seated Fit Oil",
    "Seated Oil",
    "Sect Oil",
    "Sender Oil",
    "Sensible Oil",
    "Shaved Clip Oil",
    "Shellman Oil",
    "Sherlock Oil",
    "Shower Oil",
    "Shredder Oil",
    "Skip Oil",
    "Slick Oil",
    "Slippy Coating Oil",
    "Slotmachine Oil",
    "Slow Punch Oil",
    "Smart Bullet Oil",
    "Soft Bullet Oil",
    "Solid Oil",
    "Spartan Oil",
    "Speed Trade Oil",
    "Spitter Oil",
    "Spread Oil",
    "Stability Oil",
    "Stable Hip Oil",
    "Stationary Oil",
    "Stiffy Fit Oil",
    "Stoic Oil",
    "Suppressive Oil",
    "Surgical Laser Oil",
    "Synchronicity Oil",
    "Tactical Oil",
    "Tandem Oil",
    "Task Oil",
    "Tech Support Oil",
    "Tension Oil",
    "Terminator Oil",
    "Thorough Oil",
    "Tight Barrel Oil",
    "Too Much Oil",
    "Trusty Old Oil",
    "Turbulence Oil",
    "Twice Oil",
    "Two Time Oil",
    "Unlabeled Oil",
    "Untechnical Oil",
    "Vasectomy Oil",
    "Vegan Oil",
    "Vegetable Oil",
    "Velocity Oil",
    "Walk Easy Oil",
    "Waster Oil",
    "Whim Oil",
    "Whos Counting Oil",
    "Wobble Oil",
    "Zero Fucks Oil",
    "Zooming Oil",*/
};
 

        List<string> listAllScrolls = new List<string> { "Scroll of Dark", "Scroll of Earth", "Scroll of Embers", "Scroll of Frostbite", "Scroll of Light", "Scroll of Nature", "Scroll of Plague", "Scroll of Surge", "Scroll of Water", "Scroll of Aftershock", "Scroll of Chain Lightning", "Scroll of Chaos Strike", "Scroll of Charm", "Scroll of Corpse Explosion", "Scroll of Crusader", "Scroll of Explosions", "Scroll of Fear", "Scroll of Flame Thrower", "Scroll of Holy Fire", "Scroll of Holy Purge", "Scroll of Lava", "Scroll of Least Resistance", "Scroll of Noxiosa", "Scroll of Pesticide", "Scroll of Petrification", "Scroll of Petroleum", "Scroll of Poison Blood", "Scroll of Prism", "Scroll of Rocket Launcher", "Scroll of Slush", "Scroll of Sacrifice", "Scroll of Storm Surge", "Scroll of Thunderbolt", "Scroll of Toxic Lobotomy", "Scroll of Voodoo" };

        List<string> listT1Scrolls = new List<string> { "Scroll of Dark", "Scroll of Earth", "Scroll of Embers", "Scroll of Frostbite", "Scroll of Light", "Scroll of Nature", "Scroll of Plague", "Scroll of Surge", "Scroll of Water" };

        List<string> listT2Scrolls = new List<string> { "Scroll of Aftershock", "Scroll of Chain Lightning", "Scroll of Chaos Strike", "Scroll of Charm", "Scroll of Corpse Explosion", "Scroll of Crusader", "Scroll of Explosions", "Scroll of Fear", "Scroll of Flame Thrower", "Scroll of Holy Fire", "Scroll of Holy Purge", "Scroll of Lava", "Scroll of Least Resistance", "Scroll of Noxiosa", "Scroll of Pesticide", "Scroll of Petrification", "Scroll of Petroleum", "Scroll of Poison Blood", "Scroll of Prism", "Scroll of Rocket Launcher", "Scroll of Slush", "Scroll of Sacrifice", "Scroll of Storm Surge", "Scroll of Thunderbolt", "Scroll of Toxic Lobotomy", "Scroll of Voodoo" };

        List<string> listGuns = new List<string> { "P38 Dirk", "Socom 9", "Star & Witness", "Gravekeeper", "Beck 8", "Salamander", "Bronco 89", "Flicker", "Unknown", "Hell 'N' Back", "Cavalier", "Snut .38", "Palehorse Topclipper", ".357 Balthazar", "Wyatt PULSAR", "Breacher 8", "Mossman", "Arbiter 2", "Augusta", "1889 Mario", "Flock 76", "Majordome", "Drifter 9", "Vrede", "Ploika Compact", "Ferryman", "M3 Termite", "Deathstar PG", "Valet", "Corpsemaker", "Catacoil Rapid X", "Type 80 Typhoon", "M11A2 Fisk", "Wingman", "Rektor 100rd", "Duhar", "Neuraxis F22", "Knop .22", "M182 Pierre-Fusil", "Tailor Marksman MKII", "Farsight", "Rokua .308", "Dolphin 99", "D4RT", "Impala Gravita", "Longboy" };

        List<string> listPistols = new List<string> { "P38 Dirk", "Socom 9", "Star & Witness", "Gravekeeper", "Beck 8", "Salamander", "Bronco 89", "Flicker", "Unknown", "Hell 'N' Back", "Cavalier" };

        List<string> listRevolvers = new List<string> { "Snut .38", "Palehorse Topclipper", ".357 Balthazar", "Wyatt PULSAR" };

        List<string> listShotguns = new List<string> { "Breacher 8", "Mossman", "Arbiter 2", "Augusta", "1889 Mario", "Flock 76", "Majordome" };

        List<string> listSMGs = new List<string> { "Drifter 9", "Vrede", "Ploika Compact", "Ferryman", "M3 Termite", "Deathstar PG", "Valet" };

        List<string> listARs = new List<string> { "Corpsemaker", "Catacoil Rapid X", "Type 80 Typhoon", "M11A2 Fisk", "Wingman"};

        List<string> listLMGs = new List<string> { "Rektor 100rd", "Duhar", "Neuraxis F22" };

        List<string> listRifles = new List<string> { "Knop .22", "M182 Pierre-Fusil", "Tailor Marksman MKII", "Farsight" };

        List<string> listSnipers = new List<string> { "Rokua .308", "Dolphin 99", "D4RT", "Impala Gravita", "Longboy" };

        List<string> listBarrels = new List<string> { "A12C Muzzle Brake", "Aftermarket Haukland Silencer", "Barrel Extension 2\"", "Barrel Extension 4\"", "Barrel Extension 6\"", "Breznik BMD", "Breznik BMD (Tactical)", "Haukland Flash Hider", "Haukland Silencer", "Improvised Barrel Extension", "M87 \"Albatross\" Silencer", "SR-P3 Silencer", "Shrouded Barrel Extension", "Warmage Compensator" };

        List<string> listOptics = new List<string> { "Assault Scope", "Compact Sight", "Holographic Sight", "Hunting Scope", "Recon Scope", "Reflex Sight", "Sniper Scope" };

        List<string> listLaser = new List<string> { "OrangeRed", "Lime", "Yellow" };

        List<string> listFiremode = new List<string> { "Gun Crank", "Priming Bolt" };

        List<string> listFiremodePrime = new List<string> { "Priming Bolt", "None" };

        List<string> listFiremodeCrank = new List<string> { "Gun Crank", "None" };

        List<string> listRechamber = new List<string> { "Chamber Chisel - .50 BMG", "Chamber Chisel - 12Ga", "Chamber Chisel - 5.56mm", "Chamber Chisel - 7.62mm", "Chamber Chisel - 9mm" };

        List<string> totalAttachments = new List<string>();

        List<string> totalEnchantments = new List<string>();

        List<string> totalEquipment = new List<string> { "Balaclava", "Beer Helmet", "Blue Bandana", "Cowboy Hat", "Dunce Cap", "Ear Protectors", "Eye Patch", "Firefighter Helmet", "Fluffy Hat", "Gas Mask", "High Cut Helmet", "Knight's Helmet", "Motorcycle Helmet", "Pith Helmet", "Police Hat", "Pope Hat", "OrangeRed Bandana", "Round Glasses", "Ski Goggles", "Square Glasses", "Steel Helmet", "Sunglasses", "Sylvester Hat", "Tanker Helmet", "Titanium Helmet", "Winter Scarf", "Badass Vest", "Ballistic Vest", "Bathrobe", "Breastplate", "Camo Jacket", "Cowboy Vest", "Firefighter Jacket", "Ghillie Suit", "Hazmat Suit", "Hunting Vest", "Leather Jacket", "Life Vest", "Office Wear", "Old-Timey Suit", "Parka", "Pillow Armor", "Plate Carrier", "Police Uniform", "Pyjamas", "Raincoat", "Samurai Armor", "Santa Coat", "Tracksuit", "Turtle Shell", "Yellow Hoodie" };

        List<string> listHeadEquipment = new List<string> { "Balaclava", "Beer Helmet", "Blue Bandana", "Cowboy Hat", "Dunce Cap", "Ear Protectors", "Eye Patch", "Firefighter Helmet", "Fluffy Hat", "Gas Mask", "High Cut Helmet", "Knight's Helmet", "Motorcycle Helmet", "Pith Helmet", "Police Hat", "Pope Hat", "OrangeRed Bandana", "Round Glasses", "Ski Goggles", "Square Glasses", "Steel Helmet", "Sunglasses", "Sylvester Hat", "Tanker Helmet", "Titanium Helmet", "Winter Scarf" };

        List<string> listBodyEquipment = new List<string> { "Badass Vest", "Ballistic Vest", "Bathrobe", "Breastplate", "Camo Jacket", "Cowboy Vest", "Firefighter Jacket", "Ghillie Suit", "Hazmat Suit", "Hunting Vest", "Leather Jacket", "Life Vest", "Office Wear", "Old-Timey Suit", "Parka", "Pillow Armor", "Plate Carrier", "Police Uniform", "Pyjamas", "Raincoat", "Samurai Armor", "Santa Coat", "Tracksuit", "Turtle Shell", "Yellow Hoodie" };

        List<string> listFootEquipment = new List<string> { "Blast Boot", "Blue Slipper", "Christmas Sock", "Clog", "Combat Boot", "Cowboy Boot", "Diving Fin", "Genie Shoe", "Geta", "Golden Slipper", "High Heel", "High Quality Elf Shoe", "Ice Skate", "Peg Leg", "Peg Leg", "Platform Shoe", "Roller Blade", "Rubber Boot", "Running Shoe", "Shoe", "Sneaker", "Sock", "Springcoil Boot", "Sulf Air", "Ygg" };

        List<string> listTrinkets = new List<string> { "Ass Wheel(TM)", "Dark Lamp", "Detective Pipe", "Dog Whistle", "Dogtags", "Extra Lung", "Four-Leaf Clover", "Instant Defibrillator", "Iron Feather", "Knee Pads", "Library Card", "Loaded Die", "Lock of the Magus", "Metabulator Pump", "Oxygen Tank", "Range Finder", "Sheriff's Badge", "Yakety Sax" };

        public MainWindow()
        {
            // Creates a bunch of json files for oils. i know, it's fucking insane, but im bad at this
            /*foreach (string oil in listOils)
            {
                string fileName = $"C:\\Users\\verdi\\source\\repos\\SULFURBuildGenerator\\SULFURBuildGenerator\\JSON\\Oils\\{oil}.json";
                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented
                };
                var data = new { Name = oil, TypePositive1 = "None", TypePositive2 = "None", TypeNegative1 = "None", TypeNegative2 = "None", BulletConsumeChance = "0.0", Bounces = "0.0", BulletDrop = "0.0", BulletSpeed = "0.0", ExtraAmmoUseChance = "0.0", BaseCritChance = "0.0", DamageAdd = "0.0", DamageMult = "0.0", CanADS = "Yes", JumpPower = "0.0", LootDropChance = "0.0", DurabilityMult = "0.0", MovementSpeedMult = "0.0", MoneyDrops = "Yes", OrganDrops = "Yes", Penetrations = "0.0", ProjectileMult = "0.0", RPM = "0.0", RecoilAdd = "0.0", RecoilMult = "0.0", ReloadSpeed = "0.0", SpreadAdd = "0.0", SpreadMult = "0.0", Drag = "0.0", DurabilityUsage = "1.0" };
                string jsonString = JsonConvert.SerializeObject(data, settings);
                //File.Create($"C:\\Users\\verdi\\source\\repos\\SULFURBuildGenerator\\SULFURBuildGenerator\\JSON\\Oils\\{oil}.json");
                File.WriteAllText(fileName, jsonString);
            }*/

            InitializeComponent();
            this.build_box.Items.Add(new MyItem { Item = "Gun", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Barrel", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Optic", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Laser", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Firemode", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Rechamber", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Enchantment 1", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Enchantment 2", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Enchantment 3", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Enchantment 4", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Enchantment 5", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Head Equipment", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Body Equipment", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Left Foot", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Right Foot", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Trinket 1", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Trinket 2", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Trinket 3", Selection = "None" });
            this.build_box.Items.Add(new MyItem { Item = "Trinket 4", Selection = "None" });

        }

        private void ButtonGenerateBuild_Click(object sender, RoutedEventArgs e)
        {

            this.build_box.Items[0] = (new MyItem { Item = "Gun", Selection = "None" });
            this.build_box.Items[1] = (new MyItem { Item = "Barrel", Selection = "None" });
            this.build_box.Items[2] = (new MyItem { Item = "Optic", Selection = "None" });
            this.build_box.Items[3] = (new MyItem { Item = "Laser", Selection = "None" });
            this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = "None" });
            this.build_box.Items[5] = (new MyItem { Item = "Rechamber", Selection = "None" });
            this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = "None" });
            this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = "None" });
            this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = "None" });
            this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = "None" });
            this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = "None" });
            this.build_box.Items[11] = (new MyItem { Item = "Head Equipment", Selection = "None" });
            this.build_box.Items[12] = (new MyItem { Item = "Body Equipment", Selection = "None" });
            this.build_box.Items[13] = (new MyItem { Item = "Left Foot", Selection = "None" });
            this.build_box.Items[14] = (new MyItem { Item = "Right Foot", Selection = "None" });
            this.build_box.Items[15] = (new MyItem { Item = "Trinket 1", Selection = "None" });
            this.build_box.Items[16] = (new MyItem { Item = "Trinket 2", Selection = "None" });
            this.build_box.Items[17] = (new MyItem { Item = "Trinket 3", Selection = "None" });
            this.build_box.Items[18] = (new MyItem { Item = "Trinket 4", Selection = "None" });

            string randomGun;
            randomGun = null;
            List<string> totalGuns = new List<string>();
            // Create Gun Pool
            if ((bool)Pistols.IsChecked == true && (bool)All_Guns.IsChecked == false)
            {
                totalGuns = listPistols.Concat(listPistols)
                    .ToList();
            }
            if ((bool)Revolvers.IsChecked == true && (bool)All_Guns.IsChecked == false)
            {
                totalGuns = totalGuns.Concat(listRevolvers)
                    .ToList();
            }
            if ((bool)Shotguns.IsChecked == true && (bool)All_Guns.IsChecked == false)
            {
                totalGuns = totalGuns.Concat(listShotguns)
                    .ToList();
            }
            if ((bool)SMGs.IsChecked == true && (bool)All_Guns.IsChecked == false)
            {
                totalGuns = totalGuns.Concat(listSMGs)
                    .ToList();
            }
            if ((bool)ARs.IsChecked == true && (bool)All_Guns.IsChecked == false)
            {
                totalGuns = totalGuns.Concat(listARs)
                    .ToList();
            }
            if ((bool)LMGs.IsChecked == true && (bool)All_Guns.IsChecked == false)
            {
                totalGuns = totalGuns.Concat(listLMGs)
                    .ToList();
            }
            if ((bool)Rifles.IsChecked == true && (bool)All_Guns.IsChecked == false)
            {
                totalGuns = totalGuns.Concat(listRifles)
                    .ToList();
            }
            if ((bool)Snipers.IsChecked == true && (bool)All_Guns.IsChecked == false)
            {
                totalGuns = totalGuns.Concat(listSnipers)
                    .ToList();
            }
            else if ((bool)All_Guns.IsChecked == true)
            {
                totalGuns = listGuns;
            }

            // Gun Randomizer
            System.Random randomGunInt = new System.Random();
            int randomGunNumber = randomGunInt.Next(0, totalGuns.Count);
            randomGun = totalGuns[randomGunNumber];

            // Add Gun and Stats to Grid and Card
            // Grab randomized weapon stats from json and set to variable weapon
            string weaponJsonFilename = $".\\JSON\\Weapons\\{randomGun}.json";
            string weaponJsonString = File.ReadAllText(weaponJsonFilename);
            Weapon weapon = JsonConvert.DeserializeObject<Weapon>(weaponJsonString)!;

            // Apply Chamber Stats to Weapon
            if (weapon.AmmoType != "Energy")
            {
                string chamberBaseJsonFilename = $".\\JSON\\Chamber\\Chamber Chisel - {weapon.AmmoType}.json";
                string chamberBaseJsonString = File.ReadAllText(chamberBaseJsonFilename);
                Chamber chamber = JsonConvert.DeserializeObject<Chamber>(chamberBaseJsonString)!;

                weapon.Damage = weapon.DamageMult * chamber.Damage;
                weapon.AmmoType = chamber.AmmoType;
                weapon.Projectiles = chamber.Projectiles;
            }


            File.WriteAllText(@".\JSON\Weapons\!WeaponOriginal.json", JsonConvert.SerializeObject(weapon));

            string weaponOrigJsonFilename = @".\JSON\Weapons\!WeaponOriginal.json";
            string weaponOrigJsonString = File.ReadAllText(weaponOrigJsonFilename);
            Weapon weaponOriginal = JsonConvert.DeserializeObject<Weapon>(weaponOrigJsonString)!;

            ////// Calc original damage for good measure
            weaponOriginal.TotalDamage = weaponOriginal.Damage * weaponOriginal.Projectiles;



            // Attachment Randomizer
            if ((bool)allAttachmentsCheckbox.IsChecked == true)
            {
                // Barrel Randomizer
                System.Random randomBarrelInt = new System.Random();
                int randomBarrelNumber = randomGunInt.Next(0, listBarrels.Count);
                if (randomGun == "Catacoil Rapid X" || randomGun == "Unknown" || randomGun == "Wyatt PULSAR" || randomGun == "Augusta" || randomGun == "D4RT" || randomGun == "Neuraxis F22")
                {
                    this.build_box.Items[1] = (new MyItem { Item = "Barrel", Selection = "N/A" });
                }
                else
                {
                    this.build_box.Items[1] = (new MyItem { Item = "Barrel", Selection = listBarrels[randomBarrelNumber] });
                }

                // Optic Randomizer
                System.Random randomOpticInt = new System.Random();
                int randomOpticNumber = randomOpticInt.Next(0, listOptics.Count);
                this.build_box.Items[2] = (new MyItem { Item = "Optic", Selection = listOptics[randomOpticNumber] });

                // Laser Randomizer
                System.Random randomLaserInt = new System.Random();
                int randomLaserNumber = randomLaserInt.Next(0, listLaser.Count);
                this.build_box.Items[3] = (new MyItem { Item = "Laser", Selection = listLaser[randomLaserNumber] });

                // Firemode Randomizer

                if (randomGun == "Breacher 8" || randomGun == "Wyatt PULSAR" || randomGun == "Unknown" || randomGun == "Catacoil Random X" || randomGun == "Impala Gravita" || randomGun == "D4RT")
                {
                    this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = "N/A" });
                }
                else
                {
                    if (randomGun == "P38 Dirk" || randomGun == "Socom 9" || randomGun == "Star & Witness" || randomGun == "Gravekeeper" || randomGun == "Beck 8" || randomGun == "Salamander" || randomGun == "Bronco 89" || randomGun == "Flicker" || randomGun == "Hell 'N' Back" || randomGun == "Cavalier" || randomGun == "Snut .38" || randomGun == "Palehorse Topclipper" || randomGun == ".357 Balthazar" || randomGun == "Mossman" || randomGun == "Arbiter 2" || randomGun == "Augusta" || randomGun == "1889 Mario" || randomGun == "Majordome" || randomGun == "M3 Termite" || randomGun == "Deathstar PG" || randomGun == "Knop .22" || randomGun == "M182 Pierre-Fusil" || randomGun == "Tailor Marksman MKII" || randomGun == "Farsight" || randomGun == "Rokua .308" || randomGun == "Dolphin 99" || randomGun == "Longboy")
                    {
                        System.Random randomFireCrankInt = new System.Random();
                        int randomFireCrankNumber = randomFireCrankInt.Next(0, listFiremodeCrank.Count);
                        this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = listFiremodeCrank[randomFireCrankNumber] });
                    }
                    else if (randomGun == "Flock 76" || randomGun == "Drifter 9" || randomGun == "Vrede" || randomGun == "Ploika Compact" || randomGun == "Ferryman" || randomGun == "Valet" || randomGun == "Corpsemaker" || randomGun == "Type 80 Typhoon" || randomGun == "M11A2 Fisk" || randomGun == "Wingman" || randomGun == "Rektor 100rd" || randomGun == "Duhar" || randomGun == "Neuraxis F22")
                    {
                        System.Random randomFirePrimeInt = new System.Random();
                        int randomFirePrimeNumber = randomFirePrimeInt.Next(0, listFiremodePrime.Count);
                        this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = listFiremodePrime[randomFirePrimeNumber] });
                    }
                    else
                    {
                        System.Random randomFireInt = new System.Random();
                        int randomFireNumber = randomFireInt.Next(0, listFiremode.Count);
                        this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = listFiremode[randomFireNumber] });
                    }
                }
                // Rechamber Randomizer

                System.Random randomRechamberInt = new System.Random();
                int randomRechamberNumber = randomRechamberInt.Next(0, listRechamber.Count);
                string randomChamber = listRechamber[randomRechamberNumber];

                // Grab randomized chamber stats from json and set to variable chamber
                string chamberJsonFilename = $".\\JSON\\Chamber\\{randomChamber}.json";
                string chamberJsonString = File.ReadAllText(chamberJsonFilename);
                Chamber chamberSel = JsonConvert.DeserializeObject<Chamber>(chamberJsonString)!;

                // Apply Chamber Stats to Weapon
                if (weapon.AmmoType != "Energy")
                {
                    weapon.Damage = weapon.DamageMult * chamberSel.Damage;
                    weapon.AmmoType = chamberSel.AmmoType;
                    weapon.Projectiles = chamberSel.Projectiles;
                }
                // Add Rechamber roll to Grid
                if (weapon.AmmoType == "Energy")
                {
                    this.build_box.Items[5] = (new MyItem { Item = "Rechamber", Selection = "Cannot be rechambered" });
                }
                else
                {
                    if ((bool)Rechamber.IsChecked == true || (bool)allAttachmentsCheckbox.IsChecked == true)
                    {
                        this.build_box.Items[5] = (new MyItem { Item = "Rechamber", Selection = listRechamber[randomRechamberNumber] });
                    }
                }

            }
            if ((bool)barrels.IsChecked == true && (bool)allAttachmentsCheckbox.IsChecked == false)
            {
                System.Random randomBarrelInt = new System.Random();
                int randomBarrelNumber = randomBarrelInt.Next(0, listBarrels.Count);
                this.build_box.Items[1] = (new MyItem { Item = "Barrel", Selection = listBarrels[randomBarrelNumber] });
            }
            if ((bool)optics.IsChecked == true && (bool)allAttachmentsCheckbox.IsChecked == false)
            {
                System.Random randomOpticInt = new System.Random();
                int randomOpticNumber = randomOpticInt.Next(0, listOptics.Count);
                this.build_box.Items[2] = (new MyItem { Item = "Optic", Selection = listOptics[randomOpticNumber] });
            }
            if ((bool)Laser.IsChecked == true && (bool)allAttachmentsCheckbox.IsChecked == false)
            {
                System.Random randomLaserInt = new System.Random();
                int randomLaserNumber = randomLaserInt.Next(0, listLaser.Count);
                this.build_box.Items[3] = (new MyItem { Item = "Laser", Selection = listLaser[randomLaserNumber] });
            }
            if ((bool)FiringMode.IsChecked == true && (bool)allAttachmentsCheckbox.IsChecked == false)
            {
                if (randomGun == "Breacher 8" || randomGun == "Wyatt PULSAR" || randomGun == "Unknown" || randomGun == "Catacoil Random X" || randomGun == "Impala Gravita" || randomGun == "D4RT")
                {
                    this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = "N/A" });
                }
                else
                {
                    if (randomGun == "P38 Dirk" || randomGun == "Socom 9" || randomGun == "Star & Witness" || randomGun == "Gravekeeper" || randomGun == "Beck 8" || randomGun == "Salamander" || randomGun == "Bronco 89" || randomGun == "Flicker" || randomGun == "Hell 'N' Back" || randomGun == "Cavalier" || randomGun == "Snut .38" || randomGun == "Palehorse Topclipper" || randomGun == ".357 Balthazar" || randomGun == "Mossman" || randomGun == "Arbiter 2" || randomGun == "Augusta" || randomGun == "1889 Mario" || randomGun == "Majordome" || randomGun == "M3 Termite" || randomGun == "Deathstar PG" || randomGun == "Knop .22" || randomGun == "M182 Pierre-Fusil" || randomGun == "Tailor Marksman MKII" || randomGun == "Farsight" || randomGun == "Rokua .308" || randomGun == "Dolphin 99" || randomGun == "Longboy")
                    {
                        System.Random randomFireCrankInt = new System.Random();
                        int randomFireCrankNumber = randomFireCrankInt.Next(0, listFiremodeCrank.Count);
                        this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = listFiremodeCrank[randomFireCrankNumber] });
                    }
                    else if (randomGun == "Flock 76" || randomGun == "Drifter 9" || randomGun == "Vrede" || randomGun == "Ploika Compact" || randomGun == "Ferryman" || randomGun == "Valet" || randomGun == "Corpsemaker" || randomGun == "Type 80 Typhoon" || randomGun == "M11A2 Fisk" || randomGun == "Wingman" || randomGun == "Rektor 100rd" || randomGun == "Duhar" || randomGun == "Neuraxis F22")
                    {
                        System.Random randomFirePrimeInt = new System.Random();
                        int randomFirePrimeNumber = randomFirePrimeInt.Next(0, listFiremodePrime.Count);
                        this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = listFiremodePrime[randomFirePrimeNumber] });
                    }
                    else
                    {
                        System.Random randomFireInt = new System.Random();
                        int randomFireNumber = randomFireInt.Next(0, listFiremode.Count);
                        this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = listFiremode[randomFireNumber] });
                    }
                }
            }
            if ((bool)Rechamber.IsChecked == true && (bool)allAttachmentsCheckbox.IsChecked == false)
            {
                // Rechamber Randomizer

                System.Random randomRechamberInt = new System.Random();
                int randomRechamberNumber = randomRechamberInt.Next(0, listRechamber.Count);
                string randomChamber = listRechamber[randomRechamberNumber];

                // Grab randomized chamber stats from json and set to variable chamber
                string chamberJsonFilename = $".\\JSON\\Chamber\\{randomChamber}.json";
                string chamberJsonString = File.ReadAllText(chamberJsonFilename);
                Chamber chamberSel = JsonConvert.DeserializeObject<Chamber>(chamberJsonString)!;

                // Apply Chamber Stats to Weapon
                if (weapon.AmmoType != "Energy")
                {
                    weapon.Damage = weapon.DamageMult * chamberSel.Damage;
                    weapon.AmmoType = chamberSel.AmmoType;
                    weapon.Projectiles = chamberSel.Projectiles;
                }
                // Add Rechamber roll to Grid
                if (weapon.AmmoType == "Energy")
                {
                    this.build_box.Items[5] = (new MyItem { Item = "Rechamber", Selection = "Cannot be rechambered" });
                }
                else
                {
                    if ((bool)Rechamber.IsChecked == true || (bool)allAttachmentsCheckbox.IsChecked == true)
                    {
                        this.build_box.Items[5] = (new MyItem { Item = "Rechamber", Selection = listRechamber[randomRechamberNumber] });
                    }
                }
            }

            // Enchantment Randomizer

            var oilShuffle = listOils.OrderBy(_ => Guid.NewGuid()).ToList();


            Dictionary<string, string> oilStorage =
            new Dictionary<string, string>();

            oilStorage.Add("0", oilShuffle[0].ToString());
            oilStorage.Add("1", oilShuffle[1].ToString());
            oilStorage.Add("2", oilShuffle[2].ToString());
            oilStorage.Add("3", oilShuffle[3].ToString());
            oilStorage.Add("4", oilShuffle[4].ToString());

            if (enchantment_slider.Value > 0)
            {
                var oilCount = enchantment_slider.Value;
                if (no_scrolls_button.IsChecked == true)
                {
                    oilCount += 1;
                    // First Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilStorage["0"] });
                        oilCount -= 0;
                    }
                    // Second Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilStorage["1"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("1");
                        oilStorage.Remove("2");
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = "None" });
                    }
                    // Third Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilStorage["2"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("2");
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = "None" });
                    }
                    // Fourth Round
                    if (oilCount > 1)
                    {

                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilStorage["3"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = "None" });
                    }
                    // Fifth Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilStorage["4"] });
                    }
                    else
                    {
                        oilStorage.Remove("4");
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = "None" });
                    }

                }
                if (all_scrolls_button.IsChecked == true)
                {
                    System.Random randomAllScrollInt = new System.Random();
                    int randomAllScrollNumber = randomAllScrollInt.Next(0, listAllScrolls.Count);
                    this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = listAllScrolls[randomAllScrollNumber] });
                    oilStorage.Remove("0");
                    // First Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilStorage["1"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("1");
                        oilStorage.Remove("2");
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = "None" });
                    }
                    // Second Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilStorage["2"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("2");
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = "None" });
                    }
                    // Third Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilStorage["3"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = "None" });
                    }
                    // Fourth Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilStorage["4"] });
                    }
                    else
                    {
                        oilStorage.Remove("4");
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = "None" });
                    }
                }
                // Tier 1 Scrolls Selection
                if (t1_scrolls_button.IsChecked == true)
                {
                    System.Random randomT1ScrollInt = new System.Random();
                    int randomT1ScrollNumber = randomT1ScrollInt.Next(0, listT1Scrolls.Count);
                    this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = listT1Scrolls[randomT1ScrollNumber] });
                    oilStorage.Remove("0");
                    // First Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilStorage["1"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("1");
                        oilStorage.Remove("2");
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = "None" });
                    }
                    // Second Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilStorage["2"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("2");
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = "None" });
                    }
                    // Third Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilStorage["3"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = "None" });
                    }
                    // Fourth Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilStorage["4"] });
                    }
                    else
                    {
                        oilStorage.Remove("4");
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = "None" });
                    }
                }
                // Tier 2 Scrolls Selection
                if (t2_scrolls_button.IsChecked == true)
                {
                    System.Random randomT2ScrollInt = new System.Random();
                    int randomT2ScrollNumber = randomT2ScrollInt.Next(0, listAllScrolls.Count);
                    this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = listT2Scrolls[randomT2ScrollNumber] });
                    oilStorage.Remove("0");
                    // First Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilStorage["1"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("1");
                        oilStorage.Remove("2");
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = "None" });
                    }
                    // Second Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilStorage["2"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("2");
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = "None" });
                    }
                    // Third Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilStorage["3"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = "None" });
                    }
                    // Fourth Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilStorage["4"] });
                    }
                    else
                    {
                        oilStorage.Remove("4");
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = "None" });
                    }
                }
                // Manual Scroll Selection
                if (choose_scrolls_button.IsChecked == true)
                {
                    var rawScrollSelect = scroll_dropdown.Text;
                    this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = rawScrollSelect });
                    oilStorage.Remove("0");
                    // First Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilStorage["1"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("1");
                        oilStorage.Remove("2");
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = "None" });
                    }
                    // Second Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilStorage["2"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("2");
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = "None" });
                    }
                    // Third Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilStorage["3"] });
                        oilCount -= 0;
                    }
                    else
                    {
                        oilStorage.Remove("3");
                        oilStorage.Remove("4");
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = "None" });
                    }
                    // Fourth Round
                    if (oilCount > 1)
                    {
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilStorage["4"] });
                    }
                    else
                    {
                        oilStorage.Remove("4");
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = "None" });
                    }
                }

            }
            if (enchantment_slider.Value == 0)
            {
                oilStorage.Remove("0");
                oilStorage.Remove("1");
                oilStorage.Remove("2");
                oilStorage.Remove("3");
                oilStorage.Remove("4");
            }

            // Equipment Randomizer
            if (allEquipmentCheckbox.IsChecked == true)
            {
                // Add Head Equipment
                System.Random randomHeadInt = new System.Random();
                int randomHeadNumber = randomHeadInt.Next(0, listHeadEquipment.Count);
                this.build_box.Items[11] = (new MyItem { Item = "Head Equipment", Selection = listHeadEquipment[randomHeadNumber] });

                // Add Body Equipment
                System.Random randomBodyInt = new System.Random();
                int randomBodyNumber = randomBodyInt.Next(0, listBodyEquipment.Count);
                this.build_box.Items[12] = (new MyItem { Item = "Body Equipment", Selection = listBodyEquipment[randomBodyNumber] });

                // Add Left Foot Equipment
                System.Random randomLFootInt = new System.Random();
                int randomLFootNumber = randomLFootInt.Next(0, listFootEquipment.Count);
                this.build_box.Items[13] = (new MyItem { Item = "Left Foot", Selection = listFootEquipment[randomLFootNumber] });

                // Add Right Foot Equipment
                System.Random randomRFootInt = new System.Random();
                int randomRFootNumber = randomRFootInt.Next(0, listFootEquipment.Count);
                this.build_box.Items[14] = (new MyItem { Item = "Right Foot", Selection = listFootEquipment[randomRFootNumber] });

                // Add Trinket 1
                System.Random randomTrinket1Int = new System.Random();
                int randomTrinket1Number = randomTrinket1Int.Next(0, listTrinkets.Count);
                this.build_box.Items[15] = (new MyItem { Item = "Trinket 1", Selection = listTrinkets[randomTrinket1Number] });

                // Add Trinket 2
                System.Random randomTrinket2Int = new System.Random();
                int randomTrinket2Number = randomTrinket2Int.Next(0, listTrinkets.Count);
                this.build_box.Items[16] = (new MyItem { Item = "Trinket 2", Selection = listTrinkets[randomTrinket2Number] });

                // Add Trinket 3
                System.Random randomTrinket3Int = new System.Random();
                int randomTrinket3Number = randomTrinket3Int.Next(0, listTrinkets.Count);
                this.build_box.Items[17] = (new MyItem { Item = "Trinket 3", Selection = listTrinkets[randomTrinket3Number] });

                // Add Trinket 4
                System.Random randomTrinket4Int = new System.Random();
                int randomTrinket4Number = randomTrinket4Int.Next(0, listTrinkets.Count);
                this.build_box.Items[18] = (new MyItem { Item = "Trinket 4", Selection = listTrinkets[randomTrinket4Number] });
            }
            if (headEquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                System.Random randomHeadInt = new System.Random();
                int randomHeadNumber = randomHeadInt.Next(0, listHeadEquipment.Count);
                this.build_box.Items[11] = (new MyItem { Item = "Head Equipment", Selection = listHeadEquipment[randomHeadNumber] });
            }
            if (bodyEquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                System.Random randomBodyInt = new System.Random();
                int randomBodyNumber = randomBodyInt.Next(0, listBodyEquipment.Count);
                this.build_box.Items[12] = (new MyItem { Item = "Body Equipment", Selection = listBodyEquipment[randomBodyNumber] });
            }
            if (leftFootEquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                System.Random randomLFootInt = new System.Random();
                int randomLFootNumber = randomLFootInt.Next(0, listFootEquipment.Count);
                this.build_box.Items[13] = (new MyItem { Item = "Left Foot", Selection = listFootEquipment[randomLFootNumber] });
            }
            if (rightFootEquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                System.Random randomRFootInt = new System.Random();
                int randomRFootNumber = randomRFootInt.Next(0, listFootEquipment.Count);
                this.build_box.Items[14] = (new MyItem { Item = "Right Foot", Selection = listFootEquipment[randomRFootNumber] });
            }
            if (trinket1EquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                // Add Trinket 1
                System.Random randomTrinket1Int = new System.Random();
                int randomTrinket1Number = randomTrinket1Int.Next(0, listTrinkets.Count);
                this.build_box.Items[15] = (new MyItem { Item = "Trinket 1", Selection = listTrinkets[randomTrinket1Number] });
            }
            if (trinket2EquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                System.Random randomTrinket2Int = new System.Random();
                int randomTrinket2Number = randomTrinket2Int.Next(0, listTrinkets.Count);
                this.build_box.Items[16] = (new MyItem { Item = "Trinket 2", Selection = listTrinkets[randomTrinket2Number] });
            }
            if (trinket3EquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                System.Random randomTrinket3Int = new System.Random();
                int randomTrinket3Number = randomTrinket3Int.Next(0, listTrinkets.Count);
                this.build_box.Items[17] = (new MyItem { Item = "Trinket 3", Selection = listTrinkets[randomTrinket3Number] });
            }
            if (trinket4EquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                System.Random randomTrinket4Int = new System.Random();
                int randomTrinket4Number = randomTrinket4Int.Next(0, listTrinkets.Count);
                this.build_box.Items[18] = (new MyItem { Item = "Trinket 4", Selection = listTrinkets[randomTrinket4Number] });
            }





            // Oil Math
            // Create modifier object oil
            string oilModifierJsonFilename = ".\\JSON\\Oils\\!OilRolls.json";
            string oilModifierJsonString = File.ReadAllText(oilModifierJsonFilename);
            Oil oilModifierStats = JsonConvert.DeserializeObject<Oil>(oilModifierJsonString)!;
            foreach (var oil in oilStorage)
            {
                string oilJsonFilename = $".\\JSON\\Oils\\{oil.Value}.json";
                string oilJsonString = File.ReadAllText(oilJsonFilename);
                Oil oilStats = JsonConvert.DeserializeObject<Oil>(oilJsonString)!;

                if (oilStats.BulletConsumeChance != 0.0)
                {
                    oilModifierStats.BulletConsumeChance += oilStats.BulletConsumeChance;
                }
                if (oilStats.Bounces != 0)
                {
                    oilModifierStats.Bounces += oilStats.Bounces;
                }
                if (oilStats.BulletDrop != 0)
                {
                    oilModifierStats.BulletDrop += oilStats.BulletDrop;
                }
                if (oilStats.BulletSpeed != 0.0)
                {
                    oilModifierStats.BulletSpeed += oilStats.BulletSpeed;
                }
                if (oilStats.ExtraAmmoUseChance != 0.0)
                {
                    oilModifierStats.ExtraAmmoUseChance += oilStats.ExtraAmmoUseChance;
                }
                if (oilStats.BaseCritChance != 0.0)
                {
                    oilModifierStats.BaseCritChance += oilStats.BaseCritChance;
                }
                if (oilStats.DamageAdd != 0.0)
                {
                    oilModifierStats.DamageAdd += oilStats.DamageAdd;
                }
                if (oilStats.DamageMult != 0.0)
                {
                    oilModifierStats.DamageMult += oilStats.DamageMult;
                }
                if (oilStats.CanADS != "Yes")
                {
                    oilModifierStats.CanADS = oilStats.CanADS;
                }
                if (oilStats.JumpPower != 0.0)
                {
                    oilModifierStats.JumpPower += oilStats.JumpPower;
                }
                if (oilStats.LootDropChance != 0.0)
                {
                    oilModifierStats.LootDropChance += oilStats.LootDropChance;
                }
                if (oilStats.DurabilityMult != 0.0)
                {
                    oilModifierStats.DurabilityMult += oilStats.DurabilityMult;
                }
                if (oilStats.MovementSpeedMult != 0.0)
                {
                    oilModifierStats.MovementSpeedMult += oilStats.MovementSpeedMult;
                }
                if (oilStats.MoneyDrops != "Yes")
                {
                    oilModifierStats.MoneyDrops = oilStats.MoneyDrops;
                }
                if (oilStats.OrganDrops != "Yes")
                {
                    oilModifierStats.OrganDrops = oilStats.OrganDrops;
                }
                if (oilStats.Penetrations != 0)
                {
                    oilModifierStats.Penetrations += oilStats.Penetrations;
                }
                if (oilStats.ProjectileMult != 0.0)
                {
                    oilModifierStats.ProjectileMult += oilStats.ProjectileMult;
                }
                if (oilStats.RPM != 0.0)
                {
                    oilModifierStats.RPM += oilStats.RPM;
                }
                if (oilStats.RecoilAdd != 0.0)
                {
                    oilModifierStats.RecoilAdd += oilStats.RecoilAdd;
                }
                if (oilStats.RecoilMult != 0.0)
                {
                    oilModifierStats.RecoilMult += oilStats.RecoilMult;
                }
                if (oilStats.ReloadSpeed != 0.0)
                {
                    oilModifierStats.ReloadSpeed += oilStats.ReloadSpeed;
                }
                if (oilStats.SpreadAdd != 0.0)
                {
                    oilModifierStats.SpreadAdd += oilStats.SpreadAdd;
                }
                if (oilStats.SpreadMult != 0.0)
                {
                    oilModifierStats.SpreadMult += oilStats.SpreadMult;
                }
                if (oilStats.Drag != 0.0)
                {
                    oilModifierStats.Drag += oilStats.Drag;
                }
                if (oilStats.DurabilityUsage != 0.0)
                {
                    oilModifierStats.DurabilityUsage += oilStats.DurabilityUsage;
                }
            }

            // Oils to Weapon calculations & card additions
            //// Clear Card fields
            this.cardDamage.Inlines.Clear();
            this.cardDamageTotal.Inlines.Clear();
            this.cardSpread.Inlines.Clear();
            this.cardBaseCritChance.Inlines.Clear();
            this.cardBounces.Inlines.Clear();
            this.cardReloadSpeed.Inlines.Clear();
            this.cardBulletSpeed.Inlines.Clear();
            this.cardCanADS.Inlines.Clear();
            this.cardLootDropChance.Inlines.Clear();
            this.cardDrag.Inlines.Clear();
            this.cardDurabilityUsage.Inlines.Clear();
            this.cardRPM.Inlines.Clear();
            this.cardDurability.Inlines.Clear();
            this.cardADSCritChance.Inlines.Clear();
            this.cardPenetrations.Inlines.Clear();
            this.cardRecoil.Inlines.Clear();
            this.cardMoneyDrops.Inlines.Clear();
            this.cardOrganDrops.Inlines.Clear();
            this.cardWeaponWeight.Inlines.Clear();
            this.cardMovementSpeedModifier.Inlines.Clear();
            this.cardFinalMovementSpeed.Inlines.Clear();
            this.cardBulletConsumeChance.Inlines.Clear();
            this.cardExtraAmmoUseChance.Inlines.Clear();
            this.cardBulletDrop.Inlines.Clear();
            this.cardJumpPower.Inlines.Clear();
            //// Create generic inline runs
            var runSpace = " ";

            var runX = "x";

            /////////////
            //// RPM ////
            /////////////

            weapon.RPM *= (1 + oilModifierStats.RPM);

            if (weapon.RPM > weaponOriginal.RPM)
            {
                Run runRPM = new Run($"{weapon.RPM.ToString("#####0.#")}");
                runRPM.Foreground = Brushes.Lime;

                Run runArrowUp = new Run("🡅");
                runArrowUp.Foreground = Brushes.Lime;

                Run runNoRPM = new Run($"({weaponOriginal.RPM})");
                runNoRPM.FontFamily = new FontFamily("Fredoka Light");

                this.cardRPM.Inlines.Add("RPM: ");
                this.cardRPM.Inlines.Add(runRPM);
                this.cardRPM.Inlines.Add(runArrowUp);
                this.cardRPM.Inlines.Add(runSpace);
                this.cardRPM.Inlines.Add(runNoRPM);
            }
            if (weapon.RPM < weaponOriginal.RPM)
            {
                Run runRPM = new Run($"{weapon.RPM.ToString("#####0.#")}");
                runRPM.Foreground = Brushes.OrangeRed;

                Run runArrowDown = new Run("🡇");
                runArrowDown.Foreground = Brushes.OrangeRed;

                Run runNoRPM = new Run($"({weaponOriginal.RPM})");
                runNoRPM.FontFamily = new FontFamily("Fredoka Light");

                this.cardRPM.Inlines.Add("RPM: ");
                this.cardRPM.Inlines.Add(runRPM);
                this.cardRPM.Inlines.Add(runArrowDown);
                this.cardRPM.Inlines.Add(runSpace);
                this.cardRPM.Inlines.Add(runNoRPM);
            }
            if (weapon.RPM == weaponOriginal.RPM)
            {
                this.cardRPM.Inlines.Add($"RPM: {weapon.RPM}");
            }

            ///////////////////////////////
            //// Bullet Consume Chance ////
            ///////////////////////////////

            weapon.BulletConsumeChance += oilModifierStats.BulletConsumeChance;
            weapon.BulletConsumeChance *= 100;
            this.cardDebug2.Inlines.Add(weapon.BulletConsumeChance.ToString("#####0.#"));

            if (weapon.BulletConsumeChance < 100)
            {
                Run runBulletConsumeChance = new Run($"{weapon.BulletConsumeChance.ToString("#####0.#")}%");
                runBulletConsumeChance.Foreground = Brushes.Lime;

                Run runArrowDown = new Run("🡇");
                runArrowDown.Foreground = Brushes.Lime;

                Run runNoBulletConsumeChance = new Run("(100%)");
                runNoBulletConsumeChance.FontFamily = new FontFamily("Fredoka Light");

                this.cardBulletConsumeChance.Inlines.Add("Bullet Consume Chance: ");
                this.cardBulletConsumeChance.Inlines.Add(runBulletConsumeChance);
                this.cardBulletConsumeChance.Inlines.Add(runArrowDown);
                this.cardBulletConsumeChance.Inlines.Add(runSpace);
                this.cardBulletConsumeChance.Inlines.Add(runNoBulletConsumeChance);
            }
            if (weapon.BulletConsumeChance == 100)
            {
                this.cardBulletConsumeChance.Inlines.Add("Bullet Consume Chance: 100%");
            }

            ///////////////////////////////
            //// Extra Ammo Use Chance ////
            ///////////////////////////////

            weapon.ExtraAmmoUseChance += oilModifierStats.ExtraAmmoUseChance;
            weapon.ExtraAmmoUseChance *= 100;

            if (weapon.ExtraAmmoUseChance > 0.0)
            {
                Run runExtraAmmoUseChance = new Run($"{weapon.ExtraAmmoUseChance.ToString("#####0.#")}%");
                runExtraAmmoUseChance.Foreground = Brushes.OrangeRed;

                Run runArrowUp = new Run("🡅");
                runArrowUp.Foreground = Brushes.OrangeRed;

                Run runNoExtraAmmoUseChance = new Run("(0%)");
                runNoExtraAmmoUseChance.FontFamily = new FontFamily("Fredoka Light");

                this.cardExtraAmmoUseChance.Inlines.Add("Extra Ammo Use Chance: ");
                this.cardExtraAmmoUseChance.Inlines.Add(runExtraAmmoUseChance);
                this.cardExtraAmmoUseChance.Inlines.Add(runArrowUp);
                this.cardExtraAmmoUseChance.Inlines.Add(runSpace);
                this.cardExtraAmmoUseChance.Inlines.Add(runNoExtraAmmoUseChance);
            }
            if (weapon.ExtraAmmoUseChance == 0)
            {
                this.cardExtraAmmoUseChance.Inlines.Add("Extra Ammo Use Chance: 0%");
            }

            /////////////////
            //// Bounces ////
            /////////////////

            weapon.Bounces = oilModifierStats.Bounces;

            if (weapon.Bounces > 0.0)
            {
                Run runBounces = new Run(weapon.Bounces.ToString("#####0.#"));
                runBounces.Foreground = Brushes.Lime;

                Run runArrowUp1 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;

                Run runNoBounce = new Run("(0)");
                runNoBounce.FontFamily = new FontFamily("Fredoka Light");

                this.cardBounces.Inlines.Add("Bounces: ");
                this.cardBounces.Inlines.Add(runBounces);
                this.cardBounces.Inlines.Add(runArrowUp1);
                this.cardBounces.Inlines.Add(runSpace);
                this.cardBounces.Inlines.Add(runNoBounce);
            }
            else
            {
                this.cardBounces.Inlines.Add("Bounces: ");
                this.cardBounces.Inlines.Add(weapon.Bounces.ToString("#####0.#"));
            }

            /////////////////////
            //// Bullet Drop ////
            /////////////////////

            weapon.BulletDrop += oilModifierStats.BulletDrop;

            if (weapon.BulletDrop > 0)
            {
                Run runBulletDrop = new Run($"{weapon.BulletDrop.ToString("#####0.#")}");
                runBulletDrop.Foreground = Brushes.OrangeRed;

                Run runArrowUp = new Run("🡅");
                runArrowUp.Foreground = Brushes.OrangeRed;

                Run runNoBulletDrop = new Run("(0)");
                runNoBulletDrop.FontFamily = new FontFamily("Fredoka Light");

                this.cardBulletDrop.Inlines.Add("Bullet Drop: ");
                this.cardBulletDrop.Inlines.Add(runBulletDrop);
                this.cardBulletDrop.Inlines.Add(runArrowUp);
                this.cardBulletDrop.Inlines.Add(runSpace);
                this.cardBulletDrop.Inlines.Add(runNoBulletDrop);
            }
            if (weapon.BulletDrop == 0)
            {
                this.cardBulletDrop.Inlines.Add("Bullet Drop: 0");
            }

            //////////////////////
            //// Bullet Speed ////
            //////////////////////

            weapon.BulletSpeed += ((1 + oilModifierStats.BulletSpeed) * 100);

            if (weapon.BulletSpeed > 100)
            {
                Run runBulletSpeed = new Run($"{weapon.BulletSpeed.ToString("#####0.#")}%");
                runBulletSpeed.Foreground = Brushes.Lime;

                Run runArrowUp = new Run("🡅");
                runArrowUp.Foreground = Brushes.Lime;

                Run runNoBulletSpeed = new Run("(100%)");
                runNoBulletSpeed.FontFamily = new FontFamily("Fredoka Light");

                this.cardBulletSpeed.Inlines.Add("Bullet Speed: ");
                this.cardBulletSpeed.Inlines.Add(runBulletSpeed);
                this.cardBulletSpeed.Inlines.Add(runArrowUp);
                this.cardBulletSpeed.Inlines.Add(runSpace);
                this.cardBulletSpeed.Inlines.Add(runNoBulletSpeed);
            }
            if (weapon.BulletSpeed < 100)
            {
                Run runBulletSpeed = new Run($"{weapon.BulletSpeed.ToString("#####0.#")}%");
                runBulletSpeed.Foreground = Brushes.OrangeRed;

                Run runArrowDown = new Run("🡇");
                runArrowDown.Foreground = Brushes.OrangeRed;

                Run runNoBulletSpeed = new Run("(100%)");
                runNoBulletSpeed.FontFamily = new FontFamily("Fredoka Light");

                this.cardBulletSpeed.Inlines.Add("Bullet Speed: ");
                this.cardBulletSpeed.Inlines.Add(runBulletSpeed);
                this.cardBulletSpeed.Inlines.Add(runArrowDown);
                this.cardBulletSpeed.Inlines.Add(runSpace);
                this.cardBulletSpeed.Inlines.Add(runNoBulletSpeed);
            }
            if (weapon.BulletSpeed == 100)
            {
                this.cardBulletSpeed.Inlines.Add("Bullet Speed: 100%");
            }

            //////////////////////////
            //// Base Crit Chance ////
            //////////////////////////

            weapon.BaseCritChance += (oilModifierStats.BaseCritChance * 100);

            if (weapon.BaseCritChance > 0.0)
            {
                Run runCrit = new Run($"{weapon.BaseCritChance.ToString("#####0.#")}%");
                runCrit.Foreground = Brushes.Lime;

                Run runArrowUp1 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;

                Run runNoCrit = new Run("(0%)");
                runNoCrit.FontFamily = new FontFamily("Fredoka Light");

                this.cardBaseCritChance.Inlines.Add("Base Crit Chance: ");
                this.cardBaseCritChance.Inlines.Add(runCrit);
                this.cardBaseCritChance.Inlines.Add(runArrowUp1);
                this.cardBaseCritChance.Inlines.Add(runSpace);
                this.cardBaseCritChance.Inlines.Add(runNoCrit);
            }
            else
            {
                this.cardBaseCritChance.Inlines.Add("Base Crit Chance: 0%");
            }

            //////////////////////////////
            //// Damage & Projectiles ////
            //////////////////////////////

            //// Projectiles
            weapon.Projectiles *= (1 + oilModifierStats.ProjectileMult);
            //// Damage Add
            weapon.Damage += oilModifierStats.DamageAdd;
            //// Damage Multiplier
            weapon.Damage *= (1 + oilModifierStats.DamageMult);
            //// Total Damage Calc
            weapon.TotalDamage = weapon.Damage * weapon.Projectiles;

            Run runDmgProjOrig = new Run($"({weaponOriginal.Damage.ToString("#####0.#")}x{weaponOriginal.Projectiles.ToString("#####0.#")})");
            runDmgProjOrig.FontFamily = new FontFamily("Fredoka Light");

            ////// Damage & Projectiles card addition
            if (weapon.Damage < weaponOriginal.Damage)
            {
                Run runDamageFinal = new Run(weapon.Damage.ToString("#####0.#"));
                runDamageFinal.Foreground = Brushes.OrangeRed;

                Run runArrowDown1 = new Run("🡇");
                runArrowDown1.Foreground = Brushes.OrangeRed;
                Run runArrowDown2 = new Run("🡇");
                runArrowDown2.Foreground = Brushes.OrangeRed;

                Run runArrowUp1 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;
                Run runArrowUp2 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;


                if (weapon.Projectiles < weaponOriginal.Projectiles)
                {
                    Run runProjFinal = new Run(weapon.Projectiles.ToString());
                    runProjFinal.Foreground = Brushes.OrangeRed;

                    this.cardDamage.Inlines.Add("Damage: ");
                    this.cardDamage.Inlines.Add(runDamageFinal);
                    this.cardDamage.Inlines.Add(runArrowDown1);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runX);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runProjFinal);
                    this.cardDamage.Inlines.Add(runArrowDown2);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runDmgProjOrig);
                }
                if (weapon.Projectiles > weaponOriginal.Projectiles)
                {
                    Run runProjFinal = new Run(weapon.Projectiles.ToString("#####0.#"));
                    runProjFinal.Foreground = Brushes.Lime;

                    this.cardDamage.Inlines.Add("Damage: ");
                    this.cardDamage.Inlines.Add(runDamageFinal);
                    this.cardDamage.Inlines.Add(runArrowDown1);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runX);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runProjFinal);
                    this.cardDamage.Inlines.Add(runArrowUp1);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runDmgProjOrig);
                }
                if (weapon.Projectiles == weaponOriginal.Projectiles)
                {
                    this.cardDamage.Inlines.Add("Damage: ");
                    this.cardDamage.Inlines.Add(runDamageFinal);
                    this.cardDamage.Inlines.Add(runArrowDown1);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runX);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(weapon.Projectiles.ToString());
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runDmgProjOrig);
                }
            }
            if (weapon.Damage > weaponOriginal.Damage)
            {
                Run runDamageFinal = new Run(weapon.Damage.ToString("#####0.#"));
                runDamageFinal.Foreground = Brushes.Lime;

                Run runArrowDown1 = new Run("🡇");
                runArrowDown1.Foreground = Brushes.OrangeRed;
                Run runArrowDown2 = new Run("🡇");
                runArrowDown2.Foreground = Brushes.OrangeRed;

                Run runArrowUp1 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;
                Run runArrowUp2 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;


                if (weapon.Projectiles < weaponOriginal.Projectiles)
                {
                    Run runProjFinal = new Run(weapon.Projectiles.ToString("#####0.#"));
                    runProjFinal.Foreground = Brushes.OrangeRed;

                    this.cardDamage.Inlines.Add("Damage: ");
                    this.cardDamage.Inlines.Add(runDamageFinal);
                    this.cardDamage.Inlines.Add(runArrowUp1);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runX);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runProjFinal);
                    this.cardDamage.Inlines.Add(runArrowDown1);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runDmgProjOrig);
                }
                if (weapon.Projectiles > weaponOriginal.Projectiles)
                {
                    Run runProjFinal = new Run(weapon.Projectiles.ToString("#####0.#"));
                    runProjFinal.Foreground = Brushes.Lime;

                    this.cardDamage.Inlines.Add("Damage: ");
                    this.cardDamage.Inlines.Add(runDamageFinal);
                    this.cardDamage.Inlines.Add(runArrowUp1);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runX);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runProjFinal);
                    this.cardDamage.Inlines.Add(runArrowUp2);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runDmgProjOrig);
                }
                if (weapon.Projectiles == weaponOriginal.Projectiles)
                {
                    this.cardDamage.Inlines.Add("Damage: ");
                    this.cardDamage.Inlines.Add(runDamageFinal);
                    this.cardDamage.Inlines.Add(runArrowUp1);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runX);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(weapon.Projectiles.ToString());
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runDmgProjOrig);
                }
            }
            if (weapon.Damage == weaponOriginal.Damage)
            {
                Run runArrowDown1 = new Run("🡇");
                runArrowDown1.Foreground = Brushes.OrangeRed;
                Run runArrowDown2 = new Run("🡇");
                runArrowDown2.Foreground = Brushes.OrangeRed;

                Run runArrowUp1 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;
                Run runArrowUp2 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;


                if (weapon.Projectiles < weaponOriginal.Projectiles)
                {
                    Run runProjFinal = new Run(weapon.Projectiles.ToString("#####0.#"));
                    runProjFinal.Foreground = Brushes.OrangeRed;

                    this.cardDamage.Inlines.Add("Damage: ");
                    this.cardDamage.Inlines.Add(weapon.Damage.ToString());
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runX);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runProjFinal);
                    this.cardDamage.Inlines.Add(runArrowDown1);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runDmgProjOrig);
                }
                if (weapon.Projectiles > weaponOriginal.Projectiles)
                {
                    Run runProjFinal = new Run(weapon.Projectiles.ToString("#####0.#"));
                    runProjFinal.Foreground = Brushes.Lime;

                    this.cardDamage.Inlines.Add("Damage: ");
                    this.cardDamage.Inlines.Add(weapon.Damage.ToString());
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runX);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runProjFinal);
                    this.cardDamage.Inlines.Add(runArrowUp1);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runDmgProjOrig);
                }
                if (weapon.Projectiles == weaponOriginal.Projectiles)
                {
                    this.cardDamage.Inlines.Add("Damage: ");
                    this.cardDamage.Inlines.Add(weapon.Damage.ToString());
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(runX);
                    this.cardDamage.Inlines.Add(runSpace);
                    this.cardDamage.Inlines.Add(weapon.Projectiles.ToString("#####0.#"));
                    this.cardDamage.Inlines.Add(runSpace);
                }
            }

            ////// Total Damage card addition

            Run runTotDmgOrig = new Run($"({weaponOriginal.TotalDamage.ToString("#####0.#")})");
            runTotDmgOrig.FontFamily = new FontFamily("Fredoka Light");

            if (weapon.TotalDamage > weaponOriginal.TotalDamage)
            {
                Run runTotDmgFinal = new Run(weapon.TotalDamage.ToString("#####0.#"));
                runTotDmgFinal.Foreground = Brushes.Lime;

                Run runArrowDown1 = new Run("🡇");
                runArrowDown1.Foreground = Brushes.OrangeRed;
                Run runArrowDown2 = new Run("🡇");
                runArrowDown2.Foreground = Brushes.OrangeRed;

                Run runArrowUp1 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;
                Run runArrowUp2 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;


                this.cardDamageTotal.Inlines.Add("Total: ");
                this.cardDamageTotal.Inlines.Add(runTotDmgFinal);
                this.cardDamageTotal.Inlines.Add(runArrowUp1);
                this.cardDamageTotal.Inlines.Add(runSpace);
                this.cardDamageTotal.Inlines.Add(runTotDmgOrig);
            }
            if (weapon.TotalDamage < weaponOriginal.TotalDamage)
            {
                Run runTotDmgFinal = new Run(weapon.TotalDamage.ToString("#####0.#"));
                runTotDmgFinal.Foreground = Brushes.OrangeRed;

                Run runArrowDown1 = new Run("🡇");
                runArrowDown1.Foreground = Brushes.OrangeRed;
                Run runArrowDown2 = new Run("🡇");
                runArrowDown2.Foreground = Brushes.OrangeRed;

                Run runArrowUp1 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;
                Run runArrowUp2 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;


                this.cardDamageTotal.Inlines.Add("Total: ");
                this.cardDamageTotal.Inlines.Add(runTotDmgFinal);
                this.cardDamageTotal.Inlines.Add(runArrowDown1);
                this.cardDamageTotal.Inlines.Add(runSpace);
                this.cardDamageTotal.Inlines.Add(runTotDmgOrig);
            }
            if (weapon.TotalDamage == weaponOriginal.TotalDamage)
            {
                this.cardDamageTotal.Inlines.Add("Total: ");
                this.cardDamageTotal.Inlines.Add(weapon.TotalDamage.ToString("#####0.#"));
            }

            /////////////////
            //// Can ADS ////
            /////////////////

            weapon.CanADS = oilModifierStats.CanADS;

            if (weapon.CanADS == "No")
            {
                Run runCanADS = new Run(weapon.CanADS);
                runCanADS.Foreground = Brushes.Goldenrod;

                this.cardCanADS.Inlines.Add("Can ADS: ");
                this.cardCanADS.Inlines.Add(runCanADS);
            }
            if (weapon.CanADS == "Yes")
            {
                this.cardCanADS.Inlines.Add("Can ADS: Yes");
            }

            ////////////////////
            //// Jump Power ////
            ////////////////////

            weapon.JumpPower += oilModifierStats.JumpPower;
            weapon.JumpPower *= 100;
            weaponOriginal.JumpPower *= 100;

            if (weapon.JumpPower < weaponOriginal.JumpPower)
            {
                Run runJump = new Run($"{weapon.JumpPower.ToString("#####0.#")}%");
                runJump.Foreground = Brushes.OrangeRed;

                Run runArrowDown = new Run("🡇");
                runArrowDown.Foreground = Brushes.OrangeRed;

                Run runNoJump = new Run($"{weaponOriginal.JumpPower.ToString("#####0.#")}%");
                runNoJump.FontFamily = new FontFamily("Fredoka Light");

                this.cardJumpPower.Inlines.Add("Jump Power: ");
                this.cardJumpPower.Inlines.Add(runJump);
                this.cardJumpPower.Inlines.Add(runArrowDown);
                this.cardJumpPower.Inlines.Add(runSpace);
                this.cardJumpPower.Inlines.Add(runNoJump);
            }
            if (weapon.JumpPower > weaponOriginal.JumpPower)
            {
                Run runJump = new Run($"{weapon.JumpPower.ToString("#####0.#")}%");
                runJump.Foreground = Brushes.Lime;

                Run runArrowUp = new Run("🡅");
                runArrowUp.Foreground = Brushes.Lime;

                Run runNoJump = new Run($"{weaponOriginal.JumpPower.ToString("#####0.#")}%");
                runNoJump.FontFamily = new FontFamily("Fredoka Light");

                this.cardJumpPower.Inlines.Add("Jump Power: ");
                this.cardJumpPower.Inlines.Add(runJump);
                this.cardJumpPower.Inlines.Add(runArrowUp);
                this.cardJumpPower.Inlines.Add(runSpace);
                this.cardJumpPower.Inlines.Add(runNoJump);
            }
            if (weapon.JumpPower == weaponOriginal.JumpPower)
            {
                this.cardJumpPower.Inlines.Add($"Jump Power: {weapon.JumpPower.ToString("#####0.#")}%");
            }

            //////////////////////////
            //// Loot Drop Chance ////
            //////////////////////////

            weapon.LootDropChance += oilModifierStats.LootDropChance;
            weapon.LootDropChance *= 100;
            weaponOriginal.LootDropChance *= 100;

            if (weapon.LootDropChance < weaponOriginal.LootDropChance)
            {
                Run runLoot = new Run($"{weapon.LootDropChance.ToString("#####0.#")}%");
                runLoot.Foreground = Brushes.OrangeRed;

                Run runArrowDown = new Run("🡇");
                runArrowDown.Foreground = Brushes.OrangeRed;

                Run runNoLoot = new Run($"({weaponOriginal.LootDropChance.ToString("#####0.#")})%");
                runNoLoot.FontFamily = new FontFamily("Fredoka Light");

                this.cardLootDropChance.Inlines.Add("Loot Drop Chance: ");
                this.cardLootDropChance.Inlines.Add(runLoot);
                this.cardLootDropChance.Inlines.Add(runArrowDown);
                this.cardLootDropChance.Inlines.Add(runSpace);
                this.cardLootDropChance.Inlines.Add(runNoLoot);
            }
            if (weapon.LootDropChance == weaponOriginal.LootDropChance)
            {
                this.cardLootDropChance.Inlines.Add($"Loot Drop Chance: {weapon.LootDropChance.ToString("#####0.#")}%");
            }

            ///////////////////////////////
            //// Durability Multiplier ////
            ///////////////////////////////

            weapon.Durability *= (1 + oilModifierStats.DurabilityMult);

            if (weapon.Durability < weaponOriginal.Durability)
            {
                Run runDur = new Run($"{weapon.Durability.ToString("#####0.#")}");
                runDur.Foreground = Brushes.OrangeRed;

                Run runArrowDown = new Run("🡇");
                runArrowDown.Foreground = Brushes.OrangeRed;

                Run runNoDur = new Run(weaponOriginal.Durability.ToString("#####0.#"));
                runNoDur.FontFamily = new FontFamily("Fredoka Light");

                this.cardDurability.Inlines.Add("Durability: ");
                this.cardDurability.Inlines.Add(runDur);
                this.cardDurability.Inlines.Add(runArrowDown);
                this.cardDurability.Inlines.Add(runSpace);
                this.cardDurability.Inlines.Add(runNoDur);
            }
            if (weapon.Durability > weaponOriginal.Durability)
            {
                Run runDur = new Run($"{weapon.Durability.ToString("#####0.#")}");
                runDur.Foreground = Brushes.Lime;

                Run runArrowUp = new Run("🡅");
                runArrowUp.Foreground = Brushes.Lime;

                Run runNoDur = new Run(weaponOriginal.Durability.ToString("#####0.#"));
                runNoDur.FontFamily = new FontFamily("Fredoka Light");

                this.cardDurability.Inlines.Add("Durability: ");
                this.cardDurability.Inlines.Add(runDur);
                this.cardDurability.Inlines.Add(runArrowUp);
                this.cardDurability.Inlines.Add(runSpace);
                this.cardDurability.Inlines.Add(runNoDur);
            }
            if (weapon.Durability == weaponOriginal.Durability)
            {
                this.cardDurability.Inlines.Add($"Durability: {weapon.Durability.ToString("#####0.#")}");
            }


            /////////////////////////
            //// Movement Speed  ////
            /////////////////////////

            double weaponWeightAdjustment = (double)0.0;
            double s = weapon.MovementSpeedModifier;
            //// Duplicate calculation for original comparison
            double resultFirstMvmntStepComp = (1 - weapon.WeightClassFactor) * (1 + weaponWeightAdjustment);
            double resultSecondMvmntStepComp = 1 - resultFirstMvmntStepComp;
            double resultMovementSpeedComp = resultSecondMvmntStepComp * (s * 100);
            //// Actual Calculation
            double resultFirstMvmntStep = (1 - weapon.WeightClassFactor) * (1 + weaponWeightAdjustment);
            double resultSecondMvmntStep = 1 - resultFirstMvmntStep;
            double resultMovementSpeed = resultSecondMvmntStep * (s * 100);
            weapon.FinalMovementSpeed = resultMovementSpeed * (1 + oilModifierStats.MovementSpeedMult);
            //// Comparison for colors
            this.cardFinalMovementSpeed.Inlines.Clear();
            if (weapon.FinalMovementSpeed < resultMovementSpeedComp)
            {
                Run runMovementFinal = new Run(weapon.FinalMovementSpeed.ToString());
                runMovementFinal.Foreground = Brushes.OrangeRed;
                Run runMovementComp = new Run(resultMovementSpeedComp.ToString());
                runMovementComp.Foreground = Brushes.White;

                Run runArrowDown1 = new Run("🡇");
                runArrowDown1.Foreground = Brushes.OrangeRed;
                Run runArrowDown2 = new Run("🡇");
                runArrowDown2.Foreground = Brushes.OrangeRed;

                Run runArrowUp1 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;
                Run runArrowUp2 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;


                this.cardFinalMovementSpeed.Inlines.Add($"Final Movement Speed: {runMovementFinal}%");
                this.cardFinalMovementSpeed.Inlines.Add(runSpace);
                this.cardFinalMovementSpeed.Inlines.Add(runArrowDown1);
                this.cardFinalMovementSpeed.Inlines.Add(runSpace);
                this.cardFinalMovementSpeed.Inlines.Add($"({runMovementComp})%");
            }
            if (weapon.FinalMovementSpeed > resultMovementSpeedComp)
            {
                Run runMovementFinal = new Run(weapon.FinalMovementSpeed.ToString());
                runMovementFinal.Foreground = Brushes.Lime;
                Run runMovementComp = new Run(resultMovementSpeedComp.ToString());
                runMovementComp.Foreground = Brushes.White;

                Run runArrowDown1 = new Run("🡇");
                runArrowDown1.Foreground = Brushes.OrangeRed;
                Run runArrowDown2 = new Run("🡇");
                runArrowDown2.Foreground = Brushes.OrangeRed;

                Run runArrowUp1 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;
                Run runArrowUp2 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;

                this.cardFinalMovementSpeed.Inlines.Add($"Final Movement Speed: {runMovementFinal}%");
                this.cardFinalMovementSpeed.Inlines.Add(runSpace);
                this.cardFinalMovementSpeed.Inlines.Add(runArrowUp1);
                this.cardFinalMovementSpeed.Inlines.Add(runSpace);
                this.cardFinalMovementSpeed.Inlines.Add($"({runMovementComp}%)");
            }
            else
            {
                this.cardFinalMovementSpeed.Inlines.Add($"Final Movement Speed: {weapon.FinalMovementSpeed}%");
            }

            /////////////////////
            //// Money Drops ////
            /////////////////////

            weapon.MoneyDrops = oilModifierStats.MoneyDrops;

            if (weapon.MoneyDrops == "No")
            {
                Run runMon = new Run($"{weapon.MoneyDrops}");
                runMon.Foreground = Brushes.OrangeRed;

                this.cardMoneyDrops.Inlines.Add("Money Drops: ");
                this.cardMoneyDrops.Inlines.Add(runMon);
                this.cardMoneyDrops.Inlines.Add(runSpace);
            }
            if (weapon.MoneyDrops == "Yes")
            {
                this.cardMoneyDrops.Inlines.Add($"Money Drops: {weapon.MoneyDrops}");
            }

            /////////////////////
            //// Organ Drops ////
            /////////////////////

            weapon.OrganDrops = oilModifierStats.OrganDrops;

            if (weapon.OrganDrops == "No")
            {
                Run runOrg = new Run($"{weapon.OrganDrops}");
                runOrg.Foreground = Brushes.OrangeRed;


                this.cardOrganDrops.Inlines.Add("Organ Drops: ");
                this.cardOrganDrops.Inlines.Add(runOrg);
                this.cardOrganDrops.Inlines.Add(runSpace);
            }
            if (weapon.OrganDrops == "Yes")
            {
                this.cardOrganDrops.Inlines.Add($"Organ Drops: {weapon.OrganDrops}");
            }

            //////////////////////
            //// Penetrations ////
            //////////////////////

            weapon.Penetrations += oilModifierStats.Penetrations;

            if (weapon.Penetrations > weaponOriginal.Penetrations)
            {
                Run runPen = new Run($"{weapon.Penetrations.ToString("#####0.#")}");
                runPen.Foreground = Brushes.Lime;

                Run runArrowUp = new Run("🡅");
                runArrowUp.Foreground = Brushes.Lime;

                Run runNoPen = new Run("(0)");
                runNoPen.FontFamily = new FontFamily("Fredoka Light");

                this.cardPenetrations.Inlines.Add("Penetrations: ");
                this.cardPenetrations.Inlines.Add(runPen);
                this.cardPenetrations.Inlines.Add(runArrowUp);
                this.cardPenetrations.Inlines.Add(runSpace);
                this.cardPenetrations.Inlines.Add(runNoPen);
            }
            if (weapon.Penetrations == weaponOriginal.Penetrations)
            {
                this.cardPenetrations.Inlines.Add($"Penetrations: {weapon.Penetrations.ToString()}");
            }

            ////////////////
            //// Recoil ////
            ////////////////

            //// Recoil Add

            //// Recoil Multiplier



            //////////////////////
            //// Reload Speed ////
            //////////////////////

            weapon.ReloadSpeed *= ((1 + oilModifierStats.ReloadSpeed) * 100);
            weaponOriginal.ReloadSpeed *= 100;

            if (weapon.ReloadSpeed < weaponOriginal.ReloadSpeed)
            {
                Run runReload = new Run($"{weapon.ReloadSpeed.ToString("#####0.#")}%");
                runReload.Foreground = Brushes.OrangeRed;

                Run runArrowDown = new Run("🡇");
                runArrowDown.Foreground = Brushes.OrangeRed;

                Run runNoReload = new Run("(100%)");
                runNoReload.FontFamily = new FontFamily("Fredoka Light");

                this.cardReloadSpeed.Inlines.Add("Reload Speed: ");
                this.cardReloadSpeed.Inlines.Add(runReload);
                this.cardReloadSpeed.Inlines.Add(runArrowDown);
                this.cardReloadSpeed.Inlines.Add(runSpace);
                this.cardReloadSpeed.Inlines.Add(runNoReload);
            }
            if (weapon.ReloadSpeed > weaponOriginal.ReloadSpeed)
            {
                Run runReload = new Run($"{weapon.ReloadSpeed.ToString("#####0.#")}%");
                runReload.Foreground = Brushes.Lime;

                Run runArrowUp= new Run("🡅");
                runArrowUp.Foreground = Brushes.Lime;

                Run runNoReload = new Run("(100%)");
                runNoReload.FontFamily = new FontFamily("Fredoka Light");

                this.cardReloadSpeed.Inlines.Add("Reload Speed: ");
                this.cardReloadSpeed.Inlines.Add(runReload);
                this.cardReloadSpeed.Inlines.Add(runArrowUp);
                this.cardReloadSpeed.Inlines.Add(runSpace);
                this.cardReloadSpeed.Inlines.Add(runNoReload);
            }
            if (weapon.ReloadSpeed == weaponOriginal.ReloadSpeed)
            {
                this.cardReloadSpeed.Inlines.Add($"Reload Speed: {weapon.ReloadSpeed.ToString()}%");
            }

            ////////////////
            //// Spread ////
            ////////////////

            //// Spread Add
            weapon.Spread += oilModifierStats.SpreadAdd;
            //// Spread Multiplier
            weapon.Spread *= (1 + oilModifierStats.SpreadMult);

            if (weapon.Spread > weaponOriginal.Spread)
            {
                Run runSpread = new Run($"{weapon.Spread.ToString("#####0.#")}");
                runSpread.Foreground = Brushes.OrangeRed;

                Run runArrowUp = new Run("🡅");
                runArrowUp.Foreground = Brushes.OrangeRed;

                Run runNoSpread = new Run(weaponOriginal.Spread.ToString("#####0.#"));
                runNoSpread.FontFamily = new FontFamily("Fredoka Light");

                this.cardSpread.Inlines.Add("Spread: ");
                this.cardSpread.Inlines.Add(runSpread);
                this.cardSpread.Inlines.Add(runArrowUp);
                this.cardSpread.Inlines.Add(runSpace);
                this.cardSpread.Inlines.Add(runNoSpread);
            }
            if (weapon.Spread < weaponOriginal.Spread)
            {
                Run runSpread = new Run($"{weapon.Spread.ToString("#####0.#")}");
                runSpread.Foreground = Brushes.Lime;

                Run runArrowDown = new Run("🡇");
                runArrowDown.Foreground = Brushes.Lime;

                Run runNoSpread = new Run(weaponOriginal.Spread.ToString("#####0.#"));
                runNoSpread.FontFamily = new FontFamily("Fredoka Light");

                this.cardSpread.Inlines.Add("Spread: ");
                this.cardSpread.Inlines.Add(runSpread);
                this.cardSpread.Inlines.Add(runArrowDown);
                this.cardSpread.Inlines.Add(runSpace);
                this.cardSpread.Inlines.Add(runNoSpread);
            }
            if (weapon.Spread == weaponOriginal.Spread)
            {
                this.cardSpread.Inlines.Add($"Spread: {weapon.Spread.ToString()}");
            }

            //////////////
            //// Drag ////
            //////////////

            weapon.Drag += oilModifierStats.Drag;

            if (weapon.Drag > 0)
            {
                Run runDrag = new Run(weapon.Drag.ToString("#####0.#"));
                runDrag.Foreground = Brushes.Goldenrod;

                Run runArrowUp = new Run("🡅");
                runArrowUp.Foreground = Brushes.Goldenrod;

                Run runNoDrag = new Run("(0)");
                runNoDrag.FontFamily = new FontFamily("Fredoka Light");

                this.cardDrag.Inlines.Add("Drag: ");
                this.cardDrag.Inlines.Add(runDrag);
                this.cardDrag.Inlines.Add(runArrowUp);
                this.cardDrag.Inlines.Add(runSpace);
                this.cardDrag.Inlines.Add(runNoDrag);
            }
            if (weapon.Drag == 0)
            {
                this.cardDrag.Inlines.Add("Drag: 0");
            }

            //////////////////////////
            //// Durability Usage ////
            //////////////////////////

            weapon.DurabilityUsage = oilModifierStats.DurabilityUsage;

            this.cardDurabilityUsage.Inlines.Add($"Durability Usage: {weapon.DurabilityUsage.ToString("#####0.#")}");

            // Add Weapon to Grid
            this.build_box.Items[0] = (new MyItem { Item = "Gun", Selection = weapon.Name });

            // Write Weapon Name to Card
            this.cardWeaponName.Text = weapon.Name;
            this.cardWeaponType.Text = $"Type: {weapon.Type}";
            this.cardAmmoType.Text = $"Ammo Type: {weapon.AmmoType}";
            /*
            this.cardRPM.Inlines.Clear();
            this.cardRPM.Inlines.Add ($"RPM: {weapon.RPM}");
            this.cardMagSize.Text = $"Mag Size: {weapon.MagSize}";
            this.cardSpread.Text = $"Spread: {weapon.Spread}";
            this.cardDurability.Text = $"Durability: {weapon.Durability}";
            this.cardBaseCritChance.Text = $"Base Crit Chance: {weapon.BaseCritChance * 100}%";
            this.cardADSCritChance.Text = $"ADS Crit Chance: {weapon.ADSCritChance * 100}%";
            this.cardPenetrations.Text = $"Penetrations: {weapon.Penetrations}";
            this.cardReloadSpeed.Text = $"Reload Speed: {weapon.ReloadSpeed * 100}%";
            this.cardRecoil.Text = $"Recoil: idfk";
            this.cardCanADS.Text = $"Can ADS: {weapon.CanADS}";
            this.cardMoneyDrops.Text = $"Money Drops: {weapon.MoneyDrops}";
            this.cardOrganDrops.Text = $"Organ Drops: {weapon.OrganDrops}";
            this.cardLootDropChance.Text = $"Loot Drop Chance: {weapon.LootDropChance * 100}%";
            this.cardWeaponWeight.Text = $"Weapon Weight: {weapon.WeaponWeight}";
            this.cardMovementSpeedModifier.Text = $"Movement Speed Modifier: {weapon.MovementSpeedModifier * 100}%";
            this.cardBulletConsumeChance.Text = $"Bullet Consume Chance: {weapon.BulletConsumeChance * 100}%";
            this.cardExtraAmmoUseChance.Text = $"Extra Ammo Use Chance: {weapon.ExtraAmmoUseChance * 100}%";
            this.cardBulletDrop.Text = $"Bullet Drop: {weapon.BulletDrop}";
            this.cardJumpPower.Text = $"Jump Power: {weapon.JumpPower * 100}%";
            this.cardDrag.Text = $"Drag: {weapon.Drag}";
            this.cardDurabilityUsage.Text = $"Durability Usage: {weapon.DurabilityUsage}";*/
        }

        private void choose_scrolls_button_Checked(object sender, RoutedEventArgs e)
        {
            this.scroll_dropdown.IsEnabled = true;
        }

        private void choose_scrolls_button_Unchecked(object sender, RoutedEventArgs e)
        {
            this.scroll_dropdown.IsEnabled = false;
        }
        private List<MyItem> listMyItem = new List<MyItem>();
            private void build_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                foreach (MyItem item in e.RemovedItems)
                {
                    listMyItem.Remove(item);
                }

                foreach (MyItem item in e.AddedItems)
                {
                    listMyItem.Add(item);
                }
            }
    }

    internal class MyItem
    {
        public string Done { get; set; }
        public string Item { get; set; }
        public string Name { get; set; }
        public string Selection { get; set; }
    }
    

}