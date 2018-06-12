using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmPredmet : Form
    {
        FrmAdministracija frmAdministracija = new FrmAdministracija();
        string putanjaPredmet;
        string putanjaStudent;
        string putanjaSmer;
        BinaryFormatter bfr;
        BinaryFormatter bfw;
        FileStream fsr;
        FileStream fsw;
        Predmet predmetPrePromene;

        string idPrePromene;
        string nazivPrePromene;
        string profesorPrePromene;
        Smer smerPrePromene;
        string espbPrePromene;
        string semestarPrePromene;
        bool obavezanPrePromene;

        public FrmPredmet()
        {
            InitializeComponent();
            putanjaPredmet = "predmeti.bin";
            putanjaStudent = "studenti.bin";
            putanjaSmer = "smerovi.bin";
            bfr = new BinaryFormatter();
            bfw = new BinaryFormatter();
            predmetPrePromene = new Predmet();
        }

        private void FrmPredmet_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        // VRATI SE NA ADMINISTRACIJU
        private void btnNazad_Click(object sender, EventArgs e)
        {
            frmAdministracija.Show();
            this.Hide();
        }
        // UNESI PREDMET
        private void btnUnesiPredmet_Click(object sender, EventArgs e)
        {
            iscrtavanjeGrafike(true, true, true, false, false, true, true, true, true, true, true, true, true);
            tbIdPredmeta.Clear();
            tbIdPredmeta.Focus();
            tbNazivPredmeta.Clear();
            tbProfesor.Clear();
            // AKO IMA SMEROVA
            if (File.Exists(putanjaSmer))
            {
                dohvatiSmer();
            }
            cmbEspb.SelectedIndex = 4;
            cmbSemestar.SelectedIndex = 0;
            // AKO IMA PREDMETA
            if (File.Exists(putanjaPredmet))
            {
                ispisiUListBox();
            }
        }
        // AZURIRAJ PREDMET
        private void btnAzurirajPredmet_Click(object sender, EventArgs e)
        {
            iscrtavanjeGrafike(true, true, false, true, false, true, true, true, true, true, true, true, true);
            // AKO IMA SMEROVA
            if (File.Exists(putanjaSmer))
            {
                dohvatiSmer();
            }
            // AKO IMA PREDMETA
            if (File.Exists(putanjaPredmet))
            {
                ispisiUListBox();
            }
            else
            {
                MessageBox.Show("eeej KUME, nema nijedan predmet da se AZURIRA!");
                btnUnesiPredmet_Click(sender, e);
            }
            
        }
        // IZBRISI PREDMET
        private void btnIzbrisiPredmet_Click(object sender, EventArgs e)
        {
            iscrtavanjeGrafike(true, true, false, false, true, false, false, false, false, false, false, false, false);
            // AKO IMA SMEROVA
            if (File.Exists(putanjaSmer))
            {
                dohvatiSmer();
            }
            // AKO IMA PREDMETA
            if (File.Exists(putanjaPredmet))
            {
                ispisiUListBox();
            }
            else
            {
                MessageBox.Show("eeej KUME, nema nijedan predmet da se IZBRISE!");
                btnUnesiPredmet_Click(sender, e);
            }
        }

        // DUGME POTVRDI
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            // ============================== UNOS PREDMETA =======================================
            if (lblUnesi.Visible == true && proveraKorektnostiUnosaZaPredmet())
            {
                // Ako fajl postoji dodaj jos jednog
                if (File.Exists(putanjaPredmet))
                {
                    // Pretrazi listu predmeta
                    List<Predmet> listaPredmeta = new List<Predmet>();
                    fsr = File.OpenRead(putanjaPredmet);
                    listaPredmeta = bfr.Deserialize(fsr) as List<Predmet>;
                    fsr.Dispose();
                    fsr.Close();
                    // Unesi predmet
                    unosPredmeta(listaPredmeta);
                }
                // Ako ne postoji kreiraj fajl sa prvim
                else
                {
                    // Napravi novu listu i unesi predmet
                    List<Predmet> listaPredmeta = new List<Predmet>();
                    unosPredmeta(listaPredmeta);
                }
            }
            // ============================== AZURIRANJE PREDMETA ==================================
            else if (lblAzuriraj.Visible == true && proveraKorektnostiUnosaZaPredmet())
            {
                // Ako fajl postoji izmeni
                if (File.Exists(putanjaPredmet))
                {
                    // Pretrazi listu predmeta
                    List<Predmet> listaPredmeta = new List<Predmet>();
                    fsr = File.OpenRead(putanjaPredmet);
                    listaPredmeta = bfr.Deserialize(fsr) as List<Predmet>;
                    fsr.Dispose();
                    fsr.Close();


                    // Brisi ljudima predmete iz liste
                    List<Student> listaStudenata = new List<Student>();
                    fsr = File.OpenRead(putanjaStudent);
                    listaStudenata = bfr.Deserialize(fsr) as List<Student>;
                    fsr.Dispose();
                    fsr.Close();

                    foreach (Student item in listaStudenata)
                    {
                        if (File.Exists(item.Indeks.ToString().Replace("-","").Replace("/","") + ".bin"))
                        {
                            List<Predmet> listaIzabranihPredmeta = new List<Predmet>();
                            List<Predmet> novaListaIzabranihPredmeta = new List<Predmet>();
                            FileStream citanjePredmeta = File.OpenRead(item.Indeks.ToString().Replace("-", "").Replace("/", "") + ".bin");
                            listaIzabranihPredmeta = bfr.Deserialize(citanjePredmeta) as List<Predmet>;
                            citanjePredmeta.Dispose();
                            citanjePredmeta.Close();

                            foreach (Predmet izabrani in listaIzabranihPredmeta)
                            {
                                if (izabrani.ToString().Equals(predmetPrePromene.ToString()))
                                {
                                    int espb;
                                    int.TryParse(cmbEspb.SelectedItem.ToString(), out espb);
                                    int semestar;
                                    int.TryParse(cmbSemestar.SelectedItem.ToString(), out semestar);
                                    bool obavezan = rbDa.Checked;
                                    Predmet noviPredmet = new Predmet(tbIdPredmeta.Text, tbNazivPredmeta.Text, cmbSmer.SelectedItem as Smer, tbProfesor.Text, espb, obavezan, semestar);
                                    novaListaIzabranihPredmeta.Add(noviPredmet);
                                }
                                else
                                {
                                    novaListaIzabranihPredmeta.Add(izabrani);
                                }
                            }
                            fsw = new FileStream(item.Indeks.ToString().Replace("-", "").Replace("/", "") + ".bin", FileMode.Create, FileAccess.Write);
                            bfw.Serialize(fsw, novaListaIzabranihPredmeta);
                            fsw.Dispose();
                            fsw.Close();
                        }
                    }


                    listaPredmeta.RemoveAt(lbIspisPredmeta.SelectedIndex);
                    foreach (Predmet item in listaPredmeta)
                    {
                        if (item.IdPredmeta.ToString().Equals(tbIdPredmeta.Text))
                        {
                            MessageBox.Show("Kume vec si uneo ovu sifru predmeta.");
                            tbIdPredmeta.Focus();
                            return;
                        }
                        if (item.Naziv.ToString().Equals(tbNazivPredmeta.Text))
                        {
                            MessageBox.Show("Kume vec si uneo ovaj naziv predmeta.");
                            tbIdPredmeta.Focus();
                            return;
                        }
                    }
                    unosPredmeta(listaPredmeta);
                }
            }
            // ============================== BRISANJE PREDMETA ====================================
            else if (lblIzbrisi.Visible == true)
            {
                // Ako fajl postoji izbrisi
                if (File.Exists(putanjaPredmet))
                {
                    // Pretrazi listu predmeta
                    List<Predmet> listaPredmeta = new List<Predmet>();
                    fsr = File.OpenRead(putanjaPredmet);
                    listaPredmeta = bfr.Deserialize(fsr) as List<Predmet>;
                    fsr.Dispose();
                    fsr.Close();

                    // Brisi ljudima predmete iz liste
                    List<Student> listaStudenata = new List<Student>();
                    fsr = File.OpenRead(putanjaStudent);
                    listaStudenata = bfr.Deserialize(fsr) as List<Student>;
                    fsr.Dispose();
                    fsr.Close();

                    foreach (Student item in listaStudenata)
                    {
                        if (File.Exists(item.Indeks.ToString().Replace("-", "").Replace("/", "") + ".bin"))
                        {
                            List<Predmet> listaIzabranihPredmeta = new List<Predmet>();
                            List<Predmet> novaListaIzabranihPredmeta = new List<Predmet>();
                            FileStream citanjePredmeta = File.OpenRead(item.Indeks.ToString().Replace("-", "").Replace("/", "") + ".bin");
                            listaIzabranihPredmeta = bfr.Deserialize(citanjePredmeta) as List<Predmet>;
                            citanjePredmeta.Dispose();
                            citanjePredmeta.Close();

                            foreach (Predmet izabrani in listaIzabranihPredmeta)
                            {
                                if (!izabrani.ToString().Equals(predmetPrePromene.ToString()))
                                {
                                    novaListaIzabranihPredmeta.Add(izabrani);
                                }
                            }
                            fsw = new FileStream(item.Indeks.ToString().Replace("-", "").Replace("/", "") + ".bin", FileMode.Create, FileAccess.Write);
                            bfw.Serialize(fsw, novaListaIzabranihPredmeta);
                            fsw.Dispose();
                            fsw.Close();
                        }
                    }

                    listaPredmeta.RemoveAt(lbIspisPredmeta.SelectedIndex);
                    fsw = new FileStream(putanjaPredmet, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bfe = new BinaryFormatter();
                    bfe.Serialize(fsw, listaPredmeta);
                    fsw.Close();
                    fsw.Dispose();
                    lbIspisPredmeta.DataSource = listaPredmeta;
                }
            }
        }
        // =========================================== PROVERA TACNOSTI PODATAKA ====================================
        private bool proveraKorektnostiUnosaZaPredmet()
        {
            if (lblAzuriraj.Visible != true)
            {
                if (File.Exists(putanjaPredmet))
                {
                    List<Predmet> listaPredmeta = new List<Predmet>();
                    fsr = File.OpenRead(putanjaPredmet);
                    listaPredmeta = bfr.Deserialize(fsr) as List<Predmet>;
                    fsr.Dispose();
                    fsr.Close();

                    foreach (Predmet item in listaPredmeta)
                    {
                        if (item.IdPredmeta.ToString().Equals(tbIdPredmeta.Text))
                        {
                            MessageBox.Show("Kume vec si uneo ovu sifru predmeta.");
                            tbIdPredmeta.Focus();
                            return false;
                        }
                        if (item.Naziv.ToString().Equals(tbNazivPredmeta.Text))
                        {
                            MessageBox.Show("Kume vec si uneo ovaj naziv predmeta.");
                            tbIdPredmeta.Focus();
                            return false;
                        }
                    }
                }
            }
            

            if (tbIdPredmeta.Text.Equals(""))
            {
                MessageBox.Show("Kume de ti je ID predmeta?");
                tbIdPredmeta.Focus();
                return false;
            }
            else if (!Regex.IsMatch(tbIdPredmeta.Text, @"^[0-9]{6}\z+$"))
            {
                MessageBox.Show("Unesi krstene brojeve za ID kume!");
                tbIdPredmeta.Clear();
                tbIdPredmeta.Focus();
                return false;
            }
            else if (tbNazivPredmeta.Text.Equals(""))
            {
                MessageBox.Show("Kume de ti je naziv predmeta?");
                tbNazivPredmeta.Focus();
                return false;
            }
            else if (!Regex.IsMatch(tbNazivPredmeta.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Unesi krstena slova za naziv kume!");
                tbNazivPredmeta.Clear();
                tbNazivPredmeta.Focus();
                return false;
            }
            else if (tbProfesor.Text.Equals(""))
            {
                MessageBox.Show("Kume a ko ga predaje?");
                tbProfesor.Focus();
                return false;
            }
            else if (!Regex.IsMatch(tbProfesor.Text, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Kako se stvarno zove profesor, nemoj da lazes!");
                tbProfesor.Clear();
                tbProfesor.Focus();
                return false;
            }
            return true;
        }
        // ISPIS U LISTBOX
        private void ispisiUListBox()
        {
            List<Predmet> listaPredmeta = new List<Predmet>();
            fsr = File.OpenRead(putanjaPredmet);
            listaPredmeta = bfr.Deserialize(fsr) as List<Predmet>;
            lbIspisPredmeta.DataSource = listaPredmeta;
            fsr.Dispose();
            fsr.Close();
        }
        // DOHVATANJE SMERA
        private void dohvatiSmer()
        {
            List<Smer> listaSmerova = new List<Smer>();
            fsr = File.OpenRead(putanjaSmer);
            listaSmerova = bfr.Deserialize(fsr) as List<Smer>;
            cmbSmer.DisplayMember = "nazivSmera";
            cmbSmer.ValueMember = "idSmer";
            //string[] listaStringSmerova = new string[listaSmerova.Count];
            //int i = 0;
            //foreach (Smer item in listaSmerova)
            //{
            //    string temp = item.ToString();
            //    listaStringSmerova[i++] = temp;
            //}
            cmbSmer.DataSource = listaSmerova;
            fsr.Dispose();
            fsr.Close();
        }
        // ISCRTAVANJE GRAFIKE
        private void iscrtavanjeGrafike(bool GroupBox, bool ListBox, bool LabelUnesi, bool LabelAzuriraj, bool LabelIzbrisi, bool tb1, bool tb2, bool cb1, bool tb3, bool cb2, bool cb3, bool rb1, bool rb2)
        {
            gbEdit.Visible = GroupBox;
            lbIspisPredmeta.Visible = ListBox;
            lblUnesi.Visible = LabelUnesi;
            lblAzuriraj.Visible = LabelAzuriraj;
            lblIzbrisi.Visible = LabelIzbrisi;
            tbIdPredmeta.Enabled = tb1;
            tbNazivPredmeta.Enabled = tb2;
            cmbSmer.Enabled = cb1;
            tbProfesor.Enabled = tb3;
            cmbEspb.Enabled = cb2;
            cmbSemestar.Enabled = cb3;
            rbDa.Enabled = rb1;
            rbNe.Enabled = rb2;
            tbIdPredmeta.Focus();
        }
        // PROMENA PREDMETA U LISTBOX
        private void lbIspisPredmeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Predmet izabraniPredmet = lbIspisPredmeta.SelectedItem as Predmet;
            if (lblAzuriraj.Visible == true || lblIzbrisi.Visible == true)
            {
                tbIdPredmeta.Text = izabraniPredmet.IdPredmeta;
                tbNazivPredmeta.Text = izabraniPredmet.Naziv;
                tbProfesor.Text = izabraniPredmet.Profesor;
                cmbEspb.SelectedItem = izabraniPredmet.Espb.ToString();

                cmbSmer.SelectedItem = izabraniPredmet.Smer.ToString();

                cmbSemestar.SelectedItem = izabraniPredmet.Semestar.ToString();
                rbDa.Checked = izabraniPredmet.Obavezan;
                rbNe.Checked = !izabraniPredmet.Obavezan;

                predmetPrePromene = izabraniPredmet;

                idPrePromene = izabraniPredmet.IdPredmeta.ToString();
                nazivPrePromene = izabraniPredmet.Naziv.ToString();
                profesorPrePromene = izabraniPredmet.Profesor.ToString();
                smerPrePromene = izabraniPredmet.Smer;
                semestarPrePromene = izabraniPredmet.Semestar.ToString();
                espbPrePromene = izabraniPredmet.Espb.ToString();
                obavezanPrePromene = izabraniPredmet.Obavezan;

            }
        }
        private void unosPredmeta(List<Predmet> lista)
        {
            
            string idPredmeta = tbIdPredmeta.Text;
            string nazivPredmeta = tbNazivPredmeta.Text;
            Smer smer = cmbSmer.SelectedItem as Smer;
            string profesor = tbProfesor.Text;
            int espb;
            int.TryParse(cmbEspb.SelectedItem.ToString(), out espb);
            int semestar;
            int.TryParse(cmbSemestar.SelectedItem.ToString(), out semestar);
            bool obavezan = rbDa.Checked;
            Predmet noviPredmet = new Predmet(idPredmeta, nazivPredmeta, smer, profesor, espb, obavezan, semestar);
            lista.Add(noviPredmet);
            fsw = new FileStream(putanjaPredmet, FileMode.Create, FileAccess.Write);
            bfw.Serialize(fsw, lista);
            fsw.Dispose();
            fsw.Close();
            tbIdPredmeta.Clear();
            tbNazivPredmeta.Clear();
            tbProfesor.Clear();
            tbIdPredmeta.Focus();
            lbIspisPredmeta.DataSource = lista;
        }
    }
}
