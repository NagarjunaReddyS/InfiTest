using System;
using System.Collections.Generic;

namespace DoctorsInfoApp.Models
{
    public class Doctor: Persion
    {
        public List<Patient> Patients { get; set; }
        public string depart { get; set; }

        public Doctor(int id, string firstname,string lastname, string gender,int age, string depart, List<Patient> patients) 
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.depart = depart;
            this.age = age;
            this.Patients = patients;
        }
    }
}