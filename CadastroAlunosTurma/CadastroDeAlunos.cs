using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroAlunosTurma
{
    public static class CadastroDeAlunos
    {
        private static Aluno[] _alunos = new Aluno[100];
        private static int _proximoIndice = 0;

        public static void AdicionarAluno(string nome, string turma)
        {
            if (_proximoIndice < _alunos.Length)
            {

                _alunos[_proximoIndice] = new Aluno()
                {
                    Indice = _proximoIndice,
                    Id = _proximoIndice,
                    Nome = nome,
                    Turma = turma,

                };
                _proximoIndice++;
            }

        }

        public static Aluno BuscarAlunoPorIndice(int indice)
        {
            if (indice >= 0 && indice < _alunos.Length)
            {
                return _alunos[indice];
            }
            return null;
        }
        public static void ExibirTodosOsAlunos()
        {
            foreach (Aluno Aluno in _alunos)
            {
                if (Aluno != null)
                {
                    Console.WriteLine($"\nÍndice: {Aluno.Indice}");
                    Console.WriteLine($"\nId: {Aluno.Id}");
                    Console.WriteLine($"\nNome: {Aluno.Nome}");
                    Console.WriteLine($"\nTurma: {Aluno.Turma}");
                }
            }

        }

    }
}

