﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando a nossa lista com mais de uma dimensão
            string[,] listaDeNome = new string[5, 2];

            //Aqui como estamos usando uma referencia da nossa lista, colocamos ref ao passar ela no metodo
            CarregaInformacoesEListaElasEmTela(ref listaDeNome);            
                       
            //Após carregar as informações e mostrar em tela ele espera um comando
            Console.ReadKey();

            //Indicamos que o usuario precisa informar um numero de identificação
            Console.WriteLine("Digite o ID que você deseja pesquisar: ");
            //Aqui como realizamos a pesquisa somente na chamada
            //Passamos a nossa lista normalmente pois não iremos alterar e apenas pesquisar a informação
            //Após a virgula temos o console ReadLine que espera nosso identificador único
            PesquisandoInformacoesNaNossaLista(listaDeNome, Console.ReadLine());

            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que carrega as informações dentro da nossa lista criada no metodo "MAIN"
        /// E mostra as informações logo em seguida
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada</param>
        public static void CarregaInformacoesEListaElasEmTela(ref string[,] arrayBi)
        {
            //Usando um laço simples para colocar valores mas no mesmo agora utilizando o 
            //GetLength com o parametro "0" para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identificador do nosso registro unico
                arrayBi[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra para deixar legal
                arrayBi[i, 1] = $"Asriel_{i}";
            }

            //Lembrando que GetLength é um metodo e usamos "(parametro)" com parametro ou as vezes sem
            //para realizar a chamada do mesmo
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID: {arrayBi[i, 0]} - Nome: {arrayBi[i, 1]}");
            }
        }


        /// <summary>
        /// Metodo que realiza a pesquisa pelo identificador unico de nossa coleção
        /// </summary>
        /// <param name="arrayBi">Nossa coleção de informações</param>
        /// <param name="pId">Nosso identificador únicos</param>
        public static void PesquisandoInformacoesNaNossaLista(string[,] arrayBi, string pId)
        {
            //Realizamos nossa comparação dos mesmos tipos
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                if(arrayBi[i,0] == pId)
                {//Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida: ID: {arrayBi[i,0]} - Nome: {arrayBi[i,1]}");
                    //Aqui saimos da nossa lista mas retornamos vazio "return;"pois estamos em um metodo
                    // vazio "void" que não espera retornar algo.
                    return;
                }
            }
            //Caso ele passe por esta linha e identificamos que ele não encontrou o resultado esperado.
            Console.WriteLine("Infelizmente a busca pelo ID não resultou em nenhuma informação.");
        }
    }
}
