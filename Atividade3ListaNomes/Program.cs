using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3ListaNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaAlunos = new string[,]
            {
                {"Leticia", "20", "Feminino"},
                { "	Sara", "18","Feminino"},
                { "	Rebeca", "16", "Feminino	"},
                { "	Analice","19	",  "	Feminino	"},
                { "	Isabel","25	",  "	Feminino	"},
                { "	Estela","36	",  "	Feminino	"},
                { "	Micaela","	21	",  "	Feminino	"},
                { "	Ariana", "	20	",  "	Feminino	"},
                { "	Anita", "	10	",  "	Feminino	"},
                { "	Daniela", "	29	",  "	Feminino	"},
                { "	Karen", "	25	",  "	Feminino	"},
                { "	Zoe",  "11	",  "	Feminino	"},
                { "	Raquel", "	25	",  "	Feminino	"},
                { "	Vicente", "	36	",  "	Masculino	"},
                { "	Francisco",  "	40	",  "	Masculino	"},
                { "	Thomas", "	10	",  "	Masculino	"},
                { "	Bryan", "	15	",  "	Masculino	"},
                { "	Benjamim",  "	19	",  "	Masculino	"},
                { "	Guilherme",  "	39	",  "	Masculino	"},
                { "	Gustavo", "	27	",  "	Masculino	"},
            };

            Console.WriteLine("          --- LISTA DE ALUNOS --- \n");

            for (int i = 0; i < listaAlunos.GetLength(0); i++)
            {
                Console.WriteLine($"NOME: {listaAlunos[i,0].Trim()}      |      " + 
                    $"IDADE: {listaAlunos[i,1].Trim().}          |       " + $"SEXO: {listaAlunos[i,2].Trim()}");
            }
            Console.ReadKey();
            
        }
    }
}
