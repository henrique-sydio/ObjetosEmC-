using System;
using System.Collections.Generic;

// Definição da classe Aluno
public class Aluno
{
    // Atributos
    private string alunoNome;
    private int anoNasc;

    // Propriedades
    public string Nome
    {
        get { return alunoNome; }
        set { alunoNome = value; }
    }

    public int Ano
    {
        get { return anoNasc; }
        set { anoNasc = value; }
    }

    // Método
    public void Estudar()
    {
        Console.WriteLine($"{Nome} está estudando.");
    }

    // Sobrecarga de Método
    public void Estudar(string materia)
    {
        Console.WriteLine($"{Nome} está estudando {materia}.");
    }
}

// Definição da classe Professor
public class Professor
{
    // Atributos
    private string professorNome;
    private List<string> disciplinas = new List<string>();

    // Propriedades
    public string NomeProfessor
    {
        get { return professorNome; }
        set { professorNome = value; }
    }

    // Método
    public void Ensinando()
    {
        Console.WriteLine($"{NomeProfessor} está ensinando.");
    }

    // Sobrecarga de Método
    public void Ensinando(string disciplina)
    {
        disciplinas.Add(disciplina);
        Console.WriteLine($"{NomeProfessor} está ensinando {disciplina}.");
    }
}

// Definição da classe InstituicaoEnsino com relacionamento unidirecional
public class InstituicaoEnsino
{
    // Atributos
    private List<Aluno> alunos = new List<Aluno>();

    // Método para adicionar aluno
    public void AdicionarAluno(Aluno aluno)
    {
        alunos.Add(aluno);
        Console.WriteLine($"Aluno {aluno.Nome} adicionado à instituição de ensino.");
    }
}

// Definição da classe Escola com relacionamento bidirecional
public class Escola
{
    // Atributos
    private List<Aluno> alunos = new List<Aluno>();
    private List<Professor> professores = new List<Professor>();

    // Método para adicionar aluno
    public void AdicionarAluno(Aluno aluno)
    {
        alunos.Add(aluno);
        aluno.Estudar(); // Exemplo de uso do método do aluno
        Console.WriteLine($"Aluno {aluno.Nome} adicionado à escola.");
    }

    // Método para adicionar professor
    public void AdicionarProfessor(Professor professor)
    {
        professores.Add(professor);
        professor.Ensinando(); // Exemplo de uso do método do professor
        Console.WriteLine($"Professor {professor.NomeProfessor} adicionado à escola.");
    }
}
