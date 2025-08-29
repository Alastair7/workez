namespace Workez.Application.DTOs;

public record ShiftReadDto(

    TimeOnly StartHours,
    TimeOnly? EndHours,
    float? MoneyShift,
    TimeOnly? ExtraHours,
    float? ExtraMoneyShift

);