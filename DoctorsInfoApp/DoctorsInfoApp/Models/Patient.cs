using System;

namespace DoctorsInfoApp.Models
{
    public class Patient : Persion
    {
        public string time { get; set; }
        public Patient(int id, string firstname,string lastname, string gender,int age, string time) 
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.age = age;
            this.time = time;
        }
    }
    
   
}