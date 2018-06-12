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
    public partial class FrmIzborna : Form
    {
        List<Student> listaStudenata;
        List<Predmet> listaPredmeta;
        BinaryFormatter bf;
        FileStream fs;
        Student izabraniStudent;
        int suma;
        public FrmIzborna()
        {
            InitializeComponent();
        }

        private void FrmIzborna_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            FrmAdministracija frmAdministracija = new FrmAdministracija();
            frmAdministracija.Show();
            this.Hide();
        }

        private void FrmIzborna_Load(object sender, EventArgs e)
        {
            izabraniStudent = new Student();

            listaPredmeta = new List<Predmet>();
            listaStudenata = new List<Student>();
            bf = new BinaryFormatter();
            if (File.Exists("predmeti.bin"))
            {
                fs = File.OpenRead("predmeti.bin");
                listaPredmeta = bf.Deserialize(fs) as List<Predmet>;
                fs.Dispose();
                fs.Close();
            }

            if (File.Exists("studenti.bin"))
            {
                fs = File.OpenRead("studenti.bin");
                listaStudenata = bf.Deserialize(fs) as List<Student>;
                fs.Dispose();
                fs.Close();
                cmbStudent.DataSource = listaStudenata;
            }
            else
            {
                MessageBox.Show("Studenti jos uvek nisu prijavili nijednu listu.");
            }
            
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            izabraniStudent = cmbStudent.SelectedItem as Student;
            string input = izabraniStudent.Indeks.ToString().ToUpper();
            int index = input.IndexOf("-");
            if (index > 0)
            {
                input = input.Substring(0, index);
            }
            string temp = izabraniStudent.Indeks.ToString().Replace("-", "").Replace("/", "");
            if (File.Exists(temp + ".bin"))
            {
                List<Predmet> listaIzabranihPredmeta = new List<Predmet>();
                List<Predmet> listaSaMaticnogSmera = new List<Predmet>();
                List<Predmet> listaSaDrugogSmera = new List<Predmet>();

                List<Predmet> novaListaIzabranih = new List<Predmet>();
                List<Predmet> novaListaNeizabranih = new List<Predmet>();
                List<Predmet> novaListaIzabranihSaDrugog = new List<Predmet>();
                List<Predmet> novaListaNeizabranihSaDrugog = new List<Predmet>();
                fs = File.OpenRead(temp + ".bin");
                listaIzabranihPredmeta = bf.Deserialize(fs) as List<Predmet>;
                fs.Dispose();
                fs.Close();
                // Podeli na maticne i sa drugog
                foreach (Predmet item in listaPredmeta)
                {
                    if (item.Smer.NazivSmera.ToString().ToUpper().Equals(input))
                    {
                        listaSaMaticnogSmera.Add(item);
                    }
                    else
                    {
                        listaSaDrugogSmera.Add(item);
                    }
                }
                // Dodaj sa maticnog koji nisu izabrani
                foreach (Predmet item in listaSaMaticnogSmera)
                {
                    bool nadjen = false;
                    foreach (Predmet izabrani in listaIzabranihPredmeta)
                    {
                        if (izabrani.ToString().Equals(item.ToString()))
                        {
                            nadjen = true;
                            break;
                        }
                    }
                    if (!nadjen)
                    {
                        novaListaNeizabranih.Add(item);
                    }
                }
                // Dodaj sa drugog koji nisu izabrani
                foreach (Predmet item in listaSaDrugogSmera)
                {
                    bool nadjen = false;
                    foreach (Predmet izabrani in listaIzabranihPredmeta)
                    {
                        if (izabrani.ToString().Equals(item.ToString()))
                        {
                            nadjen = true;
                            break;
                        }
                    }
                    if (!nadjen)
                    {
                        novaListaNeizabranihSaDrugog.Add(item);
                    }
                }
                // Dodaj sa maticnog koji su izabrani i sa drugog koji su izabrani
                foreach (Predmet item in listaIzabranihPredmeta)
                {
                    if (item.Smer.NazivSmera.ToString().ToUpper().Equals(input))
                    {
                        novaListaIzabranih.Add(item);
                    }
                    else
                    {
                        novaListaIzabranihSaDrugog.Add(item);
                    }
                }

                lbNeizabrani.DataSource = novaListaNeizabranih;
                lbIzabrani.DataSource = novaListaIzabranih;

                lbNeizabraniDrugi.DataSource = novaListaNeizabranihSaDrugog;
                lbIzabraniDrugi.DataSource = novaListaIzabranihSaDrugog;
                suma = 0;
                foreach (Predmet item in listaIzabranihPredmeta)
                {
                    int pomocna;
                    int.TryParse(item.Espb.ToString(), out pomocna);
                    suma += pomocna;
                }
                lblBrojBodova.Text = "ESPB: " + suma.ToString();
                if (suma > 48 || suma < 60)
                {
                    btnPredaj.Enabled = true;
                }
                else
                {
                    btnPredaj.Enabled = false;
                }
            }
            // AKO NIJE PREDAO LISTU
            else
            {
                suma = 0;
                lblBrojBodova.Text = "ESPB: " + (suma.ToString());
                btnPredaj.Enabled = false;
                //MessageBox.Show("Izabrani student jos nije predao listu predmeta.");
                List<Predmet> listaIzabranihPredmeta = new List<Predmet>();
                List<Predmet> listaSaMaticnogSmera = new List<Predmet>();
                List<Predmet> listaSaDrugogSmera = new List<Predmet>();

                foreach (Predmet item in listaPredmeta)
                {
                    if (item.Smer.NazivSmera.ToString().ToUpper().Equals(input))
                    {
                        listaSaMaticnogSmera.Add(item);
                    }
                    else
                    {
                        listaSaDrugogSmera.Add(item);
                    }
                }
                lbNeizabrani.DataSource = listaSaMaticnogSmera;
                lbNeizabraniDrugi.DataSource = listaSaDrugogSmera;
                lbIzabrani.DataSource = null;
                lbIzabraniDrugi.DataSource = null;
            }
        }
        // DUGME PREBACI DESNO IZABRANE
        private void btnPrebaciUIzabrane_Click(object sender, EventArgs e)
        {
            if (lbNeizabrani.Items.Count == 0)
            {
                return;
            }
            Predmet izabrani = lbNeizabrani.SelectedItem as Predmet;
            List<Predmet> privremenaListaPredmeta = lbIzabrani.Items.Cast<Predmet>().ToList();
            List<Predmet> privremenaListaIzabranihPredmeta = lbIzabraniDrugi.Items.Cast<Predmet>().ToList();
            List<Predmet> privremenaListaNeizabranihPredmeta = lbNeizabrani.Items.Cast<Predmet>().ToList();
            suma = 0;
            int pomocna;
            foreach (Predmet item in privremenaListaPredmeta)
            {
                int.TryParse(item.Espb.ToString(), out pomocna);
                suma += pomocna;
            }
            foreach (Predmet item in privremenaListaIzabranihPredmeta)
            {
                int.TryParse(item.Espb.ToString(), out pomocna);
                suma += pomocna;
            }

            int.TryParse(izabrani.Espb.ToString(), out pomocna);
            if (suma + pomocna >= 48)
            {
                btnPredaj.Enabled = true;
            }
            else
            {
                btnPredaj.Enabled = false;
            }
            
            if (suma + pomocna > 60)
            {
                MessageBox.Show("Ne mozete da dodate vise predmeta.");
            }
            else
            {
                List<Predmet> novaListica = new List<Predmet>();
                foreach (Predmet item in privremenaListaNeizabranihPredmeta)
                {
                    if (!item.ToString().Equals(izabrani.ToString()))
                    {
                        novaListica.Add(item);
                    }
                }
                lblBrojBodova.Text = "ESPB: " + (suma + pomocna).ToString();
                lbNeizabrani.DataSource = novaListica;
                privremenaListaPredmeta.Add(izabrani);
                lbIzabrani.DataSource = privremenaListaPredmeta;
                
            }
        }
        // IZBACI IZ ODABRANIH SA MATICNOG SMERA
        private void btnIzbaciIzIzabranih_Click(object sender, EventArgs e)
        {
            if (lbIzabrani.Items.Count == 0)
            {
                return;
            }
            Predmet izabrani = lbIzabrani.SelectedItem as Predmet;
            List<Predmet> privremenaListaPredmeta = lbIzabrani.Items.Cast<Predmet>().ToList();
            List<Predmet> privremenaListaIzabranihPredmeta = lbIzabraniDrugi.Items.Cast<Predmet>().ToList();
            List<Predmet> privremenaListaNeizabranihPredmeta = lbNeizabrani.Items.Cast<Predmet>().ToList();
            suma = 0;
            int pomocna;
            
            foreach (Predmet item in privremenaListaPredmeta)
            {
                int.TryParse(item.Espb.ToString(), out pomocna);
                suma += pomocna;
            }
            foreach (Predmet item in privremenaListaIzabranihPredmeta)
            {
                int.TryParse(item.Espb.ToString(), out pomocna);
                suma += pomocna;
            }

            int.TryParse(izabrani.Espb.ToString(), out pomocna);
            if (suma - pomocna < 48)
            {
                btnPredaj.Enabled = false;
            }
            else
            {
                btnPredaj.Enabled = true;
            }
            List<Predmet> novaListica = new List<Predmet>();
            foreach (Predmet item in privremenaListaPredmeta)
            {
                if (!item.ToString().Equals(izabrani.ToString()))
                {
                    novaListica.Add(item);
                }
            }
            lblBrojBodova.Text = "ESPB: " + (suma - pomocna).ToString();
            lbIzabrani.DataSource = novaListica;
            privremenaListaNeizabranihPredmeta.Add(izabrani);
            lbNeizabrani.DataSource = privremenaListaNeizabranihPredmeta;
        }
        // DUGME PREBACI DESNO SA DRUGOG SMERA
        private void btnDodajSaDrugog_Click(object sender, EventArgs e)
        {
            if (lbNeizabraniDrugi.Items.Count == 0 || lbIzabraniDrugi.Items.Count == 1)
            {
                return;
            }
            Predmet izabrani = lbNeizabraniDrugi.SelectedItem as Predmet;
            List<Predmet> privremenaListaPredmeta = lbIzabraniDrugi.Items.Cast<Predmet>().ToList();
            List<Predmet> privremenaListaIzabranihPredmeta = lbIzabrani.Items.Cast<Predmet>().ToList();
            List<Predmet> privremenaListaNeizabranihPredmeta = lbNeizabraniDrugi.Items.Cast<Predmet>().ToList();
            suma = 0;
            int pomocna;
            
            foreach (Predmet item in privremenaListaPredmeta)
            {
                int.TryParse(item.Espb.ToString(), out pomocna);
                suma += pomocna;
            }
            foreach (Predmet item in privremenaListaIzabranihPredmeta)
            {
                int.TryParse(item.Espb.ToString(), out pomocna);
                suma += pomocna;
            }
            int.TryParse(izabrani.Espb.ToString(), out pomocna);
            if (suma + pomocna >= 48)
            {
                btnPredaj.Enabled = true;
            }
            else
            {
                btnPredaj.Enabled = false;
            }
            if (suma + pomocna > 60)
            {
                MessageBox.Show("Ne mozete da dodate vise predmeta.");
            }
            else
            {
                List<Predmet> novaListica = new List<Predmet>();
                foreach (Predmet item in privremenaListaNeizabranihPredmeta)
                {
                    if (!item.ToString().Equals(izabrani.ToString()))
                    {
                        novaListica.Add(item);
                    }
                }
                lblBrojBodova.Text = "ESPB: " + (suma + pomocna).ToString();
                lbNeizabraniDrugi.DataSource = novaListica;
                privremenaListaPredmeta.Add(izabrani);
                lbIzabraniDrugi.DataSource = privremenaListaPredmeta;

            }
        }

        private void btnIzbaciIzDrugog_Click(object sender, EventArgs e)
        {
            if (lbIzabraniDrugi.Items.Count == 0)
            {
                return;
            }
            Predmet izabrani = lbIzabraniDrugi.SelectedItem as Predmet;
            List<Predmet> privremenaListaPredmeta = lbIzabraniDrugi.Items.Cast<Predmet>().ToList();
            List<Predmet> privremenaListaIzabranihPredmeta = lbIzabrani.Items.Cast<Predmet>().ToList();
            List<Predmet> privremenaListaNeizabranihPredmeta = lbNeizabraniDrugi.Items.Cast<Predmet>().ToList();
            suma = 0;
            int pomocna;

            foreach (Predmet item in privremenaListaPredmeta)
            {
                int.TryParse(item.Espb.ToString(), out pomocna);
                suma += pomocna;
            }
            foreach (Predmet item in privremenaListaIzabranihPredmeta)
            {
                int.TryParse(item.Espb.ToString(), out pomocna);
                suma += pomocna;
            }

            int.TryParse(izabrani.Espb.ToString(), out pomocna);
            if (suma - pomocna < 48)
            {
                btnPredaj.Enabled = false;
            }
            else
            {
                btnPredaj.Enabled = true;
            }
            List<Predmet> novaListica = new List<Predmet>();
            foreach (Predmet item in privremenaListaPredmeta)
            {
                if (!item.ToString().Equals(izabrani.ToString()))
                {
                    novaListica.Add(item);
                }
            }
            lblBrojBodova.Text = "ESPB: " + (suma - pomocna).ToString();
            lbIzabraniDrugi.DataSource = novaListica;
            privremenaListaNeizabranihPredmeta.Add(izabrani);
            lbNeizabraniDrugi.DataSource = privremenaListaNeizabranihPredmeta;
        }

        private void btnPredaj_Click(object sender, EventArgs e)
        {
            izabraniStudent = cmbStudent.SelectedItem as Student;
            string input = izabraniStudent.Indeks.ToString().ToUpper();
            int index = input.IndexOf("-");
            if (index > 0)
            {
                input = input.Substring(0, index);
            }
            string temp = izabraniStudent.Indeks.ToString().Replace("-", "").Replace("/", "");
            if (File.Exists(temp + ".bin"))
            {
                File.Delete(temp + ".bin");
            }
            List<Predmet> privremenaListaPredmeta = lbIzabraniDrugi.Items.Cast<Predmet>().ToList();
            List<Predmet> privremenaListaIzabranihPredmeta = lbIzabrani.Items.Cast<Predmet>().ToList();
            if (privremenaListaPredmeta.Count > 0)
            {
                privremenaListaIzabranihPredmeta.AddRange(privremenaListaPredmeta);
            }
            FileStream fsw = new FileStream(temp + ".bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter bfw = new BinaryFormatter();
            bfw.Serialize(fsw, privremenaListaIzabranihPredmeta);
            fsw.Close();
            fsw.Dispose();
            MessageBox.Show("Uspesno azurirana lista ovog studenta.");
        }

        private void lbNeizabrani_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPrebaciUIzabrane_Click(sender, e);
            }
        }
    }
}
