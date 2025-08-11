namespace PrimeiroProjeto
{
    public class Contato(string nome, string numero, string apelido, int quantoMeDeve)
    {
        public string Nome { get; set; } = nome;

        public string Numero { get; set; } = numero;

        public string Apelido { get; set; } = apelido;

        public int QuantoMeDeve { get; set; } = quantoMeDeve;

    }
    
}
