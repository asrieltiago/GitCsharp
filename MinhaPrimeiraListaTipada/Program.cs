using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            //O indicador <T> é o tipo da minha lista com isso temos uma lista de lanches
            List<Lanche> minhaLista = new List<Lanche>
            {
                //Adiciono na minha lista um pão de queijo
                new Lanche()
                {
                    Nome = "Pão de Queijo",
                    Quantidade = 3,
                    Valor = 1.85
                },

                new Lanche()
                {
                    Nome = "Bolinho de Soya + Refri Bonus: Gastrite",
                    Quantidade = 3,
                    Valor = 7.50
                }
            };
            
            //Um laço solicitando 5 cadastros de lanches
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe o nome, quantidade e valor do lanche: ");
                minhaLista.Add(new Lanche
                {
                    Nome = Console.ReadLine(),
                    Quantidade = Convert.ToInt32(Console.ReadLine()),
                    Valor = Convert.ToDouble(Console.ReadLine())
                });
            }

            //minhaLista.Add(new Lanche()
            //
            //{
            //    Nome = "Bolinho de Soya + Refri Bonus: Gastrite",
            //    Quantidade = 3,
            //    Valor = 7.50
            //});

            //Varro a lista trazendo todos os itens em tela
            //"item in" significa que ele já é um indice da minha lista.
            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponíveis: {item.Nome} | " +
                    $"Quantidade: {item.Quantidade} | " +
                    $"Valor: R$ {item.Valor.ToString("N2")} ");

            Console.WriteLine("Removendo item");            

            foreach (Lanche item in minhaLista)
            {
                if (item.Quantidade == 3)
                {
                    minhaLista.Remove(item);
                    break;
                }            
            }
            
            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponíveis: {item.Nome}");

            Console.ReadKey();
        }
    }
}
