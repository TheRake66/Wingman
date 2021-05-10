namespace Wingman
{
    partial class End
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(End));
            this.richTextBoxInfos = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelShot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDamage = new System.Windows.Forms.Label();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxInfos
            // 
            this.richTextBoxInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.richTextBoxInfos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfos.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold);
            this.richTextBoxInfos.ForeColor = System.Drawing.Color.White;
            this.richTextBoxInfos.Location = new System.Drawing.Point(30, 360);
            this.richTextBoxInfos.Name = "richTextBoxInfos";
            this.richTextBoxInfos.ReadOnly = true;
            this.richTextBoxInfos.Size = new System.Drawing.Size(430, 220);
            this.richTextBoxInfos.TabIndex = 1;
            this.richTextBoxInfos.Text = resources.GetString("richTextBoxInfos.Text");
            this.richTextBoxInfos.Click += new System.EventHandler(this.richTextBoxInfos_Click);
            this.richTextBoxInfos.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 630);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of shot :";
            // 
            // labelShot
            // 
            this.labelShot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelShot.AutoSize = true;
            this.labelShot.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShot.ForeColor = System.Drawing.Color.White;
            this.labelShot.Location = new System.Drawing.Point(341, 630);
            this.labelShot.Name = "labelShot";
            this.labelShot.Size = new System.Drawing.Size(28, 29);
            this.labelShot.TabIndex = 3;
            this.labelShot.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 659);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your damage :";
            // 
            // labelDamage
            // 
            this.labelDamage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDamage.AutoSize = true;
            this.labelDamage.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamage.ForeColor = System.Drawing.Color.White;
            this.labelDamage.Location = new System.Drawing.Point(341, 659);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(28, 29);
            this.labelDamage.TabIndex = 5;
            this.labelDamage.Text = "0";
            // 
            // buttonLeave
            // 
            this.buttonLeave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeave.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonLeave.ForeColor = System.Drawing.Color.White;
            this.buttonLeave.Location = new System.Drawing.Point(159, 738);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(167, 40);
            this.buttonLeave.TabIndex = 6;
            this.buttonLeave.Text = "Leave game";
            this.buttonLeave.UseVisualStyleBackColor = false;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            this.buttonLeave.MouseHover += new System.EventHandler(this.control_MouseHover);
            // 
            // timerColor
            // 
            this.timerColor.Enabled = true;
            this.timerColor.Interval = 250;
            this.timerColor.Tick += new System.EventHandler(this.timerColor_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(484, 811);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.labelDamage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelShot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxInfos);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 850);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 850);
            this.Name = "End";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Victory !! Thank you !!!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBoxInfos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelShot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.Timer timerColor;
    }
}