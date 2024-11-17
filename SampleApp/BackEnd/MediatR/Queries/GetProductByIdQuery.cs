using MediatR;

public class GetProductByIdQuery : IRequest<Product>
{
    public int ProductId { get; set; }

    public GetProductByIdQuery(int productId)
    {
        ProductId = productId;
    }
}