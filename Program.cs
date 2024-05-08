using System;
using static Aluno;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Leonel";
        aluno1.Ano = 1980;

        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Pedro";
        aluno2.Ano = 2004;

        Professor professor1 = new Professor();
        professor1.NomeProfessor = "Thiaguinho";

        Professor professor2 = new Professor();
        professor2.NomeProfessor = "Rosen";

        InstituicaoEnsino instituicao = new InstituicaoEnsino();

        instituicao.AdicionarAluno(aluno1);
        instituicao.AdicionarAluno(aluno2);

        Escola escola = new Escola();

        escola.AdicionarAluno(aluno1);
        escola.AdicionarAluno(aluno2);
        escola.AdicionarProfessor(professor1);
        escola.AdicionarProfessor(professor2);

        // Exemplo de sobrecarga de método
        aluno1.Estudar("Progamação Mobile");
        professor2.Ensinando("Orientação a Objetos");
    }
}
