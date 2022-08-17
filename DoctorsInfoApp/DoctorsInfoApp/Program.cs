// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Text;
using DoctorsInfoApp.Models;

Console.WriteLine("Hello, World!");

//Doctor:Pavitra Mahapatra Age 38, Patients: Lisa T(15-07-2022) Age 15,Ishaan Tiwari (09-07-2022) Age 89

//Doctor:Ganesh P Age 65, Patients: Grace Lane(23-04-2022) Age 25,Isha Singh (15-07-2022) Age 1, Prisha Mehta(19-07-2022) Age 23

var lstDoctores = new List<Doctor> {new Doctor(1, "Pavitra", "Mahapatra ", "F", 38, "A",
    new List<Patient>
    {
        new Patient(111, "Lisa", "T", "F", 15, "15-07-2022"),
        new Patient(112, "Ishaan", "Tiwari", "M", 89, "09-07-2022")
    }), new Doctor(2,"Ganesh","P ","F",65,"B",new List<Patient>
{
    new Patient(111, "Grace", "Lane", "F", 25, "23-04-2022"),
    new Patient(112, "Ishaan", "Singh", "M", 1, "15-07-2022"),
    new Patient(112, "Prisha", "Mehta", "F", 23, "19-07-2022"),
})};

foreach (var doctor in lstDoctores)
{
    var sb = new StringBuilder();
    sb.Append($"Doctor:{doctor.firstname}  {doctor.lastname} Age {doctor.age},");
    doctor.Patients.ForEach(x =>
    {
        sb.Append($"Patients:{x.firstname}  {x.lastname} ({x.time}) Age {doctor.age}");
    });
    Console.WriteLine(sb);
}

Console.Read();

