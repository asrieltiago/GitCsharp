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
            string[,] baseDeDados = new string[2, 5];
            //Indicador dos registros realizados em nosso sistema.
            int IndiceBaseDeDados = 0;
            //Apresentação inicial do nosso sistema
            Console.WriteLine("Iniciando sistema de nome e idade.");
            //Criamos a variavel fora para não ser criada novamente
            var escolhaInicial = MostrarMenuInicial();

            //Loop infinito até que de uma treta
            while (true)
            {
                //Iniciando a escolha do nosso menu
                switch (escolhaInicial)
                {
                    //Insere as informações
                    case "1": { InseriValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;
                    //Remove informações da nossa lista
                    case "2": { RemoverInformacoes(ref baseDeDados); } break;
                    //Lista as informações da lista
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                    //Menu que mostra somente os registros bloqueados dentro do sistema
                    case "4": { MostrarInformacoes(baseDeDados, "true"); } break;
                    //Sai do sistema
                    case "5":
                        {
                            //retorna diretamente o menu escolhido.
                            return;
                        }
                    default: { Console.WriteLine("\nNão foi uma escolha valida dentro do menu de opções."); Console.ReadKey(); } break;
                }
                //Alimento a escolha novamente
                escolhaInicial = MostrarMenuInicial();
            }

        }

        /// <summary>
        /// Apresenta as informações do menu inicial
        /// </summary>
        /// <returns>Retorna o menu escolhido.</returns>
        public static string MostrarMenuInicial()
        {
            //Entrou no Menu Inicial, inicializa a limpeza da tela
            Console.Clear();
            Console.WriteLine("----------- MENU ------------\n");
            Console.WriteLine("1 - Inserir um novo registro.");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Listar os registros inativos.");
            Console.WriteLine("5 - Sair do sistema.");

            Console.WriteLine("\nDigite o número da opção desejada:");
            //Retorna diretamente o menu escolhido.
            return Console.ReadLine();

        }

        /// <summary>
        /// Método que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="basedeDados">base de dados como ref para alterar todos os metodos</param>
        /// <param name="indiceBase">Indice da nossa base como ref para alterar todos os metodos</param>
        public static void InseriValoresNaLista(ref string[,] basedeDados, ref int indiceBase)
        {
            Console.WriteLine("\n------ Inserindo valores na lista ------");
            Console.WriteLine("Informe um nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("\nInforme a idade:");
            var idade = Console.ReadLine();

            //Aumenta o tamanho da lista quando chegou no limite.
            AumentaTamanhoLista(ref basedeDados);


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
                //Carrega a coluna que identifica se o registro esta ativo
                basedeDados[i, 3] = "true";
                //Identificamos agora a data e hora de criação dos registros dentro do sistema.
                basedeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                //Finalizamos aqui para apenas inserir um registro por vez
                break;
            }

            //Informamos para o usuario que finalizou o registro e que poderá retornar ao menu inicial.            
            Console.WriteLine("\nRegistro cadastrado com sucesso!");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();
        }

        /// <summary>
        /// Mostra as informações dentro da nossa lista de dados "base de dados"
        /// </summary>
        /// <param name="baseDeDados">base de dados para leitura e mostrar pro usuario</param>
        /// <param name="mostrarRegistrosInativos">Quanto identificado com o valor true, o mesmo mostra os valores que estão inativos dentro do sistema</param>
        public static void MostrarInformacoes(string[,] baseDeDados, string mostrarRegistrosInativos = "false") // Colocando como "false", vira opcional se querem mostrar esta informação no InsereRegistros
        {
            //Informamos em que tela o mesmo está
            Console.WriteLine("Apresentação das informações dentro da nossa base de dados.");

            //Comparacao que identifica visualmente quais registros estamos mostrando
            if (mostrarRegistrosInativos == "true")
            {
                Console.WriteLine("Registros desativados dentro do sistema.");
            }

            // Laço simples aonde o mesmo mostra de maneira formatada as informações
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Aqui
                if (baseDeDados[i, 3] != mostrarRegistrosInativos)
                {
                    Console.WriteLine($"ID {baseDeDados[i, 0]} | Nome: {baseDeDados[i, 1]} | Idade: {baseDeDados[i, 2]} | Data Alteração: {baseDeDados[i, 4]}");

                }
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

            //Identifica que só deve remover os valores ativos dentro do sistema

            //Laço de repetição que mostra as informações dentro da tela de exclusão
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 3] != "false")
                    Console.WriteLine($"ID {baseDeDados[i, 0]} | Nome: {baseDeDados[i, 1]} | Idade: {baseDeDados[i, 2]} | Data Alteração: {baseDeDados[i, 4]}");
            }

            //Indicamos para o usuario informar um ID dentro do nosso sistema para remoção
            Console.WriteLine("Informe o ID do registro a ser removido:");
            var id = Console.ReadLine();

            //Outro laço agora para remover o registro caso o mesmo exista.
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {   //Aqui comparamos o registro para validar o ID
                //Colocamos um && pois a comparação de um valor string com um valor null pode gerar erro.
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {   //Agora trocamos este valor para um identificador string "false"
                    baseDeDados[i, 3] = "false";
                    //Aqui identificamos a data que foi alterado esse registro
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
            Console.WriteLine("Operações finalizadas.");
            Console.WriteLine("Para retornar ao menu inicial, aperte qualquer tecla.");

            Console.ReadKey();
        }

        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {
            //Verifica se precisa cruar uma lista maior
            var limiteDaLista = true;

            //Laço que verifica se existe registro disponível
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Caso ainda existir registro disponível, ele seta nossa variável "limitaDaLista" para false
                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false;
            }

            //Caso não tenha mais registro, nossa variável ficou como true, então indica que precisamos aumentar nossa lista.
            if (limiteDaLista)
            {
                //Criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = baseDeDados;

                //Aqui limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaços
                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 5];

                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do identificador único
                    baseDeDados[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    baseDeDados[i, 1] = listaCopia[i, 1];
                    //Copiamos a informação do identificador único
                    baseDeDados[i, 2] = listaCopia[i, 2];
                    //Copiamos a informação do nosso nome
                    baseDeDados[i, 3] = listaCopia[i, 3];
                    //Copiamos a informação do nosso nome
                    baseDeDados[i, 4] = listaCopia[i, 4];
                }
                //indicamos que neste ponto a lista foi atualizada em seu tamanho.
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }
        }
    }
}
