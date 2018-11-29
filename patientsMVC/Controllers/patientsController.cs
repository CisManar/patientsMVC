using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using patientsDAL;
using services;

namespace patientsMVC.Controllers
{
    public class patientsController : Controller
    {
        // GET: patients
        patients patients = new patients();
        patientsService services = new patientsService();

        public ActionResult Index()
        {
            var allpatients = services.show();

            return View(allpatients);
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(patients patient)
        {
            Nullable<int> ID = null;
            var fname = "";
            var mname = "";
            var lname = "";
            Nullable<int> gender = null;
            var email = "";
            Nullable<int> status = null;
            Nullable<bool> Active = null;
            var CreatedBy = 1;

            if (ModelState.IsValid)
            {
                patients newpatient = new patients()
                {
                    ID = 93095637,
                    fname = patient.fname,
                    mname = patient.mname,
                    lname = patient.lname,
                    gender = 2,
                    email = patient.email,
                    status = 1,
                    Active = true,
                    CreatedBy = 1
                };
                services.create(newpatient);
                return RedirectToAction("Index");
            }

            return View(patient);
        }
        public ActionResult Edit(int id)
        {
            var patient = services.get(id);

            return View(patient);
        }
        [HttpPut]
        public ActionResult Edit(patients patient)
        {

            services.edit(patient.ID,patient);

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var patient = services.get(id);

            return View(patient);
        }
        [HttpDelete]
        public ActionResult Delete(patients patient)
        {
            services.delete(patient.ID);

            return RedirectToAction("Index");
        }
    }
}