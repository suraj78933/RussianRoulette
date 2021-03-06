namespace RussianRoulette
{
    partial class RussianRoulette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RussianRoulette));
            this.Wins = new System.Windows.Forms.Label();
            this.Losses = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.BulletPosition_lbl = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.BulletsFired_Lbl = new System.Windows.Forms.Label();
            this.lblBulletsFired = new System.Windows.Forms.Label();
            this.lblAway = new System.Windows.Forms.Label();
            this.ShootAway = new System.Windows.Forms.Label();
            this.Totals = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKill = new System.Windows.Forms.Label();
            this.PicBox_Gun = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnShootAway = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Gun)).BeginInit();
            this.SuspendLayout();
            // 
            // Wins
            // 
            this.Wins.AutoSize = true;
            this.Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wins.ForeColor = System.Drawing.Color.Transparent;
            this.Wins.Location = new System.Drawing.Point(648, 74);
            this.Wins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Wins.Name = "Wins";
            this.Wins.Size = new System.Drawing.Size(65, 26);
            this.Wins.TabIndex = 0;
            this.Wins.Text = "Wins";
            // 
            // Losses
            // 
            this.Losses.AutoSize = true;
            this.Losses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Losses.ForeColor = System.Drawing.Color.Transparent;
            this.Losses.Location = new System.Drawing.Point(803, 74);
            this.Losses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Losses.Name = "Losses";
            this.Losses.Size = new System.Drawing.Size(87, 26);
            this.Losses.TabIndex = 1;
            this.Losses.Text = "Losses";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.ForeColor = System.Drawing.Color.Transparent;
            this.lblWins.Location = new System.Drawing.Point(754, 74);
            this.lblWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(25, 26);
            this.lblWins.TabIndex = 2;
            this.lblWins.Text = "0";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.ForeColor = System.Drawing.Color.Transparent;
            this.lblLosses.Location = new System.Drawing.Point(928, 74);
            this.lblLosses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(25, 26);
            this.lblLosses.TabIndex = 3;
            this.lblLosses.Text = "0";
            // 
            // btnShoot
            // 
            this.btnShoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnShoot.Enabled = false;
            this.btnShoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShoot.Location = new System.Drawing.Point(1010, 250);
            this.btnShoot.Margin = new System.Windows.Forms.Padding(4);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(193, 101);
            this.btnShoot.TabIndex = 4;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = false;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Olive;
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSpin.Location = new System.Drawing.Point(1010, 129);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(192, 101);
            this.btnSpin.TabIndex = 6;
            this.btnSpin.Text = "Spin Chamber";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // BulletPosition_lbl
            // 
            this.BulletPosition_lbl.AutoSize = true;
            this.BulletPosition_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulletPosition_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.BulletPosition_lbl.Location = new System.Drawing.Point(649, 255);
            this.BulletPosition_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BulletPosition_lbl.Name = "BulletPosition_lbl";
            this.BulletPosition_lbl.Size = new System.Drawing.Size(166, 26);
            this.BulletPosition_lbl.TabIndex = 7;
            this.BulletPosition_lbl.Text = "Bullet Position";
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandom.ForeColor = System.Drawing.Color.Transparent;
            this.lblRandom.Location = new System.Drawing.Point(850, 256);
            this.lblRandom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(166, 26);
            this.lblRandom.TabIndex = 8;
            // 
            // BulletsFired_Lbl
            // 
            this.BulletsFired_Lbl.AutoSize = true;
            this.BulletsFired_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulletsFired_Lbl.ForeColor = System.Drawing.Color.Transparent;
            this.BulletsFired_Lbl.Location = new System.Drawing.Point(648, 198);
            this.BulletsFired_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BulletsFired_Lbl.Name = "BulletsFired_Lbl";
            this.BulletsFired_Lbl.Size = new System.Drawing.Size(146, 26);
            this.BulletsFired_Lbl.TabIndex = 9;
            this.BulletsFired_Lbl.Text = "Bullets Fired";
            // 
            // lblBulletsFired
            // 
            this.lblBulletsFired.AutoSize = true;
            this.lblBulletsFired.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulletsFired.ForeColor = System.Drawing.Color.Transparent;
            this.lblBulletsFired.Location = new System.Drawing.Point(813, 198);
            this.lblBulletsFired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBulletsFired.Name = "lblBulletsFired";
            this.lblBulletsFired.Size = new System.Drawing.Size(25, 26);
            this.lblBulletsFired.TabIndex = 10;
            this.lblBulletsFired.Text = "0";
            // 
            // lblAway
            // 
            this.lblAway.AutoSize = true;
            this.lblAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAway.ForeColor = System.Drawing.Color.Transparent;
            this.lblAway.Location = new System.Drawing.Point(813, 132);
            this.lblAway.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(25, 26);
            this.lblAway.TabIndex = 11;
            this.lblAway.Text = "0";
            // 
            // ShootAway
            // 
            this.ShootAway.AutoSize = true;
            this.ShootAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAway.ForeColor = System.Drawing.Color.Transparent;
            this.ShootAway.Location = new System.Drawing.Point(649, 132);
            this.ShootAway.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(139, 26);
            this.ShootAway.TabIndex = 12;
            this.ShootAway.Text = "Shoot Away";
            // 
            // Totals
            // 
            this.Totals.AutoSize = true;
            this.Totals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totals.ForeColor = System.Drawing.Color.Transparent;
            this.Totals.Location = new System.Drawing.Point(724, 24);
            this.Totals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Totals.Name = "Totals";
            this.Totals.Size = new System.Drawing.Size(64, 26);
            this.Totals.TabIndex = 14;
            this.Totals.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(842, 24);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 26);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblKill);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.Totals);
            this.panel1.Controls.Add(this.PicBox_Gun);
            this.panel1.Controls.Add(this.ShootAway);
            this.panel1.Controls.Add(this.lblAway);
            this.panel1.Controls.Add(this.lblBulletsFired);
            this.panel1.Controls.Add(this.BulletsFired_Lbl);
            this.panel1.Controls.Add(this.lblRandom);
            this.panel1.Controls.Add(this.BulletPosition_lbl);
            this.panel1.Controls.Add(this.lblLosses);
            this.panel1.Controls.Add(this.lblWins);
            this.panel1.Controls.Add(this.Losses);
            this.panel1.Controls.Add(this.Wins);
            this.panel1.Location = new System.Drawing.Point(4, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 467);
            this.panel1.TabIndex = 16;
            // 
            // lblKill
            // 
            this.lblKill.AutoSize = true;
            this.lblKill.Location = new System.Drawing.Point(385, 235);
            this.lblKill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKill.Name = "lblKill";
            this.lblKill.Size = new System.Drawing.Size(12, 17);
            this.lblKill.TabIndex = 17;
            this.lblKill.Text = " ";
            this.lblKill.Visible = false;
            // 
            // PicBox_Gun
            // 
            this.PicBox_Gun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBox_Gun.ErrorImage = global::RussianRoulette.Properties.Resources.spinning;
            this.PicBox_Gun.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_Gun.Image")));
            this.PicBox_Gun.InitialImage = global::RussianRoulette.Properties.Resources.spinning;
            this.PicBox_Gun.Location = new System.Drawing.Point(25, 14);
            this.PicBox_Gun.Margin = new System.Windows.Forms.Padding(4);
            this.PicBox_Gun.Name = "PicBox_Gun";
            this.PicBox_Gun.Size = new System.Drawing.Size(606, 437);
            this.PicBox_Gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_Gun.TabIndex = 13;
            this.PicBox_Gun.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(658, 327);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(310, 124);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Teal;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoad.Location = new System.Drawing.Point(1010, 15);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(192, 100);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Load Chamber";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnShootAway
            // 
            this.btnShootAway.BackColor = System.Drawing.Color.Navy;
            this.btnShootAway.Enabled = false;
            this.btnShootAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShootAway.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShootAway.Location = new System.Drawing.Point(1010, 371);
            this.btnShootAway.Margin = new System.Windows.Forms.Padding(4);
            this.btnShootAway.Name = "btnShootAway";
            this.btnShootAway.Size = new System.Drawing.Size(193, 111);
            this.btnShootAway.TabIndex = 16;
            this.btnShootAway.Text = "Shoot Away";
            this.btnShootAway.UseVisualStyleBackColor = false;
            this.btnShootAway.Click += new System.EventHandler(this.btnShootAway_Click);
            // 
            // RussianRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1215, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnShootAway);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnShoot);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RussianRoulette";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Russian Roulette";
            this.Load += new System.EventHandler(this.RussianRoulette_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Gun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Wins;
        private System.Windows.Forms.Label Losses;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Button btnShoot;
        //private System.Windows.Forms.Button btnPointAway;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label BulletPosition_lbl;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label BulletsFired_Lbl;
        private System.Windows.Forms.Label lblBulletsFired;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.Label ShootAway;
        private System.Windows.Forms.PictureBox PicBox_Gun;
        private System.Windows.Forms.Label Totals;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShootAway;
        private System.Windows.Forms.Label lblKill;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
    }
}

