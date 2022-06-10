namespace DemoAPIWebCQRS
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, int quantidade)
        {
            if (nome.Length < 3) {

                throw new ArgumentException("Nome inválido");

            }

            //Outras validações e etc.

            Nome = nome;
            Quantidade = quantidade;
        }
    }
}
