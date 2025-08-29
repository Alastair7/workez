using Workez.Domain.Entities;

namespace Workez.Domain.Interfaces;

public interface IShiftRepository
{
    Task<List<Shift>> GetAllAsync();
    Task<Shift?> GetByIdAsync(Guid id);
    Task<Shift> CreateAsync(Shift shift);
    Task<bool> DeleteAsync(long id);
}
