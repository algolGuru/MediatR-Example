using MediatR;
public class CreateProductCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public CreateProductCommand(int id, string name)
    {
        Id = id;
        Name = name;
    }
}


