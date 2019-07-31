using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2ReceitaBolo
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                MenuInicial();

                MetodoIngredientes();

            }

            Console.ReadKey();

        }

        /// <summary>
        /// Método que trás o Menu Inicial da aplicação.
        /// </summary>
        public static void MenuInicial()
        {
            Console.WriteLine("===============Bem vindo as Receitas do KIKO ===============\n");
            Console.WriteLine("Disponibilizamos recentemente a 'RECEITA SECRETA' do nosso delicioso Bolo de Aipim com Coco. \nPressione qualquer tecla para visualizá-lo.\n");
            Console.ReadKey();
        }

        /// <summary>
        /// Método que retorna os ingredientes necessários da receita.
        /// </summary>
        public static void MetodoIngredientes()
        {
            string[] receita = new string[]
                {
                    "> 1 kg de aipim (mandioca ou macaxeira)",
                    "> 3 xícaras (chá) de açúcar",
                    "> 100 g de manteiga",
                    "> 200 ml de leite de coco",
                    "> 1 pacote de coco ralado desidratado",
                    "> 1 pitada de sal",
                    "> 1 xícara (chá) de leite",
                    "> 3 ovos",
                    "> Obs:(Essa receita não vai fermento em pó)\n",
                };


            Console.Clear();
            Console.WriteLine("Para começar, tenha certeza de que você possui os ingredientes abaixo: \n");

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(receita[i]);
            }

            Console.WriteLine("Pressione ENTER para avançar. \n");
            Console.ReadKey();
            Console.Clear();
            

            Console.WriteLine("Pressione ENTER para avançar. \n");
            Console.WriteLine("===== MODO DE PREPARO ====\n");

            string[] etapas = new string[]
            {
                "1 - Descasque o aipim, lave-o sob água corrente e rale, usando um ralador grosso,\nou pode triturar o aipim no liquidificador.",
                "2 - Lembre-se de tirar o excesso de água do aipim ralado \nantes de adicioná-lo aos demais ingredientes.",
                "3 - No liquidificador, coloque o aipim ralado ou triturado, \no leite, o leite de coco e a manteiga.",
                "4 - Bata tudo em velocidade média por 1 minuto.",
                "5 - Acrescente o açúcar, o coco ralado \ne o sal e bata mais um pouco.",
                "6 - Despeje o creme em uma forma redonda e untada com margarina \ne farinha de trigo asse em forno pré - aquecido, a 230ºC, \npor uns 45 minutos ou até que colocando o palito ele saia limpo.",
                "7 - Espere esfriar um pouquinho e delicie-se.",
            };

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(etapas[i]);
                Console.WriteLine("");
                Console.ReadKey();
            }
            Console.WriteLine("Pressione qualquer tecla para encerrar a aplicação.");

            

        }

    }
}
