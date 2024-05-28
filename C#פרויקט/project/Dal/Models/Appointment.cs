using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Appointment
{
    public int Id { get; set; }

    public TimeSpan Time { get; set; }

    public DateTime Date { get; set; }

    public int BranchId { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
