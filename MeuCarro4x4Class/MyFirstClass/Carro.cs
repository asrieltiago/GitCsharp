using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarro4x4Class.MyFirstClass
{
    class Carro
    {
        public int Rodas { get; set; } = 0;
        public int Portas = 0;
        public int Bancos = 0;
        public int Janelas = 0;

        public void MostrarCarro()
        {
            Console.WriteLine($"Nosso carro: \r\n" +
                $"Quant Rodas {rodas} \r\n" +
                $"Quant Portas {portas}\r\n" +
                $"Quant Bancos {bancos} \r\n" +
                $"Quant Janelas {janelas}");

            
        }
    }
}
