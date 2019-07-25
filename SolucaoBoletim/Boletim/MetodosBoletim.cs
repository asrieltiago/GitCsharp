using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoBoletim.Boletim
{
    public class MetodosBoletim
    {
        public int Media(int nota1, int nota2, int nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public int Frequencia(int totAulas, int totFaltas)
        {
            return ((totAulas - totFaltas) * 100) / totAulas ;
        }

        public void Situacao(int Media, int Frequencia)
        {
            if (Media >= 7 && Frequencia >= 75)
                Console.WriteLine($"Aluno aprovado com média {Media} e frequencia de {Frequencia}%");

            else
                Console.WriteLine($"Aluno Reprovado com média {Media} e frequencia de {Frequencia}%");
        }
    }
}
