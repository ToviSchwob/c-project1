using Bl.BlApi;
using Bl.BlServices;
using Dal;
using Dal.DalApi;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bl
{
    public class BLManager
    {

        public IWorker Worker { get; }
        public IClient Client { get; }
        //public IClientRepo? Clients { get; set; }
        //public IworkerRepo? Workers { get; set; }

        public BLManager()
        {

            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<DalManager>();
            services.AddScoped<IWorker, WorkerRepo>();
            services.AddScoped<IClient, ClientRepo>();


            ServiceProvider provider = services.BuildServiceProvider();
            Worker = provider.GetRequiredService<IWorker>();

        }
    }
}
