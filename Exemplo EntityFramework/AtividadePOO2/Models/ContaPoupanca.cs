using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePOO.Models
{
    public class ContaPoupanca : Conta
    {
        public float SaldoPoupanca { get; set; }
        public DateTime DataAniversario{ get; set; }
        public float Juros {get; set;}

        public void Sacar(float valor){
            this.SaldoPoupanca-=valor;
        }
        public void Depositar(float valor){
            this.SaldoPoupanca+=valor;
        }
    }
}
