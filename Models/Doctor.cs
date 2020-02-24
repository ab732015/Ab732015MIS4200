using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Ab732015MIS4200.Models
{
    public class Doctor
    {
        [Key]

        [DisplayName("Doctor First Name")]
        public int doctorId { get; set; }

        [DisplayName("Doctor First Name")]
        [Required(ErrorMessage ="First Name Required")]
        public string doctorfirstName { get; set; }

        [DisplayName("Doctor Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        public string doctorLastName { get; set; }
        public ICollection<AppointmentDetail> AppointmentDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int patientId { get; set; }
        public virtual Patient Patient { get; set; }

        [DisplayName("Hospital Number")]
        public int hospitalId { get; set; }


    }
}