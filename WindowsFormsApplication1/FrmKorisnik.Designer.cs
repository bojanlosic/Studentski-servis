namespace WindowsFormsApplication1
{
    partial class FrmKorisnik
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.cmbDrugiSmer = new System.Windows.Forms.ComboBox();
            this.gbDrugiSmer = new System.Windows.Forms.GroupBox();
            this.rbNe = new System.Windows.Forms.RadioButton();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDrugiSmer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(12, 481);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(158, 55);
            this.btnNazad.TabIndex = 0;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(429, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(736, 407);
            this.listBox1.TabIndex = 1;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(12, 449);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(26, 29);
            this.lblSuma.TabIndex = 2;
            this.lblSuma.Text = "0";
            // 
            // cmbDrugiSmer
            // 
            this.cmbDrugiSmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrugiSmer.Enabled = false;
            this.cmbDrugiSmer.FormattingEnabled = true;
            this.cmbDrugiSmer.Location = new System.Drawing.Point(6, 59);
            this.cmbDrugiSmer.Name = "cmbDrugiSmer";
            this.cmbDrugiSmer.Size = new System.Drawing.Size(724, 21);
            this.cmbDrugiSmer.TabIndex = 3;
            this.cmbDrugiSmer.SelectedIndexChanged += new System.EventHandler(this.cmbDrugiSmer_SelectedIndexChanged);
            // 
            // gbDrugiSmer
            // 
            this.gbDrugiSmer.Controls.Add(this.rbNe);
            this.gbDrugiSmer.Controls.Add(this.rbDa);
            this.gbDrugiSmer.Controls.Add(this.cmbDrugiSmer);
            this.gbDrugiSmer.Location = new System.Drawing.Point(429, 12);
            this.gbDrugiSmer.Name = "gbDrugiSmer";
            this.gbDrugiSmer.Size = new System.Drawing.Size(736, 86);
            this.gbDrugiSmer.TabIndex = 5;
            this.gbDrugiSmer.TabStop = false;
            this.gbDrugiSmer.Text = "DA LI ZELITE PREDMET SA DRUGOG SMERA (MAX 1)";
            // 
            // rbNe
            // 
            this.rbNe.AutoSize = true;
            this.rbNe.Checked = true;
            this.rbNe.Location = new System.Drawing.Point(142, 26);
            this.rbNe.Name = "rbNe";
            this.rbNe.Size = new System.Drawing.Size(40, 17);
            this.rbNe.TabIndex = 5;
            this.rbNe.TabStop = true;
            this.rbNe.Text = "NE";
            this.rbNe.UseVisualStyleBackColor = true;
            // 
            // rbDa
            // 
            this.rbDa.AutoSize = true;
            this.rbDa.Location = new System.Drawing.Point(68, 26);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(40, 17);
            this.rbDa.TabIndex = 4;
            this.rbDa.Text = "DA";
            this.rbDa.UseVisualStyleBackColor = true;
            this.rbDa.CheckedChanged += new System.EventHandler(this.rbDa_CheckedChanged);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosalji.Location = new System.Drawing.Point(176, 481);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(170, 54);
            this.btnPosalji.TabIndex = 6;
            this.btnPosalji.Text = "POSALJI LISTU";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "SVI PREDMETI:";
            // 
            // FrmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.gbDrugiSmer);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnNazad);
            this.Name = "FrmKorisnik";
            this.Text = "Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Student_FormClosing);
            this.Load += new System.EventHandler(this.FrmKorisnik_Load);
            this.gbDrugiSmer.ResumeLayout(false);
            this.gbDrugiSmer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.ComboBox cmbDrugiSmer;
        private System.Windows.Forms.GroupBox gbDrugiSmer;
        private System.Windows.Forms.RadioButton rbNe;
        private System.Windows.Forms.RadioButton rbDa;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label label1;
    }
}