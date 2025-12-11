using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ead_11_12
{
    public class Materia
    {

        public string Nome { get; set; }
        public double Nota { get; set; }

        public Materia(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }
    }
}