using System;
using System.Collections.Generic;
using System.Linq;
using AtividadePOO.Models;
using AtividadePOO2.Repositories;

namespace AtividadeConsole.Controllers
{
    public class BancoController
    {   private Repository<Banco> repositorio;
        public BancoController()
        {
            repositorio = new Repository<Banco>();        
        }

        
        public void RealizarOperacao()
        {
            Console.WriteLine("Digite 0 para buscar por Id");
            Console.WriteLine("Digite 1 para listar");
            Console.WriteLine("Digite 2 para cadastrar");
            Console.WriteLine("Digite 3 para para atualizar");
            Console.WriteLine("Digite 4 para deletar");
            var x = Convert.ToInt32(Console.ReadLine());
            if(x==0){
                Console.WriteLine("Digite o id");
                var id =   Convert.ToInt32(Console.ReadLine());
                var entiy = repositorio.GetById(id);
                PrintObjeto(entiy);
            }
            if(x==1){
                var entidades_ = repositorio.GetAll();
                PrintLista(entidades_);
            }
            if(x==2){
                Console.WriteLine("Digite o nome do banco");
                string nome = Console.ReadLine();
                var banco = new Banco(){
                    Nome = nome,
                    
                };
                repositorio.Create(banco);
            }
            if(x==3){
                Console.WriteLine("Digite um id");
                var id  = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite um novo nome");
                string nome = Console.ReadLine();
                var banco = new Banco(){
                    Id = id,
                    Nome = nome,
                    
                };
                repositorio.Update(id, banco);
            }
            if(x==4){
                Console.WriteLine("Digite o Id da entidade");
                var id = Convert.ToInt32(Console.ReadLine());
                var entity = repositorio.GetById(id);
                if(entity == null){
                    Console.WriteLine("Id não existente");
                }else{
                    repositorio.Delete(entity);
                }
                
            }

        }

        public void PrintObjeto(Banco bc){
            Console.WriteLine("Id: "+ bc.Id +" Nome: "+ bc.Nome);
        }
        public void PrintLista(IQueryable<Banco> entidades_){
            foreach( var bc in entidades_){
                Console.WriteLine("Id: "+ bc.Id +" Nome: "+ bc.Nome);
            }
            
        }
    }
}