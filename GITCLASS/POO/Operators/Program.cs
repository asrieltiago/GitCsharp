using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementoX = new Teste(5,5); // NEW é um operador de instância
                                            //Criando uma instÂncia podemos acessar as informações a qualquer momento.
            elementoX.MostrarInformacoes();

            elementoX.AlteraInformacoes(5,5);

            elementoX.MostrarInformacoes();

            MeninaSuperFoderoza(ElementoX);
            //elementoX.AlteraInformacoes();

            elementoX.MostrarInformacoes();

            Console.ReadKey();
        }
    }

    public class Teste 
    {
        private int A { get; set; } = 0;
        private int B { get; set; } = 0; //Propriedades
        public Teste(int pA, int pB) //Construtor
        {
            A = pA;
            B = pB;
        }

        public static void MeninaSuperFoderoza(ref Teste pTeste)
        {
            pTeste.AlteraInformacoes();
            MostrarInformacoes();
        }
        public void AlteraInformacoes()
        {
            A = B * 100;
        }
        public void AlteraInformacoes(int pA, int pB)
        {
            A = pA * 2;
            B = pB * 2;
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine(A+B);
        }
    }
}
