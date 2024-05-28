using Bl.BlApi;
using Bl.BlModels;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlServices
{
    public class BranchRepo : IBranch
    {
        Dal.DalApi.IBranchRepo branchInstance;
       

        public List<BlModels.Branch> GetAll()
        {
            List<Dal.Models.Branch> allBranch = branchInstance.GetAll();
            List<BlModels.Branch> BlModelBranch = new List<BlModels.Branch>();
            for (int i = 0; i < allBranch.Count(); i++)
            {
                BlModelBranch.Add(new BlModels.Branch(allBranch[i].Street, allBranch[i].City, allBranch[i].Appointments, allBranch[i].Workers));
            }
            return BlModelBranch;
        }
      
        public BlModels.Branch Create(BlModels.Branch obj)
        {
            Dal.Models.Branch appointment = new Dal.Models.Branch();
            appointment.Street = obj.Street;
            appointment.City = obj.City;
            branchInstance.Create(appointment);
            return obj;
        }

        public BlModels.Branch Read(int id)
        {
            Dal.Models.Branch obj = branchInstance.Read(id);
            BlModels.Branch branch = new BlModels.Branch(obj.Street, obj.City, obj.Appointments, obj.Workers);
            return branch;
        }

        public BlModels.Branch Update(BlModels.Branch obj, int id)
        {
            Dal.Models.Branch branch = new Dal.Models.Branch();
            branch.Street = obj.Street;
            branch.City = obj.City;
            branchInstance.Update(branch, id);
            return obj;
        }

        public int Delete(int id)
        {
            branchInstance.Delete(id);
            return id;
        }
    }
}
