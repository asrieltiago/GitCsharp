using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaEstacionamento.ControleEstacionamento
{
    public class Estacionamento
    {
        string[,] arrayCarros = new string[5, 5]; // definindo o tamanho do Array

        const string Estacionado = "Estacionado"; 
        const string Pago = "Pago";


        /// <summary>
        /// Metodo que registramos um carro em nosso sistema, registrando automaticamente a data de entrada e alterando a situação para Estacionado.
        /// </summary>
        public void EntradaCarro()
        {
            Console.WriteLine("Informe a placa do veículo:");
            string placaCarro = Console.ReadLine();

            Console.WriteLine("Informe o modelo do veículo:");
            var modeloCarro = Console.ReadLine();

            for (int i = 0; i < arrayCarros.GetLength(0); i++)
            {
                if (arrayCarros[i, 0] != null)
                    continue;

                arrayCarros[i, 0] = placaCarro;
                arrayCarros[i, 1] = modeloCarro;
                arrayCarros[i, 2] = DateTime.Now.ToString(); // Data de Entrada
                arrayCarros[i, 3] = ""; // Data de Saída
                arrayCarros[i, 4] = Estacionado;
                break;
            }
            Console.WriteLine("\nCadastro realizado com sucesso, pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Metodo que registra o horário de saída do carro e altera a situação para Pago.
        /// </summary>
        public void SaidaCarro()
        {
            Console.WriteLine("Relação de Veiculos Estacionados");
            for (int i = 0; i < arrayCarros.GetLength(0); i++)
            {
                if (arrayCarros[i, 4] != "Pago")
                    Console.WriteLine($"Placa: {arrayCarros[i, 0]} | Modelo: {arrayCarros[i, 1]} | Data Entrada: {arrayCarros[i, 2]} | Data Saída: {arrayCarros[i, 3]} | Situação: {arrayCarros[i, 4]}");
            }

            Console.WriteLine("Informe a placa do veículo:");
            string placaCarro = Console.ReadLine();


            for (int i = 0; i < arrayCarros.GetLength(0); i++)
            {
                if ((arrayCarros[i, 0] != null) && (arrayCarros[i, 0] == placaCarro))
                {
                    arrayCarros[i, 3] = DateTime.Now.ToString();
                    arrayCarros[i, 4] = Pago;
                }
                break;
            }
            Console.WriteLine("\nSaída realizada com sucesso, pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Metodo que lista todos os carros registrados no sistema.
        /// </summary>
        public void ListarCarros()
        {
            Console.WriteLine("Relação de Veiculos Registrados");
            for (int i = 0; i < arrayCarros.GetLength(0); i++)
            {
                Console.WriteLine($"Placa: {arrayCarros[i, 0]} | Modelo: {arrayCarros[i, 1]} | Data Entrada: {arrayCarros[i, 2]} | Data Saída: {arrayCarros[i, 3]} | Situação: {arrayCarros[i, 4]}");
            }

            Console.WriteLine("\nResultados apresentados com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu Principal.");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Metodo que lista somente os carros Estacionados.
        /// </summary>
        public void ListarCarrosEstacionados()
        {
            Console.WriteLine("Relação de Veiculos Estacionados");
            for (int i = 0; i < arrayCarros.GetLength(0); i++)
            {
                if (arrayCarros[i, 4] != Pago)
                    Console.WriteLine($"Placa: {arrayCarros[i, 0]} | Modelo: {arrayCarros[i, 1]} | Data Entrada: {arrayCarros[i, 2]} | Data Saída: {arrayCarros[i, 3]} | Situação: {arrayCarros[i, 4]}");
            }

            Console.WriteLine("\nResultados apresentados com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu Principal.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
