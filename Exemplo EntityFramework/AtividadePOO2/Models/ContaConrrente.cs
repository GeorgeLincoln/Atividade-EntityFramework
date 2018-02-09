using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePOO.Models
{
    public class ContaConrrente : Conta
    {
        public float SaldoCorrente { get; set; }
        
        public void Sacar(float valor){
            this.SaldoCorrente-=valor;
        }
        public void Depositar(float valor){
            this.SaldoCorrente+=valor;
        }
    }
}
