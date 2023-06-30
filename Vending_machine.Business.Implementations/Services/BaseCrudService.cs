using AutoMapper;
using Vending_machine.Business.Interfaces.Services;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Business.Implementations.Services;

public class BaseCrudService<TEntity, TCreateDto, TUpdateDto, TOutDto> : IBaseCrudService<TCreateDto, TUpdateDto, TOutDto> where TEntity : BaseDbEntity
{
    protected readonly IBaseCrudRepository<TEntity> _repository;
    protected readonly IMapper _mapper;

    public BaseCrudService(IBaseCrudRepository<TEntity> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<TOutDto> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(id, cancellationToken);
        var result = _mapper.Map<TOutDto>(entity);
        return result;
    }

    public async Task<IList<TOutDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        var entities = await _repository.GetAllAsync(cancellationToken);
        var result = _mapper.Map<IList<TOutDto>>(entities);
        return result;
    }

    public async Task<TOutDto> CreateAsync(TCreateDto dto, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<TEntity>(dto);
        var createdEntity = await _repository.CreateAsync(entity, cancellationToken);
        var result = _mapper.Map<TOutDto>(createdEntity);
        return result;
    }

    public async Task<TOutDto> UpdateAsync(int id, TUpdateDto dto, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(id, cancellationToken);
        _mapper.Map(dto, entity);
        var updatedEntity = await _repository.UpdateAsync(entity, cancellationToken);
        var result = _mapper.Map<TOutDto>(updatedEntity);
        return result;
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
    {
        var result = await _repository.DeleteAsync(id, cancellationToken);
        return result;
    }
}