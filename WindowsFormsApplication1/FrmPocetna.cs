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
    public partial class FrmPocetna : Form
    {
        int adminBrojPokusaja = 3;
        int studentBrojPokusaja = 3;
        string putanjaStudent, putanjaPredmet;
        public static string indeksStudenta = "";
        FileStream fsw;
        FileStream fsr;
        BinaryFormatter bfw;
        BinaryFormatter bfr;
        public FrmPocetna()
        {
            InitializeComponent();
            putanjaStudent = "studenti.bin";
            putanjaPredmet = "predmeti.bin";
            bfw = new BinaryFormatter();
            bfr = new BinaryFormatter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
            textBox1.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
            textBox1.Focus();
            if (!File.Exists(putanjaStudent))
            {
                MessageBox.Show("Ne postoji nijedan student, molimo administratore da unesu studente!");
                button1_Click(sender, e);
                return;
            }
            if (!File.Exists(putanjaPredmet))
            {
                MessageBox.Show("Ne postoji nijedan predmet, molimo administratore da unesu predmete!");
                button1_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Visible == true)
            {
                string adminUsername = "admin";
                string adminPassword = "pass";

                if (adminUsername.Equals(textBox1.Text) && adminPassword.Equals(textBox2.Text))
                {
                    adminBrojPokusaja = 3;
                    FrmAdministracija frmAdministracija = new FrmAdministracija();
                    frmAdministracija.Show();
                    this.Hide();
                }
                else
                {
                    adminBrojPokusaja--;
                    MessageBox.Show("Pogresno unete akreditacije, preostali broj pokusaja: " + adminBrojPokusaja);
                    textBox1.Clear();
                    textBox2.Clear();
                }
                if (adminBrojPokusaja == 0)
                {
                    MessageBox.Show("Pogresno unete akreditacije, izlazak iz programa!");
                    Application.Exit();
                }
            }
            // ======================================= STUDENT LOGIN ================================================
            else if (label4.Visible == true)
            {
                if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                {
                    MessageBox.Show("Molimo vas da unesete vas indeks za username, i password!");
                    return;
                }

                if (File.Exists(putanjaStudent) && File.Exists(putanjaPredmet))
                {
                    List<Student> listaStudenata = new List<Student>();
                    Student upisan = new Student();
                    fsr = File.OpenRead(putanjaStudent);
                    listaStudenata = bfr.Deserialize(fsr) as List<Student>;
                    fsr.Dispose();
                    fsr.Close();

                    string username = textBox1.Text.ToUpper();
                    string studentPassword = "pass";
                    bool proso = false;
                    foreach (Student item in listaStudenata)
                    {
                        if (item.Indeks.ToString().Replace("-","").Replace("/","").Equals(username.Replace("-", "").Replace("/", "")) && studentPassword.Equals(textBox2.Text))
                        {
                            upisan = item;
                            proso = true;
                        }
                    }
                    if (proso)
                    {

                        indeksStudenta = upisan.Indeks.ToString();
                        studentBrojPokusaja = 3;
                        FrmKorisnik frmKorisnik = new FrmKorisnik();
                        frmKorisnik.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        studentBrojPokusaja--;
                        MessageBox.Show("Pogresno unete akreditacije, preostali broj pokusaja: " + studentBrojPokusaja);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();
                    }
                    if (studentBrojPokusaja == 0)
                    {
                        MessageBox.Show("Pogresno unete akreditacije, izlazak iz programa!");
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji nijedan student ili predmet, molimo administratore da unesu studente / predmete!");
                    button1_Click(sender, e);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
