using System;
using AtividadeConsole.Controllers;
using AtividadePOO.Models;
using AtividadePOO2.Repositories;

namespace AtividadeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var banco = new BancoController();
            while(1){
                Console.WriteLine("Digite 1 para operações no 'Banco'");
                Console.WriteLine("Digite 0 para Terminar as operações");
                
                var i = Convert.ToInt32(Console.ReadLine());
                if(i==0? break: banco.RealizarOp();)

            }
        }
    }
}
