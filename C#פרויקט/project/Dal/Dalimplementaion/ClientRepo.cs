using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Dalimplementaion
{
    public class ClientRepo : IClientRepo
    {
        BorbershopsContext borbershopscontext;
        public ClientRepo(BorbershopsContext borbershopscontext)
        {
            this.borbershopscontext = borbershopscontext;
        }
        public List<Client> GetAll()
        {
           return borbershopscontext.Clients.ToList();

        }

        public Client Create(Client client)
        {
            borbershopscontext.Clients.Add(client);
            borbershopscontext.SaveChanges();
            return client;
        }
        public Client Read(int id)
        {
            throw new NotImplementedException();
        }
        public Client Update(Client client, int id)
        {
            borbershopscontext.Clients.FirstOrDefault(c => c.Id == id).Age = client.Age;
            borbershopscontext.Clients.FirstOrDefault(c => c.Id == id).Apoointment = client.Apoointment;
            borbershopscontext.SaveChanges();
            return client;
        }


        public int Delete(int id)
        {
            borbershopscontext.Clients.Remove(borbershopscontext.Clients.FirstOrDefault( client => client.Id==id));
            borbershopscontext.SaveChanges();
            return id;
        }



    }
}
