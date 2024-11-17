using MediatR;
public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
{
    private readonly IProductRepository _productRepository;

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        Product product = new(request.Id, request.Name);
        _productRepository.Add(product);
        return Task.FromResult(true);
    }
}