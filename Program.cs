namespace Aula12
{
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro();           
            l1.nome = "livro do Borsato";
            l1.autor = "Fellipe Borsato";
            l1.ano = 2006;

            Livro l2 = new Livro();
            l2.nome = "livro do Medonho";
            l2.autor = "Lucas Mendonca";
            l2.ano = 2007;

            Livro l3 = new Livro();
            l3.nome = "livro do stavo";
            l3.autor = "Gustavo Borsato";
            l3.ano = 2006;

            Livro livro = new Livro(); 

            livros.Add(l1,l2,l3);

        }
    }
}
