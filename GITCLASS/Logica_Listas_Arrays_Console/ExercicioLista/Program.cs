using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeCarros = new string[3, 3];

            int IdParaLista = 0;

            MenuOpcoes(ref listaDeCarros, ref IdParaLista);

            Console.ReadKey();

            MenuOpcoes(ref listaDeCarros, ref IdParaLista);

            Console.ReadKey();

        }

        public static void MenuOpcoes(ref string[,] listaDeCarros, ref int IdParaLista)
        {
            for (int i = 0; i < listaDeCarros.GetLength(0); i++)
            {

                if (listaDeCarros[i, 0] != null)
                    continue;

                Console.WriteLine("Informe o Nome do Veículo para adicionarmos ao registro: ");
                var nome = Console.ReadLine();
                Console.WriteLine("\nDigite a Marca do Veículo informado: ");
                var marca = (Console.ReadLine());

                listaDeCarros[i, 0] = (IdParaLista++).ToString();
                listaDeCarros[i, 1] = nome;
                listaDeCarros[i, 2] = marca;

                Console.WriteLine("\r\nO que você deseja fazer? [1] Adicionar | [2] Remover | [3] Sair :");

                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "2")
                {
                    Console.WriteLine("Escolha um registro a ser apagado:");
                    var apagar = (Console.ReadLine());

                    if (apagar == listaDeCarros[i, 0])
                    {
                        listaDeCarros[i, 0] = null;
                        listaDeCarros[i, 1] = null;
                        listaDeCarros[i, 2] = null;

                        Console.WriteLine(string.Format("\nO Carro com ID {0} foi excluído com sucesso!", listaDeCarros[i, 0], listaDeCarros[i, 1], listaDeCarros[i, 2]));
                        Console.ReadKey();
                    }

                }

                if (continuar == "3")
                {
                    break;
                }
            }

            Console.WriteLine("\r\nRegistro adicionado com sucesso, segue lista de informações adicionadas: ");

            for (int i = 0; i < listaDeCarros.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("ID do Veículo {0} | Nome do Veículo {1} | Marca do Veículo {2}", listaDeCarros[i, 0], listaDeCarros[i, 1], listaDeCarros[i, 2]));
            }

            Console.ReadKey();
        }
    }
}
