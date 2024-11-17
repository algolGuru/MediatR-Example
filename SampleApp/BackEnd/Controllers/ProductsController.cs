using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("/products")]
[Produces("application/json")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("")]
    public async Task<IActionResult> AddProduct([FromBody] CreateProductCommand createCommand)
    {
        bool result = await _mediator.Send(createCommand);
        if (result)
        {
            ProductNotification productNotification = new(createCommand.Id, DateTime.UtcNow);
            await _mediator.Publish(productNotification);
        }
        return Ok(result);
    }

    [HttpGet("{productId}")]
    public async Task<IActionResult> GetProduct([FromRoute] int productId)
    {
        GetProductByIdQuery getProductByIdQuery = new(productId);
        Product product = await _mediator.Send(getProductByIdQuery);

        if (product is null)
        {
            return BadRequest($"Product with id: {productId} does not exist");
        }
        return Ok(product);
    }
}