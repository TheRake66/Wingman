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
        private int currentAmmo = 6;
        private int currentKill = 0;
        private int currentDamage = 0;
        private int currentPlayer = 60;
        private int currentSquad = 10;

        private bool emprtyToRed = false;
        private Random rnd = new Random();
        private string[] players =
        {
            "Wraith",
            "Lifeline",
            "Horizon",
            "Wattson",
            "Bloudhound",
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

            // Met en transparent
            this.pictureBoxCharm.Parent = this.pictureBoxGun;
            this.pictureBoxCharm.Location = new Point(575, 25);

            this.pictureBoxReload.Parent = this.pictureBoxGun;
            this.pictureBoxReload.Location = new Point(565, 165);

            this.pictureBoxShot.Parent = this.pictureBoxGun;
            this.pictureBoxShot.Location = new Point(480, 230);

            this.labelCraft.Parent = this.pictureBoxKill;
            this.labelCraft.Location = new Point(68, 13);

            this.labelSquadLeft.Parent = this.pictureBoxKill;
            this.labelSquadLeft.Location = new Point(147, 13);

            this.labelPlayerLeft.Parent = this.pictureBoxKill;
            this.labelPlayerLeft.Location = new Point(403, 13);

            this.labelKill.Parent = this.pictureBoxKill;
            this.labelKill.Location = new Point(210, 71);

            this.labelDamage.Parent = this.pictureBoxKill;
            this.labelDamage.Location = new Point(363, 71);

            // Change le curseur
            byte[] buffer = Resources.cursor;
            using (MemoryStream m = new MemoryStream(buffer)) this.Cursor = new Cursor(m);


            // Random craft
            this.labelCraft.Text = this.rnd.Next(99).ToString();
        }
        // --------------------------------------------------------




        // --------------------------------------------------------
        private void checkBoxCharm_CheckedChanged(object sender, EventArgs e)
        {
            // Affiche le charm
            this.pictureBoxCharm.Visible = this.checkBoxCharm.Checked;
            // Son click ou select
            if (this.pictureBoxCharm.Visible) play(Resources.select);
            else play(Resources.click);
        }

        private void checkBoxReload_CheckedChanged(object sender, EventArgs e)
        {
            play(Resources.click);
        }

        private void checkBox_MouseHover(object sender, EventArgs e)
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
            if (this.currentAmmo < 6) reload();
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
            this.currentAmmo = 6;
            this.labelAmmo.Text = this.currentAmmo.ToString();

            // Remet le compteur blanc
            this.timerEmpty.Enabled = false;
            this.labelAmmo.ForeColor = Color.White;
        }

        private void shot()
        {
            // Joue le tire
            play(this.currentAmmo > 1 ? Resources.shot : Resources.last);

            // Retire une balle
            this.currentAmmo--;
            this.labelAmmo.Text = this.currentAmmo.ToString();
            this.labelAmmo.Refresh();

            // Si plus de balle
            if (this.currentAmmo == 0) this.timerEmpty.Enabled = true;

            // Affiche le flash
            this.pictureBoxFlash.Show();
            this.pictureBoxFlash.Refresh();
            Thread.Sleep(50);
            this.pictureBoxFlash.Hide();
            this.pictureBoxFlash.Refresh();

            // Touche
            hit();

            // Temps entre chaque balle
            Thread.Sleep(300);
        }

        private void hit()
        {
            // Proba de kill
            int proba = rnd.Next(5);
            if (proba == rnd.Next(5))
            {
                // Joue le bruit down
                play(Resources.down);

                // Max 999 kills
                if (this.currentKill < 999)
                {
                    // Ajoute un kill
                    this.currentKill++;
                    this.labelKill.Text = this.currentKill.ToString();
                    this.labelKill.Refresh();
                }

                // Change les damages
                int damage = proba == rnd.Next(5) ? 90 : 45;
                // Max 9999 damage
                if (this.currentKill < 9999)
                {
                    // Ajoute les damages
                    this.currentDamage += damage;
                    this.labelDamage.Text = this.currentDamage.ToString();
                    this.labelDamage.Refresh();
                }
                this.labelDamageInflic.Text = damage.ToString();
                this.labelDamageInflic.Refresh();


                // Victoire ou pas
                this.currentPlayer--;
                if (this.currentPlayer == 3) victory();

                if (this.currentPlayer % 3 == 0)
                {
                    // Last squad
                    this.currentSquad--;
                    this.labelSquadLeft.Text = this.currentSquad.ToString();
                    this.labelSquadLeft.Refresh();
                }
                // Last player
                this.labelPlayerLeft.Text = this.currentPlayer > 10 ? this.currentPlayer.ToString() : "?";
                this.labelPlayerLeft.Refresh();

                // Change la legende
                this.labelPlayer.Text = this.players[rnd.Next(this.players.Length)].ToUpper();
                this.labelPlayer.Refresh();

                // Replace le pannel down
                this.panelDown.Location = new Point(
                    this.Size.Width / 2 - this.panelDown.Size.Width / 2,
                    this.Height / 3 * 2
                    );

                // Affiche le pannel down
                this.panelDown.Show();
                this.panelDown.Refresh();
                Thread.Sleep(1000);
                this.panelDown.Hide();
                this.panelDown.Refresh();
            }
        }

        private void victory()
        {

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
        private void timerEmpty_Tick(object sender, EventArgs e)
        {
            // Passe de rouge à blanc
            this.emprtyToRed = !this.emprtyToRed;
            if (this.emprtyToRed)
            {
                for (int i = 255; i > 0; i--)
                {
                    this.labelAmmo.ForeColor = Color.FromArgb(255, i, i);
                    this.labelAmmo.Refresh();
                }
            }
            else
            {
                for (int i = 0; i < 255; i++)
                {
                    this.labelAmmo.ForeColor = Color.FromArgb(255, i, i);
                    this.labelAmmo.Refresh();
                }
            }
        }
        // --------------------------------------------------------
    }
}
