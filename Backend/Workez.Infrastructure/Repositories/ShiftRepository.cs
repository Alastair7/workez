using Microsoft.EntityFrameworkCore;
using Workez.Application.DTOs;
using Workez.Domain.Entities;
using Workez.Domain.Interfaces;
using Workez.Infrastructure.Persistence;

namespace Workez.Infrastructure.Repositories;

public class ShiftRepository : IShiftRepository
{
    private readonly PostgresContext _context;

    public ShiftRepository(PostgresContext context) => _context = context;

    public async Task<List<Shift>> GetAllAsync()
    {
        var entities = await _context.Shifts.ToListAsync();
        return entities.Select(e => new Shift
        {
            Id = e.Id,
            UserId = e.UserId,
            StartHours = e.StartHours,
            Date = e.Date,
            EndHours = e.EndHours,
            MoneyShift = e.MoneyShift,
            ExtraHours = e.ExtraHours,
            ExtraMoneyShift = e.ExtraMoneyShift
        }).ToList();
    }

    public async Task<Shift?> GetByIdAsync(Guid id)
    {
        var entity = await _context.Shifts.FindAsync(id);
        if (entity == null) return null;

        return new Shift
        {
            Id = entity.Id,
            UserId = entity.UserId,
            StartHours = entity.StartHours,
            Date = entity.Date,
            EndHours = entity.EndHours,
            MoneyShift = entity.MoneyShift,
            ExtraHours = entity.ExtraHours,
            ExtraMoneyShift = entity.ExtraMoneyShift
        };
    }

    public async Task<Shift> CreateAsync(Shift shift)
    {
        var entity = new ShiftEntity
        {
            UserId = 1,
            StartHours = shift.StartHours,
            EndHours = shift.EndHours,
            MoneyShift = 20,
            ExtraHours = shift.ExtraHours,
            ExtraMoneyShift = 20,
            Date = shift.Date ?? DateOnly.FromDateTime(DateTime.Now)
        };

        _context.Shifts.Add(entity);
        await _context.SaveChangesAsync();

        shift.Id = entity.Id;
        return shift;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var shift = await _context.Shifts.FindAsync(id);
        if (shift != null)
        {
            _context.Shifts.Remove(shift);
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }


}
