using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Mostrar
{
    class MostrarLista
    {
        /// <summary>
        /// Metodo que realiza a pesquisa pelo identificador unico de nossa coleção
        /// </summary>
        /// <param name="arrayBi">Nossa coleção de informações</param>
        /// <param name="pId">Nosso identificador únicos</param>
        public void PesquisandoInformacoesNaNossaLista(string[,] arrayBi, string pId)
        {
            //Realizamos nossa comparação dos mesmos tipos
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                if (arrayBi[i, 0] == pId)
                {//Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida: ID: {arrayBi[i, 0]} - Nome: {arrayBi[i, 1]}");
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
