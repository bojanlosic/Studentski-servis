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
    public partial class FrmStudent : Form
    {
        string putanjaStudent;
        string datumRodjenja;
        string indeksPrePromene;
        Student lbStudent;
        Smer postojeciSmer;
        public FrmStudent()
        {
            InitializeComponent();
            putanjaStudent = "studenti.bin";
        }

        private void FrmStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnUnesiStudenta_Click(object sender, EventArgs e)
        {
            lblUnesi.Visible = true;
            lblAzuriraj.Visible = false;
            lblIzbrisi.Visible = false;
            gbEdit.Visible = true;
            lbIspiStudenta.Visible = true;
            tbIme.Enabled = true;
            tbIme.Text = "";
            tbPrezime.Enabled = true;
            tbPrezime.Text = "";
            tbIndex.Enabled = true;
            tbIndex.Text = "";
            tbJmbg.Enabled = true;
            tbJmbg.Text = "";
            tbTelefon.Enabled = true;
            tbTelefon.Text = "";

            tbIndex.Focus();
            if (File.Exists(putanjaStudent))
            {
                List<Student> listaStudenata = new List<Student>();
                FileStream fsr = File.OpenRead(putanjaStudent);
                BinaryFormatter bf = new BinaryFormatter();
                listaStudenata = bf.Deserialize(fsr) as List<Student>;
                lbIspiStudenta.DataSource = listaStudenata;
                fsr.Dispose();
            }
            
        }

        private void btnAzurirajStudenta_Click(object sender, EventArgs e)
        {
            lblUnesi.Visible = false;
            lblAzuriraj.Visible = true;
            lblIzbrisi.Visible = false;
            gbEdit.Visible = true;
            lbIspiStudenta.Visible = true;
            tbIme.Enabled = true;
            tbPrezime.Enabled = true;
            tbIndex.Enabled = true;
            tbJmbg.Enabled = true;
            tbTelefon.Enabled = true;
            tbIndex.Focus();
            if (File.Exists(putanjaStudent))
            {
                List<Student> listaStudenata = new List<Student>();
                FileStream fsr = File.OpenRead(putanjaStudent);
                BinaryFormatter bf = new BinaryFormatter();
                listaStudenata = bf.Deserialize(fsr) as List<Student>;
                lbIspiStudenta.DataSource = listaStudenata;
                fsr.Dispose();
            }
            else
            {
                MessageBox.Show("EEEJ KUME, PA NEMA STUDENATA ZA AZURIRANJE!");
                btnUnesiStudenta_Click(sender, e);
            }
        }

        private void btnIzbrisiStudenta_Click(object sender, EventArgs e)
        {
            lblUnesi.Visible = false;
            lblAzuriraj.Visible = false;
            lblIzbrisi.Visible = true;
            gbEdit.Visible = true;
            lbIspiStudenta.Visible = true;
            tbIme.Enabled = false;
            tbPrezime.Enabled = false;
            tbIndex.Enabled = false;
            tbJmbg.Enabled = false;
            tbTelefon.Enabled = false;
            tbIndex.Focus();
            if (File.Exists(putanjaStudent))
            {
                List<Student> listaStudenata = new List<Student>();
                FileStream fsr = File.OpenRead(putanjaStudent);
                BinaryFormatter bf = new BinaryFormatter();
                listaStudenata = bf.Deserialize(fsr) as List<Student>;
                lbIspiStudenta.DataSource = listaStudenata;
                fsr.Dispose();
            }
            else
            {
                MessageBox.Show("EEEJ KUME, PA NEMA STUDENATA ZA BRISANJE!");
                btnUnesiStudenta_Click(sender, e);
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            FrmAdministracija frmAdministracija = new FrmAdministracija();
            frmAdministracija.Show();
            this.Hide();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            // ========================== UNOS STUDENTA =========================
            if (lblUnesi.Visible == true)
            {
                if (File.Exists(putanjaStudent))
                {
                    if (proveraIspravnostiPodataka())
                    {
                        List<Student> listaStudenata = new List<Student>();
                        FileStream fsr = File.OpenRead(putanjaStudent);
                        BinaryFormatter bf = new BinaryFormatter();
                        listaStudenata = bf.Deserialize(fsr) as List<Student>;
                        fsr.Dispose();
                        fsr.Close();

                        Student noviStudent = new Student(tbIme.Text, tbPrezime.Text, tbJmbg.Text, datumRodjenja, tbIndex.Text.ToUpper(), tbTelefon.Text, postojeciSmer);
                        dodajStudenta(listaStudenata, noviStudent);
                    }
                }
                else
                {
                    if (proveraIspravnostiPodataka())
                    {
                        List<Student> listaStudenata = new List<Student>();

                        Student noviStudent = new Student(tbIme.Text, tbPrezime.Text, tbJmbg.Text, datumRodjenja, tbIndex.Text.ToUpper(), tbTelefon.Text, postojeciSmer);
                        dodajStudenta(listaStudenata, noviStudent);
                    }
                }
            }
            // ========================== AZURIRANJE STUDENTA =========================
            else if (lblAzuriraj.Visible == true)
            {
                if (File.Exists(putanjaStudent))
                {
                    if (proveraIspravnostiPodataka())
                    {
                        List<Student> listaStudenata = new List<Student>();
                        List<Student> novaListaStudenata = new List<Student>();
                        FileStream fsr = File.OpenRead(putanjaStudent);
                        BinaryFormatter bf = new BinaryFormatter();
                        listaStudenata = bf.Deserialize(fsr) as List<Student>;
                        fsr.Dispose();
                        fsr.Close();
                        listaStudenata.RemoveAt(lbIspiStudenta.SelectedIndex);
                        Student izabraniStudent = new Student(tbIme.Text, tbPrezime.Text, tbJmbg.Text, datumRodjenja, tbIndex.Text.ToUpper(), tbTelefon.Text, postojeciSmer);
                        
                        if (File.Exists(indeksPrePromene.ToString().Replace("-","").Replace("/","") + ".bin"))
                        {
                            File.Copy(indeksPrePromene.ToString().Replace("-", "").Replace("/", "") + ".bin", tbIndex.Text.ToUpper().Replace("-", "").Replace("/", "") + ".bin");
                            File.Delete(indeksPrePromene.ToString().Replace("-", "").Replace("/", "") + ".bin");
                        }
                        foreach (Student item in listaStudenata)
                        {
                            if (item.Indeks.Equals(izabraniStudent.Indeks))
                            {
                                MessageBox.Show("Ne mozete dodati studenta sa istim indeksom");
                                return;
                            }
                            if (item.Jmbg.Equals(izabraniStudent.Jmbg))
                            {
                                MessageBox.Show("Ne mozete dodati studenta sa istim jmbg-om");
                                return;
                            }
                            if (item.Telefon.Equals(izabraniStudent.Telefon))
                            {
                                MessageBox.Show("Ne mozete dodati studenta sa istim telefon-om");
                                return;
                            }

                        }
                        dodajStudenta(listaStudenata, izabraniStudent);
                    }
                }
            }
            // ========================== BRISANJE STUDENTA =========================
            else if (lblIzbrisi.Visible == true)
            {
                List<Student> listaStudenata = new List<Student>();
                FileStream fsr = File.OpenRead(putanjaStudent);
                BinaryFormatter bf = new BinaryFormatter();
                listaStudenata = bf.Deserialize(fsr) as List<Student>;
                fsr.Dispose();



                listaStudenata.RemoveAt(lbIspiStudenta.SelectedIndex);

                if (File.Exists(indeksPrePromene.ToString().Replace("-", "").Replace("/", "") + ".bin"))
                {
                    File.Delete(indeksPrePromene.ToString().Replace("-", "").Replace("/", "") + ".bin");
                }

                FileStream fsw = new FileStream(putanjaStudent, FileMode.Create, FileAccess.Write);
                BinaryFormatter bfe = new BinaryFormatter();
                bfe.Serialize(fsw, listaStudenata);
                fsw.Close();
                fsw.Dispose();
                lbIspiStudenta.DataSource = listaStudenata;
            }
        }
        

        private void dodajStudenta(List<Student> lista, Student student)
        {
            lista.Add(student);
            tbIme.Clear();
            tbPrezime.Clear();
            tbTelefon.Clear();
            tbJmbg.Clear();
            tbIndex.Clear();
            tbIme.Focus();
            FileStream fsw = new FileStream(putanjaStudent, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fsw, lista);
            fsw.Close();
            fsw.Dispose();
            lbIspiStudenta.DataSource = lista;
        }
        // ===========================================================================================================
        private bool proveraIspravnostiPodataka()
        {
            if (tbIndex.Text.Equals("") || !tbIndex.Text.Contains("-") || !tbIndex.Text.Contains("/"))
            {
                MessageBox.Show("Unesite dobar indeks i postarajte se da je u formatu (XXX-XX/XX");
                tbIndex.Focus();
                return false;
            }
            if (!jesiKrsten(tbIme.Text, "ime"))
            {
                tbIme.Clear();
                tbIme.Focus();
                return false;
            }
            if (!jesiKrsten(tbPrezime.Text, "prezime"))
            {
                tbPrezime.Clear();
                tbPrezime.Focus();
                return false;
            }
            if (!Regex.IsMatch(tbJmbg.Text, @"^[0-9]{13}\z+$"))
            {
                MessageBox.Show("Unesi krstene brojeve za JMBG! I da ih ima 13!");
                tbJmbg.Focus();
                return false;
            }
            datumRodjenja = "";
            for (int i = 0; i < 7; i++)
            {
                datumRodjenja += tbJmbg.Text[i];
            }
            if (!proveraRodjenja(datumRodjenja))
            {
                MessageBox.Show("Unesite dobar JMBG i postarajte se da sadrzi 13 brojeva");
                tbJmbg.Focus();
                return false;
            }
            
            if (!Regex.IsMatch(tbTelefon.Text, @"^[0-9]{9,10}\z+$"))
            {
                MessageBox.Show("Unesi krstene brojeve za telefon kume!");
                tbTelefon.Clear();
                tbTelefon.Focus();
                return false;
            }
            FileStream fsr;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(putanjaStudent))
            {
                List<Student> listaStudenata = new List<Student>();
                fsr = File.OpenRead("studenti.bin");
                listaStudenata = bf.Deserialize(fsr) as List<Student>;
                fsr.Dispose();
                fsr.Close();
                if (lblAzuriraj.Visible == false)
                {
                    foreach (Student item in listaStudenata)
                    {
                        if (item.Indeks.ToString().Equals(tbIndex.Text))
                        {
                            MessageBox.Show("Kume ovaj gi indeks vec postoji, probaj z drugi...");
                            tbIndex.Focus();
                            return false;
                        }
                        if (item.Jmbg.ToString().Equals(tbJmbg.Text))
                        {
                            MessageBox.Show("Kume ovaj gi JMBG vec postoji, probaj z drugi...");
                            tbJmbg.Focus();
                            return false;
                        }
                        if (item.Telefon.ToString().Equals(tbTelefon.Text))
                        {
                            MessageBox.Show("Kume ovaj gi telefon vec postoji, probaj z drugi...");
                            tbTelefon.Focus();
                            return false;
                        }
                    }
                }
                
            }
            List<Smer> listaSmerova = new List<Smer>();
            fsr = File.OpenRead("smerovi.bin");
            listaSmerova = bf.Deserialize(fsr) as List<Smer>;
            fsr.Dispose();
            fsr.Close();

            string input = tbIndex.Text.ToUpper();
            int index = input.IndexOf("-");
            if (index > 0)
            {
                input = input.Substring(0, index);
            }
            bool isti = false;
            postojeciSmer = new Smer();
            foreach (Smer item in listaSmerova)
            {
                if (item.NazivSmera.ToString().Equals(input))
                {
                    postojeciSmer = item;
                    isti = true;
                    break;
                }
            }
            if (!isti)
            {
                MessageBox.Show("Ne postoji dati smer!");
                tbIndex.Focus();
                return false;
            }
            return true;
        }
        // ========================= DODAVANJE STUDENTA ================================
        
        // ============================================= PROVERA DATUMA RODJENJA =====================================
        private bool proveraRodjenja(string datumRodjenja)
        {
            string danRodjenja = "", mesecRodjenja = "", godinaRodjenja = "1";
            for (int i = 0; i < 2; i++)
            {
                danRodjenja += datumRodjenja[i];
            }
            for (int i = 2; i < 4; i++)
            {
                mesecRodjenja += datumRodjenja[i];
            }
            for (int i = 4; i < 7; i++)
            {
                godinaRodjenja += datumRodjenja[i];
            }

            int dan, mesec, godina;
            int.TryParse(danRodjenja, out dan);
            int.TryParse(mesecRodjenja, out mesec);
            int.TryParse(godinaRodjenja, out godina);

            if (godina > 1950)
            {
                if (mesec < 13 && mesec > 0)
                {
                    if (mesec == 2)
                    {
                        if (dan < 29 && dan > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (dan < 32 && dan > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool jesiKrsten(string tekst, string komentar)
        {
            if (!Regex.IsMatch(tekst, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Unesi krstena slova za " + komentar + " kume!");
                return false;
            }
            return true;
        }

        private void lbIspiStudenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbStudent = lbIspiStudenta.SelectedItem as Student;
            if (lblUnesi.Visible != true)
            {
                tbIndex.Text = lbStudent.Indeks.ToString();
                tbIme.Text = lbStudent.Ime.ToString();
                tbPrezime.Text = lbStudent.Prezime.ToString();
                tbJmbg.Text = lbStudent.Jmbg.ToString();
                tbTelefon.Text = lbStudent.Telefon.ToString();
                indeksPrePromene = lbStudent.Indeks.ToString();
            }
        }
    }
}
