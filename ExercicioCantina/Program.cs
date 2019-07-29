using ExercicioCantina.Cantina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCantina
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos cantina = new Metodos();

            cantina.ListarLanchinhos();            

            while (cantina.Saldo > 0.00)
            {
                Console.Write($"\n{cantina.Nome}, informe qual lanche você quer comprar: ");

                cantina.ComprarLanchinho();            

                cantina.MostrarSaldo();

                Console.WriteLine("Compra realizada com sucesso.");
                Console.WriteLine($"Seu saldo atual é de R$ {cantina.Saldo}");

                Console.ReadKey();

                break;
            }


        }
    }
}
