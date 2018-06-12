using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    class Smer
    {
        private int idSmer;
        public int IdSmer {
            get
            {
                return idSmer;
            }
        }
        private string nazivSmera;
        public string NazivSmera
        {
            get
            {
                return nazivSmera;
            }
        }

        public Smer(int idSmer, string nazivSmera)
        {
            this.idSmer = idSmer;
            this.nazivSmera = nazivSmera;
        }

        public Smer()
        {

        }

        public override string ToString()
        {
            return idSmer + ", " + nazivSmera.ToUpper();
        }

    }
}
