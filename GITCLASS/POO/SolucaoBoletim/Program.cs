using SolucaoBoletim.Boletim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoBoletim
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodosBoletim metodo = new MetodosBoletim();

            Console.WriteLine("BEM VINDO AO PROGRAMA DE BOLETIM ESCOLAR\n");
            Console.WriteLine("Digite a primeira nota: ");
            var nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            var nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            var nota3 = Convert.ToInt32(Console.ReadLine());

            var media = metodo.Media(nota1, nota2, nota3);

            Console.WriteLine("Digite o número de aulas: ");
            var totAulas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número de faltas: ");
            var totFaltas = Convert.ToInt32(Console.ReadLine());

            int frequencia = metodo.Frequencia(totAulas, totFaltas);

            metodo.Media(nota1, nota2, nota3);

            metodo.Frequencia(totAulas, totFaltas);

            metodo.Situacao(media, frequencia);

            Console.ReadKey();
        }
    }
}
