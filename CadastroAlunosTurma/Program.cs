using System;

namespace CadastroAlunosTurma
{
    class Program
    {
        static void Main(string[] args)
        {

            int  opcao;

            do
            {

                Console.WriteLine("Escolha a opção desejada");
                Console.WriteLine("1 - Adcionar aluno");
                Console.WriteLine("2 - Buscar Aluno pelo índice");
                Console.WriteLine("3 - Exibir todos os alunos");
                Console.WriteLine("4 - Sair");

                 opcao = int.Parse (Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o nome do aluno: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe a turma do aluno: ");
                        string turma = Console.ReadLine();

                        CadastroDeAlunos.AdicionarAluno(nome, turma);
                        Console.WriteLine("Aluno adiocionado com sucesso!");
                        break;
                    case 2:
                        Console.WriteLine("Informe o índice do aluno que deseja buscar: ");
                        int indiceBusca = int.Parse(Console.ReadLine());

                        Aluno alunoBuscado = CadastroDeAlunos.BuscarAlunoPorIndice(indiceBusca);
                        if (alunoBuscado != null)
                        {
                            Console.WriteLine($"Aluno encontrado - \nId: {alunoBuscado.Id} \nNome: {alunoBuscado.Nome} \nTurma: {alunoBuscado.Turma}");
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }

                        break;
                    case 3:
                        CadastroDeAlunos.ExibirTodosOsAlunos();
                        break;

                    case 4:
                        Console.WriteLine("Saindo do programa ...");
                        break;

                    default:
                        Console.WriteLine("opção inválida. Por gentileza, escolha uma opção válida.");
                        break;
                }


             } while (opcao != 4);


        }
    }
}
