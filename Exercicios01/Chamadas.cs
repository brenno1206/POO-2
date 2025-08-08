namespace PrimeiroProjeto
{
    public class Chamadas
    {
        public Stack<string> chamadas;

        public Chamadas() => chamadas = new();

        public void InserirChamadaPerdida(string numero) => chamadas.Push(numero);
        public void ListarTodasChamadasPerdidas()
        {
            foreach (string numero in chamadas) Console.WriteLine($"Numero: {numero}.");
        }

        public string RecuperarUltima() => chamadas.First();
        public void RemoverUltima() => chamadas.Pop();
    }
}