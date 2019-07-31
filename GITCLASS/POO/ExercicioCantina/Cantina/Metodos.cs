using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCantina.Cantina
{
    public class Metodos
    {
        string nome;
        double saldo;
        string[,] lanches;

        public Metodos()
        {
            saldo = 20;
            nome = "Pedrinho";
            lanches = new string[3, 3] { { "1", "Coxinha", "5" },
                                         { "2", "Pastel ", "4" },
                                         { "3", "Risoles", "6" } };
        }

        public string Nome { get { return nome; } }
        public double Saldo { get { return saldo; } }

        public void ListarLanchinhos()
        {
            for (int i = 0; i < lanches.GetLength(0); i++)
            {
                Console.WriteLine($"Opção {lanches[i, 0]} | {lanches[i, 1]} | R$ {lanches[i, 2]}");
            }
        }
        public bool ComprarLanchinho()
        {
            int.TryParse(Console.ReadLine(), out int opcao);

            for (int i = 0; i < lanches.GetLength(0); i++)
            {

                if (saldo >= Convert.ToDouble(lanches[i, 2]) && (opcao == Convert.ToInt32(lanches[i, 0])))
                {
                    saldo -= Convert.ToDouble(lanches[i, 2]);
                    return true;
                }
            }
            return false;


        }

        public double MostrarSaldo()
        {
            return saldo;
        }

    }
}
