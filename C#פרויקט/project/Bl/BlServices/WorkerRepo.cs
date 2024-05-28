using Bl.BlApi;
using Bl.BlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlServices
{
    public class WorkerRepo : IWorker
    {
        Dal.DalApi.IworkerRepo workerInstance;
     
        public Worker Create(Worker obj)
        {
            throw new NotImplementedException();
        }


        public List<BlModels.Worker> GetAll()
        {
            List<Dal.Models.Worker> allWorker = workerInstance.GetAll();
            List<BlModels.Worker> BlModelWorker = new List<BlModels.Worker>();
            for (int i = 0; i < allWorker.Count(); i++)
            {
                BlModelWorker.Add(new BlModels.Worker(allWorker[i].FirstName, allWorker[i].LastName, allWorker[i].JobType, allWorker[i].Branch));
            }
            return BlModelWorker;
        }

        public Worker Read(int id)
        {
            throw new NotImplementedException();
        }

        public Worker Update(Worker obj, int id)
        {
            throw new NotImplementedException();
        }
        public int Delete(int id)
        {
            workerInstance.Delete(id);
            return id;
        }
    }
}
