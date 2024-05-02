namespace PPilhaDinamica
{
    internal class Livro
    {
        string titulo;
        Livro anterior; //não tem problema ser da mesma classe, anterior é do mesmo tipo

        public Livro(string titulo)
        {
            this.titulo = titulo;
            this.anterior = null; //primeira vez, anterior ainda não tem 'valor'
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public override string? ToString()
        {
            return "Título do livro\n" + titulo;
        }

        public void setAnterior(Livro livro)
        {
            anterior = livro;
        }

        public Livro getAnterior()
        {
            return anterior;
        }
    }

}
