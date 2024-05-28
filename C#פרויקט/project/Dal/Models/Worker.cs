using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Worker
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string JobType { get; set; } = null!;

    public int? BranchId { get; set; }

    public virtual Branch? Branch { get; set; }
}
