using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ab732015MIS4200.Models
{
    public class Patient
    {
        public int patientId { get; set; }
        public string patientFirstName { get; set; }
        public string patientLastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime patientSince { get; set; }

        public ICollection<Doctor> Doctor { get; set; }


    }
}