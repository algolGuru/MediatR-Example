using MediatR;

public class ProductLogCreationHandler : INotificationHandler<ProductNotification>
{
    public Task Handle(ProductNotification notification, CancellationToken cancellationToken)
    {
        // Логика логирования
        Console.WriteLine($"Product {notification.ProductId} created at {notification.CreatedAt} has been logged.");
        return Task.CompletedTask;
    }
}
