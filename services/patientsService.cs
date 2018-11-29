using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using patientsDAL;


namespace services
{
    public class patientsService
    {
        List<patients> patientsList = new List<patients>()
        {
          new patients (){ ID= 93095637, fname= "Manar" ,  mname= "AA", lname= "Sarah", gender= 2, email= "", status= 0 , Active=true,  CreatedBy= 1 }
        };
        public object show()
        {
            return patientsList;
        }
        public void create(patients patient)
        {
            patientsList.Add(patient);
        }
        public patients get(int id)
        {
            var patient = patientsList.Where(p => p.ID == id).SingleOrDefault();
            return patient;
        }
        public patients edit(int id , patients editedpatient)
        {
            var patient = patientsList.Where(p => p.ID == id).SingleOrDefault();

            patient.fname = editedpatient.fname;
            patient.mname = editedpatient.mname;
            patient.lname = editedpatient.lname;
            patient.Active = editedpatient.Active;
            patient.gender = editedpatient.gender;
            patient.status = editedpatient.status;
            patient.lastCheck = DateTime.Now;

            return patient;
        }
        public string delete(int id)
        {
            var patient = patientsList.RemoveAll(x => x.ID == id);

            return "done";
        }
    }
}
