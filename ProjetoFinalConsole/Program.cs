using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeLivros = new string[5, 5];
            int IndiceLivros = 0;
            var escolhaInicial = MostrarMenuInicial();

            while (true)
            {
                switch (escolhaInicial)
                {
                    case "1": { InserirRegistroLista(ref baseDeLivros, ref IndiceLivros); } break;
                    case "2": { RemoverRegistroLivro(ref baseDeLivros); } break;
                    case "3": { MostrarInformacoesLivros(baseDeLivros); } break;
                    case "4": { MostrarInformacoesLivros(baseDeLivros, "true"); } break;
                    case "5": { return; }
                    default: { Console.WriteLine("\nNão foi uma escolha valida dentro do menu de opções."); Console.ReadKey(); } break;
                }
                escolhaInicial = MostrarMenuInicial();
            }
        }

        /// <summary>
        /// Metodo que apresenta as informações do Menu Inicial.
        /// </summary>
        /// <returns>Retorna o Menu Escolhido.</returns>
        public static string MostrarMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("           BEM VINDO!         ");
            Console.WriteLine("==============================");
            Console.WriteLine("          MENU INICIAL        ");
            Console.WriteLine("==============================");
            Console.WriteLine("1 - Inserir um novo registro.");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar os livros ativos.");
            Console.WriteLine("4 - Listar os livros inativos.");
            Console.WriteLine("5 - Sair do sistema.");

            Console.WriteLine("\nDigite o número da opção desejada:");

            return Console.ReadLine();
        }

        /// <summary>
        /// Metodo que insere as informações digitadas na nossa base de dados
        /// </summary>
        /// <param name="baseDeLivros">Base de dados, utilizando o REF para alterar todos os métodos.</param>
        /// <param name="IndiceLivros">Indice da nossa base, utilizando o REF para alterar todos os métodos</param>
        public static void InserirRegistroLista(ref string[,] baseDeLivros, ref int IndiceLivros)
        {
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("    Inserindo Livros em Nossa Biblioteca    ");
            Console.WriteLine("============================================");
            Console.WriteLine("Informe o nome do Livro:");
            var nomeLivro = Console.ReadLine();

            Console.WriteLine("\nInforme o Autor:");
            var autor = Console.ReadLine();

            AumentaTamanhoLista(ref baseDeLivros);

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 0] != null)
                    continue;

                baseDeLivros[i, 0] = (IndiceLivros++).ToString();
                baseDeLivros[i, 1] = nomeLivro;
                baseDeLivros[i, 2] = autor;
                baseDeLivros[i, 3] = "true";
                baseDeLivros[i, 4] = DateTime.Now.ToString();
                break;

            }
            Console.WriteLine("\nLivro cadastrado com sucesso!\n");
            Console.WriteLine("Aperte qualquer tecla para retornar ao Menu Principal.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo utilizado para remover um registro utilizando a ID do livro da Base de Dados.
        /// </summary>
        /// <param name="baseDeLivros">Base de Dados aonde ele irá remover o registro do ID informado</param>
        public static void RemoverRegistroLivro(ref string[,] baseDeLivros)
        {
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("    Removendo Livros em Nossa Biblioteca    ");
            Console.WriteLine("============================================");

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 3] != "false")
                    Console.WriteLine($"ID {baseDeLivros[i, 0]} | Livro: {baseDeLivros[i, 1]} | Autor: {baseDeLivros[i, 2]} | Data Alteração: {baseDeLivros[i, 4]}");
            }

            Console.WriteLine("\nInforme o ID de Registro do Livro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 0] != null && baseDeLivros[i, 0] == id)
                {
                    baseDeLivros[i, 3] = "false";
                    baseDeLivros[i, 4] = DateTime.Now.ToString();
                }
            }
            Console.WriteLine("\nOperações finalizadas.");
            Console.WriteLine("Aperte qualquer tecla para retornar ao Menu Principal.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que mostra as informações que constam na nossa lista de dados "baseDeLivros"
        /// </summary>
        /// <param name="baseDeLivros">Base de Dados que será mostrada para o usuário, separando os Ativos e os Inativos.</param>
        /// <param name="mostrarInativos">Quando identificado como true, o mesmo retorna com a informação dos livros inativos dentro da base de dados.</param>
        public static void MostrarInformacoesLivros(string[,] baseDeLivros, string mostrarInativos = "false")
        {
            if (mostrarInativos == "true")
            {
                Console.Clear();
                Console.WriteLine("====================================================");
                Console.WriteLine("Registros de Livros Inativos dentro do nosso sistema");
                Console.WriteLine("====================================================\n");
            }

            else
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("Registros de Livros Ativos dentro do nosso sistema");
                Console.WriteLine("==================================================\n");
            }

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 3] != mostrarInativos)
                {
                    Console.WriteLine($"ID {baseDeLivros[i, 0]} | Livro: {baseDeLivros[i, 1]} | Autor: {baseDeLivros[i, 2]} | Data Alteração: {baseDeLivros[i, 4]}");
                }
            }

            Console.WriteLine("\nResultados apresentados com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu Principal.");
            Console.ReadKey();
        }

        /// <summary>
        /// Método utilizado para aumentarmos o tamanho da base de dados assim que ela chegar no limite, permitindo que novos registros sejam realizados.
        /// </summary>
        /// <param name="baseDeLivros">Retorna para a nossa base de dados</param>
        public static void AumentaTamanhoLista(ref string[,] baseDeLivros)
        {
            //Verifica se precisa cruar uma lista maior
            var limiteDaLista = true;

            //Laço que verifica se existe registro disponível
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                //Caso ainda existir registro disponível, ele seta nossa variável "limitaDaLista" para false
                if (baseDeLivros[i, 0] == null)
                    limiteDaLista = false;
            }

            //Caso não tenha mais registro, nossa variável ficou como true, então indica que precisamos aumentar nossa lista.
            if (limiteDaLista)
            {
                //Criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = baseDeLivros;

                //Aqui limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaços
                baseDeLivros = new string[baseDeLivros.GetLength(0) + 5, 5];

                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do identificador único
                    baseDeLivros[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    baseDeLivros[i, 1] = listaCopia[i, 1];
                    //Copiamos a informação do identificador único
                    baseDeLivros[i, 2] = listaCopia[i, 2];
                    //Copiamos a informação do nosso nome
                    baseDeLivros[i, 3] = listaCopia[i, 3];
                    //Copiamos a informação do nosso nome
                    baseDeLivros[i, 4] = listaCopia[i, 4];
                }
                //indicamos que neste ponto a lista foi atualizada em seu tamanho.
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }

        }
    }
}
