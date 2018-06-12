namespace WindowsFormsApplication1
{
    partial class FrmAdministracija
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
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnAzurirajSmer = new System.Windows.Forms.Button();
            this.btnAzurirajStudenta = new System.Windows.Forms.Button();
            this.btnPrikaziListu = new System.Windows.Forms.Button();
            this.btnAzurirajPredmet = new System.Windows.Forms.Button();
            this.btnPrikaziStatistiku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(779, 426);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(181, 62);
            this.btnNazad.TabIndex = 11;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnAzurirajSmer
            // 
            this.btnAzurirajSmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajSmer.Location = new System.Drawing.Point(12, 12);
            this.btnAzurirajSmer.Name = "btnAzurirajSmer";
            this.btnAzurirajSmer.Size = new System.Drawing.Size(471, 132);
            this.btnAzurirajSmer.TabIndex = 6;
            this.btnAzurirajSmer.Text = "UNESI - AZURIRAJ - IZBRISI SMER";
            this.btnAzurirajSmer.UseVisualStyleBackColor = true;
            this.btnAzurirajSmer.Click += new System.EventHandler(this.btnAzurirajSmer_Click);
            // 
            // btnAzurirajStudenta
            // 
            this.btnAzurirajStudenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajStudenta.Location = new System.Drawing.Point(489, 12);
            this.btnAzurirajStudenta.Name = "btnAzurirajStudenta";
            this.btnAzurirajStudenta.Size = new System.Drawing.Size(471, 132);
            this.btnAzurirajStudenta.TabIndex = 7;
            this.btnAzurirajStudenta.Text = "UNESI - AZURIRAJ - IZBRISI STUDENTA";
            this.btnAzurirajStudenta.UseVisualStyleBackColor = true;
            this.btnAzurirajStudenta.Click += new System.EventHandler(this.btnAzurirajStudenta_Click);
            // 
            // btnPrikaziListu
            // 
            this.btnPrikaziListu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziListu.Location = new System.Drawing.Point(488, 150);
            this.btnPrikaziListu.Name = "btnPrikaziListu";
            this.btnPrikaziListu.Size = new System.Drawing.Size(471, 132);
            this.btnPrikaziListu.TabIndex = 9;
            this.btnPrikaziListu.Text = "PRIKAZI IZBORNU LISTU";
            this.btnPrikaziListu.UseVisualStyleBackColor = true;
            this.btnPrikaziListu.Click += new System.EventHandler(this.btnPrikaziListu_Click);
            // 
            // btnAzurirajPredmet
            // 
            this.btnAzurirajPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajPredmet.Location = new System.Drawing.Point(11, 150);
            this.btnAzurirajPredmet.Name = "btnAzurirajPredmet";
            this.btnAzurirajPredmet.Size = new System.Drawing.Size(471, 132);
            this.btnAzurirajPredmet.TabIndex = 8;
            this.btnAzurirajPredmet.Text = "UNESI - AZURIRAJ - IZBRISI PREDMET";
            this.btnAzurirajPredmet.UseVisualStyleBackColor = true;
            this.btnAzurirajPredmet.Click += new System.EventHandler(this.btnAzurirajPredmet_Click);
            // 
            // btnPrikaziStatistiku
            // 
            this.btnPrikaziStatistiku.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziStatistiku.Location = new System.Drawing.Point(11, 288);
            this.btnPrikaziStatistiku.Name = "btnPrikaziStatistiku";
            this.btnPrikaziStatistiku.Size = new System.Drawing.Size(948, 132);
            this.btnPrikaziStatistiku.TabIndex = 10;
            this.btnPrikaziStatistiku.Text = "PRIKAZI STATISTIKU STUDENATA PO PREDMETU";
            this.btnPrikaziStatistiku.UseVisualStyleBackColor = true;
            this.btnPrikaziStatistiku.Click += new System.EventHandler(this.btnPrikaziStatistiku_Click);
            // 
            // FrmAdministracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 500);
            this.Controls.Add(this.btnPrikaziStatistiku);
            this.Controls.Add(this.btnPrikaziListu);
            this.Controls.Add(this.btnAzurirajPredmet);
            this.Controls.Add(this.btnAzurirajStudenta);
            this.Controls.Add(this.btnAzurirajSmer);
            this.Controls.Add(this.btnNazad);
            this.Name = "FrmAdministracija";
            this.Text = "Administracija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administracija_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdministracija_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnAzurirajSmer;
        private System.Windows.Forms.Button btnAzurirajStudenta;
        private System.Windows.Forms.Button btnPrikaziListu;
        private System.Windows.Forms.Button btnAzurirajPredmet;
        private System.Windows.Forms.Button btnPrikaziStatistiku;
    }
}