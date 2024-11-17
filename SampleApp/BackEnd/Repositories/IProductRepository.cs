public interface IProductRepository
{
    public bool Add( Product product );
    public Task<Product> GetById(int id );
}

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = [];

    public bool Add( Product product )
    {
        _products.Add(product);
        return true;
    }

    public async Task<Product> GetById( int id )
    {
        return await Task.FromResult( _products.FirstOrDefault( item => item.Id == id ) );
    }
}
