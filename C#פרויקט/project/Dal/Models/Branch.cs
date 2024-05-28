using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Branch
{
    public int IdBranch { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Worker> Workers { get; set; } = new List<Worker>();
}
