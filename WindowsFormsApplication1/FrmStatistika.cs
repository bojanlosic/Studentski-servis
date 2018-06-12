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
    public partial class FrmStatistika : Form
    {
        BinaryFormatter bf;
        FileStream fs;
        List<Student> listaStudenata;
        Predmet izabraniPredmet;
        int brojac;
        int brojacStudenata;
        float z = 0;

        public delegate void delRacunaj(int broj);
        public void prikaziBrojcano(int broj)
        {
            lblBrojStudenata.Text = "Broj studenata na ovom predmetu: " + broj;
        }
        public void prikaziProcentualno(int broj)
        {

            z = broj * 100 / brojacStudenata;
            lblProcentualno.Text = "Odnosno " + z + "%";
            z *= 3.6F;
            this.Paint += crtanje;
            this.Invalidate();
        }

        public FrmStatistika()
        {
            InitializeComponent();
        }

        private void FrmStatistika_Load(object sender, EventArgs e)
        {
            List<Predmet> listaPredmeta = new List<Predmet>();
            bf = new BinaryFormatter();
            fs = File.OpenRead("predmeti.bin");
            listaPredmeta = bf.Deserialize(fs) as List<Predmet>;
            fs.Dispose();
            fs.Close();
            cmbIzaberiPredmet.DataSource = listaPredmeta;
            listaStudenata = new List<Student>();
            izabraniPredmet = new Predmet();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            FrmAdministracija frmAdministracija = new FrmAdministracija();
            frmAdministracija.Show();
            this.Hide();
        }

        private void FrmStatistika_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmbIzaberiPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            brojac = 0;
            brojacStudenata = 0;
            izabraniPredmet = cmbIzaberiPredmet.SelectedItem as Predmet;
            fs = File.OpenRead("studenti.bin");
            listaStudenata = bf.Deserialize(fs) as List<Student>;
            fs.Dispose();
            fs.Close();

            foreach (Student item in listaStudenata)
            {
                brojacStudenata++;
                string input = item.Indeks.ToString().ToUpper().Replace("-","").Replace("/","");
                if (File.Exists(input + ".bin"))
                {
                    List<Predmet> listaIzabranihPredmeta = new List<Predmet>();
                    FileStream fsr = File.OpenRead(input + ".bin");
                    listaIzabranihPredmeta = bf.Deserialize(fsr) as List<Predmet>;
                    fsr.Dispose();
                    fsr.Close();
                    foreach (Predmet izabrani in listaIzabranihPredmeta)
                    {
                        if (izabrani.ToString().Equals(izabraniPredmet.ToString()))
                        {
                            brojac++;
                            break;
                        }
                    }
                }
            }
            delRacunaj noviDelegat = new delRacunaj(prikaziBrojcano);
            noviDelegat += prikaziProcentualno;

            noviDelegat(brojac);
        }

        private void crtanje(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(50, 150, 100, 100);
            e.Graphics.FillEllipse(Brushes.Blue, r);

            e.Graphics.FillPie(Brushes.Red, r, -90F, z);
        }
    }
}
