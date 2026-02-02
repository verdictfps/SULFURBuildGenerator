using System;
using System.Data;
using System.Data.Common;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
        List<string> listOils = new List<string> { "Action Oil",
    "Add Damage Oil",
    "Aimless Oil",
    "Airsoft Oil",
    "Altruistic Oil",
    "Arkanoid Oil",
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
    "Detune Oil",
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
    "Zooming Oil",
};
        List<string> listAllScrolls = new List<string> { "Dark", "Earth", "Embers", "Frostbite", "Light", "Nature", "Plague", "Surge", "Water", "Aftershock", "Chain Lightning", "Chaos Strike", "Charm", "Corpse Explosion", "Crusader", "Explosions", "Fear", "Flame Thrower", "Holy Fire", "Holy Purge", "Lava", "Least Resistance", "Noxiosa", "Pesticide", "Petrification", "Petroleum", "Poison Blood", "Prism", "Rocket Launcher", "Slush", "Sacrifice", "Storm Surge", "Thunderbolt", "Toxic Lobotomy", "Voodoo" };

        List<string> listT1Scrolls = new List<string> { "Dark", "Earth", "Embers", "Frostbite", "Light", "Nature", "Plague", "Surge", "Water" };

        List<string> listT2Scrolls = new List<string> { "Aftershock", "Chain Lightning", "Chaos Strike", "Charm", "Corpse Explosion", "Crusader", "Explosions", "Fear", "Flame Thrower", "Holy Fire", "Holy Purge", "Lava", "Least Resistance", "Noxiosa", "Pesticide", "Petrification", "Petroleum", "Poison Blood", "Prism", "Rocket Launcher", "Slush", "Sacrifice", "Storm Surge", "Thunderbolt", "Toxic Lobotomy", "Voodoo" };

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

        List<string> listLaser = new List<string> { "Red", "Green", "Yellow" };

        List<string> listFiremode = new List<string> { "Gun Crank", "Priming Bolt" };

        List<string> listFiremodePrime = new List<string> { "Priming Bolt", "None" };

        List<string> listFiremodeCrank = new List<string> { "Gun Crank", "None" };

        List<string> listRechamber = new List<string> { "Chamber Chisel (.50 BMG)", "Chamber Chisel (12Ga)", "Chamber Chisel (5.56mm)", "Chamber Chisel (7.62mm)", "Chamber Chisel (9mm)" };

        List<string> totalAttachments = new List<string>();

        List<string> totalEnchantments = new List<string>();

        List<string> totalEquipment = new List<string> { "Balaclava", "Beer Helmet", "Blue Bandana", "Cowboy Hat", "Dunce Cap", "Ear Protectors", "Eye Patch", "Firefighter Helmet", "Fluffy Hat", "Gas Mask", "High Cut Helmet,", "Knight's Helmet", "Motorcycle Helmet", "Pith Helmet", "Police Hat", "Pope Hat", "Red Bandana", "Round Glasses", "Ski Goggles", "Square Glasses", "Steel Helmet", "Sunglasses", "Sylvester Hat", "Tanker Helmet", "Titanium Helmet", "Winter Scarf", "Badass Vest", "Ballistic Vest", "Bathrobe", "Breastplate", "Camo Jacket", "Cowboy Vest", "Firefighter Jacket", "Ghillie Suit", "Hazmat Suit", "Hunting Vest", "Leather Jacket", "Life Vest", "Office Wear", "Old-Timey Suit", "Parka", "Pillow Armor", "Plate Carrier", "Police Uniform", "Pyjamas", "Raincoat", "Samurai Armor", "Santa Coat", "Tracksuit", "Turtle Shell", "Yellow Hoodie" };

        List<string> listHeadEquipment = new List<string> { "Balaclava", "Beer Helmet", "Blue Bandana", "Cowboy Hat", "Dunce Cap", "Ear Protectors", "Eye Patch", "Firefighter Helmet", "Fluffy Hat", "Gas Mask", "High Cut Helmet,", "Knight's Helmet", "Motorcycle Helmet", "Pith Helmet", "Police Hat", "Pope Hat", "Red Bandana", "Round Glasses", "Ski Goggles", "Square Glasses", "Steel Helmet", "Sunglasses", "Sylvester Hat", "Tanker Helmet", "Titanium Helmet", "Winter Scarf" };

        List<string> listBodyEquipment = new List<string> { "Badass Vest", "Ballistic Vest", "Bathrobe", "Breastplate", "Camo Jacket", "Cowboy Vest", "Firefighter Jacket", "Ghillie Suit", "Hazmat Suit", "Hunting Vest", "Leather Jacket", "Life Vest", "Office Wear", "Old-Timey Suit", "Parka", "Pillow Armor", "Plate Carrier", "Police Uniform", "Pyjamas", "Raincoat", "Samurai Armor", "Santa Coat", "Tracksuit", "Turtle Shell", "Yellow Hoodie" };

        List<string> listFootEquipment = new List<string> { "Blast Boot", "Blue Slipper", "Christmas Sock", "Clog", "Combat Boot", "Cowboy Boot", "Diving Fin", "Genie Shoe", "Geta", "Golden Slipper", "High Heel", "High Quality Elf Shoe", "Ice Skate", "Peg Leg", "Peg Leg", "Platform Shoe", "Roller Blade", "Rubber Boot", "Running Shoe", "Shoe", "Sneaker", "Sock", "Springcoil Boot", "Sulf Air", "Ygg" };

        List<string> listTrinkets = new List<string> { "Ass Wheel(TM)", "Dark Lamp", "Detective Pipe", "Dog Whistle", "Dogtags", "Extra Lung", "Four-Leaf Clover", "Instant Defibrillator", "Iron Feather", "Knee Pads", "Library Card", "Loaded Die", "Lock of the Magus", "Metabulator Pump", "Oxygen Tank", "Range Finder", "Sheriff's Badge", "Yakety Sax" };

        public MainWindow()
        {
            InitializeComponent();
            this.build_box.Items.Add(new MyItem { Item = "Gun" });
            this.build_box.Items.Add(new MyItem { Item = "Barrel" });
            this.build_box.Items.Add(new MyItem { Item = "Optic" });
            this.build_box.Items.Add(new MyItem { Item = "Laser" });
            this.build_box.Items.Add(new MyItem { Item = "Firemode" });
            this.build_box.Items.Add(new MyItem { Item = "Rechamber" });
            this.build_box.Items.Add(new MyItem { Item = "Enchantment 1" });
            this.build_box.Items.Add(new MyItem { Item = "Enchantment 2" });
            this.build_box.Items.Add(new MyItem { Item = "Enchantment 3" });
            this.build_box.Items.Add(new MyItem { Item = "Enchantment 4" });
            this.build_box.Items.Add(new MyItem { Item = "Enchantment 5" });
            this.build_box.Items.Add(new MyItem { Item = "Head Equipment" });
            this.build_box.Items.Add(new MyItem { Item = "Body Equipment" });
            this.build_box.Items.Add(new MyItem { Item = "Left Foot" });
            this.build_box.Items.Add(new MyItem { Item = "Right Foot" });
            this.build_box.Items.Add(new MyItem { Item = "Trinket 1" });
            this.build_box.Items.Add(new MyItem { Item = "Trinket 2" });
            this.build_box.Items.Add(new MyItem { Item = "Trinket 3" });
            this.build_box.Items.Add(new MyItem { Item = "Trinket 4" });
        }

        private void ButtonGenerateBuild_Click(object sender, RoutedEventArgs e)
        {
            // Clear Listview
            build_box.Items.Clear();
            string randomGunCompare;
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

            // Build Gun Stats

            //// P38 Dirk
            Weapon weaponP38Dirk = new Weapon();
            weaponP38Dirk.Name = "P38 Dirk";
            weaponP38Dirk.Type = "Pistol";
            weaponP38Dirk.AmmoType = "9mm";
            weaponP38Dirk.Damage = 60;
            weaponP38Dirk.Projectiles = 0;
            weaponP38Dirk.RPM = 0;
            weaponP38Dirk.Spread = 0;
            weaponP38Dirk.SpreadModified = 0;
            weaponP38Dirk.Durability = 2000;
            weaponP38Dirk.BaseCritChance = (decimal)0.0;
            weaponP38Dirk.ADSCritChance = (decimal)0.0;
            weaponP38Dirk.Bounces = 0;
            weaponP38Dirk.Penetrations = 0;
            weaponP38Dirk.ReloadSpeed = (decimal)1.0;
            weaponP38Dirk.RecoilBase = (decimal)0.0;
            weaponP38Dirk.RecoilMult = 0;
            weaponP38Dirk.CanADS = "Yes";
            weaponP38Dirk.MoneyDrops = "Yes";
            weaponP38Dirk.OrganDrops = "Yes";
            weaponP38Dirk.LootDropChance = (decimal)1.0;
            weaponP38Dirk.WeaponWeight = 5;
            weaponP38Dirk.MovementSpeed = (decimal)1.0;
            weaponP38Dirk.BulletConsumeChance = (decimal)1.0;
            weaponP38Dirk.ExtraAmmoUseChance = (decimal)0.0;
            weaponP38Dirk.BulletDrop = 0;
            weaponP38Dirk.JumpPower = (decimal)1.0;
            weaponP38Dirk.Drag = 0;
            weaponP38Dirk.DurabilityUsage = 1;
            //// Socom 9
            Weapon weaponSocom9 = new Weapon();
            weaponSocom9.Name = "Socom 9";
            weaponSocom9.Type = "Pistol";
            weaponSocom9.AmmoType = "";
            weaponSocom9.Damage = 0;
            weaponSocom9.Projectiles = 0;
            weaponSocom9.RPM = 0;
            weaponSocom9.Spread = 0;
            weaponSocom9.SpreadModified = 0;
            weaponSocom9.Durability = 0;
            weaponSocom9.BaseCritChance = (decimal)0.0;
            weaponSocom9.ADSCritChance = (decimal)0.0;
            weaponSocom9.Bounces = 0;
            weaponSocom9.Penetrations = 0;
            weaponSocom9.ReloadSpeed = (decimal)1.0;
            weaponSocom9.RecoilBase = (decimal)0.0;
            weaponSocom9.RecoilMult = 0;
            weaponSocom9.CanADS = "Yes";
            weaponSocom9.MoneyDrops = "Yes";
            weaponSocom9.OrganDrops = "Yes";
            weaponSocom9.LootDropChance = (decimal)1.0;
            weaponSocom9.WeaponWeight = 0;
            weaponSocom9.MovementSpeed = (decimal)1.0;
            weaponSocom9.BulletConsumeChance = (decimal)1.0;
            weaponSocom9.ExtraAmmoUseChance = (decimal)0.0;
            weaponSocom9.BulletDrop = 0;
            weaponSocom9.JumpPower = (decimal)1.0;
            weaponSocom9.Drag = 0;
            weaponSocom9.DurabilityUsage = 1;
            //// Star & Witness
            Weapon weaponStarWitness = new Weapon();
            weaponStarWitness.Name = "Star & Witness";
            weaponStarWitness.Type = "Pistol";
            weaponStarWitness.AmmoType = "";
            weaponStarWitness.Damage = 0;
            weaponStarWitness.Projectiles = 0;
            weaponStarWitness.RPM = 0;
            weaponStarWitness.Spread = 0;
            weaponStarWitness.SpreadModified = 0;
            weaponStarWitness.Durability = 0;
            weaponStarWitness.BaseCritChance = (decimal)0.0;
            weaponStarWitness.ADSCritChance = (decimal)0.0;
            weaponStarWitness.Bounces = 0;
            weaponStarWitness.Penetrations = 0;
            weaponStarWitness.ReloadSpeed = (decimal)1.0;
            weaponStarWitness.RecoilBase = (decimal)0.0;
            weaponStarWitness.RecoilMult = 0;
            weaponStarWitness.CanADS = "Yes";
            weaponStarWitness.MoneyDrops = "Yes";
            weaponStarWitness.OrganDrops = "Yes";
            weaponStarWitness.LootDropChance = (decimal)1.0;
            weaponStarWitness.WeaponWeight = 0;
            weaponStarWitness.MovementSpeed = (decimal)1.0;
            weaponStarWitness.BulletConsumeChance = (decimal)1.0;
            weaponStarWitness.ExtraAmmoUseChance = (decimal)0.0;
            weaponStarWitness.BulletDrop = 0;
            weaponStarWitness.JumpPower = (decimal)1.0;
            weaponStarWitness.Drag = 0;
            weaponStarWitness.DurabilityUsage = 1;
            //// Gravekeeper
            Weapon weaponGravekeeper = new Weapon();
            weaponGravekeeper.Name = "Gravekeeper";
            weaponGravekeeper.Type = "Pistol";
            weaponGravekeeper.AmmoType = "";
            weaponGravekeeper.Damage = 0;
            weaponGravekeeper.Projectiles = 0;
            weaponGravekeeper.RPM = 0;
            weaponGravekeeper.Spread = 0;
            weaponGravekeeper.SpreadModified = 0;
            weaponGravekeeper.Durability = 0;
            weaponGravekeeper.BaseCritChance = (decimal)0.0;
            weaponGravekeeper.ADSCritChance = (decimal)0.0;
            weaponGravekeeper.Bounces = 0;
            weaponGravekeeper.Penetrations = 0;
            weaponGravekeeper.ReloadSpeed = (decimal)1.0;
            weaponGravekeeper.RecoilBase = (decimal)0.0;
            weaponGravekeeper.RecoilMult = 0;
            weaponGravekeeper.CanADS = "Yes";
            weaponGravekeeper.MoneyDrops = "Yes";
            weaponGravekeeper.OrganDrops = "Yes";
            weaponGravekeeper.LootDropChance = (decimal)1.0;
            weaponGravekeeper.WeaponWeight = 0;
            weaponGravekeeper.MovementSpeed = (decimal)1.0;
            weaponGravekeeper.BulletConsumeChance = (decimal)1.0;
            weaponGravekeeper.ExtraAmmoUseChance = (decimal)0.0;
            weaponGravekeeper.BulletDrop = 0;
            weaponGravekeeper.JumpPower = (decimal)1.0;
            weaponGravekeeper.Drag = 0;
            weaponGravekeeper.DurabilityUsage = 1;
            //// Beck 8
            Weapon weaponBeck8 = new Weapon();
            weaponBeck8.Name = "Beck 8";
            weaponBeck8.Type = "Pistol";
            weaponBeck8.AmmoType = "";
            weaponBeck8.Damage = 0;
            weaponBeck8.Projectiles = 0;
            weaponBeck8.RPM = 0;
            weaponBeck8.Spread = 0;
            weaponBeck8.SpreadModified = 0;
            weaponBeck8.Durability = 0;
            weaponBeck8.BaseCritChance = (decimal)0.0;
            weaponBeck8.ADSCritChance = (decimal)0.0;
            weaponBeck8.Bounces = 0;
            weaponBeck8.Penetrations = 0;
            weaponBeck8.ReloadSpeed = (decimal)1.0;
            weaponBeck8.RecoilBase = (decimal)0.0;
            weaponBeck8.RecoilMult = 0;
            weaponBeck8.CanADS = "Yes";
            weaponBeck8.MoneyDrops = "Yes";
            weaponBeck8.OrganDrops = "Yes";
            weaponBeck8.LootDropChance = (decimal)1.0;
            weaponBeck8.WeaponWeight = 0;
            weaponBeck8.MovementSpeed = (decimal)1.0;
            weaponBeck8.BulletConsumeChance = (decimal)1.0;
            weaponBeck8.ExtraAmmoUseChance = (decimal)0.0;
            weaponBeck8.BulletDrop = 0;
            weaponBeck8.JumpPower = (decimal)1.0;
            weaponBeck8.Drag = 0;
            weaponBeck8.DurabilityUsage = 1;
            //// Salamander
            Weapon weaponSalamander = new Weapon();
            weaponSalamander.Name = "Salamander";
            weaponSalamander.Type = "Pistol";
            weaponSalamander.AmmoType = "";
            weaponSalamander.Damage = 0;
            weaponSalamander.Projectiles = 0;
            weaponSalamander.RPM = 0;
            weaponSalamander.Spread = 0;
            weaponSalamander.SpreadModified = 0;
            weaponSalamander.Durability = 0;
            weaponSalamander.BaseCritChance = (decimal)0.0;
            weaponSalamander.ADSCritChance = (decimal)0.0;
            weaponSalamander.Bounces = 0;
            weaponSalamander.Penetrations = 0;
            weaponSalamander.ReloadSpeed = (decimal)1.0;
            weaponSalamander.RecoilBase = (decimal)0.0;
            weaponSalamander.RecoilMult = 0;
            weaponSalamander.CanADS = "Yes";
            weaponSalamander.MoneyDrops = "Yes";
            weaponSalamander.OrganDrops = "Yes";
            weaponSalamander.LootDropChance = (decimal)1.0;
            weaponSalamander.WeaponWeight = 0;
            weaponSalamander.MovementSpeed = (decimal)1.0;
            weaponSalamander.BulletConsumeChance = (decimal)1.0;
            weaponSalamander.ExtraAmmoUseChance = (decimal)0.0;
            weaponSalamander.BulletDrop = 0;
            weaponSalamander.JumpPower = (decimal)1.0;
            weaponSalamander.Drag = 0;
            weaponSalamander.DurabilityUsage = 1;
            //// Bronco 89
            Weapon weaponBronco89 = new Weapon();
            weaponBronco89.Name = "Bronco 89";
            weaponBronco89.Type = "Pistol";
            weaponBronco89.AmmoType = "";
            weaponBronco89.Damage = 0;
            weaponBronco89.Projectiles = 0;
            weaponBronco89.RPM = 0;
            weaponBronco89.Spread = 0;
            weaponBronco89.SpreadModified = 0;
            weaponBronco89.Durability = 0;
            weaponBronco89.BaseCritChance = (decimal)0.0;
            weaponBronco89.ADSCritChance = (decimal)0.0;
            weaponBronco89.Bounces = 0;
            weaponBronco89.Penetrations = 0;
            weaponBronco89.ReloadSpeed = (decimal)1.0;
            weaponBronco89.RecoilBase = (decimal)0.0;
            weaponBronco89.RecoilMult = 0;
            weaponBronco89.CanADS = "Yes";
            weaponBronco89.MoneyDrops = "Yes";
            weaponBronco89.OrganDrops = "Yes";
            weaponBronco89.LootDropChance = (decimal)1.0;
            weaponBronco89.WeaponWeight = 0;
            weaponBronco89.MovementSpeed = (decimal)1.0;
            weaponBronco89.BulletConsumeChance = (decimal)1.0;
            weaponBronco89.ExtraAmmoUseChance = (decimal)0.0;
            weaponBronco89.BulletDrop = 0;
            weaponBronco89.JumpPower = (decimal)1.0;
            weaponBronco89.Drag = 0;
            weaponBronco89.DurabilityUsage = 1;
            //// Flicker
            Weapon weaponFlicker = new Weapon();
            weaponFlicker.Name = "Flicker";
            weaponFlicker.Type = "Pistol";
            weaponFlicker.AmmoType = "";
            weaponFlicker.Damage = 0;
            weaponFlicker.Projectiles = 0;
            weaponFlicker.RPM = 0;
            weaponFlicker.Spread = 0;
            weaponFlicker.SpreadModified = 0;
            weaponFlicker.Durability = 0;
            weaponFlicker.BaseCritChance = (decimal)0.0;
            weaponFlicker.ADSCritChance = (decimal)0.0;
            weaponFlicker.Bounces = 0;
            weaponFlicker.Penetrations = 0;
            weaponFlicker.ReloadSpeed = (decimal)1.0;
            weaponFlicker.RecoilBase = (decimal)0.0;
            weaponFlicker.RecoilMult = 0;
            weaponFlicker.CanADS = "Yes";
            weaponFlicker.MoneyDrops = "Yes";
            weaponFlicker.OrganDrops = "Yes";
            weaponFlicker.LootDropChance = (decimal)1.0;
            weaponFlicker.WeaponWeight = 0;
            weaponFlicker.MovementSpeed = (decimal)1.0;
            weaponFlicker.BulletConsumeChance = (decimal)1.0;
            weaponFlicker.ExtraAmmoUseChance = (decimal)0.0;
            weaponFlicker.BulletDrop = 0;
            weaponFlicker.JumpPower = (decimal)1.0;
            weaponFlicker.Drag = 0;
            weaponFlicker.DurabilityUsage = 1;
            //// Unknown
            Weapon weaponUnknown = new Weapon();
            weaponUnknown.Name = "Unknown";
            weaponUnknown.Type = "Pistol";
            weaponUnknown.AmmoType = "";
            weaponUnknown.Damage = 0;
            weaponUnknown.Projectiles = 0;
            weaponUnknown.RPM = 0;
            weaponUnknown.Spread = 0;
            weaponUnknown.SpreadModified = 0;
            weaponUnknown.Durability = 0;
            weaponUnknown.BaseCritChance = (decimal)0.0;
            weaponUnknown.ADSCritChance = (decimal)0.0;
            weaponUnknown.Bounces = 0;
            weaponUnknown.Penetrations = 0;
            weaponUnknown.ReloadSpeed = (decimal)1.0;
            weaponUnknown.RecoilBase = (decimal)0.0;
            weaponUnknown.RecoilMult = 0;
            weaponUnknown.CanADS = "Yes";
            weaponUnknown.MoneyDrops = "Yes";
            weaponUnknown.OrganDrops = "Yes";
            weaponUnknown.LootDropChance = (decimal)1.0;
            weaponUnknown.WeaponWeight = 0;
            weaponUnknown.MovementSpeed = (decimal)1.0;
            weaponUnknown.BulletConsumeChance = (decimal)1.0;
            weaponUnknown.ExtraAmmoUseChance = (decimal)0.0;
            weaponUnknown.BulletDrop = 0;
            weaponUnknown.JumpPower = (decimal)1.0;
            weaponUnknown.Drag = 0;
            weaponUnknown.DurabilityUsage = 1;
            //// Hell 'N' Back
            Weapon weaponHellNBack = new Weapon();
            weaponHellNBack.Name = "Hell 'N' Back";
            weaponHellNBack.Type = "Pistol";
            weaponHellNBack.AmmoType = "";
            weaponHellNBack.Damage = 0;
            weaponHellNBack.Projectiles = 0;
            weaponHellNBack.RPM = 0;
            weaponHellNBack.Spread = 0;
            weaponHellNBack.SpreadModified = 0;
            weaponHellNBack.Durability = 0;
            weaponHellNBack.BaseCritChance = (decimal)0.0;
            weaponHellNBack.ADSCritChance = (decimal)0.0;
            weaponHellNBack.Bounces = 0;
            weaponHellNBack.Penetrations = 0;
            weaponHellNBack.ReloadSpeed = (decimal)1.0;
            weaponHellNBack.RecoilBase = (decimal)0.0;
            weaponHellNBack.RecoilMult = 0;
            weaponHellNBack.CanADS = "Yes";
            weaponHellNBack.MoneyDrops = "Yes";
            weaponHellNBack.OrganDrops = "Yes";
            weaponHellNBack.LootDropChance = (decimal)1.0;
            weaponHellNBack.WeaponWeight = 0;
            weaponHellNBack.MovementSpeed = (decimal)1.0;
            weaponHellNBack.BulletConsumeChance = (decimal)1.0;
            weaponHellNBack.ExtraAmmoUseChance = (decimal)0.0;
            weaponHellNBack.BulletDrop = 0;
            weaponHellNBack.JumpPower = (decimal)1.0;
            weaponHellNBack.Drag = 0;
            weaponHellNBack.DurabilityUsage = 1;
            //// Cavalier
            Weapon weaponCavalier = new Weapon();
            weaponCavalier.Name = "Cavalier";
            weaponCavalier.Type = "Pistol";
            weaponCavalier.AmmoType = "";
            weaponCavalier.Damage = 0;
            weaponCavalier.Projectiles = 0;
            weaponCavalier.RPM = 0;
            weaponCavalier.Spread = 0;
            weaponCavalier.SpreadModified = 0;
            weaponCavalier.Durability = 0;
            weaponCavalier.BaseCritChance = (decimal)0.0;
            weaponCavalier.ADSCritChance = (decimal)0.0;
            weaponCavalier.Bounces = 0;
            weaponCavalier.Penetrations = 0;
            weaponCavalier.ReloadSpeed = (decimal)1.0;
            weaponCavalier.RecoilBase = (decimal)0.0;
            weaponCavalier.RecoilMult = 0;
            weaponCavalier.CanADS = "Yes";
            weaponCavalier.MoneyDrops = "Yes";
            weaponCavalier.OrganDrops = "Yes";
            weaponCavalier.LootDropChance = (decimal)1.0;
            weaponCavalier.WeaponWeight = 0;
            weaponCavalier.MovementSpeed = (decimal)1.0;
            weaponCavalier.BulletConsumeChance = (decimal)1.0;
            weaponCavalier.ExtraAmmoUseChance = (decimal)0.0;
            weaponCavalier.BulletDrop = 0;
            weaponCavalier.JumpPower = (decimal)1.0;
            weaponCavalier.Drag = 0;
            weaponCavalier.DurabilityUsage = 1;

            List<Weapon> allWeaponStats = new List<Weapon> { weaponP38Dirk, weaponSocom9, weaponStarWitness, weaponGravekeeper, weaponBeck8, weaponSalamander, weaponBronco89, weaponFlicker, weaponUnknown, weaponHellNBack, weaponCavalier };

            // Gun Randomizer
            Random randomGunInt = new Random();
            int randomGunNumber = randomGunInt.Next(0, totalGuns.Count);
            randomGunCompare = totalGuns[randomGunNumber];

            foreach (var weapon in allWeaponStats)
            {
                if (weapon.Name == randomGunCompare)
                {
                    randomGun = randomGunCompare;
                    this.build_box.Items.Add(new MyItem { Item = "Gun", Selection = randomGun });
                    this.cardWeaponName.Text = weapon.Name;
                    this.cardWeaponType.Text = $"Type: {weapon.Type}";
                    this.cardAmmoType.Text = $"Ammo Type: {weapon.AmmoType}";
                    this.cardDamage.Text = $"Damage: {weapon.Damage}";
                    this.cardRPM.Text = $"RPM: {weapon.RPM}";
                    this.cardSpread.Text = $"Spread: {weapon.Spread}";
                    this.cardDurability.Text = $"Durability: {weapon.Durability}";
                    this.cardBaseCritChance.Text = $"Base Crit Chance: {weapon.BaseCritChance}";
                    this.cardADSCritChance.Text = $"ADS Crit Chance: {weapon.ADSCritChance}";
                    this.cardBounces.Text = $"Bounces: {weapon.Bounces}";
                    this.cardPenetrations.Text = $"Penetrations: {weapon.Penetrations}";
                    this.cardReloadSpeed.Text = $"Reload Speed: {weapon.ReloadSpeed}";
                    this.cardRecoil.Text = $"Recoil: idfk";
                    this.cardCanADS.Text = $"Can ADS: {weapon.CanADS}";
                    this.cardMoneyDrops.Text = $"Money Drops: {weapon.MoneyDrops}";
                    this.cardOrganDrops.Text = $"Organ Drops: {weapon.OrganDrops}";
                    this.cardLootDropChance.Text = $"Loot Drop Chance: {weapon.LootDropChance}";
                    this.cardWeaponWeight.Text = $"Weapon Weight: {weapon.WeaponWeight}";
                    this.cardMovementSpeed.Text = $"Movement Speed: {weapon.MovementSpeed}";
                    this.cardBulletConsumeChance.Text = $"Bullet Consume Chance: {weapon.BulletConsumeChance}";
                    this.cardExtraAmmoUseChance.Text = $"Extra Ammo Use Chance: {weapon.ExtraAmmoUseChance}";
                    this.cardBulletDrop.Text = $"Bullet Drop: {weapon.BulletDrop}";
                    this.cardJumpPower.Text = $"Jump Power: {weapon.JumpPower}";
                    this.cardDrag.Text = $"Drag: {weapon.Drag}";
                    this.cardDurabilityUsage.Text = $"Durability Usage: {weapon.DurabilityUsage}";
                }
            }



            

            // Attachment Randomizer
            if ((bool)allAttachmentsCheckbox.IsChecked == true)
            {
                // Barrel Randomizer
                Random randomBarrelInt = new Random();
                int randomBarrelNumber = randomGunInt.Next(0, listBarrels.Count);
                if (randomGun == "Catacoil Rapid X" || randomGun == "Unknown" || randomGun == "Wyatt PULSAR" || randomGun == "Augusta" || randomGun == "D4RT" || randomGun == "Neuraxis F22")
                {
                    this.build_box.Items.Add(new MyItem { Item = "Barrel", Selection = "N/A" });
                }
                else
                {
                    this.build_box.Items.Add(new MyItem { Item = "Barrel", Selection = listBarrels[randomBarrelNumber] });
                }

                // Optic Randomizer
                Random randomOpticInt = new Random();
                int randomOpticNumber = randomOpticInt.Next(0, listOptics.Count);
                this.build_box.Items.Add(new MyItem { Item = "Optic", Selection = listOptics[randomOpticNumber] });

                // Laser Randomizer
                Random randomLaserInt = new Random();
                int randomLaserNumber = randomLaserInt.Next(0, listLaser.Count);
                this.build_box.Items.Add(new MyItem { Item = "Laser", Selection = listLaser[randomLaserNumber] });

                // Firemode Randomizer

                if (randomGun == "Breacher 8" || randomGun == "Wyatt PULSAR" || randomGun == "Unknown" || randomGun == "Catacoil Random X" || randomGun == "Impala Gravita" || randomGun == "D4RT")
                {
                    this.build_box.Items.Add(new MyItem { Item = "Firemode", Selection = "N/A" });
                }
                else
                {
                    if (randomGun == "P38 Dirk" || randomGun == "Socom 9" || randomGun == "Star & Witness" || randomGun == "Gravekeeper" || randomGun == "Beck 8" || randomGun == "Salamander" || randomGun == "Bronco 89" || randomGun == "Flicker" || randomGun == "Hell 'N' Back" || randomGun == "Cavalier" || randomGun == "Snut .38" || randomGun == "Palehorse Topclipper" || randomGun == ".357 Balthazar" || randomGun == "Mossman" || randomGun == "Arbiter 2" || randomGun == "Augusta" || randomGun == "1889 Mario" || randomGun == "Majordome" || randomGun == "M3 Termite" || randomGun == "Deathstar PG" || randomGun == "Knop .22" || randomGun == "M182 Pierre-Fusil" || randomGun == "Tailor Marksman MKII" || randomGun == "Farsight" || randomGun == "Rokua .308" || randomGun == "Dolphin 99" || randomGun == "Longboy")
                    {
                        Random randomFireCrankInt = new Random();
                        int randomFireCrankNumber = randomFireCrankInt.Next(0, listFiremodeCrank.Count);
                        this.build_box.Items.Add(new MyItem { Item = "Firemode", Selection = listFiremodeCrank[randomFireCrankNumber] });
                    }
                    else if (randomGun == "Flock 76" || randomGun == "Drifter 9" || randomGun == "Vrede" || randomGun == "Ploika Compact" || randomGun == "Ferryman" || randomGun == "Valet" || randomGun == "Corpsemaker" || randomGun == "Type 80 Typhoon" || randomGun == "M11A2 Fisk" || randomGun == "Wingman" || randomGun == "Rektor 100rd" || randomGun == "Duhar" || randomGun == "Neuraxis F22")
                    {
                        Random randomFirePrimeInt = new Random();
                        int randomFirePrimeNumber = randomFirePrimeInt.Next(0, listFiremodePrime.Count);
                        this.build_box.Items.Add(new MyItem { Item = "Firemode", Selection = listFiremodePrime[randomFirePrimeNumber] });
                    }
                    else
                    {
                        Random randomFireInt = new Random();
                        int randomFireNumber = randomFireInt.Next(0, listFiremode.Count);
                        this.build_box.Items.Add(new MyItem { Item = "Firemode", Selection = listFiremode[randomFireNumber] });
                    }
                }

                // Rechamber Randomizer
                Random randomRechamberInt = new Random();
                int randomRechamberNumber = randomRechamberInt.Next(0, listRechamber.Count);
                if (randomGun == "Catacoil Rapid X" || randomGun == "Unknown" || randomGun == "Wyatt PULSAR" || randomGun == "Augusta" || randomGun == "D4RT" || randomGun == "Neuraxis F22")
                {
                    this.build_box.Items.Add(new MyItem { Item = "Rechamber", Selection = "N/A" });
                }
                else
                {
                    this.build_box.Items.Add(new MyItem { Item = "Rechamber", Selection = listRechamber[randomRechamberNumber] });
                }
            }
            if ((bool)barrels.IsChecked == true && (bool)allAttachmentsCheckbox.IsChecked == false)
            {
                Random randomBarrelInt = new Random();
                int randomBarrelNumber = randomBarrelInt.Next(0, listBarrels.Count);
                this.build_box.Items.Add(new MyItem { Item = "Barrel", Selection = listBarrels[randomBarrelNumber] });
            }
            if ((bool)optics.IsChecked == true && (bool)allAttachmentsCheckbox.IsChecked == false)
            {
                Random randomOpticInt = new Random();
                int randomOpticNumber = randomOpticInt.Next(0, listOptics.Count);
                this.build_box.Items.Add(new MyItem { Item = "Optic", Selection = listOptics[randomOpticNumber] });
            }
            if ((bool)Laser.IsChecked == true && (bool)allAttachmentsCheckbox.IsChecked == false)
            {
                Random randomLaserInt = new Random();
                int randomLaserNumber = randomLaserInt.Next(0, listLaser.Count);
                this.build_box.Items.Add(new MyItem { Item = "Laser", Selection = listLaser[randomLaserNumber] });
            }
            if ((bool)FiringMode.IsChecked == true && (bool)allAttachmentsCheckbox.IsChecked == false)
            {
                Random randomFireInt = new Random();
                int randomFireNumber = randomFireInt.Next(0, listFiremode.Count);
                this.build_box.Items.Add(new MyItem { Item = "Firemode", Selection = listFiremode[randomFireNumber] });
            }
            if ((bool)Rechamber.IsChecked == true && (bool)allAttachmentsCheckbox.IsChecked == false)
            {
                Random randomRechamberInt = new Random();
                int randomRechamberNumber = randomRechamberInt.Next(0, listRechamber.Count);
                this.build_box.Items.Add(new MyItem { Item = "Rechamber", Selection = listRechamber[randomRechamberNumber] });
            }

            // Enchantment Randomizer

            if (enchantment_slider.Value > 0)
            {
                var oilCount = enchantment_slider.Value - 1;
                if (no_scrolls_button.IsChecked == true)
                {
                    oilCount += 1;
                    var scrollsEnabled = false;
                    if (oilCount > 0)
                    {
                        var enchNum = 0;
                        do
                        {
                            Random randomOilInt = new Random();
                            int randomOilNumber = randomOilInt.Next(0, listOils.Count);

                            oilCount -= 1;
                            enchNum += 1;

                            if (scrollsEnabled == false)
                            {
                                this.build_box.Items.Add(new MyItem { Item = $"Oil {enchNum}", Selection = listOils[randomOilNumber] });
                            }
                        } while (oilCount > 0);                        
                    }
                }
                if (all_scrolls_button.IsChecked == true)
                {
                    Random randomAllScrollInt = new Random();
                    int randomAllScrollNumber = randomAllScrollInt.Next(0, listAllScrolls.Count);
                    this.build_box.Items.Add(new MyItem { Item = "Scroll", Selection = listAllScrolls[randomAllScrollNumber] });
                    if (oilCount > 0)
                    {
                        var enchNum = 0;
                        do
                        {
                            Random randomOilInt = new Random();
                            int randomOilNumber = randomOilInt.Next(0, listOils.Count);

                            oilCount -= 1;
                            enchNum += 1;

                            this.build_box.Items.Add(new MyItem { Item = $"Oil {enchNum}", Selection = listOils[randomOilNumber] });

                        } while (oilCount > 0);
                    }
                }
                if (t1_scrolls_button.IsChecked == true)
                {
                    Random randomT1ScrollInt = new Random();
                    int randomT1ScrollNumber = randomT1ScrollInt.Next(0, listT1Scrolls.Count);
                    this.build_box.Items.Add(new MyItem { Item = "Scroll", Selection = listT1Scrolls[randomT1ScrollNumber] });
                    if (oilCount > 0)
                    {
                        var enchNum = 0;
                        do
                        {
                            Random randomOilInt = new Random();
                            int randomOilNumber = randomOilInt.Next(0, listOils.Count);

                            oilCount -= 1;
                            enchNum += 1;

                            this.build_box.Items.Add(new MyItem { Item = $"Oil {enchNum}", Selection = listOils[randomOilNumber] });

                        } while (oilCount > 0);
                    }
                }
                if (t2_scrolls_button.IsChecked == true)
                {
                    Random randomT2ScrollInt = new Random();
                    int randomT2ScrollNumber = randomT2ScrollInt.Next(0, listAllScrolls.Count);
                    this.build_box.Items.Add(new MyItem { Item = "Scroll", Selection = listT2Scrolls[randomT2ScrollNumber] });
                    if (oilCount > 0)
                    {
                        var enchNum = 0;
                        do
                        {
                            Random randomOilInt = new Random();
                            int randomOilNumber = randomOilInt.Next(0, listOils.Count);

                            oilCount -= 1;
                            enchNum += 1;

                            this.build_box.Items.Add(new MyItem { Item = $"Oil {enchNum}", Selection = listOils[randomOilNumber] });

                        } while (oilCount > 0);
                    }
                }
                if (choose_scrolls_button.IsChecked == true)
                {
                    var rawScrollSelect = scroll_dropdown.Text;
                    this.build_box.Items.Add(new MyItem { Item = "Scroll", Selection = rawScrollSelect });
                    if (oilCount > 0)
                    {
                        var enchNum = 0;
                        do
                        {
                            Random randomOilInt = new Random();
                            int randomOilNumber = randomOilInt.Next(0, listOils.Count);

                            oilCount -= 1;
                            enchNum += 1;

                            this.build_box.Items.Add(new MyItem { Item = $"Oil {enchNum}", Selection = listOils[randomOilNumber] });

                        } while (oilCount > 0);
                    }

                }

            }

            // Equipment Randomizer
            if (allEquipmentCheckbox.IsChecked == true)
            {
                // Add Head Equipment
                Random randomHeadInt = new Random();
                int randomHeadNumber = randomHeadInt.Next(0, listHeadEquipment.Count);
                this.build_box.Items.Add(new MyItem { Item = "Head Equipment", Selection = listHeadEquipment[randomHeadNumber] });

                // Add Body Equipment
                Random randomBodyInt = new Random();
                int randomBodyNumber = randomBodyInt.Next(0, listBodyEquipment.Count);
                this.build_box.Items.Add(new MyItem { Item = "Body Equipment", Selection = listBodyEquipment[randomBodyNumber] });

                // Add Left Foot Equipment
                Random randomLFootInt = new Random();
                int randomLFootNumber = randomLFootInt.Next(0, listFootEquipment.Count);
                this.build_box.Items.Add(new MyItem { Item = "Left Foot", Selection = listFootEquipment[randomLFootNumber] });

                // Add Right Foot Equipment
                Random randomRFootInt = new Random();
                int randomRFootNumber = randomRFootInt.Next(0, listFootEquipment.Count);
                this.build_box.Items.Add(new MyItem { Item = "Right Foot", Selection = listFootEquipment[randomRFootNumber] });

                // Add Trinket 1
                Random randomTrinket1Int = new Random();
                int randomTrinket1Number = randomTrinket1Int.Next(0, listTrinkets.Count);
                this.build_box.Items.Add(new MyItem { Item = "Trinket 1", Selection = listTrinkets[randomTrinket1Number] });

                // Add Trinket 2
                Random randomTrinket2Int = new Random();
                int randomTrinket2Number = randomTrinket2Int.Next(0, listTrinkets.Count);
                this.build_box.Items.Add(new MyItem { Item = "Trinket 2", Selection = listTrinkets[randomTrinket2Number] });

                // Add Trinket 3
                Random randomTrinket3Int = new Random();
                int randomTrinket3Number = randomTrinket3Int.Next(0, listTrinkets.Count);
                this.build_box.Items.Add(new MyItem { Item = "Trinket 3", Selection = listTrinkets[randomTrinket3Number] });

                // Add Trinket 4
                Random randomTrinket4Int = new Random();
                int randomTrinket4Number = randomTrinket4Int.Next(0, listTrinkets.Count);
                this.build_box.Items.Add(new MyItem { Item = "Trinket 4", Selection = listTrinkets[randomTrinket4Number] });
            }
            if (headEquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                Random randomHeadInt = new Random();
                int randomHeadNumber = randomHeadInt.Next(0, listHeadEquipment.Count);
                this.build_box.Items.Add(new MyItem { Item = "Head Equipment", Selection = listHeadEquipment[randomHeadNumber] });
            }
            if (bodyEquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                Random randomBodyInt = new Random();
                int randomBodyNumber = randomBodyInt.Next(0, listBodyEquipment.Count);
                this.build_box.Items.Add(new MyItem { Item = "Body Equipment", Selection = listBodyEquipment[randomBodyNumber] });
            }
            if (leftFootEquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                Random randomLFootInt = new Random();
                int randomLFootNumber = randomLFootInt.Next(0, listFootEquipment.Count);
                this.build_box.Items.Add(new MyItem { Item = "Left Foot", Selection = listFootEquipment[randomLFootNumber] });
            }
            if (rightFootEquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                Random randomRFootInt = new Random();
                int randomRFootNumber = randomRFootInt.Next(0, listFootEquipment.Count);
                this.build_box.Items.Add(new MyItem { Item = "Right Foot", Selection = listFootEquipment[randomRFootNumber] });
            }
            if (trinket1EquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                // Add Trinket 1
                Random randomTrinket1Int = new Random();
                int randomTrinket1Number = randomTrinket1Int.Next(0, listTrinkets.Count);
                this.build_box.Items.Add(new MyItem { Item = "Trinket 1", Selection = listTrinkets[randomTrinket1Number] });
            }
            if (trinket2EquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                Random randomTrinket2Int = new Random();
                int randomTrinket2Number = randomTrinket2Int.Next(0, listTrinkets.Count);
                this.build_box.Items.Add(new MyItem { Item = "Trinket 2", Selection = listTrinkets[randomTrinket2Number] });
            }
            if (trinket3EquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                Random randomTrinket3Int = new Random();
                int randomTrinket3Number = randomTrinket3Int.Next(0, listTrinkets.Count);
                this.build_box.Items.Add(new MyItem { Item = "Trinket 3", Selection = listTrinkets[randomTrinket3Number] });
            }
            if (trinket4EquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
            {
                Random randomTrinket4Int = new Random();
                int randomTrinket4Number = randomTrinket4Int.Next(0, listTrinkets.Count);
                this.build_box.Items.Add(new MyItem { Item = "Trinket 4", Selection = listTrinkets[randomTrinket4Number] });
            }

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