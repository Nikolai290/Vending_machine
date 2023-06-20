using Vending_machine.Business.Dtos.ManufacturerDtos;

namespace Vending_machine.Business.Dtos.ProductDtos;

public class ProductOutDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public int Cost { get; set; }
    public int Stock { get; set; }
}