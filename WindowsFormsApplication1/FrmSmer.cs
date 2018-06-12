using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class FrmSmer : Form
    {
        string putanjaSmerovi;
        Smer smerZaAzuriranje;
        string idPrePromene = "";
        string nazivPrePromene = "";
        public FrmSmer()
        {
            InitializeComponent();
            putanjaSmerovi = "smerovi.bin";
        }

        private void frmSmer_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            // ============================== UNOS =================================
            if (lblUnesiSmer.Visible == true)
            {
                if (File.Exists(putanjaSmerovi))
                {
                    List<Smer> deserijalizovanaLista = new List<Smer>();
                    BinaryFormatter bfr = new BinaryFormatter();
                    FileStream fsr = File.OpenRead(putanjaSmerovi);
                    deserijalizovanaLista = bfr.Deserialize(fsr) as List<Smer>;
                    fsr.Dispose();
                    if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                    {
                        MessageBox.Show("Polja moraju biti popunjena!");
                        return;
                    }
                    int idSmera;
                    bool uspesno = int.TryParse(textBox1.Text, out idSmera);
                    if (uspesno)
                    {
                        string imeSmera = textBox2.Text.ToUpper();
                        if (!Regex.IsMatch(imeSmera, @"^[a-zA-Z]+$"))
                        {
                            MessageBox.Show("Unesi krstena slova kume!");
                            textBox2.Clear();
                            textBox2.Focus();
                        }
                        else
                        { 
                            Smer smer = new Smer(idSmera, imeSmera);
                            if (!proveraIdNaziv(deserijalizovanaLista, smer))
                            {
                                dodajSmer(deserijalizovanaLista, smer, "Smer je uspesno dodat.");
                                textBox1.Clear();
                                textBox2.Clear();
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Za ID smera mozete uneti samo broj!");
                    }
                }
                else
                {
                    if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                    {
                        MessageBox.Show("Polja moraju biti popunjena!");
                        return;
                    }
                    int idSmera;
                    bool uspesno = int.TryParse(textBox1.Text, out idSmera);
                    if (uspesno)
                    {
                        string imeSmera = textBox2.Text.ToUpper();
                        List<Smer> deserijalizovanaLista = new List<Smer>();
                        Smer smer = new Smer(idSmera, imeSmera);
                        if (!proveraIdNaziv(deserijalizovanaLista, smer))
                        {
                            dodajSmer(deserijalizovanaLista, smer, "Smer je uspesno dodat.");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Za ID smera mozete uneti samo broj!");
                    }
                }
            }
            // ===================================== AZURIRANJE =============================
            else if (lblAzurirajSmer.Visible == true)
            {
                if (File.Exists(putanjaSmerovi))
                {
                    BinaryFormatter bfr = new BinaryFormatter();

                    List<Smer> deserijalizovanaLista = new List<Smer>();
                    FileStream fsr = File.OpenRead(putanjaSmerovi);
                    deserijalizovanaLista = bfr.Deserialize(fsr) as List<Smer>;
                    fsr.Dispose();
                    fsr.Close();
                    
                    int idSmera;
                    int.TryParse(textBox1.Text, out idSmera);
                    string imeSmera = textBox2.Text.ToUpper();
                    Smer smer = new Smer(idSmera, imeSmera);

                    if (proveraIdNaziv(deserijalizovanaLista, smer))
                    {
                        return;
                    }
                    
                    // OVO SAM SANJAO JTZM!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    if (File.Exists("studenti.bin"))
                    {
                        List<Student> listaStudenata = new List<Student>();
                        List<Student> novaListaStudenata = new List<Student>();
                        FileStream fsrs = File.OpenRead("studenti.bin");
                        listaStudenata = bfr.Deserialize(fsrs) as List<Student>;
                        fsrs.Dispose();
                        fsrs.Close();

                        foreach (Student item in listaStudenata)
                        {
                            if (item.Smer.NazivSmera.ToString().Equals(nazivPrePromene))
                            {
                                item.Smer = smer;
                                string temp = item.Indeks.ToString();
                                string samoBroj = temp.Substring(temp.LastIndexOf('-'));
                                temp = smer.NazivSmera + samoBroj;
                                item.Indeks = temp;

                                if (File.Exists(nazivPrePromene + samoBroj.Replace("-", "").Replace("/", "") + ".bin"))
                                {
                                    List<Predmet> listaPredmeta = new List<Predmet>();
                                    List<Predmet> novaListaPredmeta = new List<Predmet>();
                                    FileStream auVise = File.OpenRead(nazivPrePromene + samoBroj.Replace("-", "").Replace("/", "") + ".bin");
                                    listaPredmeta = bfr.Deserialize(auVise) as List<Predmet>;
                                    auVise.Dispose();
                                    auVise.Close();
                                    foreach (Predmet maDaj in listaPredmeta)
                                    {
                                        if (maDaj.Smer.NazivSmera.ToString().Equals(nazivPrePromene))
                                        {
                                            maDaj.Smer = smer;
                                        }
                                        novaListaPredmeta.Add(maDaj);
                                    }
                                    FileStream neMoguDaVerujem = new FileStream(temp.Replace("-", "").Replace("/", "") + ".bin", FileMode.Create, FileAccess.Write);
                                    BinaryFormatter bfwer = new BinaryFormatter();
                                    bfwer.Serialize(neMoguDaVerujem, novaListaPredmeta);
                                    neMoguDaVerujem.Dispose();
                                    neMoguDaVerujem.Close();
                                    File.Delete(nazivPrePromene + samoBroj.Replace("-", "").Replace("/", "") + ".bin");
                                }
                                
                            }
                            
                            novaListaStudenata.Add(item);
                            
                        }
                        
                        FileStream fsw = new FileStream("studenti.bin", FileMode.Create, FileAccess.Write);
                        BinaryFormatter bfw = new BinaryFormatter();
                        bfw.Serialize(fsw, novaListaStudenata);
                        fsw.Dispose();
                        fsw.Close();
                    }
                    if (File.Exists("predmeti.bin"))
                    {
                        List<Predmet> listaPredmeta = new List<Predmet>();
                        List<Predmet> novaListaPredmeta = new List<Predmet>();
                        FileStream fsrp = File.OpenRead("predmeti.bin");
                        listaPredmeta = bfr.Deserialize(fsrp) as List<Predmet>;
                        fsrp.Dispose();
                        fsrp.Close();

                        foreach (Predmet item in listaPredmeta)
                        {
                            if (item.Smer.NazivSmera.ToString().Equals(nazivPrePromene))
                            {
                                item.Smer = smer;
                            }
                            novaListaPredmeta.Add(item);
                            
                        }
                        FileStream fsw = new FileStream("predmeti.bin", FileMode.Create, FileAccess.Write);
                        BinaryFormatter bfw = new BinaryFormatter();
                        bfw.Serialize(fsw, listaPredmeta);
                        fsw.Dispose();
                        fsw.Close();
                    }
                    deserijalizovanaLista.RemoveAt(lbIspisSmera.SelectedIndex);

                    foreach (Smer item in deserijalizovanaLista)
                    {
                        if (item.IdSmer.Equals(smer.IdSmer))
                        {
                            MessageBox.Show("Ne mozete dodati smer sa istim ID-jem");
                            return;
                        }
                        if (item.NazivSmera.Equals(smer.NazivSmera))
                        {
                            MessageBox.Show("Ne mozete dodati smer sa istim nazivom");
                            return;
                        }
                    }
                    dodajSmer(deserijalizovanaLista, smer, "Smer je uspesno azuriran.");
                }
            }
            // ===================================== BRISANJE ==============================
            else if (lblIzbrisiSmer.Visible == true)
            {
                if (File.Exists(putanjaSmerovi))
                {
                    List<Smer> deserijalizovanaLista = new List<Smer>();
                    BinaryFormatter bfr = new BinaryFormatter();
                    FileStream fsr = File.OpenRead(putanjaSmerovi);
                    deserijalizovanaLista = bfr.Deserialize(fsr) as List<Smer>;
                    fsr.Dispose();

                    int idSmera;
                    int.TryParse(textBox1.Text, out idSmera);
                    string imeSmera = textBox2.Text.ToUpper();
                    Smer smer = new Smer(idSmera, imeSmera);
                    if (File.Exists("studenti.bin"))
                    {
                        List<Student> listaStudenata = new List<Student>();
                        List<Student> novaListaStudenata = new List<Student>();
                        FileStream fsrs = File.OpenRead("studenti.bin");
                        listaStudenata = bfr.Deserialize(fsrs) as List<Student>;
                        fsrs.Dispose();
                        fsrs.Close();

                        foreach (Student item in listaStudenata)
                        {
                            if (!item.Smer.NazivSmera.ToString().Equals(nazivPrePromene))
                            {
                                novaListaStudenata.Add(item);
                                
                            }
                        }
                        FileStream fsw1 = new FileStream("studenti.bin", FileMode.Create, FileAccess.Write);
                        BinaryFormatter bfw = new BinaryFormatter();
                        bfw.Serialize(fsw1, novaListaStudenata);
                        fsw1.Dispose();
                        fsw1.Close();
                    }
                    if (File.Exists("predmeti.bin"))
                    {
                        List<Predmet> listaPredmeta = new List<Predmet>();
                        List<Predmet> novaListaPredmeta = new List<Predmet>();
                        FileStream fsrp = File.OpenRead("predmeti.bin");
                        listaPredmeta = bfr.Deserialize(fsrp) as List<Predmet>;
                        fsrp.Dispose();
                        fsrp.Close();

                        foreach (Predmet item in listaPredmeta)
                        {
                            if (!item.Smer.NazivSmera.ToString().Equals(nazivPrePromene))
                            {
                                novaListaPredmeta.Add(item);
                            }
                        }
                        FileStream fsw2 = new FileStream("predmeti.bin", FileMode.Create, FileAccess.Write);
                        BinaryFormatter bfw = new BinaryFormatter();
                        bfw.Serialize(fsw2, novaListaPredmeta);
                        fsw2.Dispose();
                        fsw2.Close();
                    }

                    deserijalizovanaLista.RemoveAt(lbIspisSmera.SelectedIndex);

                    FileStream fsw = new FileStream(putanjaSmerovi, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fsw, deserijalizovanaLista);
                    fsw.Close();
                    fsw.Dispose();
                    lbIspisSmera.DataSource = deserijalizovanaLista;
                }
            }
        }
        // ===================== DUGME ZA NAZAD ========================
        private void btnNazad_Click(object sender, EventArgs e)
        {
            FrmAdministracija frmAdministracija = new FrmAdministracija();
            frmAdministracija.Show();
            this.Hide();
        }
        // ===================== DUGME ZA UNESI SMER ========================
        private void btnUnesiSmer_Click(object sender, EventArgs e)
        {
            lblUnesiSmer.Visible = true;
            lblAzurirajSmer.Visible = false;
            lblIzbrisiSmer.Visible = false;
            lblIdSmera.Visible = true;
            lblNazivSmera.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            btnPotvrdi.Visible = true;
            lbIspisSmera.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Focus();
            proveraPostojanjaDatoteke();
        }
        // ===================== DUGME ZA AZURIRAJ SMER ========================
        private void btnAzurirajSmer_Click(object sender, EventArgs e)
        {
            lblUnesiSmer.Visible = false;
            lblAzurirajSmer.Visible = true;
            lblIzbrisiSmer.Visible = false;
            lblIdSmera.Visible = true;
            lblNazivSmera.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            btnPotvrdi.Visible = true;
            lbIspisSmera.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            proveraPostojanjaDatoteke();
            if (!File.Exists(putanjaSmerovi))
            {
                MessageBox.Show("Trenutno ne postoji nijedan smer da biste ga azurirali!");
                btnUnesiSmer_Click(sender, e);
            }
            //MessageBox.Show("Kliknite na smer koji zelite da azurirate, zatim unesite nove vrednosti, a zatim na dugme Potvrdi");
        }
        // ===================== DUGME ZA IZBRISI SMER ========================
        private void btnIzbrisiSmer_Click(object sender, EventArgs e)
        {
            lblUnesiSmer.Visible = false;
            lblAzurirajSmer.Visible = false;
            lblIzbrisiSmer.Visible = true;
            lblIdSmera.Visible = true;
            lblNazivSmera.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            btnPotvrdi.Visible = true;
            lbIspisSmera.Visible = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            proveraPostojanjaDatoteke();
            if (!File.Exists(putanjaSmerovi))
            {
                MessageBox.Show("Trenutno ne postoji nijedan smer da biste ga obrisali!");
                btnUnesiSmer_Click(sender, e);
            }
            //MessageBox.Show("Kliknite na smer koji zelite da izbrisete, a zatim na dugme Potvrdi");
        }
        // ===================================================== PROVERA ZA ID I NAZIV ============================
        private bool proveraIdNaziv(List<Smer> lista, Smer smer)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Polja moraju biti popunjena!");
                return true;
            }
            if (!Regex.IsMatch(textBox1.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Unesi krstene brojeve za ID kume!");
                textBox1.Clear();
                textBox1.Focus();
                return true;
            }
            if (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Unesi krstena slova za naziv kume!");
                textBox2.Clear();
                textBox2.Focus();
                return true;
            }
            if (!lblAzurirajSmer.Visible)
            {
                foreach (Smer item in lista)
                {
                    if (item.IdSmer.Equals(smer.IdSmer))
                    {
                        MessageBox.Show("Ne mozete dodati smer sa istim ID-jem");
                        return true;
                    }
                    if (item.NazivSmera.Equals(smer.NazivSmera))
                    {
                        MessageBox.Show("Ne mozete dodati smer sa istim nazivom");
                        return true;
                    }
                }
            }
            
            return false;
        }
        // ================================================ DODAJ SMER ============================================
        private void dodajSmer(List<Smer> lista, Smer smer, string komentar)
        {
            lista.Add(smer);
            //MessageBox.Show(komentar);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            FileStream fsw = new FileStream(putanjaSmerovi, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fsw, lista);
            fsw.Close();
            fsw.Dispose();
            lbIspisSmera.DataSource = lista;
        }
        // ===================================== PROVERA POSTOJANJA DATOTEKE ======================================
        private void proveraPostojanjaDatoteke()
        {
            if (File.Exists(putanjaSmerovi))
            {
                List<Smer> deserijalizovanaLista = new List<Smer>();
                BinaryFormatter bfr = new BinaryFormatter();
                FileStream fsr = File.OpenRead(putanjaSmerovi);
                deserijalizovanaLista = bfr.Deserialize(fsr) as List<Smer>;
                lbIspisSmera.DataSource = deserijalizovanaLista;
                fsr.Dispose();
            }
        }

        private void lbIspisSmera_SelectedIndexChanged(object sender, EventArgs e)
        {
            smerZaAzuriranje = lbIspisSmera.SelectedItem as Smer;
            if (lblAzurirajSmer.Visible == true || lblIzbrisiSmer.Visible == true)
            {
                textBox1.Text = smerZaAzuriranje.IdSmer.ToString();
                textBox2.Text = smerZaAzuriranje.NazivSmera.ToString();
                idPrePromene = smerZaAzuriranje.IdSmer.ToString();
                nazivPrePromene = smerZaAzuriranje.NazivSmera.ToString();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
