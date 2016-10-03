using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Drawing;

namespace LegionAlchemyCalculator {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private ContextMenuStrip classes = new ContextMenuStrip();

        private static SortedDictionary<String, Enum> raidGroup = new SortedDictionary<String, Enum>();
        private static System.Windows.Controls.Button lastClicked;

        enum Specs {
            BloodDeathKnight, FrostDeathKnight, UnholyDeathKnight, HavocDemonHunter, VengeanceDemonHunter, BalanceDruid, FeralDruid, GuardianDruid, RestorationDruid,
            BeastMasteryHunter, MarksmanshipHunter, SurvivalHunter, ArcaneMage, FireMage, FrostMage, BrewmasterMonk, MistweaverMonk, WindwalkerMonk, HolyPaladin, ProtectionPaladin,
            RetributionPaladin, DisciplinePriest, HolyPriest, ShadowPriest, AssassinationRogue, OutlawRogue, SubtletyRogue, ElementalShaman, EnhancementShaman, RestorationShaman,
            AfflictionWarlock, DemonologyWarlock, DestructionWarlock, ArmsWarrior, FuryWarrior, ProtectionWarrior
        }

        /* Class Colors */
        System.Windows.Media.Color emptyColor = System.Windows.Media.Color.FromArgb(255, 54, 54, 54);
        System.Windows.Media.Color deathKnightColor = System.Windows.Media.Color.FromArgb(255, 196, 30, 59);
        System.Windows.Media.Color demonHunterColor = System.Windows.Media.Color.FromArgb(255, 163, 48, 201);
        System.Windows.Media.Color druidColor = System.Windows.Media.Color.FromArgb(255, 255, 125, 10);
        System.Windows.Media.Color hunterColor = System.Windows.Media.Color.FromArgb(255, 171, 212, 115);
        System.Windows.Media.Color mageColor = System.Windows.Media.Color.FromArgb(255, 105, 204, 240);
        System.Windows.Media.Color monkColor = System.Windows.Media.Color.FromArgb(255, 0, 255, 150);
        System.Windows.Media.Color paladinColor = System.Windows.Media.Color.FromArgb(255, 245, 140, 186);
        System.Windows.Media.Color priestColor = System.Windows.Media.Color.FromArgb(255, 255, 255, 255);
        System.Windows.Media.Color rogueColor = System.Windows.Media.Color.FromArgb(255, 255, 245, 105);
        System.Windows.Media.Color shamanColor = System.Windows.Media.Color.FromArgb(255, 0, 112, 222);
        System.Windows.Media.Color warlockColor = System.Windows.Media.Color.FromArgb(255, 148, 130, 201);
        System.Windows.Media.Color warriorColor = System.Windows.Media.Color.FromArgb(255, 199, 156, 110);




        public MainWindow() {
            InitializeComponent();
            BuildMenu();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            lastClicked = sender as System.Windows.Controls.Button;
            System.Drawing.Point cursor = new System.Drawing.Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
            classes.Show(cursor);
        }


        ContextMenuStrip BuildMenu() {
            ToolStripMenuItem parent = new ToolStripMenuItem();
            ToolStripMenuItem item = new ToolStripMenuItem();
            /* Empty Slot */
            parent.Text = "Empty";
            parent.Click += classClick;
            classes.Items.Add(parent);

            /* Death Knight */
            parent = new ToolStripMenuItem();
            parent.Text = "Death Knight";
            item = new ToolStripMenuItem();
            item.Text = "Blood";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Frost";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Unholy";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            classes.Items.Add(parent);

            /* Demon Hunter */
            parent = new ToolStripMenuItem();
            parent.Text = "Demon Hunter";
            item = new ToolStripMenuItem();
            item.Text = "Havoc";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Vengeance";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            classes.Items.Add(parent);

            /* Druid */
            parent = new ToolStripMenuItem();
            parent.Text = "Druid";
            item = new ToolStripMenuItem();
            item.Text = "Balance";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Feral";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Guardian";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Restoration";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            classes.Items.Add(parent);

            /* Hunter */
            parent = new ToolStripMenuItem();
            parent.Text = "Hunter";
            item = new ToolStripMenuItem();
            item.Text = "Beast Mastery";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Marksmanship";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Survival";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            classes.Items.Add(parent);

            /* Mage */
            parent = new ToolStripMenuItem();
            parent.Text = "Mage";
            item = new ToolStripMenuItem();
            item.Text = "Arcane";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Fire";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Frost";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            classes.Items.Add(parent);

            /* Monk */
            parent = new ToolStripMenuItem();
            parent.Text = "Monk";
            item = new ToolStripMenuItem();
            item.Text = "Brewmaster";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Mistweaver";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Windwalker";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            classes.Items.Add(parent);

            /* Paladin */
            parent = new ToolStripMenuItem();
            parent.Text = "Paladin";
            item = new ToolStripMenuItem();
            item.Text = "Holy";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Protection";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Retribution";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            classes.Items.Add(parent);

            /* Priest */
            parent = new ToolStripMenuItem();
            parent.Text = "Priest";
            item = new ToolStripMenuItem();
            item.Text = "Discipline";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Holy";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Shadow";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            classes.Items.Add(parent);

            /* Rogue */
            parent = new ToolStripMenuItem();
            parent.Text = "Rogue";
            item = new ToolStripMenuItem();
            item.Text = "Assassination";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Outlaw";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Subtlety";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            classes.Items.Add(parent);

            /* Shaman */
            parent = new ToolStripMenuItem();
            parent.Text = "Shaman";
            item = new ToolStripMenuItem();
            item.Text = "Elemental";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Enhancement";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Restoration";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            classes.Items.Add(parent);

            /* Warlock */
            parent = new ToolStripMenuItem();
            parent.Text = "Warlock";
            item = new ToolStripMenuItem();
            item.Text = "Affliction";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Demonology";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Destruction";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            classes.Items.Add(parent);

            /* Warrior */
            parent = new ToolStripMenuItem();
            parent.Text = "Warrior";
            item = new ToolStripMenuItem();
            item.Text = "Arms";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Fury";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Protection";
            item.Click += classClick;
            parent.DropDownItems.Add(item);
            classes.Items.Add(parent);

            return classes;

        }

        void classClick(object sender, EventArgs e) {
            ToolStripMenuItem source = (ToolStripMenuItem)sender;
            lastClicked.Content = source.Text;
            if (raidGroup.ContainsKey(lastClicked.Name)) raidGroup.Remove(lastClicked.Name);
            if (source.Text == "Empty") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(emptyColor);
                raidGroup.Remove(lastClicked.Name);
                updateValues();
            } else if (source.OwnerItem.Text == "Death Knight") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(deathKnightColor);
                if (source.Text == "Blood") {
                    raidGroup.Add(lastClicked.Name, Specs.BloodDeathKnight);
                } else if (source.Text == "Frost") {
                    raidGroup.Add(lastClicked.Name, Specs.FrostDeathKnight);
                } else if (source.Text == "Unholy") {
                    raidGroup.Add(lastClicked.Name, Specs.UnholyDeathKnight);
                }
                updateValues();
            } else if (source.OwnerItem.Text == "Demon Hunter") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(demonHunterColor);
                if (source.Text == "Havoc") {
                    raidGroup.Add(lastClicked.Name, Specs.HavocDemonHunter);
                } else if (source.Text == "Vengeance") {
                    raidGroup.Add(lastClicked.Name, Specs.VengeanceDemonHunter);
                }
                updateValues();
            } else if (source.OwnerItem.Text == "Druid") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(druidColor);
                if (source.Text == "Balance") {
                    raidGroup.Add(lastClicked.Name, Specs.BalanceDruid);
                } else if (source.Text == "Feral") {
                    raidGroup.Add(lastClicked.Name, Specs.FeralDruid);
                } else if (source.Text == "Guardian") {
                    raidGroup.Add(lastClicked.Name, Specs.GuardianDruid);
                } else if (source.Text == "Restoration") {
                    raidGroup.Add(lastClicked.Name, Specs.RestorationDruid);
                }
                updateValues();
            } else if (source.OwnerItem.Text == "Hunter") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(hunterColor);
                if (source.Text == "Beast Mastery") {
                    raidGroup.Add(lastClicked.Name, Specs.BeastMasteryHunter);
                } else if (source.Text == "Marksmanship") {
                    raidGroup.Add(lastClicked.Name, Specs.MarksmanshipHunter);
                } else if (source.Text == "Survival") {
                    raidGroup.Add(lastClicked.Name, Specs.SurvivalHunter);
                }
                updateValues();
            } else if (source.OwnerItem.Text == "Mage") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(mageColor);
                if (source.Text == "Arcane") {
                    raidGroup.Add(lastClicked.Name, Specs.ArcaneMage);
                } else if (source.Text == "Fire") {
                    raidGroup.Add(lastClicked.Name, Specs.FireMage);
                } else if (source.Text == "Frost") {
                    raidGroup.Add(lastClicked.Name, Specs.FrostMage);
                }
                updateValues();
            } else if (source.OwnerItem.Text == "Monk") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(monkColor);
                if (source.Text == "Brewmaster") {
                    raidGroup.Add(lastClicked.Name, Specs.BrewmasterMonk);
                } else if (source.Text == "Mistweaver") {
                    raidGroup.Add(lastClicked.Name, Specs.MistweaverMonk);
                } else if (source.Text == "Windwalker") {
                    raidGroup.Add(lastClicked.Name, Specs.WindwalkerMonk);
                }
                updateValues();
            } else if (source.OwnerItem.Text == "Paladin") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(paladinColor);
                if (source.Text == "Holy") {
                    raidGroup.Add(lastClicked.Name, Specs.HolyPaladin);
                } else if (source.Text == "Protection") {
                    raidGroup.Add(lastClicked.Name, Specs.ProtectionPaladin);
                } else if (source.Text == "Retribution") {
                    raidGroup.Add(lastClicked.Name, Specs.RetributionPaladin);
                }
                updateValues();
            } else if (source.OwnerItem.Text == "Priest") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(priestColor);
                if (source.Text == "Discipline") {
                    raidGroup.Add(lastClicked.Name, Specs.DisciplinePriest);
                } else if (source.Text == "Holy") {
                    raidGroup.Add(lastClicked.Name, Specs.HolyPriest);
                } else if (source.Text == "Shadow") {
                    raidGroup.Add(lastClicked.Name, Specs.ShadowPriest);
                }
                updateValues();
            } else if (source.OwnerItem.Text == "Rogue") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(rogueColor);
                if (source.Text == "Assassination") {
                    raidGroup.Add(lastClicked.Name, Specs.AssassinationRogue);
                } else if (source.Text == "Outlaw") {
                    raidGroup.Add(lastClicked.Name, Specs.OutlawRogue);
                } else if (source.Text == "Subtlety") {
                    raidGroup.Add(lastClicked.Name, Specs.SubtletyRogue);
                }
                updateValues();
            } else if (source.OwnerItem.Text == "Shaman") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(shamanColor);
                if (source.Text == "Elemental") {
                    raidGroup.Add(lastClicked.Name, Specs.ElementalShaman);
                } else if (source.Text == "Enhancement") {
                    raidGroup.Add(lastClicked.Name, Specs.EnhancementShaman);
                } else if (source.Text == "Restoration") {
                    raidGroup.Add(lastClicked.Name, Specs.RestorationShaman);
                }
                updateValues();
            } else if (source.OwnerItem.Text == "Warlock") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(warlockColor);
                if (source.Text == "Affliction") {
                    raidGroup.Add(lastClicked.Name, Specs.AfflictionWarlock);
                } else if (source.Text == "Demonology") {
                    raidGroup.Add(lastClicked.Name, Specs.DemonologyWarlock);
                } else if (source.Text == "Destruction") {
                    raidGroup.Add(lastClicked.Name, Specs.DestructionWarlock);
                }
                updateValues();
            } else if (source.OwnerItem.Text == "Warrior") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(warriorColor);
                if (source.Text == "Arms") {
                    raidGroup.Add(lastClicked.Name, Specs.ArmsWarrior);
                } else if (source.Text == "Fury") {
                    raidGroup.Add(lastClicked.Name, Specs.FuryWarrior);
                } else if (source.Text == "Protection") {
                    raidGroup.Add(lastClicked.Name, Specs.ProtectionWarrior);
                }
                updateValues();
            }
        }

        void updateValues() {
            SortedDictionary<String, int> potions = new SortedDictionary<String, int>();
            potions.Add("agiFlask", 0);
            potions.Add("intFlask", 0);
            potions.Add("strFlask", 0);
            potions.Add("stamFlask", 0);
            potions.Add("tankPot", 0);
            potions.Add("healPot", 0);
            potions.Add("rangedPot", 0);
            potions.Add("meleePot", 0);

            //Stam flask and tank pot
            Specs[] tanks = { Specs.BloodDeathKnight, Specs.VengeanceDemonHunter, Specs.GuardianDruid, Specs.BrewmasterMonk, Specs.ProtectionPaladin, Specs.ProtectionWarrior };
            //Int flask and healer pot
            Specs[] healers = {Specs.RestorationDruid, Specs.MistweaverMonk, Specs.HolyPaladin, Specs.DisciplinePriest, Specs.HolyPriest, Specs.RestorationShaman};
            //Agi flask and melee pot
            Specs[] agiDPS = { Specs.HavocDemonHunter, Specs.FeralDruid, Specs.WindwalkerMonk, Specs.AssassinationRogue, Specs.OutlawRogue, Specs.SubtletyRogue, Specs.EnhancementShaman };
            //Str flask and melee pot
            Specs[] strDPS = { Specs.FrostDeathKnight, Specs.UnholyDeathKnight, Specs.RetributionPaladin, Specs.ArmsWarrior, Specs.FuryWarrior };
            //Int flask and ranged pot
            Specs[] intDPS = { Specs.BalanceDruid, Specs.ArcaneMage, Specs.FireMage, Specs.FrostMage, Specs.ShadowPriest, Specs.ElementalShaman, Specs.AfflictionWarlock, Specs.DemonologyWarlock, Specs.DestructionWarlock };
            //Agi flask and ranged pot
            Specs[] hunters = {Specs.BeastMasteryHunter, Specs.MarksmanshipHunter, Specs.SurvivalHunter};

            foreach (Specs spec in raidGroup.Values) {
                if (tanks.Contains(spec)) {
                    potions["stamFlask"] += 1;
                    potions["tankPot"] += 1;
                } else if (healers.Contains(spec)) {
                    potions["intFlask"] += 1;
                    potions["healPot"] += 1;
                } else if (agiDPS.Contains(spec)) {
                    potions["agiFlask"] += 1;
                    potions["meleePot"] += 1;
                } else if (strDPS.Contains(spec)) {
                    potions["strFlask"] += 1;
                    potions["meleePot"] += 1;
                } else if (intDPS.Contains(spec)) {
                    potions["intFlask"] += 1;
                    potions["rangedPot"] += 1;
                } else if (hunters.Contains(spec)) {
                    potions["agiFlask"] += 1;
                    potions["rangedPot"] += 1;
                }
            }

            // Multiply the potion numbers by usage
            potions["stamFlask"] *= (int)raidLength.Value;
            potions["intFlask"] *= (int)raidLength.Value;
            potions["agiFlask"] *= (int)raidLength.Value;
            potions["strFlask"] *= (int)raidLength.Value;
            if (pullCount != null) {
                potions["tankPot"] *= (2 * (int)pullCount.Value);
                potions["healPot"] *= (2 * (int)pullCount.Value);
                potions["rangedPot"] *= (2 * (int)pullCount.Value);
                potions["meleePot"] *= (2 * (int)pullCount.Value);
            }

            Console.WriteLine("Tank: " + potions["tankPot"] + " Heal: " + potions["healPot"] + " Ranged: " + potions["rangedPot"] + " Melee: " + potions["meleePot"]);

            //Update herb values
            int aethril = 0;
            int dreamleaf = 0;
            int foxflower = 0;
            int fjarnskaggl = 0;
            int starlightRose = 0;
            //Stam Flask
            aethril += (potions["stamFlask"] * 10);
            dreamleaf += (potions["stamFlask"] * 10);
            starlightRose += (potions["stamFlask"] * 7);
            //Str Flask
            aethril += (potions["strFlask"] * 10);
            foxflower += (potions["strFlask"] * 10);
            starlightRose += (potions["strFlask"] * 7);
            //Int Flask
            dreamleaf += (potions["intFlask"] * 10);
            fjarnskaggl += (potions["intFlask"] * 10);
            starlightRose += (potions["intFlask"] * 7);
            //Agi Flask
            fjarnskaggl += (potions["agiFlask"] * 10);
            foxflower += (potions["agiFlask"] * 10);
            starlightRose += (potions["agiFlask"] * 7);
            //Tank Pot
            aethril += (potions["tankPot"] * 4);
            foxflower += (potions["tankPot"] * 4);
            starlightRose += (potions["tankPot"] * 2);
            //Heal Pot
            aethril += (potions["healPot"] * 4);
            dreamleaf += (potions["healPot"] * 4);
            starlightRose += (potions["healPot"] * 2);
            //Ranged Pot
            dreamleaf += (potions["rangedPot"] * 4);
            fjarnskaggl += (potions["rangedPot"] * 4);
            starlightRose += (potions["rangedPot"] * 2);
            //Melee Pot
            fjarnskaggl += (potions["meleePot"] * 4);
            foxflower += (potions["meleePot"] * 4);
            starlightRose += (potions["meleePot"] * 2);

            //update the labels
            AethrilCount.Content = aethril;
            DreamleafCount.Content = dreamleaf;
            FoxflowerCount.Content = foxflower;
            FjarnskagglCount.Content = fjarnskaggl;
            StarlightRoseCount.Content = starlightRose;

        }

        private void Clear_Button(object sender, RoutedEventArgs e) {
            foreach (System.Windows.Controls.Button but in Raid.Children){
                but.Content = "Empty";
                if (raidGroup.ContainsKey(but.Name)) raidGroup.Remove(but.Name);
                but.Background = new System.Windows.Media.SolidColorBrush(emptyColor);
                updateValues();
            }
        }

        private void Num_Changed(object sender, RoutedPropertyChangedEventArgs<object> e) {
            updateValues();
        }

    }
}
