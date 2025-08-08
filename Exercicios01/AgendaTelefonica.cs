using System.Reflection;

namespace PrimeiroProjeto
{
    public class AgendaTelefonica
    {
        private Dictionary<string, Contato> Colecao;

        public AgendaTelefonica() => Colecao = [];

        public void Inserir(string nome, Contato contato) => Colecao.Add(nome, contato);
        public string BuscarNumero(string nome) {
            Contato contato = Colecao[nome];
            if (contato == null)
            {
                return "";
            }
            else
            {
                return contato.Numero;
            }
        } 
        public void Remover(string nome) => Colecao.Remove(nome);
        public int Tamanho() => Colecao.Count;
    }
}