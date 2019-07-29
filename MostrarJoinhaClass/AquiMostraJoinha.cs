using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClass
{
    public class AquiMostraJoinha
    {
        public void MetodoInicialDoJoinha()
        {
            Console.WriteLine("Aqui iniciamos o nosso joinha.");
            Console.ReadKey();
        }

        public void MetodoDoisPontoZero(bool eQuinta)
        {
            if (eQuinta)            
                Console.WriteLine("Caraiii mermao!!!");
            
            else
                Console.WriteLine("Aiaiaiii!!!");

            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] TesteUmOperadorLegal()
        {
            return new string[2] { "Teste 1", "Teste 2" };
        }
    }
}
