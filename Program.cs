// - Atribua uma nota para cada uma das disciplinas.
// - Crie um método que avalie e informe qual foi a matéria em que o aluno obteve a melhor nota. Caso haja empate entre duas ou mais -matérias, o método deve indicar todas as matérias com a melhor nota

using ead_11_12;

List<Materia> listaMateria = new List<Materia>();
List<Materia> listaMateriaMaior = new List<Materia>();

Materia portugues = new();
Materia matematica = new();
Materia geografia = new();
Materia historia = new();
Materia fisica = new();

double maiorNota = -1;

portugues.Nome = "Português";
portugues.Nota = 10;
listaMateria.Add(portugues);

matematica.Nome = "Matemática";
matematica.Nota = 10;
listaMateria.Add(matematica);

geografia.Nome = "Geografia";
geografia.Nota = 7;
listaMateria.Add(geografia);

historia.Nome = "História";
historia.Nota = 8;
listaMateria.Add(historia);

fisica.Nome = "Física";
fisica.Nota = 10;
listaMateria.Add(fisica);

foreach(var n in listaMateria)
{
    if (n.Nota > maiorNota)
    {
        maiorNota = n.Nota;
        listaMateriaMaior.Add(n);
    }
    else if(n.Nota == maiorNota)
    {
        listaMateriaMaior.Add(n);
    }
}

Console.WriteLine("Maiores notas:");

foreach(var nM in listaMateriaMaior)
{
    Console.WriteLine($"{nM.Nome}, com {nM.Nota} de nota");
}