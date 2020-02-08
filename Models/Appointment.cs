using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ab732015MIS4200.Models
{
    public class Appointment
    {
        public int appointmentId { get; set; }
        public string description { get; set; }
      
        public ICollection<AppointmentDetail> AppointmentDetail { get; set; }


    }
}