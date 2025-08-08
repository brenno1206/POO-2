namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Programa");
            Console.WriteLine("-------");

            Chamadas Ch = new();

            Ch.InserirChamadaPerdida("111");
            Ch.InserirChamadaPerdida("222");
            Ch.InserirChamadaPerdida("333");
            Ch.InserirChamadaPerdida("444");
            Ch.InserirChamadaPerdida("555");

            Console.WriteLine(Ch.RecuperarUltima());
            Console.WriteLine("-------");
            Ch.RemoverUltima();
            Ch.ListarTodasChamadasPerdidas();

            /*
            Banco banco = new();
            Conta c1 = new("Ana");
            Conta c2 = new("Bernardo");
            Conta c3 = new("Carlos");
            Conta c4 = new("Daniela");
            Conta c5 = new("Eduard_");
            banco.Inserir("1", c1);
            banco.Inserir("2", c2);
            banco.Inserir("3", c3);
            banco.Inserir("4", c4);
            banco.Inserir("5", c5);

            if (banco.Buscar("2") != null)
            {
                
                Console.WriteLine(banco.Buscar("2").ToString());
            }
            Console.WriteLine("-------");
            banco.Remover("2");
            banco.ListarTodasAsContas();
            */

            /*
            
            AgendaTelefonica Ag = new();
            Ag.Inserir("Ana", new Contato("12"));
            Ag.Inserir("Bernardo", new Contato("23"));
            Ag.Inserir("Carlos", new Contato("34"));
            Console.WriteLine(Ag.Tamanho());

            Console.WriteLine(Ag.BuscarNumero("Ana"));
            Ag.Remover("Ana");
            Console.WriteLine(Ag.Tamanho());
            */
        }
    }
}