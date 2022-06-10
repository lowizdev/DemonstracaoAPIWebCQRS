using DemoAPIWebCQRS.Infrastructure;

namespace DemoAPIWebCQRS.Commands
{
    public interface ICreateProdutoHandler
    {
        bool Handle(CreateProdutoCommand cmd);
    }

    public class CreateProdutoHandler : ICreateProdutoHandler
    {
        private ProdutoRepository _repository;
        public CreateProdutoHandler(ProdutoRepository repository)
        {
            _repository = repository;

        }

        public bool Handle(CreateProdutoCommand cmd)
        {

            Produto produto = new Produto(cmd.Nome, cmd.Quantidade);

            var res = _repository.InsereProduto(produto);

            return res;

        }
    }
}
