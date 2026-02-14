using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    "Zooming Oil"*/
};
        
        List<string> listOilAmmo = new List<string> {
    "Bulk Oil",
    "Carefree Oil",
    "Cheap Oil",
    "Do-over Oil",
    "Food Stamp Oil",
    "Heavy Pockets Oil",
    "Helium Oil",
    "Keep Oil",
    "Last Drop Oil",
    "Mosquito Oil",
    "Plop Back Oil",
    "Recycle Oil",
    "Satiety Oil",
    "Saviour Oil",
    "Walk Easy Oil",
    "Whos Counting Oil", };
        List<string> listOilCrit = new List<string> {
    "Aimless Oil",
    "Artery Oil",
    "Axe Oil",
    "Blindfold Oil",
    "Confidence Oil",
    "Critical Oil",
    "Gambler Oil",
    "Happy Accident Oil",
    "Hunter Oil",
    "Hustler Oil",
    "Low Roller Oil",
    "Manifestation Oil",
    "No Need Oil",
    "Out of the Box Oil",
    "Puncture Oil",
    "Slotmachine Oil",
    "Smart Bullet Oil",};
        List<string> listOilBounce = new List<string> {
    "Arkanoid Oil",
    "Bandit Oil",
    "Cartoon Oil",
    "Flea Oil",
    "Hoop Oil",
    "Imperfect Oil",
    "Lazy Oil",
    "Longshot Oil",
    "Perfect Bounce Oil",
    "Pool Oil",
    "Rebound Oil",
    "Ricochet Oil",
    "Scramble Oil",
    "Sherlock Oil",
    "Skip Oil",
    "Synchronicity Oil",
    "Wobble Oil", };
        List<string> listOilSpeed = new List<string> {
    "Arrow Oil",
    "Assassin Dart Oil",
    "Dart Oil",
    "Delayed Hyper Tube Oil",
    "Diesel Oil",
    "Extra Powder Oil",
    "Fast Bet Oil",
    "Instant Oil",
    "Kinetic Oil",
    "Micro Wing Oil",
    "Tight Barrel Oil",
    "Turbulence Oil",
    "Velocity Oil",
    "Whim Oil",
    "Zooming Oil", };
        List<string> listOilAddDam = new List<string> {
    "Add Damage Oil",
    "Ascetic Oil",
    "Big Oil",
    "Brute Oil",
    "Discharge Oil",
    "Disposable Oil",
    "Expander Oil",
    "Fidget Oil",
    "Frugal Oil",
    "Great Oil",
    "Judgement Oil",
    "Kicker Oil",
    "Late Boom Oil",
    "Potshot Oil",
    "Seated Oil",
    "Sender Oil",
    "Solid Oil",};
        List<string> listOilMultDam = new List<string> {
    "Boulder Oil",
    "Complicated Oil",
    "Damage Oil",
    "Dum Dum Oil",
    "First Blood Oil",
    "Franciscan Oil",
    "Glass Cannon Oil",
    "Grounded Oil",
    "Heavy Oil",
    "Hip Blaster Oil",
    "Hyper Lead Oil",
    "Launcher Oil",
    "Overclock Oil",
    "Puncher Oil",
    "Slow Punch Oil",
    "Spartan Oil",
    "Terminator Oil", };
        List<string> listOilDur = new List<string> {
    "Dense Oil",
    "Detune Oil",
    "Feature Gun Oil",
    "Gentle Oil",
    "Hefty Oil",
    "High Grade Oil",
    "Inherited Oil",
    "Release Oil",
    "Rigid System Oil",
    "Robust Mechanics Oil",
    "Rubber Oil",
    "Seated Fit Oil",
    "Sensible Oil",
    "Slippy Coating Oil",
    "Soft Bullet Oil",
    "Stiffy Fit Oil",
    "Trusty Old Oil",};
        List<string> listOilPen = new List<string> {
    "Bad Planet Oil",
    "Bystander Oil",
    "Collateral Oil",
    "Considerate Oil",
    "Farsighted Oil",
    "Heavy Lead Oil",
    "Inconsiderate Oil",
    "Jungian Oil",
    "Needleye Oil",
    "Overdose Oil",
    "Penetration Oil",
    "Rigor Oil",
    "Sect Oil",
    "Surgical Laser Oil",
    "Too Much Oil",
    "Untechnical Oil",
    "Vasectomy Oil",};
        List<string> listOilProj = new List<string> {
    "Black Friday Oil",
    "Bombard Oil",
    "Boomstick Oil",
    "Careless Splitter Oil",
    "Division Oil",
    "Double Nothing Oil",
    "Elephant Oil",
    "Gemini Oil",
    "Matrix Oil",
    "Multichamber Oil",
    "Multishot Oil",
    "Parallel Mag Oil",
    "Scatter Oil",
    "Shredder Oil",
    "Suppressive Oil",
    "Tandem Oil",
    "Twice Oil",
    "Two Time Oil",};
        List<string> listOilRecoil = new List<string> {
    "Braced Oil",
    "Casual Oil",
    "Contained Force Oil",
    "Easy Oil",
    "Easy Plop Oil",
    "Flow Funnel Oil",
    "Less Recoil Oil",
    "Modern Technology Oil",
    "Peashooter Oil",
    "Purse Gun Oil",
    "Ready Oil",
    "Relax Oil",
    "Safety Oil",
    "Stability Oil",
    "Stable Hip Oil",
    "Tension Oil",
    "Vegetable Oil",};
        List<string> listOilReload = new List<string> {
    "Action Oil",
    "Airsoft Oil",
    "Compo Oil",
    "Cycle Oil",
    "Double Lock Oil",
    "Dynamic Oil",
    "Gunslinger Oil",
    "Fidget Lord Oil",
    "Main Discipline Oil",
    "Main Focus Oil",
    "Nerf Oil",
    "Reload Oil",
    "Rush Job Oil",
    "Shaved Clip Oil",
    "Speed Trade Oil",
    "Tactical Oil",
    "Task Oil",
    "Tech Support Oil", };
        List<string> listOilRPM = new List<string> {
    "Attack Speed Oil",
    "BB Oil",
    "Blurt Oil",
    "Bolt Oil",
    "Double Fire Oil",
    "Fragile System Oil",
    "Lightweight Oil",
    "Machine Oil",
    "No Look Oil",
    "Perforate Oil",
    "Rapid Internals Oil",
    "Rookie Oil",
    "Shower Oil",
    "Spitter Oil",
    "Stationary Oil",
    "Waster Oil",
    "Zero Fucks Oil",};
        List<string> listOilSpread = new List<string> {
    "Altruistic Oil",
    "Artillery Oil",
    "Bowl Oil",
    "Careful Oil",
    "Dead Center Oil",
    "Exotic Barrel Oil",
    "Hip Marksman Oil",
    "Lost In Focus Oil",
    "Plinker Oil",
    "Shellman Oil",
    "Slick Oil",
    "Spread Oil",
    "Stoic Oil",
    "Thorough Oil",
    "Vegan Oil",};

        List<string> listAllScrolls = new List<string> { "Scroll of Dark", "Scroll of Earth", "Scroll of Embers", "Scroll of Frostbite", "Scroll of Light", "Scroll of Nature", "Scroll of Plague", "Scroll of Surge", "Scroll of Water", "Scroll of Aftershock", "Scroll of Chain Lightning", "Scroll of Chaos Strike", "Scroll of Charm", "Scroll of Corpse Explosion", "Scroll of Crusader", "Scroll of Explosions", "Scroll of Fear", "Scroll of Flame Thrower", "Scroll of Holy Fire", "Scroll of Holy Purge", "Scroll of Lava", "Scroll of Least Resistance", "Scroll of Noxiosa", "Scroll of Pesticide", "Scroll of Petrification", "Scroll of Petroleum", "Scroll of Poison Blood", "Scroll of Prism", "Scroll of Rocket Launcher", "Scroll of Slush", "Scroll of Sacrifice", "Scroll of Storm Surge", "Scroll of Thunderbolt", "Scroll of Toxic Lobotomy", "Scroll of Voodoo" };

        List<string> listT1Scrolls = new List<string> { "Scroll of Dark", "Scroll of Earth", "Scroll of Embers", "Scroll of Frostbite", "Scroll of Light", "Scroll of Nature", "Scroll of Plague", "Scroll of Surge", "Scroll of Water" };

        List<string> listT2Scrolls = new List<string> { "Scroll of Aftershock", "Scroll of Chain Lightning", "Scroll of Chaos Strike", "Scroll of Charm", "Scroll of Corpse Explosion", "Scroll of Crusader", "Scroll of Explosions", "Scroll of Fear", "Scroll of Flame Thrower", "Scroll of Holy Fire", "Scroll of Holy Purge", "Scroll of Lava", "Scroll of Least Resistance", "Scroll of Noxiosa", "Scroll of Pesticide", "Scroll of Petrification", "Scroll of Petroleum", "Scroll of Poison Blood", "Scroll of Prism", "Scroll of Rocket Launcher", "Scroll of Slush", "Scroll of Sacrifice", "Scroll of Storm Surge", "Scroll of Thunderbolt", "Scroll of Toxic Lobotomy", "Scroll of Voodoo" };

        List<string> listGuns = new List<string> { "P38 Dirk", "Socom 9", "Star & Witness", "Gravekeeper", "Beck 8", "Salamander", "Bronco 89", "Flicker", "Unknown", "Hell 'N' Back", "Cavalier", "Snut .38", "Palehorse Topclipper", ".357 Balthazar", "Wyatt PULSAR", "Breacher 8", "Mossman", "Arbiter 2", "Augusta", "1889 Mario", "Flock 76", "Majordome", "Drifter 9", "Vrede", "Ploika Compact", "Ferryman", "M3 Termite", "Deathstar PG", "Valet", "Corpsemaker", "Catacoil Rapid X", "Type 80 Typhoon", "M11A2 Fisk", "Wingman", "Rektor 100rd", "Duhar", "Neuraxis F22", "Knop .22", "M182 Pierre-Fusil", "Tailor Marksman MKII", "Farsight", "Rokua .308", "Dolphin 99", "D4RT", "Impala Gravita", "Longboy" };

        List<string> listPistols = new List<string> { "P38 Dirk", "Socom 9", "Star & Witness", "Gravekeeper", "Beck 8", "Salamander", "Bronco 89", "Flicker", "Unknown", "Hell 'N' Back", "Cavalier" };

        List<string> listRevolvers = new List<string> { "Snut .38", "Palehorse Topclipper", ".357 Balthazar", "Wyatt PULSAR" };

        List<string> listShotguns = new List<string> { "Breacher 8", "Mossman", "Arbiter 2", "Augusta", "1889 Mario", "Flock 76", "Majordome" };

        List<string> listSMGs = new List<string> { "Drifter 9", "Vrede", "Ploika Compact", "Ferryman", "M3 Termite", "Deathstar PG", "Valet" };

        List<string> listARs = new List<string> { "Corpsemaker", "Catacoil Rapid X", "Type 80 Typhoon", "M11A2 Fisk", "Wingman" };

        List<string> listLMGs = new List<string> { "Rektor 100rd", "Duhar", "Neuraxis F22" };

        List<string> listRifles = new List<string> { "Knop .22", "M182 Pierre-Fusil", "Tailor Marksman MKII", "Farsight" };

        List<string> listSnipers = new List<string> { "Rokua .308", "Dolphin 99", "D4RT", "Impala Gravita", "Longboy" };

        List<string> listBarrels = new List<string> { "A12C Muzzle Brake", "Aftermarket Haukland Silencer", "Barrel Extension 2in", "Barrel Extension 4in", "Barrel Extension 6in", "Breznik BMD", "Breznik BMD (Tactical)", "Haukland Flash Hider", "Haukland Silencer", "Improvised Barrel Extension", "M87 Albatross Silencer", "SR-P3 Silencer", "Shrouded Barrel Extension", "Warmage Compensator" };

        List<string> listOptics = new List<string> { "Assault Scope", "Compact Sight", "Holographic Sight", "Hunting Scope", "Recon Scope", "Reflex Sight", "Sniper Scope" };

        List<string> listLaser = new List<string> { "Red", "Green", "Yellow" };

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



            InitializeComponent();
            var vm = new ViewModel();
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "None",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "Random - All",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "Random - Tier 1",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Dark",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Earth",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Embers",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Frostbite",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Light",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Nature",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Plague",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Surge",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Water",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "Random - Tier 2",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Aftershock",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Chain Lightning",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Chaos Strike",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Charm",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Corpse Explosion",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Crusader",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Explosions",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Fear",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Flame Thrower",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Holy Fire",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Holy Purge",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Lava",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Least Resistance",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Noxiosa",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Pesticide",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Petrification",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Petroleum",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Poison Blood",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Prism",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Rocket Launcher",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Slush",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Sacrifice",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Thunderbolt",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Toxic Lobotomy",
            });
            vm.Scrolls.Add(new ScrollItem
            {
                Name = "     Voodoo",
            });

            vm.SelectedScroll = vm.Scrolls[0];

            DataContext = vm;

            comboboxWeapon.SelectedIndex = 0;


            // Creates a bunch of json files for oils. i know, it's fucking insane, but im bad at this
            /*foreach (string oil in listOils)
            {
                string fileName = $"C:\\Users\\verdi\\source\\repos\\SULFURBuildGenerator\\SULFURBuildGenerator\\JSON\\Oils\\{oil}.json";
                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented
                };
                var data = new { Name = oil, TypePositive1 = "None", TypePositive2 = "None", TypeNegative1 = "None", TypeNegative2 = "None", AmmoConsumeChance = "0.0", Bounces = "0.0", BulletDrop = "0.0", BulletSpeed = "0.0", ExtraAmmoUseChance = "0.0", BaseCritChance = "0.0", DamageAdd = "0.0", DamageMult = "0.0", CanADS = "Yes", JumpPower = "0.0", LootDropChance = "0.0", DurabilityMult = "0.0", MovementSpeedMult = "0.0", MoneyDrops = "Yes", OrganDrops = "Yes", Penetrations = "0.0", ProjectileMult = "0.0", RPM = "0.0", RecoilAdd = "0.0", RecoilMult = "0.0", ReloadSpeed = "0.0", SpreadAdd = "0.0", SpreadMult = "0.0", Drag = "0.0", DurabilityUsage = "1.0" };
                string jsonString = JsonConvert.SerializeObject(data, settings);
                File.WriteAllText(fileName, jsonString);
            }

            // Attachment json generation
            foreach (string barrel in listBarrels)
           {
               string fileName = $"C:\\Users\\verdi\\source\\repos\\SULFURBuildGenerator\\SULFURBuildGenerator\\JSON\\Attachments\\Barrels\\{barrel}.json";
               var settings = new JsonSerializerSettings
               {
                   Formatting = Formatting.Indented
               };
               var data = new { Name = barrel, Type = "Barrel", SpreadAdd = "0.0", MovementSpeedMult = "0.0", };
               string jsonString = JsonConvert.SerializeObject(data, settings);
               File.WriteAllText(fileName, jsonString);
           }

            foreach (string optic in listOptics)
           {
               string fileName = $"C:\\Users\\verdi\\source\\repos\\SULFURBuildGenerator\\SULFURBuildGenerator\\JSON\\Attachments\\Optics\\{optic}.json";
               var settings = new JsonSerializerSettings
               {
                   Formatting = Formatting.Indented
               };
               var data = new { Name = optic, Type = "Optic", BaseCritChance = "0.0" };
               string jsonString = JsonConvert.SerializeObject(data, settings);
               File.WriteAllText(fileName, jsonString);
           }

            foreach (string laser in listLaser)
         {
             string fileName = $"C:\\Users\\verdi\\source\\repos\\SULFURBuildGenerator\\SULFURBuildGenerator\\JSON\\Attachments\\Lasers\\{laser}.json";
             var settings = new JsonSerializerSettings
             {
                 Formatting = Formatting.Indented
             };
             var data = new { Name = laser, Type = "Laser", MovementAccuracy = "0.0" };
             string jsonString = JsonConvert.SerializeObject(data, settings);
             File.WriteAllText(fileName, jsonString);
         }

            foreach (string firemode in listFiremode)
            {
                string fileName = $"C:\\Users\\verdi\\source\\repos\\SULFURBuildGenerator\\SULFURBuildGenerator\\JSON\\Attachments\\Firemodes\\{firemode}.json";
                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented
                };
                var data = new { Name = firemode, Type = "Firemode", DamageMult = "0.0", SpreadAdd = "0.0" };
                string jsonString = JsonConvert.SerializeObject(data, settings);
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
            if (comboboxWeapon.Text == "Pistols")
            {
                totalGuns = listPistols.Concat(listPistols)
                    .ToList();
            }
            /*
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
*/
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

            if (weaponOriginal.AmmoType == "Energy")
            {
                weaponOriginal.RecoilBase = 0.0;
            }
            if (weaponOriginal.AmmoType == "9mm")
            {
                weaponOriginal.RecoilBase = weaponOriginal.RecoilBase9mm;
            }
            if (weaponOriginal.AmmoType == "7.62mm")
            {
                weaponOriginal.RecoilBase = weaponOriginal.RecoilBase762;
            }
            if (weaponOriginal.AmmoType == "5.56mm")
            {
                weaponOriginal.RecoilBase = weaponOriginal.RecoilBase556;
            }
            if (weaponOriginal.AmmoType == ".50 BMG")
            {
                weaponOriginal.RecoilBase = weaponOriginal.RecoilBase50bmg;
            }
            if (weaponOriginal.AmmoType == "12Ga")
            {
                weaponOriginal.RecoilBase = weaponOriginal.RecoilBase12ga;
            }

            // Create Dictionary for attachments

            Dictionary<string, string> attachmentStorage =
            new Dictionary<string, string>();

            attachmentStorage.Add("Barrel", "None");
            attachmentStorage.Add("Optic", "None");
            attachmentStorage.Add("Laser", "None");
            attachmentStorage.Add("Firemode", "None");


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
                    var randomBarrel = listBarrels[randomBarrelNumber];
                    attachmentStorage.Remove("Barrel");
                    attachmentStorage.Add("Barrel", randomBarrel);
                    this.build_box.Items[1] = (new MyItem { Item = "Barrel", Selection = randomBarrel });

                }

                // Optic Randomizer
                System.Random randomOpticInt = new System.Random();
                int randomOpticNumber = randomOpticInt.Next(0, listOptics.Count);
                var randomOptic = listOptics[randomOpticNumber];
                attachmentStorage.Remove("Optic");
                attachmentStorage.Add("Optic", randomOptic);
                this.build_box.Items[2] = (new MyItem { Item = "Optic", Selection = randomOptic });

                // Laser Randomizer
                System.Random randomLaserInt = new System.Random();
                int randomLaserNumber = randomLaserInt.Next(0, listLaser.Count);
                var randomLaser = listLaser[randomLaserNumber];
                attachmentStorage.Remove("Laser");
                attachmentStorage.Add("Laser", randomLaser);
                this.build_box.Items[3] = (new MyItem { Item = "Laser", Selection = randomLaser });

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
                        var randomFire = listFiremodeCrank[randomFireCrankNumber];
                        attachmentStorage.Remove("Firemode");
                        attachmentStorage.Add("Firemode", randomFire);
                        this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = randomFire });
                    }
                    else if (randomGun == "Flock 76" || randomGun == "Drifter 9" || randomGun == "Vrede" || randomGun == "Ploika Compact" || randomGun == "Ferryman" || randomGun == "Valet" || randomGun == "Corpsemaker" || randomGun == "Type 80 Typhoon" || randomGun == "M11A2 Fisk" || randomGun == "Wingman" || randomGun == "Rektor 100rd" || randomGun == "Duhar" || randomGun == "Neuraxis F22")
                    {
                        System.Random randomFirePrimeInt = new System.Random();
                        int randomFirePrimeNumber = randomFirePrimeInt.Next(0, listFiremodePrime.Count);
                        var randomFire = listFiremodePrime[randomFirePrimeNumber];
                        attachmentStorage.Remove("Firemode");
                        attachmentStorage.Add("Firemode", randomFire);
                        this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = randomFire });
                    }
                    else
                    {
                        System.Random randomFireInt = new System.Random();
                        int randomFireNumber = randomFireInt.Next(0, listFiremode.Count);
                        var randomFire = listFiremode[randomFireNumber];
                        attachmentStorage.Remove("Firemode");
                        attachmentStorage.Add("Firemode", randomFire);
                        this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = randomFire });
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
                var randomBarrel = listBarrels[randomBarrelNumber];
                attachmentStorage.Remove("Barrel");
                attachmentStorage.Add("Barrel", randomBarrel);
                this.build_box.Items[1] = (new MyItem { Item = "Barrel", Selection = randomBarrel });
            }
            if ((bool)optics.IsChecked == true && (bool)allAttachmentsCheckbox.IsChecked == false)
            {
                System.Random randomOpticInt = new System.Random();
                int randomOpticNumber = randomOpticInt.Next(0, listOptics.Count);
                var randomOptic = listOptics[randomOpticNumber];
                attachmentStorage.Remove("Optic");
                attachmentStorage.Add("Optic", randomOptic);
                this.build_box.Items[2] = (new MyItem { Item = "Optic", Selection = randomOptic });
            }
            if ((bool)Laser.IsChecked == true && (bool)allAttachmentsCheckbox.IsChecked == false)
            {
                System.Random randomLaserInt = new System.Random();
                int randomLaserNumber = randomLaserInt.Next(0, listLaser.Count);
                var randomLaser = listLaser[randomLaserNumber];
                attachmentStorage.Remove("Laser");
                attachmentStorage.Add("Laser", randomLaser);
                this.build_box.Items[3] = (new MyItem { Item = "Laser", Selection = randomLaser });
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
                        var randomFire = listFiremodeCrank[randomFireCrankNumber];
                        attachmentStorage.Remove("Firemode");
                        attachmentStorage.Add("Firemode", randomFire);
                        this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = randomFire });
                    }
                    else if (randomGun == "Flock 76" || randomGun == "Drifter 9" || randomGun == "Vrede" || randomGun == "Ploika Compact" || randomGun == "Ferryman" || randomGun == "Valet" || randomGun == "Corpsemaker" || randomGun == "Type 80 Typhoon" || randomGun == "M11A2 Fisk" || randomGun == "Wingman" || randomGun == "Rektor 100rd" || randomGun == "Duhar" || randomGun == "Neuraxis F22")
                    {
                        System.Random randomFirePrimeInt = new System.Random();
                        int randomFirePrimeNumber = randomFirePrimeInt.Next(0, listFiremodePrime.Count);
                        var randomFire = listFiremodePrime[randomFirePrimeNumber];
                        attachmentStorage.Remove("Firemode");
                        attachmentStorage.Add("Firemode", randomFire);
                        this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = randomFire });
                    }
                    else
                    {
                        System.Random randomFireInt = new System.Random();
                        int randomFireNumber = randomFireInt.Next(0, listFiremode.Count);
                        var randomFire = listFiremode[randomFireNumber];
                        attachmentStorage.Remove("Firemode");
                        attachmentStorage.Add("Firemode", randomFire);
                        this.build_box.Items[4] = (new MyItem { Item = "Firemode", Selection = randomFire });
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

            // Get Enchantment Selections

            var vmResult = (ViewModel)DataContext;
            var selectedScroll = vmResult.SelectedScroll.Name;

            var selectedOil1Trim = vmResult.SelectedOil1.Name;
            var selectedOil1 = selectedOil1Trim.TrimStart();

            var selectedOil2Trim = vmResult.SelectedOil2.Name;
            var selectedOil2 = selectedOil2Trim.TrimStart();

            var selectedOil3Trim = vmResult.SelectedOil3.Name;
            var selectedOil3 = selectedOil3Trim.TrimStart();

            var selectedOil4Trim = vmResult.SelectedOil4.Name;
            var selectedOil4 = selectedOil4Trim.TrimStart();

            string selectedOil5;

            if (oil_dropdown_5.IsEnabled == true)
            {
                var selectedOil5Trim = vmResult.SelectedOil5.Name;
                selectedOil5 = selectedOil5Trim.TrimStart();
            }
            else
            {
                selectedOil5 = "None";
            }
            
            // Create Scroll Dictionaries
            Dictionary<string, string> scrollAllStorage =
            new Dictionary<string, string>();

            Dictionary<string, string> scrollT1Storage =
            new Dictionary<string, string>();

            Dictionary<string, string> scrollT2Storage =
            new Dictionary<string, string>();

            // Enchantment Randomizer

            //// Scroll List Shuffle
            switch (selectedScroll)
            {
                case "None":
                    break;
                case "Random - All":
                    var scrollShuffle = listAllScrolls.OrderBy(_ => Guid.NewGuid()).ToList();
                    this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = scrollShuffle[1] });
                    selectedScroll = scrollShuffle.ToString();
                    break;
                case "Random - T1":
                    var scrollT1Shuffle = listT1Scrolls.OrderBy(_ => Guid.NewGuid()).ToList();
                    this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = scrollT1Shuffle[1] });
                    selectedScroll = scrollT1Shuffle.ToString();
                    break;
                case "Random - T2":
                    var scrollT2Shuffle = listT2Scrolls.OrderBy(_ => Guid.NewGuid()).ToList();
                    this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = scrollT2Shuffle[1] });
                    selectedScroll = scrollT2Shuffle.ToString();
                    break;
                default:
                    this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = selectedScroll });
                    break;
            }

            // Collect oil selections and initialize lists
            string[] oilSelectionArray = { selectedOil1, selectedOil2, selectedOil3, selectedOil4, selectedOil5 };

            List<string> oilAllShuffle = new List<string>();
            List<string> oilAmmoShuffle = new List<string>();
            List<string> oilCritShuffle = new List<string>();
            List<string> oilBounceShuffle = new List<string>();
            List<string> oilSpeedShuffle = new List<string>();
            List<string> oilAddDamShuffle = new List<string>();
            List<string> oilMultDamShuffle = new List<string>();
            List<string> oilDurShuffle = new List<string>();
            List<string> oilPenShuffle = new List<string>();
            List<string> oilProjShuffle = new List<string>();
            List<string> oilRecoilShuffle = new List<string>();
            List<string> oilReloadShuffle = new List<string>();
            List<string> oilRPMShuffle = new List<string>();
            List<string> oilSpreadShuffle = new List<string>();

            // Shuffle All Oils
            string matchAll = "Random - All";
            if (oilSelectionArray.Any(s => s == matchAll))
            {
                oilAllShuffle = listOils.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilAllShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilAllShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle Ammo Consume Chance
            string matchAmmo = "Random - Ammo Consume Chance";
            if (oilSelectionArray.Any(s => s == matchAmmo))
            {
                oilAmmoShuffle = listOilAmmo.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilAmmoShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilAmmoShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle Base Crit Chance
            string matchCrit = "Random - Base Crit Chance";
            if (oilSelectionArray.Any(s => s == matchCrit))
            {
                oilCritShuffle = listOilCrit.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilCritShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilCritShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle Bullet Bounces
            string matchBounce = "Random - Bullet Bounces";
            if (oilSelectionArray.Any(s => s == matchBounce))
            {
                oilBounceShuffle = listOilBounce.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilBounceShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilBounceShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle Bullet Speed
            string matchSpeed = "Random - Bullet Speed";
            if (oilSelectionArray.Any(s => s == matchSpeed))
            {
                oilSpeedShuffle = listOilSpeed.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilSpeedShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilSpeedShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle Add Damage
            string matchAddDmg = "Random - Add Damage";
            if (oilSelectionArray.Any(s => s == matchAddDmg))
            {
                oilAddDamShuffle = listOilAddDam.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilAddDamShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilAddDamShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle % Damage
            string matchMultDmg = "Random - % Damage";
            if (oilSelectionArray.Any(s => s == matchMultDmg))
            {
                oilMultDamShuffle = listOilMultDam.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilMultDamShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilMultDamShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle Durability
            string matchDur = "Random - Durability";
            if (oilSelectionArray.Any(s => s == matchDur))
            {
                oilDurShuffle = listOilDur.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilDurShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilDurShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle Penetration
            string matchPen = "Random - Penetration";
            if (oilSelectionArray.Any(s => s == matchPen))
            {
                oilPenShuffle = listOilPen.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilPenShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilPenShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle Projectiles
            string matchProj = "Random - Projectiles";
            if (oilSelectionArray.Any(s => s == matchProj))
            {
                oilProjShuffle = listOilProj.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilProjShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilProjShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle Recoil
            string matchRecoil = "Random - Recoil";
            if (oilSelectionArray.Any(s => s == matchRecoil))
            {
                oilRecoilShuffle = listOilRecoil.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilRecoilShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilRecoilShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle Reload Speed
            string matchReload = "Random - Reload Speed";
            if (oilSelectionArray.Any(s => s == matchReload))
            {
                oilReloadShuffle = listOilReload.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilReloadShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilReloadShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle RPM
            string matchRPM = "Random - RPM";
            if (oilSelectionArray.Any(s => s == matchRPM))
            {
                oilRPMShuffle = listOilRPM.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilRPMShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilRPMShuffle.Remove(oil);
                    }
                }
            }

            // Shuffle Spread
            string matchSpread = "Random - Spread";
            if (oilSelectionArray.Any(s => s == matchSpread))
            {
                oilSpreadShuffle = listOilSpread.OrderBy(_ => Guid.NewGuid()).ToList();
                foreach (string oil in oilSpreadShuffle.ToList())
                {
                    if (oilSelectionArray.Any(s => s == oil))
                    {
                        bool wasRemoved = oilSpreadShuffle.Remove(oil);
                    }
                }
            }

            // Oil Dictionary to store random oils
            Dictionary<string, string> oilStorage =
            new Dictionary<string, string>();

            // Add Oils to Grid
            if (selectedScroll == "None")
            {
                // Add First Oil to Grid
                switch (selectedOil1)
                {
                    case "None":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = selectedOil1.ToString() });
                        break;
                    case "Random - All":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilAllShuffle[0] });
                        oilStorage.Add("0", oilAllShuffle[0].ToString());
                        break;
                    case "Random - Ammo Consume Chance":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilAmmoShuffle[0] });
                        oilStorage.Add("0", oilAmmoShuffle[0].ToString());
                        break;
                    case "Random - Base Crit Chance":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilCritShuffle[0] });
                        oilStorage.Add("0", oilCritShuffle[0].ToString());
                        break;
                    case "Random - Bullet Bounces":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilBounceShuffle[0] });
                        oilStorage.Add("0", oilBounceShuffle[0].ToString());
                        break;
                    case "Random - Bullet Speed":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilSpeedShuffle[0] });
                        oilStorage.Add("0", oilSpeedShuffle[0].ToString());
                        break;
                    case "Random - Add Damage":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilAddDamShuffle[0] });
                        oilStorage.Add("0", oilAddDamShuffle[0].ToString());
                        break;
                    case "Random - % Damage":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilMultDamShuffle[0] });
                        oilStorage.Add("0", oilMultDamShuffle[0].ToString());
                        break;
                    case "Random - Durability":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilDurShuffle[0] });
                        oilStorage.Add("0", oilDurShuffle[0].ToString());
                        break;
                    case "Random - Penetration":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilPenShuffle[0] });
                        oilStorage.Add("0", oilPenShuffle[0].ToString());
                        break;
                    case "Random - Projectiles":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilProjShuffle[0] });
                        oilStorage.Add("0", oilProjShuffle[0].ToString());
                        break;
                    case "Random - Recoil":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilRecoilShuffle[0] });
                        oilStorage.Add("0", oilRecoilShuffle[0].ToString());
                        break;
                    case "Random - Reload Speed":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilReloadShuffle[0] });
                        oilStorage.Add("0", oilReloadShuffle[0].ToString());
                        break;
                    case "Random - RPM":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilRPMShuffle[0] });
                        oilStorage.Add("0", oilRPMShuffle[0].ToString());
                        break;
                    case "Random - Spread":
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = oilSpreadShuffle[0] });
                        oilStorage.Add("0", oilSpreadShuffle[0].ToString());
                        break;
                    default:
                        this.build_box.Items[6] = (new MyItem { Item = "Enchantment 1", Selection = selectedOil1.ToString() });
                        oilStorage.Add("0", selectedOil1.ToString());
                        break;
                }
                // Remove potential dupes
                if (oilStorage.ContainsKey("0"))
                {
                    if (oilAllShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilAllShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilAmmoShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilAmmoShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilCritShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilCritShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilBounceShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilBounceShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilSpeedShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilSpeedShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilAddDamShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilAddDamShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilMultDamShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilMultDamShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilDurShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilDurShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilPenShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilPenShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilProjShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilProjShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilRecoilShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilRecoilShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilReloadShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilReloadShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilRPMShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilRPMShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilSpreadShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilSpreadShuffle.Remove(oilStorage["0"]);
                    }
                }

                // Add Second Oil to Grid
                switch (selectedOil2)
                {
                    case "None":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = selectedOil2.ToString() });
                        break;
                    case "Random - All":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilAllShuffle[0] });
                        oilStorage.Add("1", oilAllShuffle[0].ToString());
                        break;
                    case "Random - Ammo Consume Chance":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilAmmoShuffle[0] });
                        oilStorage.Add("1", oilAmmoShuffle[0].ToString());
                        break;
                    case "Random - Base Crit Chance":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilCritShuffle[0] });
                        oilStorage.Add("1", oilCritShuffle[0].ToString());
                        break;
                    case "Random - Bullet Bounces":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilBounceShuffle[0] });
                        oilStorage.Add("1", oilBounceShuffle[0].ToString());
                        break;
                    case "Random - Bullet Speed":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilSpeedShuffle[0] });
                        oilStorage.Add("1", oilSpeedShuffle[0].ToString());
                        break;
                    case "Random - Add Damage":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilAddDamShuffle[0] });
                        oilStorage.Add("1", oilAddDamShuffle[0].ToString());
                        break;
                    case "Random - % Damage":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilMultDamShuffle[0] });
                        oilStorage.Add("1", oilMultDamShuffle[0].ToString());
                        break;
                    case "Random - Durability":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilDurShuffle[0] });
                        oilStorage.Add("1", oilDurShuffle[0].ToString());
                        break;
                    case "Random - Penetration":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilPenShuffle[0] });
                        oilStorage.Add("1", oilPenShuffle[0].ToString());
                        break;
                    case "Random - Projectiles":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilProjShuffle[0] });
                        oilStorage.Add("1", oilProjShuffle[0].ToString());
                        break;
                    case "Random - Recoil":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilRecoilShuffle[0] });
                        oilStorage.Add("1", oilRecoilShuffle[0].ToString());
                        break;
                    case "Random - Reload Speed":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilReloadShuffle[0] });
                        oilStorage.Add("1", oilReloadShuffle[0].ToString());
                        break;
                    case "Random - RPM":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilRPMShuffle[0] });
                        oilStorage.Add("1", oilRPMShuffle[0].ToString());
                        break;
                    case "Random - Spread":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilSpreadShuffle[0] });
                        oilStorage.Add("1", oilSpreadShuffle[0].ToString());
                        break;
                    default:
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = selectedOil2.ToString() });
                        oilStorage.Add("1", selectedOil2.ToString());
                        break;
                }
                // Remove potential dupes
                if (oilStorage.ContainsKey("1"))
                {
                    if (oilAllShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilAllShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilAmmoShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilAmmoShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilCritShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilCritShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilBounceShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilBounceShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilSpeedShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilSpeedShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilAddDamShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilAddDamShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilMultDamShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilMultDamShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilDurShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilDurShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilPenShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilPenShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilProjShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilProjShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilRecoilShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilRecoilShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilReloadShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilReloadShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilRPMShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilRPMShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilSpreadShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilSpreadShuffle.Remove(oilStorage["1"]);
                    }
                }

                // Add Third Oil to Grid
                switch (selectedOil3)
                {
                    case "None":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = selectedOil3.ToString() });
                        break;
                    case "Random - All":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilAllShuffle[2] });
                        oilStorage.Add("2", oilAllShuffle[2].ToString());
                        break;
                    case "Random - Ammo Consume Chance":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilAmmoShuffle[2] });
                        oilStorage.Add("2", oilAmmoShuffle[2].ToString());
                        break;
                    case "Random - Base Crit Chance":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilCritShuffle[2] });
                        oilStorage.Add("2", oilCritShuffle[2].ToString());
                        break;
                    case "Random - Bullet Bounces":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilBounceShuffle[2] });
                        oilStorage.Add("2", oilBounceShuffle[2].ToString());
                        break;
                    case "Random - Bullet Speed":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilSpeedShuffle[2] });
                        oilStorage.Add("2", oilSpeedShuffle[2].ToString());
                        break;
                    case "Random - Add Damage":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilAddDamShuffle[2] });
                        oilStorage.Add("2", oilAddDamShuffle[2].ToString());
                        break;
                    case "Random - % Damage":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilMultDamShuffle[2] });
                        oilStorage.Add("2", oilMultDamShuffle[2].ToString());
                        break;
                    case "Random - Durability":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilDurShuffle[2] });
                        oilStorage.Add("2", oilDurShuffle[2].ToString());
                        break;
                    case "Random - Penetration":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilPenShuffle[2] });
                        oilStorage.Add("2", oilPenShuffle[2].ToString());
                        break;
                    case "Random - Projectiles":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilProjShuffle[2] });
                        oilStorage.Add("2", oilProjShuffle[2].ToString());
                        break;
                    case "Random - Recoil":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilRecoilShuffle[2] });
                        oilStorage.Add("2", oilRecoilShuffle[2].ToString());
                        break;
                    case "Random - Reload Speed":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilReloadShuffle[2] });
                        oilStorage.Add("2", oilReloadShuffle[2].ToString());
                        break;
                    case "Random - RPM":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilRPMShuffle[2] });
                        oilStorage.Add("2", oilRPMShuffle[2].ToString());
                        break;
                    case "Random - Spread":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilSpreadShuffle[2] });
                        oilStorage.Add("2", oilSpreadShuffle[2].ToString());
                        break;
                    default:
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = selectedOil3.ToString() });
                        oilStorage.Add("2", selectedOil3.ToString());
                        break;
                }
                // Remove potential dupes
                if (oilStorage.ContainsKey("2"))
                {
                    if (oilAllShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilAllShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilAmmoShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilAmmoShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilCritShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilCritShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilBounceShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilBounceShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilSpeedShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilSpeedShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilAddDamShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilAddDamShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilMultDamShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilMultDamShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilDurShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilDurShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilPenShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilPenShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilProjShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilProjShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilRecoilShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilRecoilShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilReloadShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilReloadShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilRPMShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilRPMShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilSpreadShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilSpreadShuffle.Remove(oilStorage["2"]);
                    }
                }


                // Add Fourth Oil to Grid
                switch (selectedOil4)
                {
                    case "None":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = selectedOil4.ToString() });
                        break;
                    case "Random - All":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilAllShuffle[3] });
                        oilStorage.Add("3", oilAllShuffle[3].ToString());
                        break;
                    case "Random - Ammo Consume Chance":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilAmmoShuffle[3] });
                        oilStorage.Add("3", oilAmmoShuffle[3].ToString());
                        break;
                    case "Random - Base Crit Chance":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilCritShuffle[3] });
                        oilStorage.Add("3", oilCritShuffle[3].ToString());
                        break;
                    case "Random - Bullet Bounces":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilBounceShuffle[3] });
                        oilStorage.Add("3", oilBounceShuffle[3].ToString());
                        break;
                    case "Random - Bullet Speed":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilSpeedShuffle[3] });
                        oilStorage.Add("3", oilSpeedShuffle[3].ToString());
                        break;
                    case "Random - Add Damage":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilAddDamShuffle[3] });
                        oilStorage.Add("3", oilAddDamShuffle[3].ToString());
                        break;
                    case "Random - % Damage":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilMultDamShuffle[3] });
                        oilStorage.Add("3", oilMultDamShuffle[3].ToString());
                        break;
                    case "Random - Durability":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilDurShuffle[3] });
                        oilStorage.Add("3", oilDurShuffle[3].ToString());
                        break;
                    case "Random - Penetration":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilPenShuffle[3] });
                        oilStorage.Add("3", oilPenShuffle[3].ToString());
                        break;
                    case "Random - Projectiles":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilProjShuffle[3] });
                        oilStorage.Add("3", oilProjShuffle[3].ToString());
                        break;
                    case "Random - Recoil":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilRecoilShuffle[3] });
                        oilStorage.Add("3", oilRecoilShuffle[3].ToString());
                        break;
                    case "Random - Reload Speed":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilReloadShuffle[3] });
                        oilStorage.Add("3", oilReloadShuffle[3].ToString());
                        break;
                    case "Random - RPM":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilRPMShuffle[3] });
                        oilStorage.Add("3", oilRPMShuffle[3].ToString());
                        break;
                    case "Random - Spread":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilSpreadShuffle[3] });
                        oilStorage.Add("3", oilSpreadShuffle[3].ToString());
                        break;
                    default:
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = selectedOil4.ToString() });
                        oilStorage.Add("3", selectedOil4.ToString());
                        break;
                }
                // Remove potential dupes
                if (oilStorage.ContainsKey("3"))
                {
                    if (oilAllShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilAllShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilAmmoShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilAmmoShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilCritShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilCritShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilBounceShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilBounceShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilSpeedShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilSpeedShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilAddDamShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilAddDamShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilMultDamShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilMultDamShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilDurShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilDurShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilPenShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilPenShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilProjShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilProjShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilRecoilShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilRecoilShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilReloadShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilReloadShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilRPMShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilRPMShuffle.Remove(oilStorage["3"]);
                    }
                    if (oilSpreadShuffle.Any(s => s == oilStorage["3"]))
                    {
                        bool wasRemoved = oilSpreadShuffle.Remove(oilStorage["3"]);
                    }
                }

                // Add Fifth Oil
                switch (selectedOil5)
                {
                    case "None":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = selectedOil5.ToString() });
                        break;
                    case "Random - All":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilAllShuffle[4] });
                        oilStorage.Add("4", oilAllShuffle[4].ToString());
                        break;
                    case "Random - Ammo Consume Chance":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilAmmoShuffle[4] });
                        oilStorage.Add("4", oilAmmoShuffle[4].ToString());
                        break;
                    case "Random - Base Crit Chance":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilCritShuffle[4] });
                        oilStorage.Add("4", oilCritShuffle[4].ToString());
                        break;
                    case "Random - Bullet Bounces":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilBounceShuffle[4] });
                        oilStorage.Add("4", oilBounceShuffle[4].ToString());
                        break;
                    case "Random - Bullet Speed":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilSpeedShuffle[4] });
                        oilStorage.Add("4", oilSpeedShuffle[4].ToString());
                        break;
                    case "Random - Add Damage":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilAddDamShuffle[4] });
                        oilStorage.Add("4", oilAddDamShuffle[4].ToString());
                        break;
                    case "Random - % Damage":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilMultDamShuffle[4] });
                        oilStorage.Add("4", oilMultDamShuffle[4].ToString());
                        break;
                    case "Random - Durability":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilDurShuffle[4] });
                        oilStorage.Add("4", oilDurShuffle[4].ToString());
                        break;
                    case "Random - Penetration":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilPenShuffle[4] });
                        oilStorage.Add("4", oilPenShuffle[4].ToString());
                        break;
                    case "Random - Projectiles":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilProjShuffle[4] });
                        oilStorage.Add("4", oilProjShuffle[4].ToString());
                        break;
                    case "Random - Recoil":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilRecoilShuffle[4] });
                        oilStorage.Add("4", oilRecoilShuffle[4].ToString());
                        break;
                    case "Random - Reload Speed":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilReloadShuffle[4] });
                        oilStorage.Add("4", oilReloadShuffle[4].ToString());
                        break;
                    case "Random - RPM":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilRPMShuffle[4] });
                        oilStorage.Add("4", oilRPMShuffle[4].ToString());
                        break;
                    case "Random - Spread":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilSpreadShuffle[4] });
                        oilStorage.Add("4", oilSpreadShuffle[4].ToString());
                        break;
                    default:
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = selectedOil5.ToString() });
                        oilStorage.Add("4", selectedOil5.ToString());
                        break;
                }
            }
            // If Scrolls enabled
            if (selectedScroll != "None")
            {
                // Add First Oil to Grid
                switch (selectedOil1)
                {
                    case "None":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = selectedOil1.ToString() });
                        break;
                    case "Random - All":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilAllShuffle[0] });
                        oilStorage.Add("0", oilAllShuffle[0].ToString());
                        break;
                    case "Random - Ammo Consume Chance":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilAmmoShuffle[0] });
                        oilStorage.Add("0", oilAmmoShuffle[0].ToString());
                        break;
                    case "Random - Base Crit Chance":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilCritShuffle[0] });
                        oilStorage.Add("0", oilCritShuffle[0].ToString());
                        break;
                    case "Random - Bullet Bounces":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilBounceShuffle[0] });
                        oilStorage.Add("0", oilBounceShuffle[0].ToString());
                        break;
                    case "Random - Bullet Speed":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilSpeedShuffle[0] });
                        oilStorage.Add("0", oilSpeedShuffle[0].ToString());
                        break;
                    case "Random - Add Damage":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilAddDamShuffle[0] });
                        oilStorage.Add("0", oilAddDamShuffle[0].ToString());
                        break;
                    case "Random - % Damage":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilMultDamShuffle[0] });
                        oilStorage.Add("0", oilMultDamShuffle[0].ToString());
                        break;
                    case "Random - Durability":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilDurShuffle[0] });
                        oilStorage.Add("0", oilDurShuffle[0].ToString());
                        break;
                    case "Random - Penetration":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilPenShuffle[0] });
                        oilStorage.Add("0", oilPenShuffle[0].ToString());
                        break;
                    case "Random - Projectiles":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilProjShuffle[0] });
                        oilStorage.Add("0", oilProjShuffle[0].ToString());
                        break;
                    case "Random - Recoil":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilRecoilShuffle[0] });
                        oilStorage.Add("0", oilRecoilShuffle[0].ToString());
                        break;
                    case "Random - Reload Speed":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilReloadShuffle[0] });
                        oilStorage.Add("0", oilReloadShuffle[0].ToString());
                        break;
                    case "Random - RPM":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilRPMShuffle[0] });
                        oilStorage.Add("0", oilRPMShuffle[0].ToString());
                        break;
                    case "Random - Spread":
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = oilSpreadShuffle[0] });
                        oilStorage.Add("0", oilSpreadShuffle[0].ToString());
                        break;
                    default:
                        this.build_box.Items[7] = (new MyItem { Item = "Enchantment 2", Selection = selectedOil1.ToString() });
                        oilStorage.Add("0", selectedOil1.ToString());
                        break;
                }
                // Remove potential dupes
                if (oilStorage.ContainsKey("0"))
                {
                    if (oilAllShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilAllShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilAmmoShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilAmmoShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilCritShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilCritShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilBounceShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilBounceShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilSpeedShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilSpeedShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilAddDamShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilAddDamShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilMultDamShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilMultDamShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilDurShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilDurShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilPenShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilPenShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilProjShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilProjShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilRecoilShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilRecoilShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilReloadShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilReloadShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilRPMShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilRPMShuffle.Remove(oilStorage["0"]);
                    }
                    if (oilSpreadShuffle.Any(s => s == oilStorage["0"]))
                    {
                        bool wasRemoved = oilSpreadShuffle.Remove(oilStorage["0"]);
                    }
                }

                // Add Second Oil to Grid
                switch (selectedOil2)
                {
                    case "None":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = selectedOil2.ToString() });
                        break;
                    case "Random - All":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilAllShuffle[1] });
                        oilStorage.Add("1", oilAllShuffle[1].ToString());
                        break;
                    case "Random - Ammo Consume Chance":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilAmmoShuffle[1] });
                        oilStorage.Add("1", oilAmmoShuffle[1].ToString());
                        break;
                    case "Random - Base Crit Chance":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilCritShuffle[1] });
                        oilStorage.Add("1", oilCritShuffle[1].ToString());
                        break;
                    case "Random - Bullet Bounces":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilBounceShuffle[1] });
                        oilStorage.Add("1", oilBounceShuffle[1].ToString());
                        break;
                    case "Random - Bullet Speed":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilSpeedShuffle[1] });
                        oilStorage.Add("1", oilSpeedShuffle[1].ToString());
                        break;
                    case "Random - Add Damage":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilAddDamShuffle[1] });
                        oilStorage.Add("1", oilAddDamShuffle[1].ToString());
                        break;
                    case "Random - % Damage":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilMultDamShuffle[1] });
                        oilStorage.Add("1", oilMultDamShuffle[1].ToString());
                        break;
                    case "Random - Durability":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilDurShuffle[1] });
                        oilStorage.Add("1", oilDurShuffle[1].ToString());
                        break;
                    case "Random - Penetration":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilPenShuffle[1] });
                        oilStorage.Add("1", oilPenShuffle[1].ToString());
                        break;
                    case "Random - Projectiles":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilProjShuffle[1] });
                        oilStorage.Add("1", oilProjShuffle[1].ToString());
                        break;
                    case "Random - Recoil":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilRecoilShuffle[1] });
                        oilStorage.Add("1", oilRecoilShuffle[1].ToString());
                        break;
                    case "Random - Reload Speed":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilReloadShuffle[1] });
                        oilStorage.Add("1", oilReloadShuffle[1].ToString());
                        break;
                    case "Random - RPM":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilRPMShuffle[1] });
                        oilStorage.Add("1", oilRPMShuffle[1].ToString());
                        break;
                    case "Random - Spread":
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = oilSpreadShuffle[1] });
                        oilStorage.Add("1", oilSpreadShuffle[1].ToString());
                        break;
                    default:
                        this.build_box.Items[8] = (new MyItem { Item = "Enchantment 3", Selection = selectedOil2.ToString() });
                        oilStorage.Add("1", selectedOil2.ToString());
                        break;
                }
                // Remove potential dupes
                if (oilStorage.ContainsKey("1"))
                {
                    if (oilAllShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilAllShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilAmmoShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilAmmoShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilCritShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilCritShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilBounceShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilBounceShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilSpeedShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilSpeedShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilAddDamShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilAddDamShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilMultDamShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilMultDamShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilDurShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilDurShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilPenShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilPenShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilProjShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilProjShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilRecoilShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilRecoilShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilReloadShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilReloadShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilRPMShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilRPMShuffle.Remove(oilStorage["1"]);
                    }
                    if (oilSpreadShuffle.Any(s => s == oilStorage["1"]))
                    {
                        bool wasRemoved = oilSpreadShuffle.Remove(oilStorage["1"]);
                    }
                }

                // Add Third Oil to Grid
                switch (selectedOil3)
                {
                    case "None":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = selectedOil3.ToString() });
                        break;
                    case "Random - All":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilAllShuffle[2] });
                        oilStorage.Add("2", oilAllShuffle[2].ToString());
                        break;
                    case "Random - Ammo Consume Chance":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilAmmoShuffle[2] });
                        oilStorage.Add("2", oilAmmoShuffle[2].ToString());
                        break;
                    case "Random - Base Crit Chance":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilCritShuffle[2] });
                        oilStorage.Add("2", oilCritShuffle[2].ToString());
                        break;
                    case "Random - Bullet Bounces":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilBounceShuffle[2] });
                        oilStorage.Add("2", oilBounceShuffle[2].ToString());
                        break;
                    case "Random - Bullet Speed":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilSpeedShuffle[2] });
                        oilStorage.Add("2", oilSpeedShuffle[2].ToString());
                        break;
                    case "Random - Add Damage":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilAddDamShuffle[2] });
                        oilStorage.Add("2", oilAddDamShuffle[2].ToString());
                        break;
                    case "Random - % Damage":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilMultDamShuffle[2] });
                        oilStorage.Add("2", oilMultDamShuffle[2].ToString());
                        break;
                    case "Random - Durability":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilDurShuffle[2] });
                        oilStorage.Add("2", oilDurShuffle[2].ToString());
                        break;
                    case "Random - Penetration":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilPenShuffle[2] });
                        oilStorage.Add("2", oilPenShuffle[2].ToString());
                        break;
                    case "Random - Projectiles":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilProjShuffle[2] });
                        oilStorage.Add("2", oilProjShuffle[2].ToString());
                        break;
                    case "Random - Recoil":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilRecoilShuffle[2] });
                        oilStorage.Add("2", oilRecoilShuffle[2].ToString());
                        break;
                    case "Random - Reload Speed":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilReloadShuffle[2] });
                        oilStorage.Add("2", oilReloadShuffle[2].ToString());
                        break;
                    case "Random - RPM":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilRPMShuffle[2] });
                        oilStorage.Add("2", oilRPMShuffle[2].ToString());
                        break;
                    case "Random - Spread":
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = oilSpreadShuffle[2] });
                        oilStorage.Add("2", oilSpreadShuffle[2].ToString());
                        break;
                    default:
                        this.build_box.Items[9] = (new MyItem { Item = "Enchantment 4", Selection = selectedOil3.ToString() });
                        oilStorage.Add("2", selectedOil3.ToString());
                        break;
                }
                // Remove potential dupes
                if (oilStorage.ContainsKey("2"))
                {
                    if (oilAllShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilAllShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilAmmoShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilAmmoShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilCritShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilCritShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilBounceShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilBounceShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilSpeedShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilSpeedShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilAddDamShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilAddDamShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilMultDamShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilMultDamShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilDurShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilDurShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilPenShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilPenShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilProjShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilProjShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilRecoilShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilRecoilShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilReloadShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilReloadShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilRPMShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilRPMShuffle.Remove(oilStorage["2"]);
                    }
                    if (oilSpreadShuffle.Any(s => s == oilStorage["2"]))
                    {
                        bool wasRemoved = oilSpreadShuffle.Remove(oilStorage["2"]);
                    }
                }

                // Add Fourth Oil to Grid
                switch (selectedOil4)
                {
                    case "None":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = selectedOil4.ToString() });
                        break;
                    case "Random - All":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilAllShuffle[3] });
                        oilStorage.Add("3", oilAllShuffle[3].ToString());
                        break;
                    case "Random - Ammo Consume Chance":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilAmmoShuffle[3] });
                        oilStorage.Add("3", oilAmmoShuffle[3].ToString());
                        break;
                    case "Random - Base Crit Chance":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilCritShuffle[3] });
                        oilStorage.Add("3", oilCritShuffle[3].ToString());
                        break;
                    case "Random - Bullet Bounces":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilBounceShuffle[3] });
                        oilStorage.Add("3", oilBounceShuffle[3].ToString());
                        break;
                    case "Random - Bullet Speed":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilSpeedShuffle[3] });
                        oilStorage.Add("3", oilSpeedShuffle[3].ToString());
                        break;
                    case "Random - Add Damage":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilAddDamShuffle[3] });
                        oilStorage.Add("3", oilAddDamShuffle[3].ToString());
                        break;
                    case "Random - % Damage":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilMultDamShuffle[3] });
                        oilStorage.Add("3", oilMultDamShuffle[3].ToString());
                        break;
                    case "Random - Durability":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilDurShuffle[3] });
                        oilStorage.Add("3", oilDurShuffle[3].ToString());
                        break;
                    case "Random - Penetration":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilPenShuffle[3] });
                        oilStorage.Add("3", oilPenShuffle[3].ToString());
                        break;
                    case "Random - Projectiles":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilProjShuffle[3] });
                        oilStorage.Add("3", oilProjShuffle[3].ToString());
                        break;
                    case "Random - Recoil":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilRecoilShuffle[3] });
                        oilStorage.Add("3", oilRecoilShuffle[3].ToString());
                        break;
                    case "Random - Reload Speed":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilReloadShuffle[3] });
                        oilStorage.Add("3", oilReloadShuffle[3].ToString());
                        break;
                    case "Random - RPM":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilRPMShuffle[3] });
                        oilStorage.Add("3", oilRPMShuffle[3].ToString());
                        break;
                    case "Random - Spread":
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = oilSpreadShuffle[3] });
                        oilStorage.Add("3", oilSpreadShuffle[3].ToString());
                        break;
                    default:
                        this.build_box.Items[10] = (new MyItem { Item = "Enchantment 5", Selection = selectedOil4.ToString() });
                        oilStorage.Add("3", selectedOil4.ToString());
                        break;
                }
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
            /*if (headEquipmentCheckbox.IsChecked == true && (bool)allEquipmentCheckbox.IsChecked == false)
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
            }*/


            // Attachment math
            string attachmentJsonFilename = $".\\JSON\\Attachments\\!AttachmentStats.json";
            string attachmentJsonString = File.ReadAllText(attachmentJsonFilename);
            Attachment attachmentStats = JsonConvert.DeserializeObject<Attachment>(attachmentJsonString)!;

            //// Barrels
            if (attachmentStorage["Barrel"] != "None")
            {
                string barrelJsonFilename = $".\\JSON\\Attachments\\Barrels\\{attachmentStorage["Barrel"]}.json";
                string barrelJsonString = File.ReadAllText(barrelJsonFilename);
                Attachment barrelStats = JsonConvert.DeserializeObject<Attachment>(barrelJsonString)!;
                attachmentStats.SpreadAdd += barrelStats.SpreadAdd;
                attachmentStats.MovementSpeedMult += barrelStats.MovementSpeedMult;
            }

            if (attachmentStorage["Optic"] != "None")
            {
                string opticJsonFilename = $".\\JSON\\Attachments\\Optics\\{attachmentStorage["Optic"]}.json";
                string opticJsonString = File.ReadAllText(opticJsonFilename);
                Attachment opticStats = JsonConvert.DeserializeObject<Attachment>(opticJsonString)!;
                attachmentStats.ADSCritChance += opticStats.ADSCritChance;
            }

            if (attachmentStorage["Laser"] != "None")
            {
                string laserJsonFilename = $".\\JSON\\Attachments\\Lasers\\{attachmentStorage["Laser"]}.json";
                string laserJsonString = File.ReadAllText(laserJsonFilename);
                Attachment laserStats = JsonConvert.DeserializeObject<Attachment>(laserJsonString)!;
                attachmentStats.MovingAccuracy += laserStats.MovingAccuracy;
            }

            if (attachmentStorage["Firemode"] != "None")
            {
                string fireJsonFilename = $".\\JSON\\Attachments\\Firemodes\\{attachmentStorage["Firemode"]}.json";
                string fireJsonString = File.ReadAllText(fireJsonFilename);
                Attachment fireStats = JsonConvert.DeserializeObject<Attachment>(fireJsonString)!;
                attachmentStats.DamageMult += fireStats.DamageMult;
                attachmentStats.SpreadAdd += fireStats.SpreadAdd;
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

                if (oilStats.AmmoConsumeChance != 0.0)
                {
                    oilModifierStats.AmmoConsumeChance += oilStats.AmmoConsumeChance;
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
                if (oilStats.BulletBounciness != 0.0)
                {
                    oilModifierStats.BulletBounciness += oilStats.BulletBounciness;
                }
                if (oilStats.MovingAccuracy != 0.0)
                {
                    oilModifierStats.MovingAccuracy += oilStats.MovingAccuracy;
                }

            }

            // Oils to Weapon calculations & card additions
            //// Clear Card fields
            this.cardDamage.Inlines.Clear();
            this.cardDamageTotal.Inlines.Clear();
            this.cardSpread.Inlines.Clear();
            this.cardBaseCritChance.Inlines.Clear();
            this.cardTotalCritChance.Inlines.Clear();
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
            this.cardAmmoConsumeChance.Inlines.Clear();
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
            //// Ammo Consume Chance ////
            ///////////////////////////////

            weapon.AmmoConsumeChance += oilModifierStats.AmmoConsumeChance;
            weapon.AmmoConsumeChance *= 100;

            if (weapon.AmmoConsumeChance < 100)
            {
                Run runAmmoConsumeChance = new Run($"{weapon.AmmoConsumeChance.ToString("#####0.#")}%");
                runAmmoConsumeChance.Foreground = Brushes.Lime;

                Run runArrowDown = new Run("🡇");
                runArrowDown.Foreground = Brushes.Lime;

                Run runNoAmmoConsumeChance = new Run("(100%)");
                runNoAmmoConsumeChance.FontFamily = new FontFamily("Fredoka Light");

                this.cardAmmoConsumeChance.Inlines.Add("Ammo Consume Chance: ");
                this.cardAmmoConsumeChance.Inlines.Add(runAmmoConsumeChance);
                this.cardAmmoConsumeChance.Inlines.Add(runArrowDown);
                this.cardAmmoConsumeChance.Inlines.Add(runSpace);
                this.cardAmmoConsumeChance.Inlines.Add(runNoAmmoConsumeChance);
            }
            if (weapon.AmmoConsumeChance == 100)
            {
                this.cardAmmoConsumeChance.Inlines.Add("Ammo Consume Chance: 100%");
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

            /////////////////////////
            //// ADS Crit Chance ////
            /////////////////////////

            weapon.ADSCritChance += (attachmentStats.ADSCritChance * 100);

            if (weapon.ADSCritChance > 0.0)
            {
                Run runACrit = new Run($"{weapon.ADSCritChance.ToString("#####0.#")}%");
                runACrit.Foreground = Brushes.Lime;

                Run runArrowUp1 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;

                Run runNoACrit = new Run("(0%)");
                runNoACrit.FontFamily = new FontFamily("Fredoka Light");

                this.cardADSCritChance.Inlines.Add("ADS Crit Chance: ");
                this.cardADSCritChance.Inlines.Add(runACrit);
                this.cardADSCritChance.Inlines.Add(runArrowUp1);
                this.cardADSCritChance.Inlines.Add(runSpace);
                this.cardADSCritChance.Inlines.Add(runNoACrit);
            }
            else
            {
                this.cardADSCritChance.Inlines.Add("ADS Crit Chance: 0%");
            }

            ///////////////////////////
            //// Total Crit Chance ////
            ///////////////////////////

            weapon.TotalCritChance = weapon.ADSCritChance + weapon.BaseCritChance;

            if (weapon.TotalCritChance > 0.0)
            {
                Run runTCrit = new Run($"{weapon.TotalCritChance.ToString("#####0.#")}%");
                runTCrit.Foreground = Brushes.Lime;

                Run runArrowUp1 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;

                Run runNoTCrit = new Run("(0%)");
                runNoTCrit.FontFamily = new FontFamily("Fredoka Light");

                this.cardTotalCritChance.Inlines.Add("Total: ");
                this.cardTotalCritChance.Inlines.Add(runTCrit);
                this.cardTotalCritChance.Inlines.Add(runArrowUp1);
                this.cardTotalCritChance.Inlines.Add(runSpace);
                this.cardTotalCritChance.Inlines.Add(runNoTCrit);
            }
            else
            {
                this.cardTotalCritChance.Inlines.Add("Total: 0%");
            }

            //////////////////////////////
            //// Damage & Projectiles ////
            //////////////////////////////

            //// Projectiles
            weapon.Projectiles *= (1 + oilModifierStats.ProjectileMult);
            //// Damage Add
            weapon.Damage += oilModifierStats.DamageAdd;
            //// Damage Multiplier
            weapon.Damage *= (1 + oilModifierStats.DamageMult + attachmentStats.DamageMult);
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

                Run runNoLoot = new Run($"({weaponOriginal.LootDropChance.ToString("#####0.#")}%)");
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

            this.cardWeaponWeight.Inlines.Add($"Weapon Weight: {weapon.WeaponWeight.ToString("#####0.#")}");

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
                Run runMovementFinal = new Run($"{weapon.FinalMovementSpeed.ToString("#####0.#")}%");
                runMovementFinal.Foreground = Brushes.OrangeRed;

                Run runMovementComp = new Run($"{resultMovementSpeedComp.ToString("#####0.#")}%");
                runMovementComp.FontFamily = new FontFamily("Fredoka Light");

                Run runArrowDown1 = new Run("🡇");
                runArrowDown1.Foreground = Brushes.OrangeRed;

                this.cardFinalMovementSpeed.Inlines.Add($"Final Movement Speed: ");
                this.cardFinalMovementSpeed.Inlines.Add(runMovementFinal);
                this.cardFinalMovementSpeed.Inlines.Add(runSpace);
                this.cardFinalMovementSpeed.Inlines.Add(runArrowDown1);
                this.cardFinalMovementSpeed.Inlines.Add(runSpace);
                this.cardFinalMovementSpeed.Inlines.Add($"({runMovementComp})%");
            }
            if (weapon.FinalMovementSpeed > resultMovementSpeedComp)
            {
                Run runMovementFinal = new Run(weapon.FinalMovementSpeed.ToString("#####0.#"));
                runMovementFinal.Foreground = Brushes.Lime;

                Run runMovementComp = new Run($"{resultMovementSpeedComp.ToString("#####0.#")}%");
                runMovementComp.FontFamily = new FontFamily("Fredoka Light");

                Run runArrowUp1 = new Run("🡅");
                runArrowUp1.Foreground = Brushes.Lime;

                this.cardFinalMovementSpeed.Inlines.Add($"Final Movement Speed: ");
                this.cardFinalMovementSpeed.Inlines.Add(runMovementFinal);
                this.cardFinalMovementSpeed.Inlines.Add(runSpace);
                this.cardFinalMovementSpeed.Inlines.Add(runArrowUp1);
                this.cardFinalMovementSpeed.Inlines.Add(runSpace);
                this.cardFinalMovementSpeed.Inlines.Add(runMovementComp);
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

            if (weapon.AmmoType == "Energy")
            {
                weapon.RecoilBase = 0.0;
            }
            if (weapon.AmmoType == "9mm")
            {
                weapon.RecoilBase = weapon.RecoilBase9mm;
            }
            if (weapon.AmmoType == "7.62mm")
            {
                weapon.RecoilBase = weapon.RecoilBase762;
            }
            if (weapon.AmmoType == "5.56mm")
            {
                weapon.RecoilBase = weapon.RecoilBase556;
            }
            if (weapon.AmmoType == ".50 BMG")
            {
                weapon.RecoilBase = weapon.RecoilBase50bmg;
            }
            if (weapon.AmmoType == "12Ga")
            {
                weapon.RecoilBase = weapon.RecoilBase12ga;
            }

            //// Recoil Add

            weapon.RecoilMult += oilModifierStats.RecoilAdd;

            //// Recoil Multiplier

            weapon.RecoilBase *= (weapon.RecoilMult * (1 + oilModifierStats.RecoilMult));

            if (weapon.RecoilBase < weaponOriginal.RecoilBase)
            {
                Run runRecoil = new Run($"{weapon.RecoilBase.ToString("#####0.#")}");
                runRecoil.Foreground = Brushes.Lime;

                Run runArrowDown = new Run("🡇");
                runArrowDown.Foreground = Brushes.Lime;

                Run runNoRecoil = new Run($"({weaponOriginal.RecoilBase.ToString("#####0.#")})");
                runNoRecoil.FontFamily = new FontFamily("Fredoka Light");

                this.cardRecoil.Inlines.Add("Recoil: ");
                this.cardRecoil.Inlines.Add(runRecoil);
                this.cardRecoil.Inlines.Add(runArrowDown);
                this.cardRecoil.Inlines.Add(runSpace);
                this.cardRecoil.Inlines.Add(runNoRecoil);
            }
            if (weapon.RecoilBase > weaponOriginal.RecoilBase)
            {
                Run runRecoil = new Run($"{weapon.RecoilBase.ToString("#####0.#")}");
                runRecoil.Foreground = Brushes.OrangeRed;

                Run runArrowUp = new Run("🡅");
                runArrowUp.Foreground = Brushes.OrangeRed;

                Run runNoRecoil = new Run($"({weaponOriginal.RecoilBase.ToString("#####0.#")})");
                runNoRecoil.FontFamily = new FontFamily("Fredoka Light");

                this.cardRecoil.Inlines.Add("Recoil: ");
                this.cardRecoil.Inlines.Add(runRecoil);
                this.cardRecoil.Inlines.Add(runArrowUp);
                this.cardRecoil.Inlines.Add(runSpace);
                this.cardRecoil.Inlines.Add(runNoRecoil);
            }
            if (weapon.RecoilBase == weaponOriginal.RecoilBase)
            {
                this.cardRecoil.Inlines.Add($"Recoil: {weapon.RecoilBase.ToString()}");
            }

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

                Run runArrowUp = new Run("🡅");
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
            weapon.Spread += attachmentStats.SpreadAdd;
            //// Spread Multiplier
            weapon.Spread *= (1 + oilModifierStats.SpreadMult);

            if (weapon.Spread < 0)
            {
                weapon.Spread = 0;
            }

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

            // Add image to card
            this.cardWeaponImage.Source = new BitmapImage(new Uri($".\\Images\\Guns\\Pistols\\{weapon.Name}.png", UriKind.Relative));
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