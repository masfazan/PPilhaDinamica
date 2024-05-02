namespace PPilhaDinamica
{
    internal class PilhaLivro
    {
        Livro topo;

        public PilhaLivro()
        {
            topo = null;
            Console.WriteLine("Pilha criada!");
        } //pilha

        public void push(Livro aux) //ponteiro do livro existente
        {
            if (vazia() == true)
            {
                topo = aux;
            }

            else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
        } //insere o livro

        public void pop()
        {
            if (vazia() == false)
            {

                Console.WriteLine("Pilha vazia!");
                Console.WriteLine("Impossível remover");
                Console.ReadKey();
            }
            else
            {
                topo = topo.getAnterior();
            }
        } //remover livro

        Boolean vazia()
        {
            if (topo == null)
                return true;
            else
                return false;
        } //verificar

        public void print()
        {
            Livro aux = topo;

            if (vazia())
            {
                Console.WriteLine("Pilha vazia!");
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();
                } while (aux != null);
                Console.WriteLine("Fim da impressão!");
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            }
        } //imprimir
        public int quantidade()
        {
            Livro aux = topo;
            int cont = 0;
            if (vazia())
            {
                return 0;
            }
            else
            {
                do
                {
                    cont++;
                    aux = aux.getAnterior();
                } while (aux != null);
            }
            return cont;
        }

        public void PrintListaVazia()
        {
            Console.WriteLine("\nPilha vazia!");
            Console.WriteLine("Pressione qualquer tecla para continuar...\n\n");
            Console.ReadKey();
        }
            public void BuscarLivro(string titulo)
        {
            if (vazia())
                PrintListaVazia();
            else
            {
                Livro aux = topo;
                while (titulo != aux.getTitulo() && aux.getAnterior() != null)
                {
                    aux = aux.getAnterior();
                }
                if (aux.getTitulo() == titulo)
                    Console.WriteLine("Livro encontrado na pilha");
                else
                    Console.WriteLine("Livro não encontrado na pilha");

                Console.ReadKey();
            }
        }
    }
}
