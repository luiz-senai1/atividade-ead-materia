// - Atribua uma nota para cada uma das disciplinas.
// - Crie um método que avalie e informe qual foi a matéria em que o aluno obteve a melhor nota. Caso haja empate entre duas ou mais -matérias, o método deve indicar todas as matérias com a melhor nota

using ead_11_12;

Lista listaMateria = new ();

Materia portugues = new("Português", 10);
Materia matematica = new("Matemática", 10);
Materia geografia = new("Geografia", 7);
Materia historia = new("História", 8);
Materia fisica = new("Física", 10);

listaMateria.AdicionaLista(portugues);
listaMateria.AdicionaLista(matematica);
listaMateria.AdicionaLista(geografia);
listaMateria.AdicionaLista(historia);
listaMateria.AdicionaLista(fisica);

listaMateria.Comparacao();
