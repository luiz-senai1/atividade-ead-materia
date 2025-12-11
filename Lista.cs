using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ead_11_12
{
    public class Lista
    {
        double maiorNota = -1;
        public List<Materia> listaMateria = new List<Materia>();
        public List<Materia> listaMateriaMaior = new List<Materia>();

        public void AdicionaLista(Materia materia)
        {
            if (materia != null)
            {
                listaMateria.Add(materia);
            }
        }
        public void Comparacao()
        {
            foreach (var n in listaMateria)
            {
                if (n.Nota > maiorNota)
                {
                    maiorNota = n.Nota;
                    listaMateriaMaior.Add(n);
                }
                else if (n.Nota == maiorNota)
                {
                    listaMateriaMaior.Add(n);
                }
            }

            Console.WriteLine("Maiores notas:");

            foreach (var nM in listaMateriaMaior)
            {
                Console.WriteLine($"{nM.Nome}, com {nM.Nota} de nota");
            }
        }
    }
}