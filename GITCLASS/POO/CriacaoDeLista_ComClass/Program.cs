using CriacaoDeLista_ComClass.Lista_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista_
{
    class Program
    {        
        static void Main(string[] args)
        {
            var listaClass = new ListaClass();

            listaClass.VarreRegistro();

            listaClass.LimpaRegistro();

            listaClass.MudarTamanho(50);

            listaClass.CarregaLista();

            listaClass.VarreRegistro();
                     

        }

    }
}