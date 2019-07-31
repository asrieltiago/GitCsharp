using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeCharp.Classes
{
    public class Conta
    {
        double saldo = 0;

        //Propriedade que contem o valor do saldo
        public double Saldo { get { return saldo; } }

        /// <summary>
        /// Construtor
        /// </summary>
        public Conta()
        {   //bonus
            saldo = 1000;
        }

        /// <summary>
        /// Metodo para sacar dinheiro, de acordo com o saldo disponivel
        /// </summary>
        /// <param name="valor">Valor para sacar</param>
        /// <returns>Retorna se o saque foi feito ou não</returns>
        public bool Sacar(double valor)
        {
            if(valor <= saldo)
            {//Desconto do valor em saldo da conta
                saldo -= valor;
                return true;
            }
            //Retorna false em caso de não conter saldo disponível
            return false;
        }

        /// <summary>
        /// Método para mostrar o saldo em conta disponível
        /// </summary>
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
