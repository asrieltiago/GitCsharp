using SolucaoBoletim.Boletim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodosBoletim metodo = new MetodosBoletim();
            CrudEscola inserir = new CrudEscola();


            while (true) 
            {
                switch (inserir.MenuInicial())
                {
                    case 1: { inserir.InsereRegistro(); } break;
                    case 2: { inserir.RemoveAluno(); } break;
                    case 3: { inserir.ListarAlunos(); } break;
                    case 4: { inserir.AlterarNota(); } break;
                    case 5: { inserir.AlterarFrequencia(); } break;
                    case 6:
                        { return; }
                    default: { Console.WriteLine("\nNão foi uma escolha valida dentro do menu de opções."); Console.ReadKey(); } break;

                }


                Console.ReadKey();
            }
        }
    }
}