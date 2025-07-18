﻿namespace HaNgi
{
    partial class SongCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.avatarCover = new Sunny.UI.UIAvatar();
            this.lblSongName = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // avatarCover
            // 
            this.avatarCover.AvatarSize = 150;
            this.avatarCover.Dock = System.Windows.Forms.DockStyle.Top;
            this.avatarCover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.avatarCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.avatarCover.ForeColor = System.Drawing.Color.LightSlateGray;
            this.avatarCover.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.avatarCover.Location = new System.Drawing.Point(0, 0);
            this.avatarCover.MinimumSize = new System.Drawing.Size(1, 1);
            this.avatarCover.Name = "avatarCover";
            this.avatarCover.Radius = 0;
            this.avatarCover.Shape = Sunny.UI.UIShape.Square;
            this.avatarCover.Size = new System.Drawing.Size(150, 150);
            this.avatarCover.Symbol = 557392;
            this.avatarCover.SymbolSize = 100;
            this.avatarCover.TabIndex = 0;
            this.avatarCover.Text = "uiAvatar1";
            this.avatarCover.Click += new System.EventHandler(this.avatarCover_MouseEnter);
            // 
            // lblSongName
            // 
            this.lblSongName.BackColor = System.Drawing.Color.Transparent;
            this.lblSongName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSongName.Font = new System.Drawing.Font("Lora Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblSongName.Location = new System.Drawing.Point(0, 150);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Padding = new System.Windows.Forms.Padding(5);
            this.lblSongName.Size = new System.Drawing.Size(150, 50);
            this.lblSongName.TabIndex = 1;
            this.lblSongName.Text = "Tên nhạc";
            this.lblSongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SongCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.avatarCover);
            this.Name = "SongCard";
            this.Size = new System.Drawing.Size(150, 200);
            this.MouseEnter += new System.EventHandler(this.SongCard_MouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIAvatar avatarCover;
        private Sunny.UI.UILabel lblSongName;
    }
}
