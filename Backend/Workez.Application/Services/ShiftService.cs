using Workez.Application.DTOs;
using Workez.Domain.Entities;
using Workez.Domain.Interfaces;

namespace Workez.Application.Services;

public class ShiftService
{
    private readonly IShiftRepository _shiftRepository;

    public ShiftService(IShiftRepository shiftRepository)
    {
        _shiftRepository = shiftRepository;
    }

    public async Task<List<Shift>> GetAllShiftsAsync()
    {
        return await _shiftRepository.GetAllAsync();
    }

    public async Task<Shift?> GetShiftByIdAsync(Guid id)
    {
        return await _shiftRepository.GetByIdAsync(id);
    }

    public async Task<Shift> CreateShiftAsync(ShiftCreateDto shiftDto)
    {
        var shift = new Shift
        {
            StartHours = shiftDto.StartHours,
            EndHours = shiftDto.EndHours,
            MoneyShift = 20,
            ExtraHours = shiftDto.ExtraHours,
            ExtraMoneyShift = 20
        };

        return await _shiftRepository.CreateAsync(shift);

    }


    public async Task<bool> DeleteShiftAsync(long id)
    {
        return await _shiftRepository.DeleteAsync(id);
    }
}
