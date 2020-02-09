using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Ab732015MIS4200.Models
{
    public class Patient

    {
        public int patientId { get; set; }


        [DisplayName("First Name")]
        public string patientFirstName { get; set; }

        [DisplayName("Last Name")]
        public string patientLastName { get; set; }

        [DisplayName("Email")]
        public string email { get; set; }

        [DisplayName("Phone")]
        public string phone { get; set; }

        [DisplayName("Patient Since")]
        public DateTime patientSince { get; set; }

        public ICollection<Doctor> Doctor { get; set; }


    }
}