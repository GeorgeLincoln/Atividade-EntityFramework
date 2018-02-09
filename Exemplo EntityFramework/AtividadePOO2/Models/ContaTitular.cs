using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePOO.Models
{
    public class TitularConta
    {
        
        public int TitularId { get; set; }
        public int ContaId { get; set; }
        public virtual Conta Conta { get; set; }
        public virtual Titular Titular { get; set; }
    }

     public class Titular
    {
        public Titular()
        {
            Contas = new HashSet<ContaTitular>();
            
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public ICollection<ContaTitular> Contas { get; set; }
    }
}
