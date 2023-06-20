namespace Vending_machine.Business.Dtos.ProductDtos;

public class ProductCreateDto
{
    public string Name { get; set; }
    public string Image { get; set; }
    public int Cost { get; set; }
    public int Stock { get; set; }
}