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
            List<Lanche> listaAdd = new List<Lanche>
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
                listaAdd.Add(new Lanche
                {
                    Nome = RetornaValores("Nome"),
                    Quantidade = int.Parse(RetornaValores("Quantidade")),
                    Valor = double.Parse(RetornaValores("Valor"))
                });
            }

            //Varro a lista trazendo todos os itens em tela
            //"item in" significa que ele já é um indice da minha lista.
            foreach (Lanche item in listaAdd)
                Console.WriteLine($"Lanches disponíveis: {item.Nome} | " +
                    $"Quantidade: {item.Quantidade} | " +
                    $"Valor: R$ {item.Valor.ToString("N2")} ");

            Console.WriteLine("Removendo item");            

            foreach (Lanche item in listaAdd)
            {
                if (item.Quantidade == 3)
                {
                    listaAdd.Remove(item);
                    break;
                }            
            }

            foreach (Lanche item in listaAdd)
                Console.WriteLine($"Lanches disponíveis: {item.Nome} | " +
                    $"Quantidade: {item.Quantidade} | " +
                    $"Valor: R$ {item.Valor.ToString("N2")} ");

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra uma interface legal para adicionar os valores
        /// </summary>
        /// <param name="nome">Nome do campo que ira retornar o valor</param>
        /// <returns>Retorna uma string com o valor</returns>
        public static string RetornaValores(string nome)
        {//informo e retorno o valor confrome a solicitação do campo
            Console.WriteLine($"Informe o valor para o campo {nome}");
            return Console.ReadLine();
        }
    }
}
