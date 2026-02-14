using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Data;
using System.Runtime.CompilerServices;

namespace SULFURBuildGenerator
{


    public class ScrollItem
    {
        public string Name { get; set; }
    }
    public class OilItem
    {
        public string Name { get; set; }

    }

    public class ViewModel : INotifyPropertyChanged
    {


        List<string> listComboBoxOils = new List<string> { "None",
    "Random - All",
    "Random - Ammo Consume Chance",
    "     Bulk Oil",
    "     Carefree Oil",
    "     Cheap Oil",
    "     Do-over Oil",
    "     Food Stamp Oil",
    "     Heavy Pockets Oil",
    "     Helium Oil",
    "     Keep Oil",
    "     Last Drop Oil",
    "     Mosquito Oil",
    "     Plop Back Oil",
    "     Recycle Oil",
    "     Satiety Oil",
    "     Saviour Oil",
    "     Walk Easy Oil",
    "     Whos Counting Oil",
    "Random - Base Crit Chance",
    "     Aimless Oil",
    "     Artery Oil",
    "     Axe Oil",
    "     Blindfold Oil",
    "     Confidence Oil",
    "     Critical Oil",
    "     Gambler Oil",
    "     Happy Accident Oil",
    "     Hunter Oil",
    "     Hustler Oil",
    "     Low Roller Oil",
    "     Manifestation Oil",
    "     No Need Oil",
    "     Out of the Box Oil",
    "     Puncture Oil",
    "     Slotmachine Oil",
    "     Smart Bullet Oil",
    "Random - Bullet Bounces",
    "     Arkanoid Oil",
    "     Bandit Oil",
    "     Cartoon Oil",
    "     Flea Oil",
    "     Hoop Oil",
    "     Imperfect Oil",
    "     Lazy Oil",
    "     Longshot Oil",
    "     Perfect Bounce Oil",
    "     Pool Oil",
    "     Rebound Oil",
    "     Ricochet Oil",
    "     Scramble Oil",
    "     Sherlock Oil",
    "     Skip Oil",
    "     Synchronicity Oil",
    "     Wobble Oil",
    "Random - Bullet Speed",
    "     Arrow Oil",
    "     Assassin Dart Oil",
    "     Dart Oil",
    "     Delayed Hyper Tube Oil",
    "     Diesel Oil",
    "     Extra Powder Oil",
    "     Fast Bet Oil",
    "     Instant Oil",
    "     Kinetic Oil",
    "     Micro Wing Oil",
    "     Tight Barrel Oil",
    "     Turbulence Oil",
    "     Velocity Oil",
    "     Whim Oil",
    "     Zooming Oil",
    "Random - Add Damage",
    "     Add Damage Oil",
    "     Ascetic Oil",
    "     Big Oil",
    "     Brute Oil",
    "     Discharge Oil",
    "     Disposable Oil",
    "     Expander Oil",
    "     Fidget Oil",
    "     Frugal Oil",
    "     Great Oil",
    "     Judgement Oil",
    "     Kicker Oil",
    "     Late Boom Oil",
    "     Potshot Oil",
    "     Seated Oil",
    "     Sender Oil",
    "     Solid Oil",
    "Random - % Damage",
    "     Boulder Oil",
    "     Complicated Oil",
    "     Damage Oil",
    "     Dum Dum Oil",
    "     First Blood Oil",
    "     Franciscan Oil",
    "     Glass Cannon Oil",
    "     Grounded Oil",
    "     Heavy Oil",
    "     Hip Blaster Oil",
    "     Hyper Lead Oil",
    "     Launcher Oil",
    "     Overclock Oil",
    "     Puncher Oil",
    "     Slow Punch Oil",
    "     Spartan Oil",
    "     Terminator Oil",
    "Random - Durability",
    "     Dense Oil",
    "     Detune Oil",
    "     Feature Gun Oil",
    "     Gentle Oil",
    "     Hefty Oil",
    "     High Grade Oil",
    "     Inherited Oil",
    "     Release Oil",
    "     Rigid System Oil",
    "     Robust Mechanics Oil",
    "     Rubber Oil",
    "     Seated Fit Oil",
    "     Sensible Oil",
    "     Slippy Coating Oil",
    "     Soft Bullet Oil",
    "     Stiffy Fit Oil",
    "     Trusty Old Oil",
    "Random - Penetration",
    "     Bad Planet Oil",
    "     Bystander Oil",
    "     Collateral Oil",
    "     Considerate Oil",
    "     Farsighted Oil",
    "     Heavy Lead Oil",
    "     Inconsiderate Oil",
    "     Jungian Oil",
    "     Needleye Oil",
    "     Overdose Oil",
    "     Penetration Oil",
    "     Rigor Oil",
    "     Sect Oil",
    "     Surgical Laser Oil",
    "     Too Much Oil",
    "     Untechnical Oil",
    "     Vasectomy Oil",
    "Random - Projectiles",
    "     Black Friday Oil",
    "     Bombard Oil",
    "     Boomstick Oil",
    "     Careless Splitter Oil",
    "     Division Oil",
    "     Double Nothing Oil",
    "     Elephant Oil",
    "     Gemini Oil",
    "     Matrix Oil",
    "     Multichamber Oil",
    "     Multishot Oil",
    "     Parallel Mag Oil",
    "     Scatter Oil",
    "     Shredder Oil",
    "     Suppressive Oil",
    "     Tandem Oil",
    "     Twice Oil",
    "     Two Time Oil",
    "Random - Recoil",
    "     Braced Oil",
    "     Casual Oil",
    "     Contained Force Oil",
    "     Easy Oil",
    "     Easy Plop Oil",
    "     Flow Funnel Oil",
    "     Less Recoil Oil",
    "     Modern Technology Oil",
    "     Peashooter Oil",
    "     Purse Gun Oil",
    "     Ready Oil",
    "     Relax Oil",
    "     Safety Oil",
    "     Stability Oil",
    "     Stable Hip Oil",
    "     Tension Oil",
    "     Vegetable Oil",
    "Random - Reload Speed",
    "     Action Oil",
    "     Airsoft Oil",
    "     Compo Oil",
    "     Cycle Oil",
    "     Double Lock Oil",
    "     Dynamic Oil",
    "     Gunslinger Oil",
    "     Fidget Lord Oil",
    "     Main Discipline Oil",
    "     Main Focus Oil",
    "     Nerf Oil",
    "     Reload Oil",
    "     Rush Job Oil",
    "     Shaved Clip Oil",
    "     Speed Trade Oil",
    "     Tactical Oil",
    "     Task Oil",
    "     Tech Support Oil",
    "Random - RPM",
    "     Attack Speed Oil",
    "     BB Oil",
    "     Blurt Oil",
    "     Bolt Oil",
    "     Double Fire Oil",
    "     Fragile System Oil",
    "     Lightweight Oil",
    "     Machine Oil",
    "     No Look Oil",
    "     Perforate Oil",
    "     Rapid Internals Oil",
    "     Rookie Oil",
    "     Shower Oil",
    "     Spitter Oil",
    "     Stationary Oil",
    "     Waster Oil",
    "     Zero Fucks Oil",
    "Random - Spread",
    "     Altruistic Oil",
    "     Artillery Oil",
    "     Bowl Oil",
    "     Careful Oil",
    "     Dead Center Oil",
    "     Exotic Barrel Oil",
    "     Hip Marksman Oil",
    "     Lost In Focus Oil",
    "     Plinker Oil",
    "     Shellman Oil",
    "     Slick Oil",
    "     Spread Oil",
    "     Stoic Oil",
    "     Thorough Oil",
    "     Vegan Oil",
};

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ScrollItem> Scrolls { get; set; }
            = new ObservableCollection<ScrollItem>();

        private ScrollItem selectedScroll;
        public ScrollItem SelectedScroll
        {
            get { return selectedScroll; }
            set
            {
                selectedScroll = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(SelectedScroll)));
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(IsOil5Enabled)));
            }
        }


        public ObservableCollection<OilItem> Oils1 { get; set; }

        public ObservableCollection<OilItem> Oils2 { get; set; }

        public ObservableCollection<OilItem> Oils3 { get; set; }

        public ObservableCollection<OilItem> Oils4 { get; set; }

        public ObservableCollection<OilItem> Oils5 { get; set; }



        private List<OilItem> _masterOilList;

        private void InitSourceCollection()
        {

            _masterOilList = new List<OilItem>();
            foreach (var oilName in listComboBoxOils)
            {
                _masterOilList.Add(new OilItem { Name = oilName });
            }

            Oils1 = new ObservableCollection<OilItem>(_masterOilList);
            Oils2 = new ObservableCollection<OilItem>(_masterOilList);
            Oils3 = new ObservableCollection<OilItem>(_masterOilList);
            Oils4 = new ObservableCollection<OilItem>(_masterOilList);
            Oils5 = new ObservableCollection<OilItem>(_masterOilList);
        }


        private OilItem _selectedOil1;
        public OilItem SelectedOil1
        {
            get
            {
                return _selectedOil1;
            }
            set
            {
                _selectedOil1 = value;
                var pc = PropertyChanged;
                UpdateList(Oils2, _selectedOil1, value);
                UpdateList(Oils3, _selectedOil1, value);
                UpdateList(Oils4, _selectedOil1, value);
                UpdateList(Oils5, _selectedOil1, value); 
                if (pc != null)
                {
                    _selectedOil1 = value;
                    pc(this, new PropertyChangedEventArgs("SelectedOil1"));
                }

            }
        }

        private OilItem _selectedOil2;
        public OilItem SelectedOil2
        {
            get
            {
                return _selectedOil2;
            }
            set
            {
                _selectedOil2 = value;
                var pc = PropertyChanged;
                UpdateList(Oils1, _selectedOil2, value);
                UpdateList(Oils3, _selectedOil2, value);
                UpdateList(Oils4, _selectedOil2, value);
                UpdateList(Oils5, _selectedOil2, value);
                if (pc != null)
                {
                    _selectedOil2 = value;
                    pc(this, new PropertyChangedEventArgs("SelectedOil2"));
                }
            }

        }

        private OilItem _selectedOil3;
        public OilItem SelectedOil3
        {
            get
            {
                return _selectedOil3;
            }
            set
            {
                _selectedOil3 = value;
                var pc = PropertyChanged;
                UpdateList(Oils1, _selectedOil3, value);
                UpdateList(Oils2, _selectedOil3, value);
                UpdateList(Oils4, _selectedOil3, value);
                UpdateList(Oils5, _selectedOil3, value);
                if (pc != null)
                {
                    _selectedOil3 = value;
                    pc(this, new PropertyChangedEventArgs("SelectedOil3"));
                }
            }

        }

        private OilItem _selectedOil4;
        public OilItem SelectedOil4
        {
            get
            {
                return _selectedOil4;
            }
            set
            {
                _selectedOil4 = value;
                var pc = PropertyChanged;
                UpdateList(Oils1, _selectedOil4, value);
                UpdateList(Oils2, _selectedOil4, value);
                UpdateList(Oils3, _selectedOil4, value);
                UpdateList(Oils5, _selectedOil4, value);
                if (pc != null)
                {
                    _selectedOil4 = value;
                    pc(this, new PropertyChangedEventArgs("SelectedOil4"));
                }
            }

        }

        private OilItem _selectedOil5;
        public OilItem SelectedOil5
        {
            get
            {
                return _selectedOil5;
            }
            set
            {
                _selectedOil5 = value;
                var pc = PropertyChanged;
                UpdateList(Oils1, _selectedOil5, value);
                UpdateList(Oils2, _selectedOil5, value);
                UpdateList(Oils3, _selectedOil5, value);
                UpdateList(Oils4, _selectedOil5, value);

                if (pc != null)
                {
                    _selectedOil5 = value;
                    pc(this, new PropertyChangedEventArgs("SelectedOil5"));
                }
            }

        }


        private void UpdateList(ObservableCollection<OilItem> targetList, OilItem oldItem, OilItem newItem)
        {
            if (newItem.Name != "None" && newItem.Name != "Random - All" && newItem.Name != "Random - Combos" && newItem.Name != "Random - Ammo Consume Chance" && newItem.Name != "Random - Base Crit Chance" && newItem.Name != "Random - Bullet Bounces" && newItem.Name != "Random - Bullet Speed" && newItem.Name != "Random - Add Damage" && newItem.Name != "Random - % Damage" && newItem.Name != "Random - Durability" && newItem.Name != "Random - Penetration" && newItem.Name != "Random - Projectiles" && newItem.Name != "Random - Recoil" && newItem.Name != "Random - Reload Speed" && newItem.Name != "Random - RPM" && newItem.Name != "Random - Spread")
            {
                if (oldItem != null && !targetList.Contains(oldItem))
                {
                    int originalIndex = _masterOilList.IndexOf(oldItem);

                    int insertIndex = 0;
                    foreach (var item in targetList)
                    {
                        if (_masterOilList.IndexOf(item) > originalIndex) break;
                        insertIndex++;
                    }

                    targetList.Insert(insertIndex, oldItem);
                }

                if (newItem != null && targetList.Contains(newItem))
                {
                    targetList.Remove(newItem);
                }
            }
        }
        public bool IsOil5Enabled =>
        SelectedScroll != null &&
        SelectedScroll.Name == "None";

        // public List<string> SelectedItems { get; set; } = new List<string>();

        public ViewModel()
        {

            InitSourceCollection();

            SelectedOil1 = Oils1.FirstOrDefault();
            SelectedOil2 = Oils2.FirstOrDefault();
            SelectedOil3 = Oils3.FirstOrDefault();
            SelectedOil4 = Oils4.FirstOrDefault();
            SelectedOil5 = Oils5.FirstOrDefault();

        }
    }


}
