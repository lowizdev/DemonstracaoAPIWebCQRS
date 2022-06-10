using DemoAPIWebCQRS.Infrastructure;

namespace DemoAPIWebCQRS.Queries
{
    public class QueryAllProdutos
    {
        

        private ProdutoRepository _repository;
        public QueryAllProdutos(ProdutoRepository repository)
        {
            _repository = repository;

        }

        public List<Produto> Execute() 
        {
            
            return this._repository.GetAllProduto();
        
        }
    }
}
