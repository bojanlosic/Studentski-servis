namespace WindowsFormsApplication1
{
    partial class FrmSmer
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
            this.btnUnesiSmer = new System.Windows.Forms.Button();
            this.btnAzurirajSmer = new System.Windows.Forms.Button();
            this.btnIzbrisiSmer = new System.Windows.Forms.Button();
            this.lblUnesiSmer = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.lblAzurirajSmer = new System.Windows.Forms.Label();
            this.lblIzbrisiSmer = new System.Windows.Forms.Label();
            this.lblIdSmera = new System.Windows.Forms.Label();
            this.lblNazivSmera = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.lbIspisSmera = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUnesiSmer
            // 
            this.btnUnesiSmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesiSmer.Location = new System.Drawing.Point(13, 13);
            this.btnUnesiSmer.Name = "btnUnesiSmer";
            this.btnUnesiSmer.Size = new System.Drawing.Size(259, 62);
            this.btnUnesiSmer.TabIndex = 0;
            this.btnUnesiSmer.Text = "UNESI SMER";
            this.btnUnesiSmer.UseVisualStyleBackColor = true;
            this.btnUnesiSmer.Click += new System.EventHandler(this.btnUnesiSmer_Click);
            // 
            // btnAzurirajSmer
            // 
            this.btnAzurirajSmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajSmer.Location = new System.Drawing.Point(13, 99);
            this.btnAzurirajSmer.Name = "btnAzurirajSmer";
            this.btnAzurirajSmer.Size = new System.Drawing.Size(259, 62);
            this.btnAzurirajSmer.TabIndex = 1;
            this.btnAzurirajSmer.Text = "AZURIRAJ SMER";
            this.btnAzurirajSmer.UseVisualStyleBackColor = true;
            this.btnAzurirajSmer.Click += new System.EventHandler(this.btnAzurirajSmer_Click);
            // 
            // btnIzbrisiSmer
            // 
            this.btnIzbrisiSmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiSmer.Location = new System.Drawing.Point(13, 187);
            this.btnIzbrisiSmer.Name = "btnIzbrisiSmer";
            this.btnIzbrisiSmer.Size = new System.Drawing.Size(259, 62);
            this.btnIzbrisiSmer.TabIndex = 2;
            this.btnIzbrisiSmer.Text = "IZBRISI SMER";
            this.btnIzbrisiSmer.UseVisualStyleBackColor = true;
            this.btnIzbrisiSmer.Click += new System.EventHandler(this.btnIzbrisiSmer_Click);
            // 
            // lblUnesiSmer
            // 
            this.lblUnesiSmer.AutoSize = true;
            this.lblUnesiSmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnesiSmer.Location = new System.Drawing.Point(290, 12);
            this.lblUnesiSmer.Name = "lblUnesiSmer";
            this.lblUnesiSmer.Size = new System.Drawing.Size(171, 29);
            this.lblUnesiSmer.TabIndex = 3;
            this.lblUnesiSmer.Text = "UNESI SMER";
            this.lblUnesiSmer.Visible = false;
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(13, 274);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(259, 62);
            this.btnNazad.TabIndex = 4;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // lblAzurirajSmer
            // 
            this.lblAzurirajSmer.AutoSize = true;
            this.lblAzurirajSmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzurirajSmer.Location = new System.Drawing.Point(290, 12);
            this.lblAzurirajSmer.Name = "lblAzurirajSmer";
            this.lblAzurirajSmer.Size = new System.Drawing.Size(214, 29);
            this.lblAzurirajSmer.TabIndex = 5;
            this.lblAzurirajSmer.Text = "AZURIRAJ SMER";
            this.lblAzurirajSmer.Visible = false;
            // 
            // lblIzbrisiSmer
            // 
            this.lblIzbrisiSmer.AutoSize = true;
            this.lblIzbrisiSmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzbrisiSmer.Location = new System.Drawing.Point(290, 12);
            this.lblIzbrisiSmer.Name = "lblIzbrisiSmer";
            this.lblIzbrisiSmer.Size = new System.Drawing.Size(181, 29);
            this.lblIzbrisiSmer.TabIndex = 6;
            this.lblIzbrisiSmer.Text = "IZBRISI SMER";
            this.lblIzbrisiSmer.Visible = false;
            // 
            // lblIdSmera
            // 
            this.lblIdSmera.AutoSize = true;
            this.lblIdSmera.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSmera.Location = new System.Drawing.Point(290, 98);
            this.lblIdSmera.Name = "lblIdSmera";
            this.lblIdSmera.Size = new System.Drawing.Size(226, 29);
            this.lblIdSmera.TabIndex = 7;
            this.lblIdSmera.Text = "UNESI ID SMERA:";
            this.lblIdSmera.Visible = false;
            // 
            // lblNazivSmera
            // 
            this.lblNazivSmera.AutoSize = true;
            this.lblNazivSmera.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivSmera.Location = new System.Drawing.Point(290, 168);
            this.lblNazivSmera.Name = "lblNazivSmera";
            this.lblNazivSmera.Size = new System.Drawing.Size(274, 29);
            this.lblNazivSmera.TabIndex = 8;
            this.lblNazivSmera.Text = "UNESI NAZIV SMERA:";
            this.lblNazivSmera.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(570, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(570, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.Location = new System.Drawing.Point(570, 211);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(206, 125);
            this.btnPotvrdi.TabIndex = 11;
            this.btnPotvrdi.Text = "POTVRDI";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Visible = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // lbIspisSmera
            // 
            this.lbIspisSmera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIspisSmera.FormattingEnabled = true;
            this.lbIspisSmera.ItemHeight = 20;
            this.lbIspisSmera.Location = new System.Drawing.Point(782, 12);
            this.lbIspisSmera.Name = "lbIspisSmera";
            this.lbIspisSmera.Size = new System.Drawing.Size(473, 324);
            this.lbIspisSmera.TabIndex = 12;
            this.lbIspisSmera.Visible = false;
            this.lbIspisSmera.SelectedIndexChanged += new System.EventHandler(this.lbIspisSmera_SelectedIndexChanged);
            // 
            // FrmSmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 348);
            this.Controls.Add(this.lbIspisSmera);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNazivSmera);
            this.Controls.Add(this.lblIdSmera);
            this.Controls.Add(this.lblIzbrisiSmer);
            this.Controls.Add(this.lblAzurirajSmer);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.lblUnesiSmer);
            this.Controls.Add(this.btnIzbrisiSmer);
            this.Controls.Add(this.btnAzurirajSmer);
            this.Controls.Add(this.btnUnesiSmer);
            this.Name = "FrmSmer";
            this.Text = "frmSmer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSmer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnesiSmer;
        private System.Windows.Forms.Button btnAzurirajSmer;
        private System.Windows.Forms.Button btnIzbrisiSmer;
        private System.Windows.Forms.Label lblUnesiSmer;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label lblAzurirajSmer;
        private System.Windows.Forms.Label lblIzbrisiSmer;
        private System.Windows.Forms.Label lblIdSmera;
        private System.Windows.Forms.Label lblNazivSmera;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.ListBox lbIspisSmera;
    }
}