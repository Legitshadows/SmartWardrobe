﻿namespace SmartWardrobe
{
    partial class GenOutfit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenOutfit));
            this.powerButton = new System.Windows.Forms.PictureBox();
            this.returnButton = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.powerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // powerButton
            // 
            this.powerButton.BackColor = System.Drawing.Color.Transparent;
            this.powerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("powerButton.BackgroundImage")));
            this.powerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.powerButton.Location = new System.Drawing.Point(1415, 208);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(100, 50);
            this.powerButton.TabIndex = 15;
            this.powerButton.TabStop = false;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Transparent;
            this.returnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnButton.BackgroundImage")));
            this.returnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.returnButton.Location = new System.Drawing.Point(1415, 416);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(100, 50);
            this.returnButton.TabIndex = 14;
            this.returnButton.TabStop = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeButton.Location = new System.Drawing.Point(1415, 308);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(100, 50);
            this.homeButton.TabIndex = 13;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(52, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1347, 561);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // GenOutfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1566, 680);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenOutfit";
            this.Text = "GenOutfit";
            ((System.ComponentModel.ISupportInitialize)(this.powerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox powerButton;
        private System.Windows.Forms.PictureBox returnButton;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}