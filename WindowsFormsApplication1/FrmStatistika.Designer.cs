namespace WindowsFormsApplication1
{
    partial class FrmStatistika
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
            this.lblIzaberiPredmet = new System.Windows.Forms.Label();
            this.cmbIzaberiPredmet = new System.Windows.Forms.ComboBox();
            this.lblBrojStudenata = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.lblProcentualno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIzaberiPredmet
            // 
            this.lblIzaberiPredmet.AutoSize = true;
            this.lblIzaberiPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzaberiPredmet.Location = new System.Drawing.Point(13, 13);
            this.lblIzaberiPredmet.Name = "lblIzaberiPredmet";
            this.lblIzaberiPredmet.Size = new System.Drawing.Size(199, 24);
            this.lblIzaberiPredmet.TabIndex = 0;
            this.lblIzaberiPredmet.Text = "IZABERI PREDMET:";
            // 
            // cmbIzaberiPredmet
            // 
            this.cmbIzaberiPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzaberiPredmet.FormattingEnabled = true;
            this.cmbIzaberiPredmet.Location = new System.Drawing.Point(17, 41);
            this.cmbIzaberiPredmet.Name = "cmbIzaberiPredmet";
            this.cmbIzaberiPredmet.Size = new System.Drawing.Size(633, 21);
            this.cmbIzaberiPredmet.TabIndex = 1;
            this.cmbIzaberiPredmet.SelectedIndexChanged += new System.EventHandler(this.cmbIzaberiPredmet_SelectedIndexChanged);
            // 
            // lblBrojStudenata
            // 
            this.lblBrojStudenata.AutoSize = true;
            this.lblBrojStudenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojStudenata.Location = new System.Drawing.Point(17, 69);
            this.lblBrojStudenata.Name = "lblBrojStudenata";
            this.lblBrojStudenata.Size = new System.Drawing.Size(366, 24);
            this.lblBrojStudenata.TabIndex = 2;
            this.lblBrojStudenata.Text = "Broj studenata na ovom predmetu: XX";
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(636, 350);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(197, 71);
            this.btnNazad.TabIndex = 3;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // lblProcentualno
            // 
            this.lblProcentualno.AutoSize = true;
            this.lblProcentualno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcentualno.Location = new System.Drawing.Point(17, 93);
            this.lblProcentualno.Name = "lblProcentualno";
            this.lblProcentualno.Size = new System.Drawing.Size(157, 24);
            this.lblProcentualno.TabIndex = 4;
            this.lblProcentualno.Text = "Odnosno: 100%";
            // 
            // FrmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 433);
            this.Controls.Add(this.lblProcentualno);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.lblBrojStudenata);
            this.Controls.Add(this.cmbIzaberiPredmet);
            this.Controls.Add(this.lblIzaberiPredmet);
            this.Name = "FrmStatistika";
            this.Text = "FrmStatistika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStatistika_FormClosing);
            this.Load += new System.EventHandler(this.FrmStatistika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzaberiPredmet;
        private System.Windows.Forms.ComboBox cmbIzaberiPredmet;
        private System.Windows.Forms.Label lblBrojStudenata;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label lblProcentualno;
    }
}