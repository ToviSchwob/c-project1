using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlModels
{
    public class Branch
    {
        private ICollection<Dal.Models.Appointment> appointments;
        private ICollection<Dal.Models.Worker> workers;
        public string? Street { get; set; }

        public string? City { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

        public virtual ICollection<Worker> Workers { get; set; } = new List<Worker>();


        public Branch(string? street, string? city, ICollection<Dal.Models.Appointment> appointments, ICollection<Dal.Models.Worker> workers)
        {
            Street = street;
            City = city;
            this.appointments = appointments;
            this.workers = workers;
        }
    }
}
