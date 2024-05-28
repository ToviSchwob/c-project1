using Dal.DalApi;
using Dal.Dalimplementaion;
using Dal.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalManager
    {
        public IworkerRepo Worker { get; set; }
        public IClientRepo Client { get; set; }
        public DalManager()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<BorbershopsContext>();
            services.AddScoped<IworkerRepo, WorkerRepo>();
            services.AddScoped<IClientRepo, ClientRepo>();

            ServiceProvider servicesProvider = services.BuildServiceProvider();

            Worker = servicesProvider.GetRequiredService<IworkerRepo>();
            Client = servicesProvider.GetRequiredService<IClientRepo>();
        }
    }
}
