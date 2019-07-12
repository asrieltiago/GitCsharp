using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnlineNasa3PONTOZERO
{

    class Program
    {
        static string[,] baseDeLivros;
        static void Main(string[] args)
        {

            CarregaBaseDeDados(); // chamando a função 

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 3)
            {
                if (opcaoMenu == 1)
                    LocarUmLivro();

                if (opcaoMenu == 2)
                    DesalocarUmLivro();

                opcaoMenu = MenuPrincipal();
            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Volte sempre!");

            Console.ReadKey();
        }

        /// <summary>
        /// Mensagem de Abertura do Sistema.
        /// </summary>
        public static void MostrarSejaBemVindo() //dando nome para a função        
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("         Seja bem vindo ao sistema de locação de livros.           ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("               Desenvolvido pela Troll company");
            Console.WriteLine("-------------------------------------------------------------------");
        } /// void não se espera que retorne alguma coisa

        // summary utilizado logo acima de um método
        /// <summary> 
        /// Metodo que mostra o conteudo do menu inicial e as opcoes de escolha
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("MENU INICIAL \n");
            Console.WriteLine("O que você deseja fazer?\n");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Devolver um livro.");
            Console.WriteLine("3 - Sair do sistema. \n");
            Console.WriteLine("Digite o número desejado: ");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao); // transformado resposta para int e jogado na variavel opcao


            return opcao; // return significa que essa função irá retornar algo

            //var opcao = Console.ReadKey().KeyChar.ToString(); // traz somente a informação textual
        }

        /// <summary>
        /// Método que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O pequeno","sim"},
                { "O grande","não"}
            };
        }

        /// <summary>
        /// Metodo que retorna se um livro pode ser locado.
        /// </summary>
        /// <param name="nomeDoLivro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro caso o livro esteja livre para a locação, senão, retorna como falso.</returns>
        public static bool? PesquisaLivroParaAlocacao(ref string nomeDoLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++) // GetLength(0) # 0 é a primeira coluna do banco de dados
            {
                if (CompararNomes(nomeDoLivro, baseDeLivros[i, 0]))
                {
                    Console.WriteLine($"O livro: {nomeDoLivro}" +
                        $" pode ser alocado?: {baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "sim";
                }
            }

            Console.WriteLine("Nenhum livro encontrado, deseja realizar a busca novamente?");
            Console.WriteLine("Digite o número da opção desejada: Sim (1) | Não (2)");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome do livro a ser pesquisado:");
                nomeDoLivro = Console.ReadLine();

                return PesquisaLivroParaAlocacao(ref nomeDoLivro);
            }
            return null;
        }

        /// <summary>
        /// Metodo para alterar a informação de locação do livro.
        /// </summary>
        /// <param name="nomeDoLivro">Nome do livro a ser alocado.</param>
        /// <param name="locar">Valor booleano que define se o livro esta ou não disponível.</param>
        public static void LocarLivro(string nomeDoLivro, bool locar)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (CompararNomes(nomeDoLivro, baseDeLivros[i, 0]))
                    baseDeLivros[i, 1] = locar ? "não" : "sim";   // após a locação, irá alterar o status de SIM para NAO e de NAO para SIM
            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("LISTAGEM ATUALIZADA COM SUCESSO!\r\n");
        }

        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do menu 1
        /// </summary>
        public static void LocarUmLivro()
        {
            MostrarMenuInicialLivros("Locar um livro: ");

            var nomeDoLivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(ref nomeDoLivro);

            if (resultadoPesquisa != null && resultadoPesquisa == true) // se o resultado da pesquisa for diferente de NULL e igual a TRUE;
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja locar o livro? Sim [1] | Não [2]");

                LocarLivro(nomeDoLivro, Console.ReadKey().KeyChar.ToString() == "1");

                Console.WriteLine("Listagem de livros: \r\n");

                MostrarListaDeLivros();

                Console.WriteLine("Volte sempre! \n");
                Console.WriteLine("Pressione Qualquer tecla para retornar ao Menu Principal.");
            }

            if (resultadoPesquisa == null)
            {
                Console.WriteLine("Livro não localizado");
                Console.WriteLine("Pressione Qualquer tecla para retornar ao Menu Principal.");
            }

            Console.ReadKey();
        }


        /// <summary>
        /// Metodo que mostra a lista de livros atualizada.
        /// </summary>
        public static void MostrarListaDeLivros()
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeLivros[i, 0]} \r\n" +
                    $"Disponível: {baseDeLivros[i, 1]}");

                Console.WriteLine("");
            }
        }

        public static void DesalocarUmLivro()
        {
            MostrarMenuInicialLivros("Desalocar um livro: ");

            MostrarListaDeLivros();

            var nomeDoLivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(ref nomeDoLivro);

            if (resultadoPesquisa != null && resultadoPesquisa == false) // se o usuário não preencher corretamente, o livro não poderá ser alocado. 
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja Devolver um livro? Sim [1] | Não [2]");

                LocarLivro(nomeDoLivro, Console.ReadKey().KeyChar.ToString() == "2");

                Console.WriteLine("Listagem de livros: \r\n");

                MostrarListaDeLivros();

                Console.WriteLine("Volte sempre! \n");
                Console.WriteLine("Pressione Qualquer tecla para retornar ao Menu Principal.");
            }
            Console.ReadKey();
        }

        public static void MostrarMenuInicialLivros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao} ");
            Console.WriteLine("Digite o nome do livro para realizar a operação:\n");
        }

        public static bool CompararNomes(string primeiro, string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "") == segundo.ToLower().Replace(" ", ""))
                return true;

            return false;


        }
    }
}
