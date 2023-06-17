namespace Vending_machine.Business.Dtos.ManufacturerDtos;

public class ManufacturerUpdateDto
{
    public string Name { get; set; }
    public List<int> ProductIds { get; set; }
}