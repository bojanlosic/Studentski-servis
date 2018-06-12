namespace WindowsFormsApplication1
{
    partial class FrmStudent
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
            this.btnUnesiStudenta = new System.Windows.Forms.Button();
            this.btnAzurirajStudenta = new System.Windows.Forms.Button();
            this.btnIzbrisiStudenta = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.tbJmbg = new System.Windows.Forms.TextBox();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.lblUnesi = new System.Windows.Forms.Label();
            this.lblAzuriraj = new System.Windows.Forms.Label();
            this.lblIzbrisi = new System.Windows.Forms.Label();
            this.lbIspiStudenta = new System.Windows.Forms.ListBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.gbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUnesiStudenta
            // 
            this.btnUnesiStudenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesiStudenta.Location = new System.Drawing.Point(12, 12);
            this.btnUnesiStudenta.Name = "btnUnesiStudenta";
            this.btnUnesiStudenta.Size = new System.Drawing.Size(256, 87);
            this.btnUnesiStudenta.TabIndex = 0;
            this.btnUnesiStudenta.Text = "UNESI STUDENTA";
            this.btnUnesiStudenta.UseVisualStyleBackColor = true;
            this.btnUnesiStudenta.Click += new System.EventHandler(this.btnUnesiStudenta_Click);
            // 
            // btnAzurirajStudenta
            // 
            this.btnAzurirajStudenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajStudenta.Location = new System.Drawing.Point(12, 105);
            this.btnAzurirajStudenta.Name = "btnAzurirajStudenta";
            this.btnAzurirajStudenta.Size = new System.Drawing.Size(256, 87);
            this.btnAzurirajStudenta.TabIndex = 1;
            this.btnAzurirajStudenta.Text = "AZURIRAJ STUDENTA";
            this.btnAzurirajStudenta.UseVisualStyleBackColor = true;
            this.btnAzurirajStudenta.Click += new System.EventHandler(this.btnAzurirajStudenta_Click);
            // 
            // btnIzbrisiStudenta
            // 
            this.btnIzbrisiStudenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiStudenta.Location = new System.Drawing.Point(12, 198);
            this.btnIzbrisiStudenta.Name = "btnIzbrisiStudenta";
            this.btnIzbrisiStudenta.Size = new System.Drawing.Size(256, 87);
            this.btnIzbrisiStudenta.TabIndex = 2;
            this.btnIzbrisiStudenta.Text = "IZBRISI STUDENTA";
            this.btnIzbrisiStudenta.UseVisualStyleBackColor = true;
            this.btnIzbrisiStudenta.Click += new System.EventHandler(this.btnIzbrisiStudenta_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(6, 68);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(87, 25);
            this.lblIndex.TabIndex = 3;
            this.lblIndex.Text = "INDEX:";
            // 
            // tbIndex
            // 
            this.tbIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIndex.Location = new System.Drawing.Point(132, 66);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(197, 29);
            this.tbIndex.TabIndex = 4;
            // 
            // tbIme
            // 
            this.tbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIme.Location = new System.Drawing.Point(132, 113);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(197, 29);
            this.tbIme.TabIndex = 6;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(6, 115);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(59, 25);
            this.lblIme.TabIndex = 5;
            this.lblIme.Text = "IME:";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrezime.Location = new System.Drawing.Point(132, 162);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(197, 29);
            this.tbPrezime.TabIndex = 8;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(6, 164);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(119, 25);
            this.lblPrezime.TabIndex = 7;
            this.lblPrezime.Text = "PREZIME:";
            // 
            // tbJmbg
            // 
            this.tbJmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJmbg.Location = new System.Drawing.Point(132, 212);
            this.tbJmbg.Name = "tbJmbg";
            this.tbJmbg.Size = new System.Drawing.Size(197, 29);
            this.tbJmbg.TabIndex = 10;
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJmbg.Location = new System.Drawing.Point(6, 214);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(82, 25);
            this.lblJmbg.TabIndex = 9;
            this.lblJmbg.Text = "JMBG:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefon.Location = new System.Drawing.Point(132, 260);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(197, 29);
            this.tbTelefon.TabIndex = 12;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(6, 264);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(123, 25);
            this.lblTelefon.TabIndex = 11;
            this.lblTelefon.Text = "TELEFON:";
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(12, 291);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(256, 87);
            this.btnNazad.TabIndex = 13;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.btnPotvrdi);
            this.gbEdit.Controls.Add(this.lblIzbrisi);
            this.gbEdit.Controls.Add(this.lblAzuriraj);
            this.gbEdit.Controls.Add(this.lblUnesi);
            this.gbEdit.Controls.Add(this.lblIndex);
            this.gbEdit.Controls.Add(this.tbIndex);
            this.gbEdit.Controls.Add(this.tbTelefon);
            this.gbEdit.Controls.Add(this.lblIme);
            this.gbEdit.Controls.Add(this.lblTelefon);
            this.gbEdit.Controls.Add(this.tbIme);
            this.gbEdit.Controls.Add(this.tbJmbg);
            this.gbEdit.Controls.Add(this.lblPrezime);
            this.gbEdit.Controls.Add(this.lblJmbg);
            this.gbEdit.Controls.Add(this.tbPrezime);
            this.gbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEdit.Location = new System.Drawing.Point(303, 12);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(341, 368);
            this.gbEdit.TabIndex = 14;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "STUDENT";
            this.gbEdit.Visible = false;
            // 
            // lblUnesi
            // 
            this.lblUnesi.AutoSize = true;
            this.lblUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnesi.Location = new System.Drawing.Point(127, 31);
            this.lblUnesi.Name = "lblUnesi";
            this.lblUnesi.Size = new System.Drawing.Size(98, 29);
            this.lblUnesi.TabIndex = 13;
            this.lblUnesi.Text = "UNESI:";
            // 
            // lblAzuriraj
            // 
            this.lblAzuriraj.AutoSize = true;
            this.lblAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzuriraj.Location = new System.Drawing.Point(127, 31);
            this.lblAzuriraj.Name = "lblAzuriraj";
            this.lblAzuriraj.Size = new System.Drawing.Size(141, 29);
            this.lblAzuriraj.TabIndex = 14;
            this.lblAzuriraj.Text = "AZURIRAJ:";
            // 
            // lblIzbrisi
            // 
            this.lblIzbrisi.AutoSize = true;
            this.lblIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzbrisi.Location = new System.Drawing.Point(127, 31);
            this.lblIzbrisi.Name = "lblIzbrisi";
            this.lblIzbrisi.Size = new System.Drawing.Size(108, 29);
            this.lblIzbrisi.TabIndex = 15;
            this.lblIzbrisi.Text = "IZBRISI:";
            // 
            // lbIspiStudenta
            // 
            this.lbIspiStudenta.FormattingEnabled = true;
            this.lbIspiStudenta.Location = new System.Drawing.Point(650, 35);
            this.lbIspiStudenta.Name = "lbIspiStudenta";
            this.lbIspiStudenta.Size = new System.Drawing.Size(601, 342);
            this.lbIspiStudenta.TabIndex = 15;
            this.lbIspiStudenta.Visible = false;
            this.lbIspiStudenta.SelectedIndexChanged += new System.EventHandler(this.lbIspiStudenta_SelectedIndexChanged);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(11, 303);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(318, 59);
            this.btnPotvrdi.TabIndex = 16;
            this.btnPotvrdi.Text = "POTVRDI";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 392);
            this.Controls.Add(this.lbIspiStudenta);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnIzbrisiStudenta);
            this.Controls.Add(this.btnAzurirajStudenta);
            this.Controls.Add(this.btnUnesiStudenta);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStudent_FormClosing);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnesiStudenta;
        private System.Windows.Forms.Button btnAzurirajStudenta;
        private System.Windows.Forms.Button btnIzbrisiStudenta;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox tbJmbg;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Label lblUnesi;
        private System.Windows.Forms.Label lblIzbrisi;
        private System.Windows.Forms.Label lblAzuriraj;
        private System.Windows.Forms.ListBox lbIspiStudenta;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}