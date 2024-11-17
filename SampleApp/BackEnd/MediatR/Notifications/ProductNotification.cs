using MediatR;

public class ProductNotification : INotification
{
    public int ProductId { get; set; }
    public DateTime CreatedAt { get; set; }

    public ProductNotification(int productId, DateTime createdAt)
    {
        ProductId = productId;
        CreatedAt = createdAt;
    }
}
