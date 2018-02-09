using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePOO.Models
{
    public class Conta
    {
        public Conta()
        {
            Titulares = new HashSet<ContaTitular>();   
        }
        public int Id { get; set; }
        public string Numero {get; set;}
        public int AgenciaId { get; set; }
        public virtual Agencia Agencia{get; set;}
        public ICollection<ContaTitular> Titulares { get; set; }

    }
}
