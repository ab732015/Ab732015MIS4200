using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Ab732015MIS4200.Models
{
    public class Appointment
    {
        [DisplayName("Appointment Id")]
        public int appointmentId { get; set; }

        [DisplayName("Appointment Description")]
        public string description { get; set; }
      
        public ICollection<AppointmentDetail> AppointmentDetail { get; set; }


    }
}