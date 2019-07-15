using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddValoresEmListaManualmente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da nossa lista
            string[,] listaDeNome = new string[10, 2];

            //Aqui vamos criar uma forma externa de identificar nossos registros
            int IdParaLista = 0;

            //Chamada no nosso metodo para inserir registro passando por meio de referencia
            //nossos dois itens, lista de nomes e nosso identificador unico.
            InsereRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();

            //Aqui acionamento novamente nosso inserir registros
            InsereRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();
        }

        /// <summary>
        /// Método que insere novo registro
        /// </summary>
        /// <param name="listaDeNome">Nossa lista de nomes vazia ou não</param>
        /// <param name="IdParaLista">Nossa referencia externa de ID</param>
        public static void InsereRegistro(ref string[,] listaDeNome, ref int IdParaLista)
        {
            //Aqui estaremos em um laço para informar nossos registros
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Aqui definimos que o mesmo deve continuar para o próximo registro, pois este registro já está ocupado
                if (listaDeNome[i, 0] != null)
                    continue;

                //Indicamos que ele deve apenas informar o nome do nosso registro
                Console.WriteLine("Informe um nome para adicionar um registro: ");
                var nome = Console.ReadLine();

                //Criamos o nosso identificador unico com um objeto externo que
                //mesmo após sairmos do nosso laço, ainda poderá ser incrementado.
                listaDeNome[i, 0] = (IdParaLista++).ToString();

                //Aqui colocamos nosso nome na lista
                listaDeNome[i, 1] = nome;

                //Identificamos se o mesmo ainda deseja inserir registros dentro da nossa lista
                Console.WriteLine("\nDeseja inserir um novo registro? Sim [1] | Não [0]");
                //O ReadKey so espera uma unica tecla e nos retorna a telca que foi acionada e não o valor dela
                //Por isso usamos o KeyChar para pegar esse valor e converte ele em String, para comparação.
                var continuar = Console.ReadKey().KeyChar.ToString();

                //Aqui validamos a condição se o mesmo deve ou não continuar a adicionar registro até que a nossa
                //lista esteja completa de informações 
                if (continuar == "0")
                    break; //Break é uma palavra reservada do C# que para todo laço de repetição ou sequenciador lógico.

                AumentaTamanhoLista(ref listaDeNome);
            }

            Console.WriteLine("Registro adicionado com sucesso, segue lista de informações adicionadas: ");

            //Mas agora a coisa muda,
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Utilizamos o string.Format, basicamente ele faz da mesma forma que o sifrão, 
                // a diferença entre eles é que este é um cara que em grandes quantidades acaba sendo mais rápido.
                Console.WriteLine(string.Format("Registro ID {0} - Nome: {1}", listaDeNome[i, 0], listaDeNome[i, 1]));

            }
        }
        public static void AumentaTamanhoLista(ref string[,] ListaDeNome)
        {
            //Verifica se precisa cruar uma lista maior
            var limiteDaLista = true;

            //Laço que verifica se existe registro disponível
            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                //Caso ainda existir registro disponível, ele seta nossa variável "limitaDaLista" para false
                if (ListaDeNome[i, 0] == null)
                    limiteDaLista = false;
            }

            //Caso não tenha mais registro, nossa variável ficou como true, então indica que precisamos aumentar nossa lista.
            if (limiteDaLista)
            {
                //Criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = ListaDeNome;

                //Aqui limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaços
                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 2];

                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do identificador único
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    ListaDeNome[i, 1] = listaCopia[i, 1];
                }
                //indicamos que neste ponto a lista foi atualizada em seu tamanho.
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }
        }
    }
}
