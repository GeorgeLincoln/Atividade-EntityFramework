using System;
using System.Collections.Generic;
using System.Linq;
using AtividadePOO;
using Microsoft.EntityFrameworkCore;

namespace AtividadePOO2.Repositorios
{
    public class Repository<T> where T : class
    {   
        private DataContext aux;
        
        public Repository(){
            //aux = contexts
            this.aux = new DataContext();
        }

        public virtual IQueryable<T> GetAll()
        {
            return aux.Set<T>(); 
        }

        public virtual T GetById(int id)
        {
            return aux.Set<T>().Find(id);
        }

        public virtual void Create(T entity){
            try{
                aux.Set<T>().Add(entity);
                aux.SaveChanges();
            }catch(DbUpdateException e){
                Console.WriteLine("Erro: " + e.InnerException.Message);
            }
        }

        public virtual T Update(int id, T entity){
            var exist = aux.Set<T>().Find(id);
    
           
            if (exist != null)
            {
                aux.Entry(exist).CurrentValues.SetValues(entity);
                try {
                    aux.SaveChanges();
                }
                catch (DbUpdateException e){
                    Console.WriteLine("Erro: " + e.InnerException.Message);
                }
            
            }
            else
                Console.WriteLine("O objeto não existe");     
            return entity;
        }
        public virtual void Delete(T entity)
        {
            aux.Set<T>().Remove(entity);
            try{
                aux.SaveChanges();
            }catch(DbUpdateException e){
                Console.WriteLine("Erro: " + e.InnerException.Message);
            }
        }
    }
}