namespace WindowsFormsApplication1
{
    partial class FrmIzborna
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
            this.lbNeizabrani = new System.Windows.Forms.ListBox();
            this.lbIzabrani = new System.Windows.Forms.ListBox();
            this.lbIzabraniDrugi = new System.Windows.Forms.ListBox();
            this.lbNeizabraniDrugi = new System.Windows.Forms.ListBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.lblIzaberiStudenta = new System.Windows.Forms.Label();
            this.lblBrojBodova = new System.Windows.Forms.Label();
            this.btnPrebaciUIzabrane = new System.Windows.Forms.Button();
            this.btnIzbaciIzIzabranih = new System.Windows.Forms.Button();
            this.btnIzbaciIzDrugog = new System.Windows.Forms.Button();
            this.btnDodajSaDrugog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPredaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(952, 12);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(192, 63);
            this.btnNazad.TabIndex = 0;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // lbNeizabrani
            // 
            this.lbNeizabrani.FormattingEnabled = true;
            this.lbNeizabrani.Location = new System.Drawing.Point(12, 108);
            this.lbNeizabrani.Name = "lbNeizabrani";
            this.lbNeizabrani.Size = new System.Drawing.Size(545, 251);
            this.lbNeizabrani.TabIndex = 1;
            this.lbNeizabrani.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbNeizabrani_KeyDown);
            // 
            // lbIzabrani
            // 
            this.lbIzabrani.FormattingEnabled = true;
            this.lbIzabrani.Location = new System.Drawing.Point(599, 107);
            this.lbIzabrani.Name = "lbIzabrani";
            this.lbIzabrani.Size = new System.Drawing.Size(545, 251);
            this.lbIzabrani.TabIndex = 2;
            // 
            // lbIzabraniDrugi
            // 
            this.lbIzabraniDrugi.FormattingEnabled = true;
            this.lbIzabraniDrugi.Location = new System.Drawing.Point(599, 390);
            this.lbIzabraniDrugi.Name = "lbIzabraniDrugi";
            this.lbIzabraniDrugi.Size = new System.Drawing.Size(545, 251);
            this.lbIzabraniDrugi.TabIndex = 4;
            // 
            // lbNeizabraniDrugi
            // 
            this.lbNeizabraniDrugi.FormattingEnabled = true;
            this.lbNeizabraniDrugi.Location = new System.Drawing.Point(12, 391);
            this.lbNeizabraniDrugi.Name = "lbNeizabraniDrugi";
            this.lbNeizabraniDrugi.Size = new System.Drawing.Size(545, 251);
            this.lbNeizabraniDrugi.TabIndex = 3;
            // 
            // cmbStudent
            // 
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(12, 40);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(545, 21);
            this.cmbStudent.TabIndex = 5;
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            // 
            // lblIzaberiStudenta
            // 
            this.lblIzaberiStudenta.AutoSize = true;
            this.lblIzaberiStudenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzaberiStudenta.Location = new System.Drawing.Point(13, 13);
            this.lblIzaberiStudenta.Name = "lblIzaberiStudenta";
            this.lblIzaberiStudenta.Size = new System.Drawing.Size(163, 24);
            this.lblIzaberiStudenta.TabIndex = 6;
            this.lblIzaberiStudenta.Text = "Izaberi studenta:";
            // 
            // lblBrojBodova
            // 
            this.lblBrojBodova.AutoSize = true;
            this.lblBrojBodova.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojBodova.Location = new System.Drawing.Point(595, 40);
            this.lblBrojBodova.Name = "lblBrojBodova";
            this.lblBrojBodova.Size = new System.Drawing.Size(86, 24);
            this.lblBrojBodova.TabIndex = 7;
            this.lblBrojBodova.Text = "ESPB: 0";
            // 
            // btnPrebaciUIzabrane
            // 
            this.btnPrebaciUIzabrane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrebaciUIzabrane.Location = new System.Drawing.Point(563, 205);
            this.btnPrebaciUIzabrane.Name = "btnPrebaciUIzabrane";
            this.btnPrebaciUIzabrane.Size = new System.Drawing.Size(30, 29);
            this.btnPrebaciUIzabrane.TabIndex = 8;
            this.btnPrebaciUIzabrane.Text = ">";
            this.btnPrebaciUIzabrane.UseVisualStyleBackColor = true;
            this.btnPrebaciUIzabrane.Click += new System.EventHandler(this.btnPrebaciUIzabrane_Click);
            // 
            // btnIzbaciIzIzabranih
            // 
            this.btnIzbaciIzIzabranih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbaciIzIzabranih.Location = new System.Drawing.Point(563, 234);
            this.btnIzbaciIzIzabranih.Name = "btnIzbaciIzIzabranih";
            this.btnIzbaciIzIzabranih.Size = new System.Drawing.Size(30, 29);
            this.btnIzbaciIzIzabranih.TabIndex = 9;
            this.btnIzbaciIzIzabranih.Text = "<";
            this.btnIzbaciIzIzabranih.UseVisualStyleBackColor = true;
            this.btnIzbaciIzIzabranih.Click += new System.EventHandler(this.btnIzbaciIzIzabranih_Click);
            // 
            // btnIzbaciIzDrugog
            // 
            this.btnIzbaciIzDrugog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbaciIzDrugog.Location = new System.Drawing.Point(563, 522);
            this.btnIzbaciIzDrugog.Name = "btnIzbaciIzDrugog";
            this.btnIzbaciIzDrugog.Size = new System.Drawing.Size(30, 29);
            this.btnIzbaciIzDrugog.TabIndex = 11;
            this.btnIzbaciIzDrugog.Text = "<";
            this.btnIzbaciIzDrugog.UseVisualStyleBackColor = true;
            this.btnIzbaciIzDrugog.Click += new System.EventHandler(this.btnIzbaciIzDrugog_Click);
            // 
            // btnDodajSaDrugog
            // 
            this.btnDodajSaDrugog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSaDrugog.Location = new System.Drawing.Point(563, 493);
            this.btnDodajSaDrugog.Name = "btnDodajSaDrugog";
            this.btnDodajSaDrugog.Size = new System.Drawing.Size(30, 29);
            this.btnDodajSaDrugog.TabIndex = 10;
            this.btnDodajSaDrugog.Text = ">";
            this.btnDodajSaDrugog.UseVisualStyleBackColor = true;
            this.btnDodajSaDrugog.Click += new System.EventHandler(this.btnDodajSaDrugog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista predmeta sa maticnog smera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lista izabranih predmeta sa maticnog smera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Lista izabranih predmeta sa drugog smera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Lista predmeta sa drugog smera";
            // 
            // btnPredaj
            // 
            this.btnPredaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredaj.Location = new System.Drawing.Point(754, 12);
            this.btnPredaj.Name = "btnPredaj";
            this.btnPredaj.Size = new System.Drawing.Size(192, 63);
            this.btnPredaj.TabIndex = 16;
            this.btnPredaj.Text = "PREDAJ";
            this.btnPredaj.UseVisualStyleBackColor = true;
            this.btnPredaj.Click += new System.EventHandler(this.btnPredaj_Click);
            // 
            // FrmIzborna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 646);
            this.Controls.Add(this.btnPredaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzbaciIzDrugog);
            this.Controls.Add(this.btnDodajSaDrugog);
            this.Controls.Add(this.btnIzbaciIzIzabranih);
            this.Controls.Add(this.btnPrebaciUIzabrane);
            this.Controls.Add(this.lblBrojBodova);
            this.Controls.Add(this.lblIzaberiStudenta);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.lbIzabraniDrugi);
            this.Controls.Add(this.lbNeizabraniDrugi);
            this.Controls.Add(this.lbIzabrani);
            this.Controls.Add(this.lbNeizabrani);
            this.Controls.Add(this.btnNazad);
            this.Name = "FrmIzborna";
            this.Text = "FrmIzborna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIzborna_FormClosing);
            this.Load += new System.EventHandler(this.FrmIzborna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.ListBox lbNeizabrani;
        private System.Windows.Forms.ListBox lbIzabrani;
        private System.Windows.Forms.ListBox lbIzabraniDrugi;
        private System.Windows.Forms.ListBox lbNeizabraniDrugi;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label lblIzaberiStudenta;
        private System.Windows.Forms.Label lblBrojBodova;
        private System.Windows.Forms.Button btnPrebaciUIzabrane;
        private System.Windows.Forms.Button btnIzbaciIzIzabranih;
        private System.Windows.Forms.Button btnIzbaciIzDrugog;
        private System.Windows.Forms.Button btnDodajSaDrugog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPredaj;
    }
}