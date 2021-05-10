namespace Wingman
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.richTextBoxInfos = new System.Windows.Forms.RichTextBox();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxInfos
            // 
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
            // buttonLeave
            // 
            this.buttonLeave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeave.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonLeave.ForeColor = System.Drawing.Color.White;
            this.buttonLeave.Location = new System.Drawing.Point(159, 628);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(167, 40);
            this.buttonLeave.TabIndex = 6;
            this.buttonLeave.Text = "Start game";
            this.buttonLeave.UseVisualStyleBackColor = false;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            this.buttonLeave.MouseHover += new System.EventHandler(this.control_MouseHover);
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
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(484, 701);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.richTextBoxInfos);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 740);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 740);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome !! Thank you !!!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBoxInfos;
        private System.Windows.Forms.Button buttonLeave;
    }
}