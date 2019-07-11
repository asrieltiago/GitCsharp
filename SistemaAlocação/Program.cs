using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaAlocação
{

    class Program
    {
        static string[,] baseDeReliquias;
        static void Main(string[] args)
        {

            CarregaBaseDeReliquias();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 4)
            {
                if (opcaoMenu == 1)
                    LocarUmaReliquia();

                if (opcaoMenu == 2)
                    DevolverUmaReliquia();

                if (opcaoMenu == 3) 
                    Lista();                

                opcaoMenu = MenuPrincipal();
            }

            Console.Clear();
            SejaBemVindo();
            VolteSempre();

            Console.ReadKey();
        }

        /// <summary>
        /// Menu de Boas vindas.
        /// </summary>
        public static void SejaBemVindo()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("BEM VINDO AO SISTEMA DE LOCAÇÃO DE VEÍCULOS\r\n " +
                              "            RELÍQUIAS DO RUDY");
            Console.WriteLine("===========================================");

        }

        /// <summary>
        /// Metodo que mostra o menu inicial e as opções disponíveis para escolha.
        /// </summary>
        /// <returns>Retorna o valor da opcao desejada em um tipo inteiro.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();
            SejaBemVindo();

            Console.WriteLine("MENU INICIAL - Locação de Veículos\n");
            Console.WriteLine("O que você deseja fazer?\n");
            Console.WriteLine("1 - Locar um Veículo.");
            Console.WriteLine("2 - Devolver um Veículo.");
            Console.WriteLine("3 - Listar Relíquias");
            Console.WriteLine("4 - Sair do Sistema\n");
            Console.WriteLine("Digite a opção desejada: ");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        /// <summary>
        /// Metodo que carrega a base dos veículos disponíveis dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeReliquias()
        {
            baseDeReliquias = new string[6, 3]
            {
                    {"Escort", "1984", "Sim" },
                    {"Brasilia", "1955", "Sim"},
                    {"Fusca", "1955", "Sim"},
                    {"Variant", "1962", "Sim"},
                    {"TL", "1961", "Não"},
                    {"Versailles", "1991", "Não"}
            };
        }

        /// <summary>
        /// Metodo que retorna se um veiculo pode ser locado.
        /// </summary>
        /// <param name="nomeDaReliquia">Nome do veiculo a ser pesquisado.</param>
        /// <returns>Retorna verdadeiro caso o veiculo esteja disponivel para locação, senão, retorna como falso.</returns>
        public static bool PesquisaReliquiaParaLocacao(string nomeDaReliquia)
        {
            for (int i = 0; i < baseDeReliquias.GetLength(0); i++)
            {
                if (nomeDaReliquia == baseDeReliquias[i, 0])
                {

                    Console.WriteLine($"A relíquia: {nomeDaReliquia} " + $"pode ser locada? {baseDeReliquias[i, 2]}");

                    return baseDeReliquias[i, 2] == "Sim";
                }
            }
            return false;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomeDoLivro"></param>
        /// <param name="locar">Metodo que irá alterar a disponibilidade do veículo.</param>
        public static void AtualizarReliquia(string nomeDaReliquia, bool locar)
        {
            for (int i = 0; i < baseDeReliquias.GetLength(0); i++)
            {
                if (nomeDaReliquia == baseDeReliquias[i, 0])
                    baseDeReliquias[i, 2] = locar ? "Não" : "Sim";   // após a locação, irá alterar o status de SIM para NAO e de NAO para SIM
            }

            Console.Clear();
            SejaBemVindo();
            Console.WriteLine("LIVRO ATUALIZADO COM SUCESSO!\r\n");
        }
        /// <summary>
        /// Metodo que loca o veículo conforme o parametro usado, alterando a disponibilidade para "Não".
        /// </summary>
        /// <param name="nomeDaReliquia">Nome do Veiculo a ser locado.</param>
        public static void LocarReliquia(string nomeDaReliquia)
        {
            for (int i = 0; i < baseDeReliquias.GetLength(0); i++)
            {
                if (nomeDaReliquia == baseDeReliquias[i, 0])
                    baseDeReliquias[i, 2] = "Não";
            }
        }

        /// <summary>
        /// Metodo que carrega o conteudo inicial do Menu 1
        /// </summary>
        public static void LocarUmaReliquia()
        {
            MostrarMenuInicialReliquia("Locar uma Relíquia: ");

            Console.Clear();

            SejaBemVindo();

            Console.WriteLine("MENU - Locação de Relíquias\n");
            MostrarListaDeReliquias();

            Console.WriteLine("\nDigite o nome da Relíquia desejada:");

            var nomeDaReliquia = Console.ReadLine();

            if (PesquisaReliquiaParaLocacao(nomeDaReliquia)) // se o usuário não preencher corretamente, o veículo não poderá ser locado.
            {
                Console.Clear();
                Console.WriteLine("Você deseja locar esta relíquia? Sim [1] | Não [2]");

                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    LocarReliquia(nomeDaReliquia);
                    Console.Clear();
                    Console.WriteLine(">>> RELÍQUIA LOCADA COM SUCESSO! <<<");
                }

                else
                {
                    Console.Clear();
                    VolteSempre();
                }

                Console.WriteLine("==================================");
                Console.WriteLine("       RELAÇÃO DE RELÍQUIAS: ");
                Console.WriteLine("==================================");

                for (int i = 0; i < baseDeReliquias.GetLength(0); i++)
                {
                    Console.WriteLine($"RELÍQUIA: {baseDeReliquias[i, 0]}\n" + $"DISPONÍVEL: {baseDeReliquias[i, 2]}\r\n");

                }
                Console.Clear();
                VolteSempre();
            }
        }

        public static void DevolverUmaReliquia()
        {

            MostrarMenuInicialReliquia("Devolver uma Relíquia: \n");

            Console.Clear();

            SejaBemVindo();

            Console.WriteLine("      MENU - Devolução de Relíquias\n");
            MostrarListaDeReliquias();
            Console.WriteLine("\nQual Relíquia você deseja devolver?");

            var nomeDaReliquia = Console.ReadLine();
            if (PesquisaReliquiaParaLocacao(nomeDaReliquia)) // se o usuário não preencher corretamente, o veículo não poderá ser locado.
            {
                Console.Clear();
                SejaBemVindo();
                Console.WriteLine("Você deseja Devolver esta Relíquia? Sim [1] | Não [2]");

                AtualizarReliquia(nomeDaReliquia, Console.ReadKey().KeyChar.ToString() == "2");

                Console.Clear();
                Console.WriteLine(">>> RELÍQUIA DEVOLVIDA COM SUCESSO! <<<");
            }
            else
            {
                Console.Clear();
                SejaBemVindo();
                Console.WriteLine("Carro não encontrado. ");
                Console.WriteLine("Aperte qualquer tecla para retornar ao Menu Inicial.");

                Console.ReadKey();
                Console.Clear();
            }
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("          RELAÇÃO DE RELÍQUIAS: ");
                Console.WriteLine("===========================================");

                for (int i = 0; i < baseDeReliquias.GetLength(0); i++)
                {
                    Console.WriteLine($"RELÍQUIA: {baseDeReliquias[i, 0]}\n" + $"DISPONÍVEL: {baseDeReliquias[i, 2]}\r\n");

                }
                Console.Clear();
                VolteSempre();
            }
        }

        public static void MostrarMenuInicialReliquia(string operacao)
        {
            Console.Clear();

            SejaBemVindo();

            Console.WriteLine($"Menu - {operacao} ");
        }

        public static void MostrarListaDeReliquias()
        {
            for (int i = 0; i < baseDeReliquias.GetLength(0); i++)
            {
                Console.WriteLine($"NOME: {baseDeReliquias[i, 0]} | ANO: {baseDeReliquias[i, 1]} | DISPONÍVEL: {baseDeReliquias[i, 2]}");

            }
        }

        public static void Lista()
        {
            Console.Clear();
            SejaBemVindo();
            Console.WriteLine("           LISTAGEM DE RELÍQUIAS\n");
            MostrarListaDeReliquias();
            Console.WriteLine("\nDigite qualquer tecla para retornar ao Menu Inicial.");

            Console.ReadKey();
        }

        /// <summary>
        /// Mensagem de Volte Sempre, que finaliza a aplicação.
        /// </summary>
        public static void VolteSempre()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("          Obrigado! Volte sempre!");
            Console.WriteLine("===========================================");
            Console.WriteLine("Digite qualquer tecla para retornar ao Menu Inicial.");

            Console.ReadKey();
            Console.Clear();

            //            Thread.Sleep(500);
            //
            //            var contador = 0;
            //            string espaco = "   ";
            //
            //            while (contador < 10)
            //            
            //            {
            //                Thread.Sleep(300);
            //                Console.Clear();
            //                VolteSempre();
            //                Console.Write(@"     ___________
            //    //   |||   \\
            // __//____|||____\\____
            //| _|      |       _  ||
            //|/ \______|______/ \_|| 
            //_\_/_____________\_/_______
            //");
            //                Thread.Sleep(300);
            //                Console.Clear();
            //                VolteSempre();
            //                Console.Write($@"{espaco}          ___________
            //{espaco}         //   |||   \\
            //{espaco}      __//____|||____\\____
            //{espaco}      | _|      |     --_  ||
            //{espaco}      |/ \______ | __ / \_ || 
            //{espaco}     __\_/ ___________\_/ _______
            //");
            //                Thread.Sleep(300);
            //                Console.Clear();
            //                VolteSempre();
            //                Console.Write($@"{espaco}{espaco}          ___________
            //{espaco}{espaco}         //   |||   \\
            //{espaco}{espaco}      __//____|||____\\____
            //{espaco}{espaco}      | _|      |     --_  ||
            //{espaco}{espaco}      |/ \______ | __ / \_ || 
            //{espaco}{espaco}     __\_/ ___________\_/ _______
            //");
            //                Thread.Sleep(300);
            //                Console.Clear();
            //                VolteSempre();
            //                Console.Write($@"{espaco}{espaco}{espaco}          ___________
            //{espaco}{espaco}{espaco}         //   |||   \\
            //{espaco}{espaco}{espaco}      __//____|||____\\____
            //{espaco}{espaco}{espaco}      | _|      |     --_  ||
            //{espaco}{espaco}{espaco}      |/ \______ | __ / \_ || 
            //{espaco}{espaco}{espaco}     __\_/ ___________\_/ _______
            //");
            //                Thread.Sleep(300);
            //                Console.Clear();                
            //                Console.Write($@"{espaco}{espaco}{espaco}{espaco}          ___________
            //{espaco}{espaco}{espaco}{espaco}         //   |||   \\
            //{espaco}{espaco}{espaco}{espaco}      __//____|||____\\____
            //{espaco}{espaco}{espaco}{espaco}      | _|      |     --_  ||
            //{espaco}{espaco}{espaco}{espaco}      |/ \______ | __ / \_ || 
            //{espaco}{espaco}{espaco}{espaco}     __\_/ ___________\_/ _______
            //");
            //                Thread.Sleep(300);
            //                Console.Clear();
            //                VolteSempre();
            //                Console.Write($@"{espaco}{espaco}{espaco}{espaco}{espaco}          ___________
            //{espaco}{espaco}{espaco}{espaco}{espaco}         //   |||   \\
            //{espaco}{espaco}{espaco}{espaco}{espaco}      __//____|||____\\____
            //{espaco}{espaco}{espaco}{espaco}{espaco}      | _|      |     --_  ||
            //{espaco}{espaco}{espaco}{espaco}{espaco}      |/ \______ | __ / \_ || 
            //{espaco}{espaco}{espaco}{espaco}{espaco}     __\_/ ___________\_/ _______
            //");
            //            }

        }
    }
}