namespace PrimeiroProjeto
{
    public class Conta(string nome)
    {
        public string Nome = nome;
        public double Saldo;
        
        public override string ToString()
        {
            return $"Nome: {Nome}, Saldo: {Saldo:C}";
        }
    }
}