using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Dalimplementaion
{
    public class WorkerRepo : IworkerRepo
    {
        BorbershopsContext borbershopscontext;
        public WorkerRepo(BorbershopsContext borbershopscontext)
        {
            this.borbershopscontext = borbershopscontext;
        }
        public List<Worker> GetAll()
        {
            return borbershopscontext.Workers.ToList();

        }

        public Worker Create(Worker worker)
        {
            borbershopscontext.Workers.Add(worker);
            borbershopscontext.SaveChanges();
            return worker;
        }
        public Worker Read(int id)
        {
            throw new NotImplementedException();
        }
        public Worker Update(Worker worker, int id)
        {
            borbershopscontext.Workers.FirstOrDefault(c => c.Id == id).JobType = worker.JobType;
            borbershopscontext.Workers.FirstOrDefault(c => c.Id == id).BranchId = worker.BranchId;
            borbershopscontext.SaveChanges();
            return worker;
        }

        public int Delete(int id)
        {
            borbershopscontext.Workers.Remove(borbershopscontext.Workers.FirstOrDefault(Worker => Worker.Id == id));
            borbershopscontext.SaveChanges();
            return id;
        }



    }
}
