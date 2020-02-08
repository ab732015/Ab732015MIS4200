using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ab732015MIS4200.Models
{
    public class Doctor
    {
        [Key]
        public int doctorId { get; set; }
        public string doctorfirstName { get; set; }
        public string doctorLastName { get; set; }
        public ICollection<AppointmentDetail> AppointmentDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int patientId { get; set; }
        public virtual Patient Patient { get; set; }


    }
}