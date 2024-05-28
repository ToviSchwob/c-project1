using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Dalimplementaion
{
    public class BranchRepo : IBranchRepo
    {
        BorbershopsContext borbershopscontext;
        public BranchRepo(BorbershopsContext borbershopscontext)
        {
            this.borbershopscontext = borbershopscontext;
        }
        public List<Branch> GetAll()
        {
            return borbershopscontext.Branches.ToList();

        }

        public Branch Create(Branch branch)
        {
            borbershopscontext.Branches.Add(branch);
            borbershopscontext.SaveChanges();
            return branch;
        }
        public Branch Read(int id)
        {
            throw new NotImplementedException();
        }
        public Branch Update(Branch branch, int id)
        {
            borbershopscontext.Branches.FirstOrDefault(b => b.IdBranch == id).City = branch.City;
            borbershopscontext.SaveChanges();
            return branch;
        }

        public int Delete(int IdBranch)
        {
            borbershopscontext.Branches.Remove(borbershopscontext.Branches.FirstOrDefault(Branch => Branch.IdBranch == IdBranch));
            borbershopscontext.SaveChanges();
            return IdBranch;
        }


    }
}
