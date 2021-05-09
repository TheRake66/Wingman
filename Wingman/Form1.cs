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
    public partial class Form1 : Form
    {
        // --------------------------------------------------------
        private const int MAXAMMO = 6;
        private int currentAmmo = MAXAMMO;
        // --------------------------------------------------------



        // --------------------------------------------------------
        public Form1()
        {
            InitializeComponent();

            this.labelAmmo.Text = MAXAMMO.ToString();

            this.pictureBoxCharm.Parent = this.pictureBoxGun;
            this.pictureBoxCharm.Location = new Point(575, 25);

            this.pictureBoxReload.Parent = this.pictureBoxGun;
            this.pictureBoxReload.Location = new Point(565, 165);

            this.pictureBoxShot.Parent = this.pictureBoxGun;
            this.pictureBoxShot.Location = new Point(480, 230);
        }
        // --------------------------------------------------------




        // --------------------------------------------------------
        private void checkBoxCharm_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxCharm.Visible = this.checkBoxCharm.Checked;
        }
        // --------------------------------------------------------



        // --------------------------------------------------------
        private void pictureBoxShot_Click(object sender, EventArgs e)
        {
            if (this.currentAmmo > 0)
            {
                play(this.currentAmmo > 1 ? Resources.shot : Resources.last);

                this.currentAmmo--;
                this.labelAmmo.Text = this.currentAmmo.ToString();
                if (this.currentAmmo == 0) this.labelAmmo.ForeColor = Color.Red;
                this.labelAmmo.Refresh();

                this.pictureBoxFlash.Visible = true;
                this.pictureBoxFlash.Refresh();
                Thread.Sleep(50);
                this.pictureBoxFlash.Visible = false;
                this.pictureBoxFlash.Refresh();
            }
            else play(Resources.empty);
        }

        private void pictureBoxReload_Click(object sender, EventArgs e)
        {
            if (this.currentAmmo < MAXAMMO)
            {
                playSync(Resources.reload);

                this.currentAmmo = MAXAMMO;
                this.labelAmmo.Text = this.currentAmmo.ToString();
                if (this.labelAmmo.ForeColor == Color.Red) this.labelAmmo.ForeColor = SystemColors.ControlText;
            }
        }
        // --------------------------------------------------------



        // --------------------------------------------------------
        private void play(UnmanagedMemoryStream ressource)
        {
            using (SoundPlayer snd = new SoundPlayer(ressource))
            {
                snd.Play();
            }
        }

        private void playSync(UnmanagedMemoryStream ressource)
        {
            using (SoundPlayer snd = new SoundPlayer(ressource))
            {
                snd.PlaySync();
            }
        }
        // --------------------------------------------------------
    }
}
