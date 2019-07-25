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

            decimal nota1, nota2, nota3;

            Console.WriteLine("BEM VINDO AO PROGRAMA DE BOLETIM ESCOLAR\n");
            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = Convert.ToDecimal(Console.ReadLine());

            metodo.Notas(nota1, nota2, nota3);

            metodo.Frequencia();

            metodo.Situacao();

            Console.ReadKey();

        }
    }
}
