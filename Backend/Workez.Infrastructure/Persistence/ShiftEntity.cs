using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workez.Infrastructure.Persistence;

/// <summary>
/// The Shift of a Journal
/// </summary>

[Table("Shift")]
public partial class ShiftEntity
{
    public long Id { get; set; }

    public short? UserId { get; set; }

    public TimeOnly StartHours { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? EndHours { get; set; }

    public float? MoneyShift { get; set; }

    public TimeOnly? ExtraHours { get; set; }

    public float? ExtraMoneyShift { get; set; }
}
