using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class FuncoesCalc
    {
        /// <summary>
        /// Método que Soma os valores de N1 e N2.
        /// </summary>
        /// <param name="n1">Primeiro Valor</param>
        /// <param name="n2">Segundo Valor</param>
        /// <returns></returns>
        public int Adicao(int n1, int n2)
        {
            return n1 + n2;
        }

        /// <summary>
        /// Método que Subtrai os valores de N1 e N2.
        /// </summary>
        /// <param name="n1">Primeiro Valor</param>
        /// <param name="n2">Segundo Valor</param>
        /// <returns></returns>
        public int Subtracao(int n1, int n2)
        {
            return n1 - n2;
        }

        /// <summary>
        /// Método que Divide os valores de N1 e N2.
        /// </summary>
        /// <param name="n1">Primeiro Valor</param>
        /// <param name="n2">Segundo Valor</param>
        /// <returns></returns>
        public int Divisao(int n1, int n2)
        {
            return n1 / n2;
        }

        /// <summary>
        /// Método que Multiplica os valores de N1 e N2.
        /// </summary>
        /// <param name="n1">Primeiro Valor</param>
        /// <param name="n2">Segundo Valor</param>
        /// <returns></returns>
        public int Multiplicacao(int n1, int n2)
        {
            return n1 * n2;
        }

        /// <summary>
        /// Método que calcula a área de um retângulo, multiplicando a largura pelo comprimento.
        /// </summary>
        /// <param name="largura">Valor da Largura</param>
        /// <param name="comprimento">Valor do Comprimento</param>
        /// <returns></returns>
        public int CalcRetangulo(int largura, int comprimento)
        {
            return largura * comprimento;
        }

        /// <summary>
        /// Método que calcula a área de um triângulo equilátero, multiplicando a largura pelo comprimento e dividindo por 2.
        /// </summary>
        /// <param name="largura">Valor da Largura</param>
        /// <param name="comprimento">Valor do Comprimento</param>
        /// <returns></returns>
        public int CalcTrianguloEquilatero(int largura, int comprimento)
        {
            return (largura * comprimento) / 2;
        }

        /// <summary>
        /// Método que calcula o raio de um círculo, dividindo a área pelo valor do PI.
        /// </summary>
        /// <param name="area">Valor da Área</param>
        /// <returns></returns>
        public double CalcRaioCirculo(double area)
        {
            return Math.Sqrt(area / Math.PI);
        }
    }
}
