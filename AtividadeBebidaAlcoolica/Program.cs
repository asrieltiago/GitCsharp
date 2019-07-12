using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtividadeBebidaAlcoolica
{
    class Program
    {
        static void Main(string[] args)
        {

            // Crie um Sistema que indique se a pessoa informada é maior de 18 anos, e se está autorizada a consumir bebidas alcoólicas.

            string opcao = "1";

            while (opcao == "1")
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Seja bem vindo ao Sistema AMBEV");
                Console.WriteLine("================================\n");

                Console.WriteLine("Para começar, digite o seu nome:");
                string nome = Console.ReadLine().ToUpper();

                Console.WriteLine("\nAgora digite a sua idade para sabermos se você \nestá autorizado a consumir bebidas alcoólicas:");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nAguarde um momento enquanto calculamos a sua idade... \n");
                Thread.Sleep(1500);

                if (idade < 18)
                {
                    Console.WriteLine($"\n{nome}, infelizmente a AMBEV está sem Leite no estoque.");
                    Console.WriteLine($"Tente novamente daqui a {18 - idade} anos. ");
                }

                else
                {
                    Console.WriteLine("==================================================");
                    Console.WriteLine($"PARABÉNS {nome}! \nA sua idade é {idade} e você já consumir os produtos AMBEV.");
                    Console.WriteLine("====================================================================================");
                    Console.WriteLine("Acesse o nosso site: www.ambev.com.br e confira os nossos produtos.\n");                    
                }

                Console.WriteLine("\nPRESSIONE [1] para retornar ou QUALQUER TECLA para encerrar a aplicação.");
                Console.ReadKey();
            }

            
            
            
            
        }
    }
}
