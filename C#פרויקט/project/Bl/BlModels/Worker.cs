using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Models;

namespace Bl.BlModels
{
    public class Worker
    {
        private Dal.Models.Branch? branch;
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string JobType { get; set; } = null!;

        public virtual Branch? Branch { get; set; }

        public Worker(string firstName, string lastName, string jobType, Dal.Models.Branch? branch)
        {
            FirstName = firstName;
            LastName = lastName;
            JobType = jobType;
            this.branch = branch;
        }
    }
}
