using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wingman.Properties;

namespace Wingman
{
    public partial class Main : Form
    {
        // --------------------------------------------------------
        private int maxAmmo = 6;
        private bool isVictory = false;

        private int currentAmmo = 6;
        private int currentKill = 0;
        private int currentDamage = 0;
        private int currentPlayer = 60;
        private int currentSquad = 20;
        private int currentShot = 0;

        private bool emprtyToRed = false;
        private Random rnd = new Random();
        private string[] players =
        {
            "Wraith",
            "Lifeline",
            "Horizon",
            "Wattson",
            "Bloodhound",
            "Valkyrie",
            "Octane",
            "Gibraltar",
            "Bangalore",
            "Mirage",
            "Loba",
            "Caustic",
            "Pathfinder",
            "Crypto",
            "Revenant",
            "Fuse",
            "Rempart"
        };
        // --------------------------------------------------------



        // --------------------------------------------------------
        public Main()
        {
            InitializeComponent();

            // Affiche la version
            this.Text += " [3.0.0.0]";

            // Choisi le fond ecran
            this.comboBoxWallpaper.SelectedIndex = 1;

            // Met en transparent
            parent(this.pictureBoxCharm, this.pictureBoxGun, 575, 25);
            parent(this.pictureBoxReload, this.pictureBoxGun, 565, 165);
            parent(this.pictureBoxShot, this.pictureBoxGun, 480, 230);
            parent(this.labelCraft, this.pictureBoxKill, 68, 13);
            parent(this.labelSquadLeft, this.pictureBoxKill, 147, 13);
            parent(this.labelPlayerLeft, this.pictureBoxKill, 403, 13);
            parent(this.labelKill, this.pictureBoxKill, 210, 71);
            parent(this.labelDamage, this.pictureBoxKill, 363, 71);

            // Change le curseur
            byte[] buffer = Resources.cursor;
            using (MemoryStream m = new MemoryStream(buffer)) this.Cursor = new Cursor(m);

            // Random craft
            int craft = 0;
            do craft = this.rnd.Next(5, 95);
            while (craft % 5 != 0);
            this.labelCraft.Text = craft.ToString();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Sauvegarde le score
            string file = "Wingman history.txt";
            if (!File.Exists(file))
            {
                try
                {
                    File.WriteAllText(file, @"
###################################################################################################################
#                                     ____                                                                        #
#                                     \   \                                                                       #
#                               ____   \   \    ____                                                              #
#                               \   \   \   \   \   \                                                             #
#                                \   \   \   \   \   \                                                            #
#                        _________\___\___\___\___\___\______________________                                     #
#                       \        __   __ ___   _   _     _    ___  ___      \                                     #
#                        \       \ \ / // _ \ | | | |   /_\  | _ \| __|      \                                    #
#                         \       \ V /| (_) || |_| |  / _ \ |   /| _|        \                                   #
#                          \       |_|  \___/  \___/  /_/ \_\|_|_\|___|        \                                  #
#                   ________\___________________________________________________\________                         #
#           ________\        _____  _    _            __  __  _____  _____  ____   _   _ \_________               #
#           \        \      / ____|| |  | |    /\    |  \/  ||  __ \|_   _|/ __ \ | \ | | \        \              #
#            \        \    | |     | |__| |   /  \   | \  / || |__) | | | | |  | ||  \| |  \        \             #
#             \        \   | |     |  __  |  / /\ \  | |\/| ||  ___/  | | | |  | || . ` |   \        \            #
#              \        \  | |____ | |  | | / ____ \ | |  | || |     _| |_| |__| || |\  |    \        \           #
#               \________\  \_____||_|  |_|/_/    \_\|_|  |_||_|    |_____|\____/ |_| \_|     \________\          #
#                         \____________________________________________________________________\                  #
#                                               \   \   \   \   \   \                                             #
#                                                \   \   \   \   \   \                                            #
#                                                 \___\   \   \   \___\                                           #
#                                                          \___\                                                  #
#                                                                                                                 #
###################################################################################################################
#                                                                                                                 #
#                                      ~* Apex Legends Wingman simulator *~                                       #
#                                ~* Made by Thibault BUSTOS (alias TheRake6666) *~                                #
#                                                                                                                 #
###################################################################################################################
#            #            #            #             #              #                #                #           #
#   Result   #    Date    #    Hour    # Squads left # Players left # Number of kill # Number of shot #  Damages  #
#            #            #            #             #              #                #                #           #
###################################################################################################################");
                } catch { }
            }

            string victory = completestr(this.isVictory ? "Victory" : "Defeat", 10);
            string date = completestr(DateTime.Now.ToString("M/d/yyyy"), 10);
            string hour = completestr(DateTime.Now.ToString("HH:mm:ss"), 10);
            string squad = completestr(this.currentSquad.ToString(), 11);
            string player = completestr(this.currentPlayer.ToString(), 12);
            string kill = completestr(this.currentKill.ToString(), 14);
            string shot = completestr(this.currentShot.ToString(), 14);
            string damage = completestr(this.currentDamage.ToString(), 9);

            try
            {
                File.AppendAllText(file, @"
#            #            #            #             #              #                #                #           #
# " + victory + @" # " + date + @" # " + hour + @" # " + squad + @" # " + player + @" # " + kill + @" # " + shot + @" # " + damage + @" #
#            #            #            #             #              #                #                #           #
###################################################################################################################");
            } catch { }
        }
        // --------------------------------------------------------




        // --------------------------------------------------------
        private void checkBoxCharm_CheckedChanged(object sender, EventArgs e)
        {
            // Affiche le charm
            if (this.checkBoxCharm.Checked)
            {
                this.pictureBoxCharm.Show();
                play(Resources.select);
            }
            else
            {
                this.pictureBoxCharm.Hide();
                play(Resources.click);
            }
        }

        private void checkBoxBigmag_CheckedChanged(object sender, EventArgs e)
        {
            play(Resources.click);
            // Change chargeur
            this.maxAmmo = this.checkBoxBigmag.Checked ? 9 : 6;
        }

        private void checkBoxFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            play(Resources.click);
            // Met en plein ecran ou pas
            Rectangle screen = Screen.PrimaryScreen.Bounds;
            if (this.checkBoxFullscreen.Checked)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Size = new Size(screen.Width, screen.Height);
                this.Location = new Point(0, 0);
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.Size = this.MinimumSize;
                this.Location = new Point(screen.Width / 2 - this.Width / 2, 
                    screen.Height / 2 - this.Height / 2);
            }
        }

        private void comboBoxWallpaper_SelectedIndexChanged(object sender, EventArgs e)
        {
            play(Resources.select);
            /*
            Only color
            Kings canyon
            Olympus
            World's Edge
            */
            switch (this.comboBoxWallpaper.SelectedIndex)
            {
                case 0:
                    this.BackgroundImage = null;
                    break;

                case 1:
                    this.BackgroundImage = Resources.kingskanyon;
                    break;

                case 2:
                    this.BackgroundImage = Resources.olympus;
                    break;

                case 3:
                    this.BackgroundImage = Resources.wordlsedge;
                    break;
            }
        }

        private void controlClick_CheckedChanged(object sender, EventArgs e)
        {
            // Son du click
            play(Resources.click);
        }

        private void control_MouseHover(object sender, EventArgs e)
        {
            // Son hover
            play(Resources.hover);
        }
        // --------------------------------------------------------



        // --------------------------------------------------------
        private void pictureBoxShot_Click(object sender, EventArgs e)
        {
            // Appui gachette
            if (this.currentAmmo > 0) shot();
            else if (this.checkBoxReload.Checked) reload();
            else play(Resources.empty);
        }

        private void pictureBoxReload_Click(object sender, EventArgs e)
        {
            // Appui recharge
            if (this.currentAmmo < this.maxAmmo) reload();
        }

        private void pictureBoxAmmo_MouseClick(object sender, MouseEventArgs e)
        {
            // Joue le son here
            if (e.Button == MouseButtons.Middle) play(Resources.here);
        }
        // --------------------------------------------------------



        // --------------------------------------------------------
        private void reload()
        {
            // Joue le bruit
            playSync(Resources.reload);

            // Remet au max
            this.currentAmmo = this.maxAmmo;
            this.labelAmmo.Text = this.currentAmmo.ToString();

            // Remet le compteur blanc
            this.timerEmpty.Stop();
            this.labelAmmo.ForeColor = Color.White;
        }

        private void shot()
        {
            // Joue le tire
            play(this.currentAmmo > 1 ? Resources.shot : Resources.last);

            // Compte les tirs
            this.currentShot++;

            // Retire une balle
            this.currentAmmo--;
            this.labelAmmo.Text = this.currentAmmo.ToString();

            // Si plus de balle
            if (this.currentAmmo == 0) this.timerEmpty.Start();

            // Affiche le flash
            this.pictureBoxFlash.Show();
            this.timerFlash.Start();

            // Touche
            hit();
        }

        private void hit()
        {
            // Proba de kill
            if (proba())
            {
                // Joue le bruit down
                play(Resources.down);

                // Defini les degats
                int damage = proba() ? 90 : 45;

                // Down ennemi
                down(damage);

                // Met a jour les compteurs
                counter(damage);
            }
        }

        private void counter(int damage)
        {
            // Retire un joueur
            this.currentPlayer--;
            this.labelPlayerLeft.Text = this.currentPlayer > 10 ? this.currentPlayer.ToString() : "?";

            // Retire une squad
            if (this.currentPlayer % 3 == 0)
            {
                // Last squad
                this.currentSquad--;
                this.labelSquadLeft.Text = this.currentSquad.ToString();
                play(Resources.squad);
            }

            // Ajoute un kill
            this.currentKill++;
            this.labelKill.Text = this.currentKill.ToString();

            // Ajoute les damages
            this.currentDamage += damage;
            this.labelDamage.Text = this.currentDamage.ToString();

            // Victoire ou pas
            if (this.currentSquad == 1) victory();
        }

        private void down(int damage)
        {
            // Change les damages inglige
            this.labelDamageInflic.Text = damage.ToString();

            // Change la legende
            this.labelPlayer.Text = this.players[rnd.Next(this.players.Length)].ToUpper();

            // Replace le pannel down
            this.panelDown.Location = new Point(
                this.Size.Width / 2 - this.panelDown.Size.Width / 2,
                this.Height / 4 * 3
                );

            // Affiche le pannel down
            this.panelDown.Show();
            this.timerDown.Start();
        }

        private void victory()
        {
            // Victory !!!
            this.isVictory = true;
            this.panelVictoryTop.Show();
            this.pictureBoxVictory.Show();
            this.panelVictoryBot.Show();
            play(Resources.victory);
        }
        // --------------------------------------------------------



        // --------------------------------------------------------
        private void play(UnmanagedMemoryStream ressource)
        {
            // Joue async
            using (SoundPlayer snd = new SoundPlayer(ressource)) snd.Play();
        }

        private void playSync(UnmanagedMemoryStream ressource)
        {
            // Joue sync
            using (SoundPlayer snd = new SoundPlayer(ressource)) snd.PlaySync();
        }
        // --------------------------------------------------------



        // --------------------------------------------------------
        private bool proba()
        {
            return this.rnd.Next(5) == this.rnd.Next(5);
        }

        private void parent(Control elem, Control parent, int x, int y)
        {
            // Place sur parent
            elem.Parent = parent;
            elem.Location = new Point(x, y);
        }

        private string completestr(string str, int max)
        {
            while (true)
            {
                if (str.Length < max) str += " ";
                else break;
                if (str.Length < max) str = " " + str;
                else break;
            }
            return str;
        }
        // --------------------------------------------------------



        // --------------------------------------------------------
        private void timerEmpty_Tick(object sender, EventArgs e)
        {
            // Passe de rouge à blanc
            this.emprtyToRed = !this.emprtyToRed;
            if (this.emprtyToRed)
            {
                for (int i = 255; i > 0; i--)
                {
                    this.labelAmmo.ForeColor = Color.FromArgb(255, i, i);
                }
            }
            else
            {
                for (int i = 0; i < 255; i++)
                {
                    this.labelAmmo.ForeColor = Color.FromArgb(255, i, i);
                }
            }
        }

        private void timerDown_Tick(object sender, EventArgs e)
        {
            // Cache au bout de 1 seconde
            this.panelDown.Hide();
            this.timerDown.Stop();
        }

        private void timerFlash_Tick(object sender, EventArgs e)
        {
            // Cache au bout de 50 ms
            this.pictureBoxFlash.Hide();
            this.timerFlash.Stop();
        }
        // --------------------------------------------------------
    }
}
