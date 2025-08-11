using System.Reflection;

namespace PrimeiroProjeto
{
    public class AgendaTelefonica
    {
        private Dictionary<string, Contato> Agenda;

        public AgendaTelefonica() => Agenda = [];

        public void InserirContato(Contato contato) => Agenda.Add(contato.Nome, contato);
        public Contato BuscarContato(string nome) => Agenda[nome];

        public void Remover(string nome) => Agenda.Remove(nome);
        public int Tamanho() => Agenda.Count;
    }
}
