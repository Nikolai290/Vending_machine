namespace Vending_machine.Business.Dtos.ProductDtos;

public class ProductCreateDto
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public int ManufacturerId { get; set; }
}