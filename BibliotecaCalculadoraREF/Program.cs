using BibliotecaCalculadora.Funcoes;
using FuncoesCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaCalculadoraREF
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaFuncoes funcoes = new ListaFuncoes();
            FuncoesCalc funcao = new FuncoesCalc();

            int n1, n2, largura, comprimento = 0;
            double area = 0;
            

            Console.WriteLine("BEM VINDO AO SISTEMA DE BIBLIOTECA DA NASA");
            Console.WriteLine("Para começar digite o número do primeiro valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número do segundo valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSeguem os resultados:");

            var adicao = funcao.Adicao(n1, n2);

            var subtracao = funcao.Subtracao(n1, n2);

            var multiplicacao = funcao.Multiplicacao(n1, n2);

            var divisao = funcao.Divisao(n1, n2);

            Console.WriteLine($"Adição:{adicao} | Subtração: {subtracao} | Multiplicação {multiplicacao} | Divisão: {divisao}");

            Thread.Sleep(500);

            Console.WriteLine("\nDigite a Largura para Calcularmos os valores de um Triângulo Equilatero e de um Retângulo");
            largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Altura: ");
            comprimento = Convert.ToInt32(Console.ReadLine());

            var retangulo = funcao.AreaRetângulo(comprimento, largura);
            Console.WriteLine($"Area Retângulo: {retangulo}");

            Thread.Sleep(500);
            var trianguloeq = funcao.AreaTrianguloEqui(comprimento, largura);
            Console.WriteLine($"Area Triângulo Equilatero: {trianguloeq}");

            Console.WriteLine("\nDigite a Area para Calcularmos o raio de um círculo");
            area = Convert.ToDouble(Console.ReadLine());

            var circulo = funcao.RaioCirculo(Convert.ToInt32(area));
            Console.WriteLine($"Area Circulo: {circulo}");

            Console.ReadKey();
        }
    }
}
