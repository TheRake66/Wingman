using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wingman.Properties;

namespace Wingman
{
    public partial class Start : Form
    {
        // --------------------------------------------------------
        public Start()
        {
            InitializeComponent();

            // Change le curseur
            byte[] buffer = Resources.cursor;
            using (MemoryStream m = new MemoryStream(buffer)) this.Cursor = new Cursor(m);
        }
        // --------------------------------------------------------



        // --------------------------------------------------------
        private void buttonLeave_Click(object sender, EventArgs e)
        {
            // Son du click
            play(Resources.click);
            // Leave
            this.Close();
        }

        private void richTextBoxInfos_Click(object sender, EventArgs e)
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
        private void play(UnmanagedMemoryStream ressource)
        {
            // Joue async
            using (SoundPlayer snd = new SoundPlayer(ressource)) snd.Play();
        }
        // --------------------------------------------------------
    }
}
