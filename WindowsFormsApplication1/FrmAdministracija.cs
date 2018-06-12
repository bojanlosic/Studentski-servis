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
    public partial class FrmAdministracija : Form
    {
        
        
        
        public FrmAdministracija()
        {
            InitializeComponent();
        }

        private void Administracija_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            FrmPocetna frmPocetna = new FrmPocetna();
            frmPocetna.Show();
            this.Hide();
        }

        private void btnAzurirajSmer_Click(object sender, EventArgs e)
        {
            FrmSmer frmSmer = new FrmSmer();
            frmSmer.Show();
            this.Hide();
        }

        private void btnAzurirajStudenta_Click(object sender, EventArgs e)
        {
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.Show();
            this.Hide();
        }

        private void btnAzurirajPredmet_Click(object sender, EventArgs e)
        {
            FrmPredmet frmPredmet = new FrmPredmet();
            frmPredmet.Show();
            this.Hide();
        }

        private void btnPrikaziListu_Click(object sender, EventArgs e)
        {
            FrmIzborna frmIzborna = new FrmIzborna();
            frmIzborna.Show();
            this.Hide();
        }

        private void FrmAdministracija_Load(object sender, EventArgs e)
        {
            if (!File.Exists("smerovi.bin"))
            {
                btnAzurirajStudenta.Enabled = false;
                btnPrikaziListu.Enabled = false;
            }
            else
            {
                btnAzurirajStudenta.Enabled = true;
                btnPrikaziListu.Enabled = true;
            }
            if (!File.Exists("studenti.bin"))
            {
                btnAzurirajPredmet.Enabled = false;
                btnPrikaziListu.Enabled = false;
            }
            else
            {
                List<Student> listaStudenata;
                BinaryFormatter bf;
                FileStream fs;
                listaStudenata = new List<Student>();
                bf = new BinaryFormatter();
                fs = File.OpenRead("studenti.bin");
                listaStudenata = bf.Deserialize(fs) as List<Student>;
                fs.Dispose();
                fs.Close();
                bool nadjen = false;
                foreach (Student item in listaStudenata)
                {
                    if (File.Exists(item.Indeks.ToString().ToUpper().Replace("-","").Replace("/","") + ".bin"))
                    {
                        nadjen = true;
                        break;
                    }
                }
                if (!nadjen)
                {
                    btnAzurirajPredmet.Enabled = true;
                    btnPrikaziListu.Enabled = true;
                    btnPrikaziStatistiku.Enabled = false;
                }
                
            }
        }

        private void btnPrikaziStatistiku_Click(object sender, EventArgs e)
        {
            FrmStatistika frmStatistika = new FrmStatistika();
            frmStatistika.Show();
            this.Hide();
        }
    }
}
