using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista_ComClass.Lista_Class
{
    public class ListaClass
    {
        string[] listaClass;

        public ListaClass()
        {
            listaClass = new string[10];
            CarregaLista();

        }

        public void MudarTamanho(int novoTamanho)
        {
            listaClass = new string[novoTamanho];
        }

        public void CarregaLista()
        {
            for (int i = 0; i < listaClass.Length; i++)
                listaClass[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");

        }

        public void VarreRegistro()
        {
            foreach (var item in listaClass)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public void LimpaRegistro()
        {
            for (int i = 0; i < listaClass.Length; i++)
                listaClass[i] = string.Empty;            
        }

          


    }
}
