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
            Metodos compraCantina = new Metodos();

            compraCantina.ListarLanchinhos();            

            while (true)
            {
                Console.Write($"\n{compraCantina.Nome}, informe qual lanche você quer comprar: ");

                compraCantina.ComprarLanchinho();            

                compraCantina.MostrarSaldo();

                Console.WriteLine("Compra realizada com sucesso.");
                Console.WriteLine($"Seu saldo atual é de R$ {compraCantina.Saldo}");

                Console.ReadKey();

            }


        }
    }
}
