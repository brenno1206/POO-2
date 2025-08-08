namespace PrimeiroProjeto
{
    public class Banco
    {
        public Dictionary<string, Conta> Contas;

        public Banco()
        {
            Contas = [];
        }

        public void Inserir(string cod, Conta conta) => Contas.Add(cod, conta);
        public Conta Buscar(string cod) => Contas[cod];
        
        public void ListarTodasAsContas()
        {
            foreach (Conta conta in Contas.Values) Console.WriteLine(conta.ToString());
        }

        public void Remover(string cod) => Contas.Remove(cod);
    }
}