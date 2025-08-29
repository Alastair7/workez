

namespace Workez.Domain.Entities;

public partial class Shift
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
