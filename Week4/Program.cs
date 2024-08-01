// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using Week4;

Console.WriteLine("Hello, World!");

Baby baby1 = new Baby("Sezen", "Aksu");

Baby baby2 = new Baby();
baby2.name = "Şebnem";
baby2.surName = "Ferah";
baby2.BirthDay=DateTime.Now;
baby2.Print();


