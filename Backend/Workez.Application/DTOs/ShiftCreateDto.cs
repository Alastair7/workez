namespace Workez.Application.DTOs;

public record ShiftCreateDto(
    short? UserId,
    TimeOnly StartHours,
    TimeOnly? EndHours,
    TimeOnly? ExtraHours
);