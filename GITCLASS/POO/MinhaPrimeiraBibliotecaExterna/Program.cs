using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = new GetFiles();


            Console.WriteLine("Arquivos da Pasta Documentos:");
            files.RetornaArquivosDoMeuDocumentos();
            foreach (var item in files.RetornaArquivosDoMeuDocumentos())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nArquivos da Pasta Imagens:");
            files.RetornaArquivosImagesFiles();
            foreach (var item in files.RetornaArquivosImagesFiles())
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("\nArquivos da Pasta do GIT");
            files.RetornaArquivosGit();

            var git = Directory.GetFiles(@"C:\Csharp\GitCsharp");


            foreach (var item in files.RetornaArquivosGit())
            {
                Console.WriteLine(item);
            }
        }
    }
}
