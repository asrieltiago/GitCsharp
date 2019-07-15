using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAndRemoveList
{
    class Program
    {
        static void Main(string[] args)
        {
            //criamos a nossa base de dados inicial
            string[,] baseDeDados = new string[2, 3];
            //Indicador dos registros realizados em nosso sistema.
            int IndiceBaseDeDados = 0;
            //Apresentação inicial do nosso sistema
            Console.WriteLine("Iniciando sistema de nome e idade.");
            //Criamos a variavel fora para não ser criada novamente
            var escolhaInicial = ApresentaMenuInicial();

            //Loop infinito até que de uma treta
            while (true)
            {
                //Iniciando a escolha do nosso menu
                switch (escolhaInicial)
                {
                    case "1": { InseriValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;
                    case "2": { RemoverInformacoes(ref baseDeDados); } break;
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                    case "4":
                        {
                            //retorna diretamente o menu escolhido.
                            return;
                        }
                }
                //Alimento a escolha novamente
                escolhaInicial = ApresentaMenuInicial();
            }

        }

        /// <summary>
        /// Apresenta as informações do menu inicial
        /// </summary>
        /// <returns>Retorna o menu escolhido.</returns>
        public static string ApresentaMenuInicial()
        {
            //Entrou no Menu Inicial, inicializa a limpeza da tela
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir um novo registro.");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada:");
            //Retorna diretamente o menu escolhido.
            return Console.ReadLine();

        }

        /// <summary>
        /// Método que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="basedeDados">base de dados como ref para alterar todos os metodos</param>
        /// <param name="indiceBase">Indice da nossa base como read para alterar todos os metodos</param>
        public static void InseriValoresNaLista(ref string[,] basedeDados, ref int indiceBase)
        {
            Console.WriteLine("------ Inserindo valores na lista ------");
            Console.WriteLine("Informe um nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade:");
            var idade = Console.ReadLine();

            for (int i = 0; i < basedeDados.GetLength(0); i++)
            {
                if (basedeDados[i, 0] != null)
                    continue;
                //Identificamos de maneira unica nosso registro "(" e ")" garante que ele incremente primeiro, antes de fazer a conversão para string
                basedeDados[i, 0] = (indiceBase++).ToString();
                //Carregamos na segunda coluna o valor do nome
                basedeDados[i, 1] = nome;
                //Carregamos na terceira coluna o valor da idade
                basedeDados[i, 2] = idade;
                //Finalizamos aqui para apenas inserir um registro por vez
                break;
            }

            //Informamos para o usuario que finalizou o registro e que poderá retornar ao menu inicial.
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();
        }

        /// <summary>
        /// Mostra as informações dentro da nossa lista de dados "base de dados"
        /// </summary>
        /// <param name="baseDeDados">base de dados para leitura e mostrar pro usuario</param>
        public static void MostrarInformacoes(string[,] baseDeDados)
        {
            //Informamos em que tela o mesmo está
            Console.WriteLine("Apresentação das informações dentro da nossa base de dados.");

            // Laço simples aonde o mesmo mostra de maneira formatada as informações
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                Console.WriteLine($"ID {baseDeDados[i, 0]} | Nome: {baseDeDados[i, 1]} | Idade: {baseDeDados[i, 2]}");
                //Finalizamos a operação e indicamos que não existe mais operações a serem realizadas em nosso metodo.                
            }
            Console.WriteLine("Resultados apresentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo utilizado para remover um registro pelo ID dentro do sistema.
        /// </summary>
        /// <param name="baseDeDados">Base de dados em que ele irá remover o registro pelo ID</param>
        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            //Identificamos a tela do menu que o usuário está
            Console.WriteLine("Area de remoção de registro do sistema.");

            //Laço de repetição que mostra as informações dentro da tela de exclusão
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                Console.WriteLine($"ID {baseDeDados[i, 0]} | Nome: {baseDeDados[i, 1]} | Idade: {baseDeDados[i, 2]}");
            }

            //Indicamos para o usuario informar um ID dentro do nosso sistema para remoção
            Console.WriteLine("Informe o ID do registro a ser removido:");
            var id = Console.ReadLine();

            //Outro laço agora para remover o registro caso o mesmo exista.
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {   //Aqui comparamos o registro para validar o ID
                //Colocamos um && pois a comparação de um valor string com um valor null pode gerar erro.
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {   //Nesta parte limpaos o registro de nossa base de dados.
                    baseDeDados[i, 0] = null;
                    baseDeDados[i, 1] = null;
                    baseDeDados[i, 2] = null;
                }
            }
            Console.WriteLine("Operações finalizadas.");
            Console.WriteLine("Para retornar ao menu inicial, aperte qualquer tecla.");

            Console.ReadKey();
        }

        //public static void Aumenta
    }
}
