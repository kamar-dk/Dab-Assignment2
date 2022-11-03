// See https://aka.ms/new-console-template for more information
using DAB_Assignment2;
using System;
using System.Linq;

using var db = new FacilitysContext();

Console.WriteLine($"Database Path: {db.DbPath}");


// create
/*
Console.WriteLine("Insering a new Facility");
db.Add(new Facilitys { PK_FcName = "Uni parken" });
db.SaveChanges();
*/


