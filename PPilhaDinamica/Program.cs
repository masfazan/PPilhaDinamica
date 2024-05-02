using PPilhaDinamica;

internal class Program
{
    private static void Main(string[] args)
    {
        PilhaLivro minhaPilha = new PilhaLivro();
        int opc;
        do
        {
            Console.Clear();
            Console.WriteLine("MENU PRINCIPAL - Pilha de livros");
            Console.WriteLine("Opções:");
            Console.WriteLine("1-Inserir livro");
            Console.WriteLine("2-Remover livro");
            Console.WriteLine("3-Imprimir pilha");
            Console.WriteLine("4-Busca´por título");
            Console.WriteLine("0-Sair");
            Console.Write("Informar a opção desejada:< >\b\b");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    minhaPilha.push(cadastro_livro());
                    break;
                case 2:
                    minhaPilha.pop();
                    break;
                case 3:
                    minhaPilha.print();
                    break;
                case 4:
                    Console.WriteLine("Digite o nome do livro:");
                    minhaPilha.BuscarLivro(Console.ReadLine());
                    break;
                case 0:
                    Console.WriteLine("Fim do programa");
                    break;
                default:
                    Console.WriteLine("Opção não existe");
                    break;
            } 

        } while (opc != 0);
    }

    static Livro cadastro_livro()
    {
        string titulo;
        Console.WriteLine("Informe o título do novo livro: ");
        titulo = Console.ReadLine();
        return new Livro(titulo);

    }
}