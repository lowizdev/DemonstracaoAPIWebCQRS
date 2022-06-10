using DemoAPIWebCQRS.Commands;
using DemoAPIWebCQRS.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPIWebCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ICreateProdutoHandler _createProdutoHandler;
        private QueryAllProdutos _queryAllProdutos;
        private QuerySingleProduto _querySingleProduto;
        public ProdutoController(
            ICreateProdutoHandler createProdutoHandler,
            QueryAllProdutos queryAllProdutos,
            QuerySingleProduto querySingleProduto)
        {
            _createProdutoHandler = createProdutoHandler;
            _queryAllProdutos = queryAllProdutos;
            _querySingleProduto = querySingleProduto;
        }

        [HttpPost("/")]
        public async Task<IActionResult> CreateProduto(CreateProdutoCommand produtoCommand)
        {
            var result = _createProdutoHandler.Handle(produtoCommand);

            if (result) {
                return StatusCode(200);
            
            }

            return StatusCode(400);

        }


        [HttpGet("/{nome}")]
        public async Task<IActionResult> GetProduto(string nome)
        {
            var result = _querySingleProduto.Execute(nome);

            if (result != null)
            {
                return StatusCode(200, result);

            }

            return StatusCode(400);

        }

        [HttpGet("/")]
        public async Task<IActionResult> GetAllProduto()
        {
            var result = _queryAllProdutos.Execute();

            if (result != null)
            {
                return StatusCode(200, result);

            }

            return StatusCode(400);

        }

    }
}
