namespace Vending_machine.Business.Interfaces.Services;

public interface IBaseCrudService<TCreateDto, TUpdateDto, TOutDto>
{
    Task<TOutDto> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<IList<TOutDto>> GetAllAsync(CancellationToken cancellationToken);
    Task<TOutDto> CreateAsync(TCreateDto dto, CancellationToken cancellationToken);
    Task<TOutDto> UpdateAsync(int id, TUpdateDto dto, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
}