using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
    public interface Icrud<T> where T : class
    {
        public T Create(T obj);
        public List<T> GetAll();
        public T Read(int id);
        public T Update(T obj, int id);
        public int Delete(int id);
    }
}
