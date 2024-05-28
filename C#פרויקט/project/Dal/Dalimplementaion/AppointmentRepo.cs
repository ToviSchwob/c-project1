using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Dalimplementaion
{
    public class AppointmentRepo : IAppointmentRepo
    {
        BorbershopsContext borbershopscontext;
        public AppointmentRepo(BorbershopsContext borbershopscontext)
        {
            this.borbershopscontext = borbershopscontext;
        }
        public List<Appointment> GetAll()
        {
            return borbershopscontext.Appointments.ToList();
        }


        public Appointment Create(Appointment appointment)
        {
            borbershopscontext.Appointments.Add(appointment);
            borbershopscontext.SaveChanges();
            return appointment;
        }
        public Appointment Read(int id)
        {
            throw new NotImplementedException();
        }


        public Appointment Update(Appointment appointment, int id)
        {
            borbershopscontext.Appointments.FirstOrDefault(a => a.Id == id).Branch = appointment.Branch;
            borbershopscontext.Appointments.FirstOrDefault(a => a.Id == id).Time = appointment.Time;
            borbershopscontext.SaveChanges();
            return appointment;
        }

        public int Delete(int id)
        {
            borbershopscontext.Appointments.Remove(borbershopscontext.Appointments.FirstOrDefault(Appointment => Appointment.Id == id));
            borbershopscontext.SaveChanges();
            return id;
        }







    }
}
