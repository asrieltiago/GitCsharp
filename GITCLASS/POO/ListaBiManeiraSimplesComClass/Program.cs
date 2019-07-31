using ListaBiManeiraSimplesComClass.Carrega;
using ListaBiManeiraSimplesComClass.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Aqui iniciamos o nosso Objeto em memória
            var Nicholas = new CarregarLista(); // CTRL + . para importar a biblioteca CarregarLista

            //Aqui chamamos o nosso método para carregar a lista
            Nicholas.CarregaInformacoesEListaElasEmTela();            

            //Carregamos novamente mas agora a classe mostrar lista
            // aonde colocamos todos os metodos que serão direcionados 
            // para mostrar a listagem de informações na tela do console.
            var FelipeBlindao = new MostrarLista();

            //aqui chamamos o metodo novamente
            FelipeBlindao.PesquisandoInformacoesNaNossaLista(Nicholas.ListaNome, "0");

            Console.ReadKey();
        }
    }
}
