using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora.Funcoes
{
    public class ListaFuncoes
    {
        public void GetNumber()
        {
            int n1 = 0;
            int n2 = 0;

            Console.WriteLine("BEM VINDO AO SISTEMA DE BIBLIOTECA DA NASA");
            Console.WriteLine("Para começar digite o número do primeiro valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número do segundo valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSeguem os resultados:");
        }
               
        public void Adicao(int n1, int n2)
        {                       
            int resultado = n1 + n2;
            Console.WriteLine($"{n1} + {n2} = {resultado}");
        }

        public void Subtracao(int n1, int n2)
        {
            int resultado = n1 - n2;
            Console.WriteLine($"{n1} - {n2} = {resultado}");
        }

        public void Divisao(int n1, int n2)
        {
            int resultado = n1 / n2;
            Console.WriteLine($"{n1} / {n2} = {resultado}");
        }

        public void Multiplicacao(int n1, int n2)
        {
            int resultado = n1 * n2;
            Console.WriteLine($"{n1} x {n2} = {resultado}");
        }
    }

}
