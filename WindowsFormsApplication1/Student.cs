using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    class Student
    {
        private string ime, prezime, jmbg, datumRodjenja, indeks, telefon;
        private Smer smer;

        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }
        public string Jmbg
        {
            get
            {
                return jmbg;
            }
            set
            {
                jmbg = value;
            }
        }
        public string DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }
        }
        public string Indeks
        {
            get
            {
                return indeks;
            }
            set
            {
                indeks = value;
            }
        }
        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
            }
        }
        public Smer Smer
        {
            get
            {
                return smer;
            }
            set
            {
                smer = value;
            }
        }

        public int SelectedIndex { get; internal set; }

        public Student(string ime, string prezime, string jmbg, string datumRodjenja, string indeks, string telefon, Smer smer)
        {
            this.smer = smer;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datumRodjenja = datumRodjenja;
            this.indeks = indeks;
            this.telefon = telefon;
        }

        public Student()
        {

        }

        public override string ToString()
        {
            return "Index: " + indeks + " | " +  ime + " " + prezime + ", JMBG: " + jmbg + ", Datum rodjenja: " + (napisiDatum(datumRodjenja)) + ", Fon: " + telefon + ", Smer: " + smer.NazivSmera.ToString();
        }

        private string napisiDatum(string datumRodjenja)
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

            return dan + "." + mesec + "." + godina;
        }
    }
}
