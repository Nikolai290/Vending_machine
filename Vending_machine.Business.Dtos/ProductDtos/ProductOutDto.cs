using Vending_machine.Business.Dtos.ManufacturerDtos;

namespace Vending_machine.Business.Dtos.ProductDtos;

public class ProductOutDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Cost { get; set; }
    public ManufacturerShortOutDto Manufacturer { get; set; }
}