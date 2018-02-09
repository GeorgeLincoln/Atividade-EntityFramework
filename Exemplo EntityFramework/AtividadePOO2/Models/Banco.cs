using System.Collections.Generic;

namespace AtividadePOO.Models
{
    public class Banco
    {
        public Banco()
        {
            Agencia = new HashSet<Agencia>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Agencia> Agencia{ get; set;}
    }
}