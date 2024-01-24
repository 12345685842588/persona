using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona
{
    internal class Persona
    {
        public int AnnoDiNascita { get; set; }

        public Persona(int annoDiNascita)
        {
            this.AnnoDiNascita = annoDiNascita;
        }

        public int CalcolaEtà()
        {
            return DateTime.Now.Year - AnnoDiNascita;
        }
    }
}
