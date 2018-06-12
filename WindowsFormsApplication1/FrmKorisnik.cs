using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmKorisnik : Form
    {
        FileStream fsr;
        FileStream fsw;
        BinaryFormatter bfr;
        BinaryFormatter bfw;
        CheckBox[] cb;
        Student ulogovanStudent;
        List<Student> listaStudenata;
        
        List<Predmet> listaPredmeta;
        List<Predmet> listaPredmetaSaMaticnogSmera;
        List<Predmet> listaPredmetaSaDrugogSmera;
        List<Predmet> listaIzabranihPredmeta;
        Predmet predmetSaDrugogSmera;
        int suma = 0;
        string putanjaPredmet;
        string putanjaStudent;
        string indeksStudentaPotvrda;
        string nastavakZaDatoteku = ".bin";
        string temp;
        public FrmKorisnik()
        {
            InitializeComponent();
            bfr = new BinaryFormatter();
            bfw = new BinaryFormatter();
            
        }

        private void Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            FrmPocetna frmPocetna = new FrmPocetna();
            frmPocetna.Show();
            this.Hide();
        }

        private void FrmKorisnik_Load(object sender, EventArgs e)
        {
            putanjaPredmet = "predmeti.bin";
            putanjaStudent = "studenti.bin";

            // PRONADJI ULOGOVANOG STUDENTA
            indeksStudentaPotvrda = FrmPocetna.indeksStudenta;
            listaStudenata = new List<Student>();
            ulogovanStudent = new Student();
            fsr = File.OpenRead(putanjaStudent);
            listaStudenata = bfr.Deserialize(fsr) as List<Student>;
            fsr.Dispose();
            fsr.Close();
            foreach (Student item in listaStudenata)
            {
                if (indeksStudentaPotvrda.Equals(item.Indeks.ToString()))
                {
                    ulogovanStudent = item;
                    break;
                }
            }
            temp = ulogovanStudent.Indeks.ToString() + nastavakZaDatoteku;
            temp = temp.Replace("-", "").Replace("/", "");
            // AKO JE POSLAO LISTU ======================================================================================
            if (File.Exists(temp))
            {
                listaIzabranihPredmeta = new List<Predmet>();
                listaPredmeta = new List<Predmet>();
                listaPredmetaSaMaticnogSmera = new List<Predmet>();
                listaPredmetaSaDrugogSmera = new List<Predmet>();
                predmetSaDrugogSmera = new Predmet();
                // svi predmeti
                fsr = File.OpenRead(putanjaPredmet);
                listaPredmeta = bfr.Deserialize(fsr) as List<Predmet>;
                fsr.Dispose();
                fsr.Close();
                // samo izabrani predmeti
                fsr = File.OpenRead(temp);
                listaIzabranihPredmeta = bfr.Deserialize(fsr) as List<Predmet>;
                fsr.Dispose();
                fsr.Close();
                //dodaj u liste sa maticnog i drugog smera
                foreach (Predmet item in listaPredmeta)
                {
                    if (item.Smer.NazivSmera.ToString().Equals(ulogovanStudent.Smer.NazivSmera.ToString()))
                    {
                        listaPredmetaSaMaticnogSmera.Add(item);
                    }
                    else
                    {
                        listaPredmetaSaDrugogSmera.Add(item);
                    }
                }

                cmbDrugiSmer.DataSource = listaPredmetaSaDrugogSmera;
                // dodaj ako ima predmeta sa drugog smera
                for (int i = 0; i < listaPredmetaSaDrugogSmera.Count; i++)
                {
                    foreach (Predmet item in listaIzabranihPredmeta)
                    {
                        if (listaPredmetaSaDrugogSmera[i].ToString().Equals(item.ToString()))
                        {
                            cmbDrugiSmer.Enabled = true;
                            cmbDrugiSmer.SelectedItem = listaPredmetaSaDrugogSmera;
                            rbDa.Checked = true;
                            break;
                        }
                    }
                }
                cb = new CheckBox[listaPredmetaSaMaticnogSmera.Count];
                listaPredmetaSaMaticnogSmera = listaPredmetaSaMaticnogSmera.OrderBy(o => o.Semestar).ThenBy(o => o.Naziv).ToList();
                listBox1.DataSource = listaPredmeta;
                for (int i = 0; i < listaPredmetaSaMaticnogSmera.Count; i++)
                {
                    cb[i] = new CheckBox();
                    foreach (Predmet item in listaIzabranihPredmeta)
                    {
                        if (listaPredmetaSaMaticnogSmera[i].ToString().Equals(item.ToString()))
                        {
                            cb[i].Checked = true;
                            if (listaPredmetaSaMaticnogSmera[i].Obavezan == true)
                            {
                                cb[i].Enabled = false;
                            }
                            else
                            {
                                cb[i].Enabled = true;
                            }
                            int pom;
                            int.TryParse(listaPredmetaSaMaticnogSmera[i].Espb.ToString(), out pom);
                            suma += pom;
                            break;
                        }
                        else
                        {
                            cb[i].Checked = false;
                        }
                    }
                    cb[i].Text = listaPredmetaSaMaticnogSmera[i].Naziv.ToString() + ", Semestar: " + listaPredmetaSaMaticnogSmera[i].Semestar.ToString();
                    cb[i].Width = 300;
                    cb[i].Click += cb_Click;
                    cb[i].Top = i * 25;
                    cb[i].Left = 20;
                    this.Controls.Add(cb[i]);
                }
                

                if (suma < 48)
                {
                    btnPosalji.Enabled = false;
                }
                else
                {
                    btnPosalji.Enabled = true;
                }
                lblSuma.Text = "ESPB: " + suma.ToString();

            }
            // AKO NIJE POSLAO LISTU ===================================================================================
            else
            {
                // DODAJ SVE PREDMETE SA MATICNOG SMERA ULOGOVANOG STUDENTA
                listaPredmeta = new List<Predmet>();
                listaPredmetaSaMaticnogSmera = new List<Predmet>();
                listaPredmetaSaDrugogSmera = new List<Predmet>();
                predmetSaDrugogSmera = new Predmet();
                fsr = File.OpenRead(putanjaPredmet);
                listaPredmeta = bfr.Deserialize(fsr) as List<Predmet>;
                fsr.Dispose();
                fsr.Close();

                foreach (Predmet item in listaPredmeta)
                {
                    if (item.Smer.NazivSmera.ToString().Equals(ulogovanStudent.Smer.NazivSmera.ToString()))
                    {
                        listaPredmetaSaMaticnogSmera.Add(item);
                    }
                    else
                    {
                        listaPredmetaSaDrugogSmera.Add(item);
                    }
                }
                cmbDrugiSmer.DataSource = listaPredmetaSaDrugogSmera;
                cb = new CheckBox[listaPredmetaSaMaticnogSmera.Count];
                listaPredmetaSaMaticnogSmera = listaPredmetaSaMaticnogSmera.OrderBy(o => o.Semestar).ThenBy(o => o.Naziv).ToList();
                listBox1.DataSource = listaPredmeta;
                for (int i = 0; i < listaPredmetaSaMaticnogSmera.Count; i++)
                {
                    cb[i] = new CheckBox();
                    if (listaPredmetaSaMaticnogSmera[i].Obavezan == true)
                    {
                        cb[i].Checked = true;
                        cb[i].Enabled = false;
                        int pom;
                        int.TryParse(listaPredmetaSaMaticnogSmera[i].Espb.ToString(), out pom);
                        suma += pom;
                    }
                    else
                    {
                        cb[i].Checked = false;
                    }
                    cb[i].Text = listaPredmetaSaMaticnogSmera[i].Naziv.ToString() + ", Semestar: " + listaPredmetaSaMaticnogSmera[i].Semestar.ToString();
                    cb[i].Width = 300;
                    cb[i].Click += cb_Click;
                    cb[i].Top = i * 25;
                    cb[i].Left = 20;
                    this.Controls.Add(cb[i]);
                }
                if (suma < 48)
                {
                    btnPosalji.Enabled = false;
                }
                else
                {
                    btnPosalji.Enabled = true;
                }
                lblSuma.Text = "ESPB: " + suma.ToString();
            }
        }
        // CHECKBOX CLICK EVENT
        private void cb_Click(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            if (c.Checked && suma < 60)
            {
                foreach (Predmet item in listaPredmetaSaMaticnogSmera)
                {
                    if (c.Text.Equals(item.Naziv.ToString() + ", Semestar: " + item.Semestar.ToString()))
                    {
                        int pom;
                        int.TryParse(item.Espb.ToString(), out pom);
                        suma += pom;
                    }
                }
            }
            else if (c.Checked && suma >= 60)
            {
                MessageBox.Show("De ces, ne moze vise, samo 60 ESPB po godini, ne bahati se!");
                c.Checked = false;
            }
            else
            {
                foreach (Predmet item in listaPredmetaSaMaticnogSmera)
                {
                    if (c.Text.Equals(item.Naziv.ToString() + ", Semestar: " + item.Semestar.ToString()))
                    {
                        int pom;
                        int.TryParse(item.Espb.ToString(), out pom);
                        suma -= pom;
                    }
                }
            }
            if (suma < 48)
            {
                btnPosalji.Enabled = false;
            }
            else
            {
                btnPosalji.Enabled = true;
            }
            lblSuma.Text = "ESPB: " + suma.ToString();
        }
        // RADIO BUTTON =========================================================================
        private void rbDa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDa.Checked && suma == 60)
            {
                MessageBox.Show("Maksimalno je dozvoljeno 60 ESPB po godini!");
                rbDa.Checked = false;
                rbNe.Checked = true;
                return;
            }
            if (rbDa.Checked)
            {
                cmbDrugiSmer.Enabled = true;
                foreach (Predmet item in listaPredmetaSaDrugogSmera)
                {
                    if (item.ToString().Equals(cmbDrugiSmer.SelectedItem.ToString()))
                    {
                        int pom;
                        int.TryParse(item.Espb.ToString(), out pom);
                        suma += pom;
                    }
                }
            }
            if (rbNe.Checked)
            {
                cmbDrugiSmer.Enabled = false;
                foreach (Predmet item in listaPredmetaSaDrugogSmera)
                {
                    if (item.ToString().Equals(cmbDrugiSmer.SelectedItem.ToString()))
                    {
                        int pom;
                        int.TryParse(item.Espb.ToString(), out pom);
                        suma -= pom;

                    }
                }
            }
            if (suma < 48)
            {
                btnPosalji.Enabled = false;
            }
            else
            {
                btnPosalji.Enabled = true;
            }
            lblSuma.Text = "ESPB: " + suma.ToString();
        }

        private void cmbDrugiSmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            predmetSaDrugogSmera = cmbDrugiSmer.SelectedItem as Predmet;
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            List<Predmet> konacnaListaPredmetaZaStudenta = new List<Predmet>();
            for (int i = 0; i < cb.Length; i++)
            {
                if (cb[i].Checked)
                {
                    foreach (Predmet item in listaPredmetaSaMaticnogSmera)
                    {
                        if (cb[i].Text.Equals(item.Naziv.ToString() + ", Semestar: " + item.Semestar.ToString()))
                        {
                            konacnaListaPredmetaZaStudenta.Add(item);
                            break;
                        }
                    }
                }
            }
            if (cmbDrugiSmer.Enabled)
            {
                konacnaListaPredmetaZaStudenta.Add(predmetSaDrugogSmera);
            }
            string temp = ulogovanStudent.Indeks.ToString() + nastavakZaDatoteku;
            temp = temp.Replace("-", "").Replace("/", "");
            fsw = new FileStream(temp, FileMode.Create, FileAccess.Write);
            bfw.Serialize(fsw, konacnaListaPredmetaZaStudenta);
            fsw.Dispose();
            fsw.Close();
            FrmPocetna frmPocetna = new FrmPocetna();
            frmPocetna.Show();
            this.Hide();
        }
    }
}
