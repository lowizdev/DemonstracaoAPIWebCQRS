using DemoAPIWebCQRS.Infrastructure;

namespace DemoAPIWebCQRS.Queries
{
    public class QuerySingleProduto
    {
        private ProdutoRepository _repository;
        public QuerySingleProduto(ProdutoRepository repository)
        {
            _repository = repository;

        }

        public Produto Execute(string nome)
        {

            var produto = this._repository.GetProdutoByNome(nome);

            if (produto == null) {

                throw new Exception("Cade meu bagulho?");

            }

            return produto;

        }
    }
}
