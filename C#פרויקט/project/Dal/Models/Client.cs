using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Client
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int? Age { get; set; }

    public int? ApoointmentId { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
