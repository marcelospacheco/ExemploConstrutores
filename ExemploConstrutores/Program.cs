using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno("Marcelo", "Pacheco", "Inglês");
            p1.Apresentar();

            


            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instância";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);
            
            
            
        }
    }
}
