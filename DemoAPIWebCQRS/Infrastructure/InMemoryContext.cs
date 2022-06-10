namespace DemoAPIWebCQRS.Infrastructure
{
    public class InMemoryContext
    {
        public List<Produto> ProdutoDatabase { get; set; }

        public InMemoryContext()
        {
            ProdutoDatabase = new List<Produto>();
        }

        public void SaveChanges() { 
            //Intencionalmente nao faz nada, so pra simular mesmo
        }
    }
}
