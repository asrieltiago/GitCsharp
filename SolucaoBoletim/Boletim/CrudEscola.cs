using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoBoletim.Boletim
{
    public class CrudEscola
    {
        string[,] arrayAluno = new string[2, 6];
        MetodosBoletim metodo = new MetodosBoletim();
        int indiceAluno = 0;

        public int MenuInicial()
        {

            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("           BEM VINDO!         ");
            Console.WriteLine("==============================");
            Console.WriteLine("          MENU INICIAL        ");
            Console.WriteLine("==============================");
            Console.WriteLine("1 - Inserir um registro.");
            Console.WriteLine("2 - Remover um registro.");
            Console.WriteLine("3 - Listar registros ativos.");
            Console.WriteLine("4 - Alterar as notas");
            Console.WriteLine("5 - Alterar a frequência.");
            Console.WriteLine("6 - Sair do sistema.");

            Console.WriteLine("\nDigite o número da opção desejada:");
            var opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;

        }

        /// <summary>
        /// Método utilizado para inserir 5 registros de alunos, solicitar as notas, calcular a média, frequencia e retornar com a situação do mesmo.
        /// </summary>
        public void InsereRegistro()
        {
            Console.WriteLine("\nInforme o nome do Aluno");
            var nomeAluno = Console.ReadLine();

            Console.WriteLine("\nInforme as 3 notas do aluno:");
            int nota1 = Convert.ToInt32(Console.ReadLine());
            int nota2 = Convert.ToInt32(Console.ReadLine());
            int nota3 = Convert.ToInt32(Console.ReadLine());
            //Calculando a media
            var media = metodo.Media(nota1, nota2, nota3);

            Console.WriteLine("\nInforme o numero de aulas:");
            int totAulas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInforme o numero de faltas:");
            int totFaltas = Convert.ToInt32(Console.ReadLine());

            var frequencia = metodo.Frequencia(totAulas, totFaltas);

            var situacao = metodo.RetornaSituacao(media, frequencia);


            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] != null)
                    continue;

                arrayAluno[i, 0] = (indiceAluno++).ToString();
                arrayAluno[i, 1] = nomeAluno;
                arrayAluno[i, 2] = media.ToString();
                arrayAluno[i, 3] = frequencia.ToString();
                arrayAluno[i, 4] = situacao;
                arrayAluno[i, 5] = "true";
                break;
            }
            Console.WriteLine("\nCadastro realizado com sucesso, pressione qualquer tecla para continuar.");

        }

        /// <summary>
        /// Metodo utilizado para remover um Aluno, alterando o cadastro para False.
        /// </summary>
        public void RemoveAluno()
        {
            Console.WriteLine("Relação de Alunos Cadastrados");
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 5] != "false")
                    Console.WriteLine($"ID {arrayAluno[i, 0]} | Nome: {arrayAluno[i, 1]} | Média: {arrayAluno[i, 2]} | Frequência: {arrayAluno[i, 3]} | Situação: {arrayAluno[i, 4]} | Cadastro {arrayAluno[i, 5]}");
            }
            Console.WriteLine("\nInforme o ID do aluno que você deseja remover.");
            var id = Console.ReadLine();

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] != null && arrayAluno[i, 0] == id)
                    arrayAluno[i, 5] = "false";

                //Console.WriteLine($"ID {arrayAluno[i, 0]} | Nome: {arrayAluno[i, 1]} | Média: {arrayAluno[i, 2]} | Frequência: {arrayAluno[i, 3]} | Situação: {arrayAluno[i, 4]} | Cadastro {arrayAluno[i, 5]}");
            }
            Console.WriteLine("\nOperações finalizadas.");
            Console.WriteLine("Aperte qualquer tecla para retornar ao Menu Principal.");
        }

        /// <summary>
        /// Metodo que lista todos os alunos cadastrados, com as medias, frequencias e situações.
        /// </summary>
        public void ListarAlunos()
        {
            Console.WriteLine("Relação de Alunos Cadastrados");
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 5] != "false")
                    Console.WriteLine($"ID {arrayAluno[i, 0]} | Nome: {arrayAluno[i, 1]} | Média: {arrayAluno[i, 2]} | Frequência: {arrayAluno[i, 3]} | Situação: {arrayAluno[i, 4]} | Cadastro {arrayAluno[i, 5]}");
            }

            Console.WriteLine("\nResultados apresentados com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu Principal.");
        }

        public void AlterarNota()
        {
            Console.WriteLine("Relação de Alunos Cadastrados");
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 5] != "false")
                    Console.WriteLine($"ID {arrayAluno[i, 0]} | Nome: {arrayAluno[i, 1]} | Média: {arrayAluno[i, 2]} | Frequência: {arrayAluno[i, 3]}% | Situação: {arrayAluno[i, 4]} | Cadastro {arrayAluno[i, 5]}");
            }

            Console.WriteLine("\nInforme o ID do aluno que você deseja alterar a nota");
            var id = Console.ReadLine();

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] != null && arrayAluno[i, 0] == id)
                {
                    Console.WriteLine($"\nInforme as 3 notas do aluno {id}:");
                    int nota1 = Convert.ToInt32(Console.ReadLine());
                    int nota2 = Convert.ToInt32(Console.ReadLine());
                    int nota3 = Convert.ToInt32(Console.ReadLine());

                    //Calculando a media
                    var media = metodo.Media(nota1, nota2, nota3);
                    arrayAluno[i, 2] = media.ToString();

                    int frequencia = Convert.ToInt32(arrayAluno[i, 3]);
                    arrayAluno[i, 4] = metodo.RetornaSituacao(media, frequencia);

                }

            }
        }
        public void AlterarFrequencia()
        {
            Console.WriteLine("Relação de Alunos Cadastrados");
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 5] != "false")
                    Console.WriteLine($"ID {arrayAluno[i, 0]} | Nome: {arrayAluno[i, 1]} | Média: {arrayAluno[i, 2]} | Frequência: {arrayAluno[i, 3]}% | Situação: {arrayAluno[i, 4]} | Cadastro {arrayAluno[i, 5]}");
            }

            Console.WriteLine("\nInforme o ID do aluno que você deseja alterar a frequência");
            var id = Console.ReadLine();

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] != null && arrayAluno[i, 0] == id)
                {
                    Console.WriteLine("\nInforme o numero de aulas:");
                    int totAulas = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nInforme o numero de faltas:");
                    int totFaltas = Convert.ToInt32(Console.ReadLine());

                    var frequencia = metodo.Frequencia(totAulas, totFaltas);
                    arrayAluno[i, 3] = frequencia.ToString();

                    var media = Convert.ToInt32(arrayAluno[i,2]);    
                    arrayAluno[i, 4] = metodo.RetornaSituacao(media, frequencia);


                }

            }
        }
    }
}