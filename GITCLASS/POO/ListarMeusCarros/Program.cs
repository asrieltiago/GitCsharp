using ListarMeusCarros.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarMeusCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> listaAdd = new List<Carro>();

            //{
            //    new Carro()
            //    {
            //        Modelo = RetornaValores("Modelo"),
            //        Ano = int.Parse(RetornaValores("Ano")),
            //        Placa = RetornaValores("Placa"),
            //        Cv = int.Parse(RetornaValores("Cv"))
            //    }
            //};
                    
            bool concluido = false;

            while (!concluido)
            {
                switch (MenuInicial())
                {
                    //case 1: { ListarCarros(); } break;
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Listagem de Carros:");
                            foreach (Carro item in listaAdd)
                                Console.WriteLine($"Modelo Disponível: {item.Modelo} Ano: {item.Ano} Placa: {item.Placa} Cv: {item.Cv}");
                            break;

                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Adicionando Carros em nossa lista:");
                            listaAdd.Add(
                                new Carro()
                                {
                                    Modelo = RetornaValores("Modelo"),
                                    Ano = int.Parse(RetornaValores("Ano")),
                                    Placa = RetornaValores("Placa"),
                                    Cv = int.Parse(RetornaValores("Cv"))
                                });
                            Console.WriteLine("Carro inserido com sucesso!");
                            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu Inicial.");
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Finalizando...");
                            concluido = true;
                            break;
                        }
                }
                Console.ReadKey();
            }            
        }

        public static string RetornaValores(string valor)
        {//informo e retorno o valor confrome a solicitação do campo
            Console.WriteLine($"Informe o valor para o campo {valor}");
            return Console.ReadLine();
        }

        public static int MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO SISTEMA DE CADASTRAMENTO DE CARROS");
            Console.WriteLine("Para continuar, digite a opção desejada:");
            Console.WriteLine("1 - Listar os Carros.");
            Console.WriteLine("2 - Adicionar um Carro.");
            Console.WriteLine("3 - Sair do Sistema.");
            //Console.ReadKey();

            var opcao = Convert.ToInt32(Console.ReadLine());
            
            return opcao;            
        }
    }
}
