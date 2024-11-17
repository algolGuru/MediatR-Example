using MediatR;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly IProductRepository _productRepository;

    public GetProductByIdQueryHandler(IProductRepository orderRepository)
    {
        _productRepository = orderRepository;
    }

    public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        Product product = await _productRepository.GetById(request.ProductId);
        return product;
    }
}
