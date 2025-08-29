using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workez.Infrastructure.Persistence;

[Table("User")]
public partial class UserEntity
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public float? TotalAmountMoney { get; set; }
}
