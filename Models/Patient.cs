using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ab732015MIS4200.Models
{
    public class Patient

    {
        public int patientId { get; set; }


        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name Required")]
        public string patientFirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        public string patientLastName { get; set; }

        [DisplayName("Email")]
        public string email { get; set; }

        [DisplayName("Phone")]
        [DataType(DataType.PhoneNumber)]

        [Required(ErrorMessage = "First Name Required")]
        public string phone { get; set; }

        [DisplayName("Patient Since")]
        public DateTime patientSince { get; set; }

        public ICollection<Doctor> Doctor { get; set; }


    }
}