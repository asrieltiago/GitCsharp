using BibliotecaCalculadora.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadoraREF
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaFuncoes funcoes = new ListaFuncoes();

            int n1 = 0;
            int n2 = 0;

            Console.WriteLine("BEM VINDO AO SISTEMA DE BIBLIOTECA DA NASA");
            Console.WriteLine("Para começar digite o número do primeiro valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número do segundo valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSeguem os resultados:");

            funcoes.Adicao(n1, n2);

            funcoes.Subtracao(n1, n2);

            funcoes.Multiplicacao(n1, n2);

            funcoes.Divisao(n1, n2);

            Console.ReadKey();
        }
    }
}
