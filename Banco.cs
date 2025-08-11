using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Cliente(string nome, string endereco, string cpf)
    {
        private string Nome { get; } = nome;
        private string Endereco = endereco;
        private string Cpf { get; } = cpf;

       
    }
}
// ----------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Conta
    {
        private double Saldo;
        private int Numero;
        private Cliente Cliente;

        public Conta(double saldo, int numero, string nome, string endereco, string cpf) { 
            this.Saldo = saldo;
            this.Numero = numero;
            this.Cliente = new(nome, endereco, cpf);
        }

        public bool Saca(double valor) {
            if (VerificarTransacao(valor)) { 
                Saldo -= valor;
                return true;
            }
            else return false; 
        }

        public void Deposita(double valor) => Saldo += valor;

        public bool Transfere(Conta destino, double valor) {
            if (VerificarTransacao(valor)) {
                Saldo -= valor;
                return true;
            } 
            return false;
        }

        private bool VerificarTransacao(double valor) => Saldo - valor >= 0;

        public double VisualizarSaldo() => this.Saldo;
    }
}
