using System;

namespace controle_armazenamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(printarNome());

            Produto p = new Produto();
            p.quantidade = 5;
            Console.WriteLine(p.retornaQuantidade());
        }

        public static String printarNome()
        {
            return "GiU";
        }
    }
}
