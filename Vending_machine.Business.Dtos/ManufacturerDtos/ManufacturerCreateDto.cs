namespace Vending_machine.Business.Dtos.ManufacturerDtos;

public class ManufacturerCreateDto
{
    public string Name { get; set; }
    public List<int> ProductIds { get; set; }
}