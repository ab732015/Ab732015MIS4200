using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Ab732015MIS4200.Models
{
    public class AppointmentDetail
    {
        public int appointmentDetailId { get; set; }

        [DisplayName("Price")]
        public decimal price { get; set; }

        [DisplayName("Doctor Name")]
        public int doctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
       
        public int appointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }



    }
}