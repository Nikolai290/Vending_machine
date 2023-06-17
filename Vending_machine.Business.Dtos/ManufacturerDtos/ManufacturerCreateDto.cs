namespace Vending_machine.Business.Dtos.ManufacturerDtos;

public class ManufacturerCreateDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<int> ProductIds { get; set; }
}