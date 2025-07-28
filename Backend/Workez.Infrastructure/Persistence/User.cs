using System;
using System.Collections.Generic;

namespace Workez.Infrastructure.Persistence;

public partial class User
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public float? TotalAmountMoney { get; set; }
}
