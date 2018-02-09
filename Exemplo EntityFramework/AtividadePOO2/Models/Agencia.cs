using System.Collections.Generic;

namespace AtividadePOO.Models
{
    public class Agencia
    {
        public Agencia()
        {
            Contas = new HashSet<Conta>();
        }
        public int Id { get; set; }
        public string Nome {get ; set;}
        public string Numero {get; set;}
        public string Cidade{ get; set; }
        public int BancoId { get; set; }
        public virtual Banco Banco { get; set; }
        public ICollection<Conta> Contas { get; set; }       
    }
}