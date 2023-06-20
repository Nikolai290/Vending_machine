namespace Vending_machine.Business.Dtos.ProductDtos;

public class ProductUpdateDto
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public string Image { get; set; }
    public int Stock { get; set; }
}