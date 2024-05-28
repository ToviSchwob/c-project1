using Bl.BlApi;
using Bl.BlModels;
using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlServices
{
    public class AppointmentRepo : IAppointment
    {

        Dal.DalApi.IAppointmentRepo AppointmentInstance;
        public AppointmentRepo(IAppointmentRepo appointmentRepo)
        {
            AppointmentInstance = appointmentRepo;
        }
       
        public BlModels.Appointment Create(BlModels.Appointment obj)
        {
            Dal.Models.Appointment appointment = new Dal.Models.Appointment();
            appointment.Time = obj.Time;
            appointment.Date = obj.Date;
            AppointmentInstance.Create(appointment);
            return obj;

        }

        public List<BlModels.Appointment> GetAll()
        {
            List<Dal.Models.Appointment> allAppointment = AppointmentInstance.GetAll();
            List<BlModels.Appointment> BlModelAppointment = new List<BlModels.Appointment>();
            for (int i = 0; i < allAppointment.Count(); i++)
            {
                BlModelAppointment.Add(new BlModels.Appointment(allAppointment[i].Time, allAppointment[i].Date, allAppointment[i].Branch, allAppointment[i].Clients));
            }
            return BlModelAppointment;
        }
        public BlModels.Appointment Read(int id)
        {
            Dal.Models.Appointment obj=AppointmentInstance.Read(id);
            BlModels.Appointment appointment = new BlModels.Appointment(obj.Time,obj.Date,obj.Branch,obj.Clients);
            return appointment;
        }


        public BlModels.Appointment Update(BlModels.Appointment obj, int id)
        {
            Dal.Models.Appointment appointment = new Dal.Models.Appointment();
            appointment.Time = obj.Time;
            appointment.Date = obj.Date;
            AppointmentInstance.Update(appointment,id);
            return obj;
        }

        public int Delete(int id)
        {
            AppointmentInstance.Delete(id);
            return id;
        }
    }
}

