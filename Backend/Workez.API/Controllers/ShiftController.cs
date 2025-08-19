using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Workez.Application.DTOs;
using Workez.Application.Services;
using Workez.Infrastructure.Persistence;

namespace Workez.API.Controllers;

[ApiController]
public class ShiftController : ControllerBase
{
    private readonly ShiftService _shiftService;

    public ShiftController(ShiftService shiftService)
    {
        _shiftService = shiftService;
    }

    [HttpGet("api/shifts/")]
    public async Task<IActionResult> GetAllShifts()
    {
        var shifts = await _shiftService.GetAllShiftsAsync();
        return Ok(shifts);
    }

    [HttpGet("api/shifts/{id}")]
    public async Task<IActionResult> GetShiftById(Guid id)
    {
        var shift = await _shiftService.GetShiftByIdAsync(id);
        if (shift == null)
        {
            return NotFound();
        }
        return Ok(shift);
    }

    [HttpPost("api/shifts/")]
    public async Task<IActionResult> CreateShift([FromBody] ShiftCreateDto shiftDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var createdShift = await _shiftService.CreateShiftAsync(shiftDto);
        return CreatedAtAction(nameof(GetShiftById), new { id = createdShift.Id }, createdShift);
    }

    [HttpDelete("api/shifts/{id}")]
    public async Task<IActionResult> DeleteShift(long id)
    {
        var deleted = await _shiftService.DeleteShiftAsync(id);
        if (!deleted)
        {
            return NotFound();
        }
        return NoContent();
    }

}
