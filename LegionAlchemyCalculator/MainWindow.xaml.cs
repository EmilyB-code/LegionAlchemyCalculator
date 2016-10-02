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

        private static SortedDictionary<String, Enum> raidGroup;
        private static System.Windows.Controls.Button lastClicked;

        enum Specs {
            BloodDeathKnight, FrostDeathKnight, UnholyDeathKnight, HavocDemonHunter, VengeanceDemonHunter, BalanceDruid, FeralDruid, GuardianDruid, RestorationDruid,
            BeastMasteryHunter, MarksmanshipHunter, SurvivalHunter, ArcaneMage, FireMage, FrostMage, BrewmasterMonk, MistweaverMonk, WindwalkerMonk, HolyPaladin, ProtectionPaladin,
            RetributionPaladin, DisciplinePriest, HolyPriest, ShadowPriest, AssassinationRogue, OutlawRogue, SubtletyRogue, ElementalShaman, EnhancementShaman, RestorationShaman,
            AfflictionWarlock, DemonologyWarlock, DestructionWarlock
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

            /* Hunter */
            parent = new ToolStripMenuItem();
            parent.Text = "Hunter";
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

            return classes;

        }

        void classClick(object sender, EventArgs e) {
            ToolStripMenuItem source = (ToolStripMenuItem)sender;
            lastClicked.Content = source.Text;
            if (source.Text == "Empty") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(emptyColor);
            } else if (source.OwnerItem.Text == "Death Knight") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(deathKnightColor);
                if (source.Text == "Blood") {
                    raidGroup.Add(lastClicked.Name, Specs.BloodDeathKnight);
}
            } else if (source.OwnerItem.Text == "Demon Hunter") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(demonHunterColor);
            } else if (source.OwnerItem.Text == "Druid") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(druidColor);
            } else if (source.OwnerItem.Text == "Hunter") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(hunterColor);
            } else if (source.OwnerItem.Text == "Mage") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(mageColor);
            } else if (source.OwnerItem.Text == "Monk") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(monkColor);
            } else if (source.OwnerItem.Text == "Paladin") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(paladinColor);
            } else if (source.OwnerItem.Text == "Priest") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(priestColor);
            } else if (source.OwnerItem.Text == "Rogue") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(rogueColor);
            } else if (source.OwnerItem.Text == "Shaman") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(shamanColor);
            } else if (source.OwnerItem.Text == "Warlock") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(warlockColor);
            } else if (source.OwnerItem.Text == "Warrior") {
                lastClicked.Background = new System.Windows.Media.SolidColorBrush(warriorColor);
            }
        }
    }
}
