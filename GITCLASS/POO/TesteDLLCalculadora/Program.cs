using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraClassBrunoV;


namespace TesteDLLCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadorinha calc = new Calculadorinha();

            double n1 = 10;
            double n2 = 10;
            double comprimento = 10;
            double altura = 10;
            double raio = 10;

            var adicao = calc.calculoSoma(n1, n2);
            var subtracao = calc.calculoSubtracao(n1, n2);
            var multiplicacao = calc.calculoMultiplicacao(n1, n2);
            var divisao = calc.calculoDivisao(n1, n2);
            var retangulo = calc.calculoRetangulo(comprimento, altura);
            var triangulo = calc.calculoTriangulo(comprimento, altura);
            var circulo = calc.calculoCirculo(raio);

            Console.WriteLine($"{adicao}, {subtracao}, {multiplicacao}, {divisao}, {retangulo}, {triangulo}, {circulo}");

            Console.ReadKey();



        }
    }
}
