using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlModels
{
    public class Appointment
    {
        private Dal.Models.Branch branch;
        private ICollection<Dal.Models.Client> clients;
        public TimeSpan Time { get; set; }

        public DateTime Date { get; set; }

        public virtual Branch Branch { get; set; } = null!;

        public virtual ICollection<Client> Clients { get; set; } = new List<Client>();


        public Appointment(TimeSpan time, DateTime date, Dal.Models.Branch branch, ICollection<Dal.Models.Client> clients)
        {
            Time = time;
            Date = date;
            this.branch = branch;
            this.clients = clients;
        }
    }
}
