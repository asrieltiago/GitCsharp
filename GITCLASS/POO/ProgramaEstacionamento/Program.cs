using ProgramaEstacionamento.ControleEstacionamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Um estacionamento deseja controlar a entrada de carros no estacionamento.
            - Deve ser registrado o modelo do carro, a placa, a hora de entrada e a hora de saída.
            - A placa deve ser a chave de pesquisa para o carro.
            - Quando registrar a entrada do carro a hora de saída ficará nula;
            - Quando o veículo sair do estacionamento, deve ser alterado a hora de saída;

            - Listar todos os registros onde não ocorreu a saída;
            - Listar todos os registros;
            - Listar um registro pesquisando pela placa.

            Criar a classe com os métodos de entrada, saída do estacionamento e listagem em um projeto 
            e a aplicação para cadastrar os carros entrando no estacionamento em outro projeto. */

            Estacionamento metodo = new Estacionamento();


            metodo.EntradaCarro();

            metodo.SaidaCarro();

            metodo.ListarCarros();

            metodo.ListarCarrosEstacionados();

            Console.ReadKey();

        }
    }
}
