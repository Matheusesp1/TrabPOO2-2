using System;
using System.Collections.Generic;
namespace TRABPOO2{



    internal class Program
    {
        static void Main(string[] args)
        {
            var repo = new Repository.QuartoRepository("Data Source=./DataAccess/Database.db;");
            Quarto q1 = repo.Get(11);
            
            List<List<string>> lista = new List<List<string>>();
            lista = repo.GetQuartos();
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                List<string> list = lista[i];
                Console.WriteLine(" ------- ");
                foreach (String s in list)
                {
                    Console.WriteLine(s);
                }
            }}

      } 

    }