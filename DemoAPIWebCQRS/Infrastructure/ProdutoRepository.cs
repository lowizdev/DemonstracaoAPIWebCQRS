namespace DemoAPIWebCQRS.Infrastructure
{
    public class ProdutoRepository
    {
        private InMemoryContext _context;
        public ProdutoRepository(InMemoryContext context)
        {
            _context = context;
        }

        public bool InsereProduto(Produto produto) 
        {
            _context.ProdutoDatabase.Add(produto);
            _context.SaveChanges();

            return true;
        }

        public List<Produto> GetAllProduto()
        {
            //PODE SER IMPLEMENTADO COM OUTRA TECNOLOGIA, OU ATE MESMO EM OUTRO LOCAL
            return _context.ProdutoDatabase;
            
        }

        public Produto GetProdutoByNome(string nome)
        {
            //PODE SER IMPLEMENTADO COM OUTRA TECNOLOGIA, OU ATE MESMO EM OUTRO LOCAL
            return _context.ProdutoDatabase.Where(p => p.Nome == nome).FirstOrDefault();

        }

    }
}
