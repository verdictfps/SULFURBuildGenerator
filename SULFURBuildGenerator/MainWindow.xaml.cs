using System;
using System.Data.Common;
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
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

namespace SULFURBuildGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
            Random randomGunInt = new Random();
            int randomGunNumber = randomGunInt.Next(0, totalGuns.Count);
            randomGun = totalGuns[randomGunNumber];
            this.build_box.Items.Add(new MyItem { Item = "Gun", Selection = randomGun });

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