using Bl.BlApi;
using Bl.BlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlServices
{
    public class ClientRepo : IClient
    {
        Dal.DalApi.IClientRepo clientInstance;

        public List<BlModels.Client> GetAll()
        {
            List<Dal.Models.Client> allClient = clientInstance.GetAll();
            List<BlModels.Client> BlModelClient = new List<BlModels.Client>();
            for (int i = 0; i < allClient.Count(); i++)
            {
                BlModelClient.Add(new BlModels.Client(allClient[i].FirstName, allClient[i].LastName, allClient[i].Age, allClient[i].Appointments));
            }
            return BlModelClient;
        }
        public Client Create(Client obj)
        {
            throw new NotImplementedException();
        }


        public BlModels.Client Read(int id)
        {
            Dal.Models.Client obj = clientInstance.Read(id);
            BlModels.Client client = new BlModels.Client(obj.FirstName, obj.LastName, obj.Age);
            return client;
        }

        public Client Update(Client obj, int id)
        {
            throw new NotImplementedException();
        }
        public int Delete(int id)
        {
            clientInstance.Delete(id);
            return id;
        }
    }
}
