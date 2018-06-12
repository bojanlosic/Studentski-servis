namespace WindowsFormsApplication1
{
    partial class FrmPredmet
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
            this.lbIspisPredmeta = new System.Windows.Forms.ListBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.gbObavezan = new System.Windows.Forms.GroupBox();
            this.rbNe = new System.Windows.Forms.RadioButton();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.cmbSemestar = new System.Windows.Forms.ComboBox();
            this.lblSemestar = new System.Windows.Forms.Label();
            this.cmbEspb = new System.Windows.Forms.ComboBox();
            this.cmbSmer = new System.Windows.Forms.ComboBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.lblIzbrisi = new System.Windows.Forms.Label();
            this.lblAzuriraj = new System.Windows.Forms.Label();
            this.lblUnesi = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.tbIdPredmeta = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.tbNazivPredmeta = new System.Windows.Forms.TextBox();
            this.tbProfesor = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnIzbrisiPredmet = new System.Windows.Forms.Button();
            this.btnAzurirajPredmet = new System.Windows.Forms.Button();
            this.btnUnesiPredmet = new System.Windows.Forms.Button();
            this.smerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbEdit.SuspendLayout();
            this.gbObavezan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIspisPredmeta
            // 
            this.lbIspisPredmeta.FormattingEnabled = true;
            this.lbIspisPredmeta.Location = new System.Drawing.Point(672, 35);
            this.lbIspisPredmeta.Name = "lbIspisPredmeta";
            this.lbIspisPredmeta.Size = new System.Drawing.Size(671, 485);
            this.lbIspisPredmeta.TabIndex = 21;
            this.lbIspisPredmeta.Visible = false;
            this.lbIspisPredmeta.SelectedIndexChanged += new System.EventHandler(this.lbIspisPredmeta_SelectedIndexChanged);
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.gbObavezan);
            this.gbEdit.Controls.Add(this.cmbSemestar);
            this.gbEdit.Controls.Add(this.lblSemestar);
            this.gbEdit.Controls.Add(this.cmbEspb);
            this.gbEdit.Controls.Add(this.cmbSmer);
            this.gbEdit.Controls.Add(this.btnPotvrdi);
            this.gbEdit.Controls.Add(this.lblIzbrisi);
            this.gbEdit.Controls.Add(this.lblAzuriraj);
            this.gbEdit.Controls.Add(this.lblUnesi);
            this.gbEdit.Controls.Add(this.lblIndex);
            this.gbEdit.Controls.Add(this.tbIdPredmeta);
            this.gbEdit.Controls.Add(this.lblIme);
            this.gbEdit.Controls.Add(this.lblTelefon);
            this.gbEdit.Controls.Add(this.tbNazivPredmeta);
            this.gbEdit.Controls.Add(this.tbProfesor);
            this.gbEdit.Controls.Add(this.lblPrezime);
            this.gbEdit.Controls.Add(this.lblJmbg);
            this.gbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEdit.Location = new System.Drawing.Point(303, 12);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(363, 506);
            this.gbEdit.TabIndex = 20;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "PREDMET";
            this.gbEdit.Visible = false;
            // 
            // gbObavezan
            // 
            this.gbObavezan.Controls.Add(this.rbNe);
            this.gbObavezan.Controls.Add(this.rbDa);
            this.gbObavezan.Location = new System.Drawing.Point(11, 362);
            this.gbObavezan.Name = "gbObavezan";
            this.gbObavezan.Size = new System.Drawing.Size(346, 73);
            this.gbObavezan.TabIndex = 25;
            this.gbObavezan.TabStop = false;
            this.gbObavezan.Text = "OBAVEZAN";
            // 
            // rbNe
            // 
            this.rbNe.AutoSize = true;
            this.rbNe.Location = new System.Drawing.Point(263, 26);
            this.rbNe.Name = "rbNe";
            this.rbNe.Size = new System.Drawing.Size(67, 33);
            this.rbNe.TabIndex = 25;
            this.rbNe.TabStop = true;
            this.rbNe.Text = "NE";
            this.rbNe.UseVisualStyleBackColor = true;
            // 
            // rbDa
            // 
            this.rbDa.AutoSize = true;
            this.rbDa.Checked = true;
            this.rbDa.Location = new System.Drawing.Point(173, 26);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(65, 33);
            this.rbDa.TabIndex = 24;
            this.rbDa.TabStop = true;
            this.rbDa.Text = "DA";
            this.rbDa.UseVisualStyleBackColor = true;
            // 
            // cmbSemestar
            // 
            this.cmbSemestar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemestar.FormattingEnabled = true;
            this.cmbSemestar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbSemestar.Location = new System.Drawing.Point(160, 311);
            this.cmbSemestar.Name = "cmbSemestar";
            this.cmbSemestar.Size = new System.Drawing.Size(197, 32);
            this.cmbSemestar.TabIndex = 24;
            // 
            // lblSemestar
            // 
            this.lblSemestar.AutoSize = true;
            this.lblSemestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestar.Location = new System.Drawing.Point(6, 313);
            this.lblSemestar.Name = "lblSemestar";
            this.lblSemestar.Size = new System.Drawing.Size(128, 25);
            this.lblSemestar.TabIndex = 21;
            this.lblSemestar.Text = "SMESTAR:";
            // 
            // cmbEspb
            // 
            this.cmbEspb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspb.FormattingEnabled = true;
            this.cmbEspb.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbEspb.Location = new System.Drawing.Point(160, 262);
            this.cmbEspb.Name = "cmbEspb";
            this.cmbEspb.Size = new System.Drawing.Size(197, 32);
            this.cmbEspb.TabIndex = 20;
            // 
            // cmbSmer
            // 
            this.cmbSmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSmer.FormattingEnabled = true;
            this.cmbSmer.Location = new System.Drawing.Point(160, 162);
            this.cmbSmer.Name = "cmbSmer";
            this.cmbSmer.Size = new System.Drawing.Size(197, 32);
            this.cmbSmer.TabIndex = 19;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(11, 441);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(346, 59);
            this.btnPotvrdi.TabIndex = 16;
            this.btnPotvrdi.Text = "POTVRDI";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
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
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(6, 68);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(41, 25);
            this.lblIndex.TabIndex = 3;
            this.lblIndex.Text = "ID:";
            // 
            // tbIdPredmeta
            // 
            this.tbIdPredmeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdPredmeta.Location = new System.Drawing.Point(160, 66);
            this.tbIdPredmeta.Name = "tbIdPredmeta";
            this.tbIdPredmeta.Size = new System.Drawing.Size(197, 29);
            this.tbIdPredmeta.TabIndex = 4;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(6, 115);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(85, 25);
            this.lblIme.TabIndex = 5;
            this.lblIme.Text = "NAZIV:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(6, 264);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(79, 25);
            this.lblTelefon.TabIndex = 11;
            this.lblTelefon.Text = "ESPB:";
            // 
            // tbNazivPredmeta
            // 
            this.tbNazivPredmeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNazivPredmeta.Location = new System.Drawing.Point(160, 113);
            this.tbNazivPredmeta.Name = "tbNazivPredmeta";
            this.tbNazivPredmeta.Size = new System.Drawing.Size(197, 29);
            this.tbNazivPredmeta.TabIndex = 6;
            // 
            // tbProfesor
            // 
            this.tbProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfesor.Location = new System.Drawing.Point(160, 212);
            this.tbProfesor.Name = "tbProfesor";
            this.tbProfesor.Size = new System.Drawing.Size(197, 29);
            this.tbProfesor.TabIndex = 10;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(6, 164);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(84, 25);
            this.lblPrezime.TabIndex = 7;
            this.lblPrezime.Text = "SMER:";
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJmbg.Location = new System.Drawing.Point(6, 214);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(144, 25);
            this.lblJmbg.TabIndex = 9;
            this.lblJmbg.Text = "PROFESOR:";
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(12, 425);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(256, 87);
            this.btnNazad.TabIndex = 19;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnIzbrisiPredmet
            // 
            this.btnIzbrisiPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiPredmet.Location = new System.Drawing.Point(12, 198);
            this.btnIzbrisiPredmet.Name = "btnIzbrisiPredmet";
            this.btnIzbrisiPredmet.Size = new System.Drawing.Size(256, 87);
            this.btnIzbrisiPredmet.TabIndex = 18;
            this.btnIzbrisiPredmet.Text = "IZBRISI PREDMET";
            this.btnIzbrisiPredmet.UseVisualStyleBackColor = true;
            this.btnIzbrisiPredmet.Click += new System.EventHandler(this.btnIzbrisiPredmet_Click);
            // 
            // btnAzurirajPredmet
            // 
            this.btnAzurirajPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajPredmet.Location = new System.Drawing.Point(12, 105);
            this.btnAzurirajPredmet.Name = "btnAzurirajPredmet";
            this.btnAzurirajPredmet.Size = new System.Drawing.Size(256, 87);
            this.btnAzurirajPredmet.TabIndex = 17;
            this.btnAzurirajPredmet.Text = "AZURIRAJ PREDMET";
            this.btnAzurirajPredmet.UseVisualStyleBackColor = true;
            this.btnAzurirajPredmet.Click += new System.EventHandler(this.btnAzurirajPredmet_Click);
            // 
            // btnUnesiPredmet
            // 
            this.btnUnesiPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesiPredmet.Location = new System.Drawing.Point(12, 12);
            this.btnUnesiPredmet.Name = "btnUnesiPredmet";
            this.btnUnesiPredmet.Size = new System.Drawing.Size(256, 87);
            this.btnUnesiPredmet.TabIndex = 16;
            this.btnUnesiPredmet.Text = "UNESI PREDMET";
            this.btnUnesiPredmet.UseVisualStyleBackColor = true;
            this.btnUnesiPredmet.Click += new System.EventHandler(this.btnUnesiPredmet_Click);
            // 
            // FrmPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 524);
            this.Controls.Add(this.lbIspisPredmeta);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnIzbrisiPredmet);
            this.Controls.Add(this.btnAzurirajPredmet);
            this.Controls.Add(this.btnUnesiPredmet);
            this.Name = "FrmPredmet";
            this.Text = "FrmPredmet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPredmet_FormClosing);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.gbObavezan.ResumeLayout(false);
            this.gbObavezan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbIspisPredmeta;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label lblIzbrisi;
        private System.Windows.Forms.Label lblAzuriraj;
        private System.Windows.Forms.Label lblUnesi;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.TextBox tbIdPredmeta;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox tbNazivPredmeta;
        private System.Windows.Forms.TextBox tbProfesor;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnIzbrisiPredmet;
        private System.Windows.Forms.Button btnAzurirajPredmet;
        private System.Windows.Forms.Button btnUnesiPredmet;
        private System.Windows.Forms.BindingSource smerBindingSource;
        private System.Windows.Forms.ComboBox cmbEspb;
        private System.Windows.Forms.ComboBox cmbSmer;
        private System.Windows.Forms.Label lblSemestar;
        private System.Windows.Forms.ComboBox cmbSemestar;
        private System.Windows.Forms.GroupBox gbObavezan;
        private System.Windows.Forms.RadioButton rbNe;
        private System.Windows.Forms.RadioButton rbDa;
    }
}