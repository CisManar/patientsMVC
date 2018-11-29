﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patientsDAL
{
    public class patients
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string fname { get; set; }
        [Required]
        [Display(Name = "Middle Name")]
        public string mname { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lname { get; set; }
        [Required]
        [Range(1, 2)]
        public int gender { get; set; }
        [Required]
        public string email { get; set; }
        public DateTime lastCheck { get; set; }
        [Required]
        public int status { get; set; }
        [Required]
        public bool Active { get; set; }
        public DateTime creationDate { get; set; }
        public int CreatedBy { get; set; }

        List<patients> patientList = new List<patients>();
    }
   
}
