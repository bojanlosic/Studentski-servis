using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    class Predmet
    {
        private string idPredmeta, naziv, profesor;
        private int espb, semestar;
        private bool obavezan;
        Smer smer;

        public string IdPredmeta
        {
            get
            {
                return idPredmeta;
            }
        }
        public string Naziv
        {
            get
            {
                return naziv;
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
        public string Profesor
        {
            get
            {
                return profesor;
            }
        }
        public int Espb
        {
            get
            {
                return espb;
            }
        }
        public int Semestar
        {
            get
            {
                return semestar;
            }
        }
        public bool Obavezan
        {
            get
            {
                return obavezan;
            }
        }

        public Predmet()
        {

        }
        public Predmet(string idPredmeta, string naziv, Smer smer, string profesor, int espb, bool obavezan, int semestar)
        {
            this.idPredmeta = idPredmeta;
            this.naziv = naziv;
            this.smer = smer;
            this.profesor = profesor;
            this.espb = espb;
            this.semestar = semestar;
            this.obavezan = obavezan;
        }

        public override string ToString()
        {
            return "Sifra: " + idPredmeta + " - " + naziv + 
                ", Smer: " + smer.ToString() + ", Profesor: " + profesor + 
                ", ESPB: " + espb + ", Obavezan: " + daLiJeObavezan(obavezan) + 
                ", Semestar: " + semestar;
        }

        private string daLiJeObavezan(bool obavezan)
        {
            return obavezan ? "DA" : "NE";
        }


    }
}
