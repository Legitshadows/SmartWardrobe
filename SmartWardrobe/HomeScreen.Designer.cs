namespace SmartWardrobe
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buscadorRopa = new System.Windows.Forms.Button();
            this.generadorVestimienta = new System.Windows.Forms.Button();
            this.addCloset = new System.Windows.Forms.Button();
            this.eliminarCloset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::SmartWardrobe.Properties.Resources.power;
            this.pictureBox1.InitialImage = global::SmartWardrobe.Properties.Resources.power;
            this.pictureBox1.Location = new System.Drawing.Point(1443, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buscadorRopa
            // 
            this.buscadorRopa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buscadorRopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscadorRopa.Location = new System.Drawing.Point(139, 31);
            this.buscadorRopa.Name = "buscadorRopa";
            this.buscadorRopa.Size = new System.Drawing.Size(508, 252);
            this.buscadorRopa.TabIndex = 5;
            this.buscadorRopa.Text = "Buscador De Ropa";
            this.buscadorRopa.UseVisualStyleBackColor = false;
            this.buscadorRopa.Click += new System.EventHandler(this.button1_Click);
            // 
            // generadorVestimienta
            // 
            this.generadorVestimienta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.generadorVestimienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generadorVestimienta.Location = new System.Drawing.Point(905, 31);
            this.generadorVestimienta.Name = "generadorVestimienta";
            this.generadorVestimienta.Size = new System.Drawing.Size(508, 252);
            this.generadorVestimienta.TabIndex = 6;
            this.generadorVestimienta.Text = "Generador De Vestimenta";
            this.generadorVestimienta.UseVisualStyleBackColor = false;
            this.generadorVestimienta.Click += new System.EventHandler(this.button2_Click);
            // 
            // addCloset
            // 
            this.addCloset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addCloset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCloset.Location = new System.Drawing.Point(139, 383);
            this.addCloset.Name = "addCloset";
            this.addCloset.Size = new System.Drawing.Size(508, 252);
            this.addCloset.TabIndex = 7;
            this.addCloset.Text = "Agregar Al Closet";
            this.addCloset.UseVisualStyleBackColor = false;
            this.addCloset.Click += new System.EventHandler(this.addCloset_Click);
            // 
            // eliminarCloset
            // 
            this.eliminarCloset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.eliminarCloset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarCloset.Location = new System.Drawing.Point(905, 383);
            this.eliminarCloset.Name = "eliminarCloset";
            this.eliminarCloset.Size = new System.Drawing.Size(508, 252);
            this.eliminarCloset.TabIndex = 8;
            this.eliminarCloset.Text = "Eliminar Del Closet";
            this.eliminarCloset.UseVisualStyleBackColor = false;
            this.eliminarCloset.Click += new System.EventHandler(this.eliminarCloset_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1566, 680);
            this.Controls.Add(this.eliminarCloset);
            this.Controls.Add(this.addCloset);
            this.Controls.Add(this.generadorVestimienta);
            this.Controls.Add(this.buscadorRopa);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buscadorRopa;
        private System.Windows.Forms.Button generadorVestimienta;
        private System.Windows.Forms.Button addCloset;
        private System.Windows.Forms.Button eliminarCloset;
    }
}