namespace Wingman
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBoxFlash = new System.Windows.Forms.PictureBox();
            this.pictureBoxGun = new System.Windows.Forms.PictureBox();
            this.pictureBoxCharm = new System.Windows.Forms.PictureBox();
            this.pictureBoxAmmo = new System.Windows.Forms.PictureBox();
            this.checkBoxCharm = new System.Windows.Forms.CheckBox();
            this.checkBoxReload = new System.Windows.Forms.CheckBox();
            this.labelAmmo = new System.Windows.Forms.Label();
            this.pictureBoxShot = new System.Windows.Forms.PictureBox();
            this.pictureBoxReload = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerEmpty = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxKill = new System.Windows.Forms.PictureBox();
            this.labelKill = new System.Windows.Forms.Label();
            this.panelDown = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDamage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKill)).BeginInit();
            this.panelDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxFlash
            // 
            this.pictureBoxFlash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxFlash.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFlash.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFlash.Image")));
            this.pictureBoxFlash.Location = new System.Drawing.Point(20, 60);
            this.pictureBoxFlash.Name = "pictureBoxFlash";
            this.pictureBoxFlash.Size = new System.Drawing.Size(370, 275);
            this.pictureBoxFlash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlash.TabIndex = 0;
            this.pictureBoxFlash.TabStop = false;
            this.pictureBoxFlash.Visible = false;
            // 
            // pictureBoxGun
            // 
            this.pictureBoxGun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxGun.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGun.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGun.Image")));
            this.pictureBoxGun.Location = new System.Drawing.Point(370, 60);
            this.pictureBoxGun.Name = "pictureBoxGun";
            this.pictureBoxGun.Size = new System.Drawing.Size(800, 500);
            this.pictureBoxGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGun.TabIndex = 1;
            this.pictureBoxGun.TabStop = false;
            // 
            // pictureBoxCharm
            // 
            this.pictureBoxCharm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxCharm.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCharm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCharm.Image")));
            this.pictureBoxCharm.Location = new System.Drawing.Point(940, 85);
            this.pictureBoxCharm.Name = "pictureBoxCharm";
            this.pictureBoxCharm.Size = new System.Drawing.Size(109, 143);
            this.pictureBoxCharm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCharm.TabIndex = 2;
            this.pictureBoxCharm.TabStop = false;
            // 
            // pictureBoxAmmo
            // 
            this.pictureBoxAmmo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxAmmo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAmmo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAmmo.Image")));
            this.pictureBoxAmmo.Location = new System.Drawing.Point(105, 485);
            this.pictureBoxAmmo.Name = "pictureBoxAmmo";
            this.pictureBoxAmmo.Size = new System.Drawing.Size(70, 68);
            this.pictureBoxAmmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAmmo.TabIndex = 3;
            this.pictureBoxAmmo.TabStop = false;
            this.pictureBoxAmmo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAmmo_MouseClick);
            // 
            // checkBoxCharm
            // 
            this.checkBoxCharm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxCharm.AutoSize = true;
            this.checkBoxCharm.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCharm.Checked = true;
            this.checkBoxCharm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCharm.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCharm.ForeColor = System.Drawing.Color.White;
            this.checkBoxCharm.Location = new System.Drawing.Point(45, 370);
            this.checkBoxCharm.Name = "checkBoxCharm";
            this.checkBoxCharm.Size = new System.Drawing.Size(185, 27);
            this.checkBoxCharm.TabIndex = 5;
            this.checkBoxCharm.Text = "Diamond charm";
            this.checkBoxCharm.UseVisualStyleBackColor = false;
            this.checkBoxCharm.CheckedChanged += new System.EventHandler(this.checkBoxCharm_CheckedChanged);
            this.checkBoxCharm.MouseHover += new System.EventHandler(this.checkBox_MouseHover);
            // 
            // checkBoxReload
            // 
            this.checkBoxReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxReload.AutoSize = true;
            this.checkBoxReload.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxReload.Checked = true;
            this.checkBoxReload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxReload.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReload.ForeColor = System.Drawing.Color.White;
            this.checkBoxReload.Location = new System.Drawing.Point(45, 400);
            this.checkBoxReload.Name = "checkBoxReload";
            this.checkBoxReload.Size = new System.Drawing.Size(161, 27);
            this.checkBoxReload.TabIndex = 6;
            this.checkBoxReload.Text = "Auto reload";
            this.checkBoxReload.UseVisualStyleBackColor = false;
            this.checkBoxReload.CheckedChanged += new System.EventHandler(this.checkBoxReload_CheckedChanged);
            this.checkBoxReload.MouseHover += new System.EventHandler(this.checkBox_MouseHover);
            // 
            // labelAmmo
            // 
            this.labelAmmo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAmmo.AutoSize = true;
            this.labelAmmo.BackColor = System.Drawing.Color.Transparent;
            this.labelAmmo.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmmo.ForeColor = System.Drawing.Color.White;
            this.labelAmmo.Location = new System.Drawing.Point(180, 495);
            this.labelAmmo.Name = "labelAmmo";
            this.labelAmmo.Size = new System.Drawing.Size(54, 58);
            this.labelAmmo.TabIndex = 8;
            this.labelAmmo.Text = "6";
            // 
            // pictureBoxShot
            // 
            this.pictureBoxShot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxShot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShot.Location = new System.Drawing.Point(850, 290);
            this.pictureBoxShot.Name = "pictureBoxShot";
            this.pictureBoxShot.Size = new System.Drawing.Size(120, 85);
            this.pictureBoxShot.TabIndex = 9;
            this.pictureBoxShot.TabStop = false;
            this.pictureBoxShot.Click += new System.EventHandler(this.pictureBoxShot_Click);
            // 
            // pictureBoxReload
            // 
            this.pictureBoxReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxReload.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxReload.Location = new System.Drawing.Point(935, 225);
            this.pictureBoxReload.Name = "pictureBoxReload";
            this.pictureBoxReload.Size = new System.Drawing.Size(65, 30);
            this.pictureBoxReload.TabIndex = 10;
            this.pictureBoxReload.TabStop = false;
            this.pictureBoxReload.Click += new System.EventHandler(this.pictureBoxReload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 485);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(595, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fire";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(750, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Reload";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(670, 485);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // timerEmpty
            // 
            this.timerEmpty.Interval = 250;
            this.timerEmpty.Tick += new System.EventHandler(this.timerEmpty_Tick);
            // 
            // pictureBoxKill
            // 
            this.pictureBoxKill.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKill.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKill.Image")));
            this.pictureBoxKill.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxKill.Name = "pictureBoxKill";
            this.pictureBoxKill.Size = new System.Drawing.Size(152, 49);
            this.pictureBoxKill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKill.TabIndex = 15;
            this.pictureBoxKill.TabStop = false;
            // 
            // labelKill
            // 
            this.labelKill.AutoSize = true;
            this.labelKill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(61)))));
            this.labelKill.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKill.ForeColor = System.Drawing.Color.White;
            this.labelKill.Location = new System.Drawing.Point(90, 32);
            this.labelKill.Name = "labelKill";
            this.labelKill.Size = new System.Drawing.Size(28, 29);
            this.labelKill.TabIndex = 16;
            this.labelKill.Text = "0";
            // 
            // panelDown
            // 
            this.panelDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelDown.Controls.Add(this.labelPlayer);
            this.panelDown.Controls.Add(this.label5);
            this.panelDown.Controls.Add(this.labelDamage);
            this.panelDown.Controls.Add(this.label3);
            this.panelDown.Location = new System.Drawing.Point(445, 387);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(299, 60);
            this.panelDown.TabIndex = 17;
            this.panelDown.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "KNOCKED DOWN";
            // 
            // labelDamage
            // 
            this.labelDamage.AutoSize = true;
            this.labelDamage.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDamage.ForeColor = System.Drawing.Color.White;
            this.labelDamage.Location = new System.Drawing.Point(60, 30);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(34, 23);
            this.labelDamage.TabIndex = 1;
            this.labelDamage.Text = "45";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(100, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "DAMAGE INFLICTED";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPlayer.ForeColor = System.Drawing.Color.Red;
            this.labelPlayer.Location = new System.Drawing.Point(162, 7);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(130, 23);
            this.labelPlayer.TabIndex = 3;
            this.labelPlayer.Text = "BLOUDHOUND";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 581);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.labelKill);
            this.Controls.Add(this.pictureBoxKill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxReload);
            this.Controls.Add(this.pictureBoxShot);
            this.Controls.Add(this.labelAmmo);
            this.Controls.Add(this.checkBoxReload);
            this.Controls.Add(this.checkBoxCharm);
            this.Controls.Add(this.pictureBoxAmmo);
            this.Controls.Add(this.pictureBoxCharm);
            this.Controls.Add(this.pictureBoxGun);
            this.Controls.Add(this.pictureBoxFlash);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1205, 580);
            this.Name = "Main";
            this.Text = "Apex Legends Wingman simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKill)).EndInit();
            this.panelDown.ResumeLayout(false);
            this.panelDown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFlash;
        private System.Windows.Forms.PictureBox pictureBoxGun;
        private System.Windows.Forms.PictureBox pictureBoxCharm;
        private System.Windows.Forms.PictureBox pictureBoxAmmo;
        private System.Windows.Forms.CheckBox checkBoxCharm;
        private System.Windows.Forms.CheckBox checkBoxReload;
        private System.Windows.Forms.Label labelAmmo;
        private System.Windows.Forms.PictureBox pictureBoxShot;
        private System.Windows.Forms.PictureBox pictureBoxReload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerEmpty;
        private System.Windows.Forms.PictureBox pictureBoxKill;
        private System.Windows.Forms.Label labelKill;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.Label label3;
    }
}

