using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoBoletim.Boletim
{
    public class MetodosBoletim
    {
        public decimal media { get; set; } = 0;
        public decimal frequencia { get; set; } = 0;

        public decimal Notas(decimal nota1, decimal nota2, decimal nota3)
        {
            return media = (nota1 + nota2 + nota3) / 3;            
        }

        public decimal Frequencia()
        {
            decimal totaulas = 20;
            decimal totfaltas = 5;
            return frequencia = (totaulas - totfaltas) / (totaulas) * 100;
             
        }

        public void Situacao()
        {

            string situacao = "";

            if (media >= 7 && frequencia >= 75)            
                situacao = "APROVADO";            

            else            
                situacao = "REPROVADO";            

            Console.WriteLine($"\nA sua média foi {media.ToString("F")} com {frequencia}% de frequência, portanto você está {situacao}.");
        }
    }
}
