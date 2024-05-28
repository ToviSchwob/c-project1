using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlModels
{
    public class Client
    {
        private ICollection<Dal.Models.Appointment> appointments;
        public string? FirstName { get; set; } = null!;

        public string? LastName { get; set; } = null!;

        public int? Age { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();


        public Client(string firstName, string lastName, int? age, ICollection<Dal.Models.Appointment> appointments)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            this.appointments = appointments;
        }
    }
}
